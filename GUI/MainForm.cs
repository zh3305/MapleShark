using SharpPcap;
using SharpPcap.LibPcap;
using PacketDotNet;
using PacketDotNet.Utils;
using PacketDotNet.LLDP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

using System.IO;
using System.Text.RegularExpressions;

namespace MapleShark
{
    public partial class MainForm : Form
    {
        private bool mClosed = false;
        private LibPcapLiveDevice mDevice = null;
        private SearchForm mSearchForm = new SearchForm();
        private DataForm mDataForm = new DataForm();
        private StructureForm mStructureForm = new StructureForm();
        private PropertyForm mPropertyForm = new PropertyForm();
        public static DummyOutputWindow mDummyOutputWindow = new DummyOutputWindow();

        private string[] _startupArguments = null;

        public MainForm(string[] startupArguments)
        {
            InitializeComponent();
            Text = "MapleShark " + Program.AssemblyVersion;
            _startupArguments = startupArguments;
            //mDockPanel.Theme= new VS2013BlueTheme();
            //mDockPanel.Theme = new VS2013LightTheme();
            // mDockPanel.Theme = new VS2013DarkTheme();
            // mDockPanel.Theme = new VS2012BlueTheme();
            // mDockPanel.Theme = new VS2012LightTheme();
            // mDockPanel.Theme = new VS2012DarkTheme();
            //mDockPanel.Theme = new VS2015BlueTheme();
            mDockPanel.Theme = new VS2015LightTheme();
            //mDockPanel.Theme = new VS2015DarkTheme();
        }

        public SearchForm SearchForm { get { return mSearchForm; } }
        public DataForm DataForm { get { return mDataForm; } }
        public StructureForm StructureForm { get { return mStructureForm; } }
        public PropertyForm PropertyForm { get { return mPropertyForm; } }
        public byte Locale { get { return (mDockPanel.ActiveDocument as SessionForm).Locale; } }
        public string _dockpanelConfigFile = "DockPanel.xml";

        PcapDevice device;

        private SessionForm NewSession()
        {
            SessionForm session = new SessionForm();
            return session;
        }

        public void CloseSession(SessionForm form)
        {
            //mDockPanel.Contents.Remove(form);
        }

        public void CopyPacketHex(KeyEventArgs pArgs)
        {
            if (mDataForm.HexBox.SelectionLength > 0 && pArgs.Modifiers == Keys.Control && pArgs.KeyCode == Keys.C)
            {
                Clipboard.SetText(BitConverter.ToString((mDataForm.HexBox.ByteProvider as DynamicByteProvider).Bytes.ToArray(), (int)mDataForm.HexBox.SelectionStart, (int)mDataForm.HexBox.SelectionLength).Replace("-", " "));
                pArgs.SuppressKeyPress = true;
            }
            else if (mDataForm.HexBox.SelectionLength > 0 && pArgs.Control && pArgs.Shift && pArgs.KeyCode == Keys.C)
            {
                byte[] buffer = new byte[mDataForm.HexBox.SelectionLength];
                Buffer.BlockCopy((mDataForm.HexBox.ByteProvider as DynamicByteProvider).Bytes.ToArray(), (int)mDataForm.HexBox.SelectionStart, buffer, 0, (int)mDataForm.HexBox.SelectionLength);
                mSearchForm.HexBox.ByteProvider.DeleteBytes(0, mSearchForm.HexBox.ByteProvider.Length);
                mSearchForm.HexBox.ByteProvider.InsertBytes(0, buffer);
                pArgs.SuppressKeyPress = true;
            }
        }

        private DialogResult ShowSetupForm()
        {
            return new SetupForm().ShowDialog(this);
        }

        private void SetupAdapter()
        {
            if (mDevice != null)
            {
                mDevice.Close();
            }

            foreach (LibPcapLiveDevice device in LibPcapLiveDeviceList.Instance)
            {
                if (device.Interface.FriendlyName == Config.Instance.Interface)
                {
                    mDevice = device;
                    break;
                }
            }

            if (mDevice == null)
            {
                // Well shit...
                MessageBox.Show("Invalid configuration. Please re-setup your MapleShark configuration.", "MapleShark", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ShowSetupForm() != DialogResult.OK)
                {
                    Close();
                    return;
                }
                SetupAdapter();
            }

            try
            {
                mDevice.Open(DeviceMode.Promiscuous, 1);
            }
            catch
            {
                MessageBox.Show("Failed to set the device in Promiscuous mode! But that doesn't really matter lol.");
                mDevice.Open();
            }
            mDevice.Filter = string.Format("tcp portrange {0}-{1}", Config.Instance.LowPort, Config.Instance.HighPort);
        }

        private void MainForm_Load(object pSender, EventArgs pArgs)
        {
            if (!Config.Instance.LoadedFromFile)
            {
                if (ShowSetupForm() != DialogResult.OK)
                {
                    Close();
                    return;
                }
            }

            SetupAdapter();

            mTimer.Enabled = true;
            //mDockPanel.AllowEndUserDocking = false;

            try
            {
                if (File.Exists(_dockpanelConfigFile))
                {
                    mDockPanel.SuspendLayout(true);

                    // In order to load layout from XML, we need to close all the DockContents
                    CloseAllContents();

                    //Assembly assembly = Assembly.GetAssembly(typeof(MainForm));
                    //Stream xmlStream = assembly.GetManifestResourceStream(_dockpanelConfigFile);
                    mDockPanel.LoadFromXml(_dockpanelConfigFile, new DeserializeDockContent(GetContentFromPersistString));
                    //xmlStream.Close();
                    mDockPanel.ResumeLayout(true, true);
                }
                else
                {
                    SetDefautDock();
                }

            }
            catch (Exception)
            {
                SetDefautDock();
            }

            foreach (string arg in _startupArguments)
            {
                SessionForm session = NewSession();
                session.OpenReadOnly(arg);
                session.Show(mDockPanel, DockState.Document);
            }
            mDockPanel.ResumeLayout(true, true);
        }
        public void SetDefautDock()
        {
            CloseAllContents();
            mDockPanel.SuspendLayout(true);
            mSearchForm.Show(mDockPanel);
            mDataForm.Show(mDockPanel);
            mStructureForm.Show(mDockPanel, DockState.DockRight);
            mPropertyForm.Show(mStructureForm.Pane, DockAlignment.Bottom, 0.5);
            mDummyOutputWindow.Show(mDockPanel, DockState.DockBottom);
            mDataForm.Activate();

            mDockPanel.ResumeLayout(true, true);
        }
        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(SearchForm).ToString())
                return mSearchForm;
            else if (persistString == typeof(DataForm).ToString())
                return mDataForm;
            else if (persistString == typeof(StructureForm).ToString())
                return mStructureForm;
            else if (persistString == typeof(PropertyForm).ToString())
                return mPropertyForm;
            else if (persistString == typeof(DummyOutputWindow).ToString())
                return mDummyOutputWindow;
            else
            {
                // DummyDoc overrides GetPersistString to add extra information into persistString.
                // Any DockContent may override this value to add any needed information for deserialization.

                //string[] parsedStrings = persistString.Split(new char[] { ',' });
                //if (parsedStrings.Length != 3)
                //    return null;

                //if (parsedStrings[0] != typeof(DummyDoc).ToString())
                //    return null;

                //DummyDoc dummyDoc = new DummyDoc();
                //if (parsedStrings[1] != string.Empty)
                //    dummyDoc.FileName = parsedStrings[1];
                //if (parsedStrings[2] != string.Empty)
                //    dummyDoc.Text = parsedStrings[2];

                return null;
            }
        }
        private void CloseAllContents()
        {
            // we don't want to create another instance of tool window, set DockPanel to null
            mSearchForm.DockPanel = null;
            mDataForm.DockPanel = null;
            mStructureForm.DockPanel = null;
            mPropertyForm.DockPanel = null;
            mDummyOutputWindow.DockPanel = null;

            // Close all other document windows
            CloseAllDocuments();
        }
        private void CloseAllDocuments()
        {
            if (mDockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    form.Close();
            }
            else
            {
                for (int index = mDockPanel.Contents.Count - 1; index >= 0; index--)
                {
                    if (mDockPanel.Contents[index] is IDockContent)
                    {
                        IDockContent content = (IDockContent)mDockPanel.Contents[index];
                        content.DockHandler.Close();
                    }
                }
            }
        }

        private void MainForm_FormClosed(object pSender, FormClosedEventArgs pArgs)
        {
            mTimer.Enabled = false;
            if (mDevice != null) mDevice.Close();
            mClosed = true;

            mDockPanel.SaveAsXml(_dockpanelConfigFile);
        }

        private void mDockPanel_ActiveDocumentChanged(object pSender, EventArgs pArgs)
        {
            if (!mClosed)
            {
                SessionForm session = mDockPanel.ActiveDocument as SessionForm;
                mSearchForm.ComboBox.Items.Clear();
                if (session != null)
                {
                    //   session.RefreshPackets();

                    mSearchForm.RefreshOpcodes(false);
                    session.ReselectPacket();
                }
                else
                {
                    if (mDataForm.HexBox.ByteProvider != null) mDataForm.HexBox.ByteProvider.DeleteBytes(0, mDataForm.HexBox.ByteProvider.Length);
                    mStructureForm.Tree.Nodes.Clear();
                    mPropertyForm.Properties.SelectedObject = null;
                }
            }
        }

        private void mFileImportMenu_Click(object pSender, EventArgs pArgs)
        {
            if (mImportDialog.ShowDialog(this) != DialogResult.OK) return;
            device = new CaptureFileReaderDevice(mImportDialog.FileName);
            device.Open();
            new Thread(ParseImportedFile).Start();
        }

        void ParseImportedFile()
        {
            RawCapture packet = null;
            SessionForm session = null;

            this.Invoke((MethodInvoker)delegate
            {
                while ((packet = device.GetNextPacket()) != null)
                {
                    if (!started)
                        continue;

                    TcpPacket tcpPacket = (TcpPacket)Packet.ParsePacket(packet.LinkLayerType, packet.Data).Extract(typeof(TcpPacket));
                    if (tcpPacket == null)
                        continue;

                    if ((tcpPacket.SourcePort < Config.Instance.LowPort || tcpPacket.SourcePort > Config.Instance.HighPort) &&
                        (tcpPacket.DestinationPort < Config.Instance.LowPort || tcpPacket.DestinationPort > Config.Instance.HighPort))
                        continue;
                    try
                    {
                        if (tcpPacket.Syn && !tcpPacket.Ack)
                        {
                            if (session != null)
                                session.Show(mDockPanel, DockState.Document);

                            session = NewSession();
                            var res = session.BufferTCPPacket(tcpPacket, packet.Timeval.Date);
                            if (res == SessionForm.Results.Continue)
                            {
                                //    mDockPanel.Contents.Add(session);
                                //session.Show(mDockPanel, DockState.Document);
                            }
                        }
                        else if (session != null && session.MatchTCPPacket(tcpPacket))
                        {
                            var res = session.BufferTCPPacket(tcpPacket, packet.Timeval.Date);
                            if (res == SessionForm.Results.CloseMe)
                            {
                                session.Close();
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception while parsing logfile: {0}", ex);
                        session.Close();
                        session = null;
                    }
                }


                if (session != null)
                    session.Show(mDockPanel, DockState.Document);

                if (session != null)
                {
                    mSearchForm.RefreshOpcodes(false);
                }
            });
        }

        private void mFileOpenMenu_Click(object pSender, EventArgs pArgs)
        {
            if (mOpenDialog.ShowDialog(this) == DialogResult.OK)
            {
                foreach (string path in mOpenDialog.FileNames)
                {
                    SessionForm session = NewSession();
                    session.OpenReadOnly(path);
                    session.Show(mDockPanel, DockState.Document);
                }
                mSearchForm.RefreshOpcodes(false);
            }
        }

        private void mFileQuit_Click(object pSender, EventArgs pArgs)
        {
            Close();
        }

        private void mViewMenu_DropDownOpening(object pSender, EventArgs pArgs)
        {
            mViewSearchMenu.Checked = !mSearchForm.IsHidden;
            mViewDataMenu.Checked = !mDataForm.IsHidden;
            mViewStructureMenu.Checked = !mStructureForm.IsHidden;
            mViewPropertiesMenu.Checked = !mPropertyForm.IsHidden;
            outToolStripMenuItem.Checked = !mDummyOutputWindow.IsHidden;
        }

        private void mViewSearchMenu_CheckedChanged(object pSender, EventArgs pArgs)
        {
            if (mViewSearchMenu.Checked) mSearchForm.Show();
            else mSearchForm.Hide();

        }

        private void mViewDataMenu_CheckedChanged(object pSender, EventArgs pArgs)
        {
            if (mViewDataMenu.Checked) mDataForm.Show();
            else mDataForm.Hide();
        }

        private void mViewStructureMenu_CheckedChanged(object pSender, EventArgs pArgs)
        {
            if (mViewStructureMenu.Checked) mStructureForm.Show();
            else mStructureForm.Hide();
        }

        private void mViewPropertiesMenu_CheckedChanged(object pSender, EventArgs pArgs)
        {
            if (mViewPropertiesMenu.Checked) mPropertyForm.Show();
            else mPropertyForm.Hide();
        }

        Dictionary<int, SessionForm> waiting = new Dictionary<int, SessionForm>();
        List<SessionForm> closes = new List<SessionForm>();

        private void mTimer_Tick(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => { mTimer_Tick(); }));
        }

        private void mTimer_Tick()
        {
            try
            {
                RawCapture packet = null;
                mTimer.Enabled = false;

                DateTime now = DateTime.Now;
                foreach (SessionForm ses in MdiChildren)
                {
                    if (ses.CloseMe(now))
                        closes.Add(ses);
                }
                closes.ForEach((a) => { a.Close(); });
                closes.Clear();

                while ((packet = mDevice.GetNextPacket()) != null)
                {
                    if (!started)
                        continue;

                    TcpPacket tcpPacket = (TcpPacket)Packet.ParsePacket(packet.LinkLayerType, packet.Data).Extract(typeof(TcpPacket));
                    SessionForm session = null;
                    try
                    {
                        if (tcpPacket.Syn && !tcpPacket.Ack && tcpPacket.DestinationPort >= Config.Instance.LowPort && tcpPacket.DestinationPort <= Config.Instance.HighPort)
                        {
                            session = NewSession();
                            var res = session.BufferTCPPacket(tcpPacket, packet.Timeval.Date);
                            if (res == SessionForm.Results.Continue)
                            {
                                int hash = tcpPacket.SourcePort << 16 | tcpPacket.DestinationPort;
                                waiting[hash] = session;
                            }
                        }
                        else
                        {
                            int hash = tcpPacket.DestinationPort << 16 | tcpPacket.SourcePort;
                            session = Array.Find(MdiChildren, f => (f as SessionForm).MatchTCPPacket(tcpPacket)) as SessionForm;
                            if (session != null)
                            {
                                var res = session.BufferTCPPacket(tcpPacket, packet.Timeval.Date);

                                if (res == SessionForm.Results.CloseMe)
                                {
                                    waiting.Remove(hash);
                                    session.Close();
                                }
                                continue;
                            }

                            if (waiting.TryGetValue(hash, out session))
                            {
                                var res = session.BufferTCPPacket(tcpPacket, packet.Timeval.Date);

                                switch (res)
                                {
                                    case SessionForm.Results.Show:
                                        session.Show(mDockPanel, DockState.Document);
                                        break;
                                    case SessionForm.Results.Continue:
                                        continue;
                                }
                                waiting.Remove(hash);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        session.Close();
                        session = null;
                    }
                }
                mTimer.Enabled = true;
            }
            catch (Exception)
            {
                if (!mDevice.Opened)
                    mDevice.Open(DeviceMode.Promiscuous, 1);
            }
        }
        /// <summary>
        /// 监听状态
        /// </summary>
        bool started = true;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (started)
            {
                started = false;
                mStopStartButton.Image = Properties.Resources.Button_Blank_Green_icon;
                mStopStartButton.Text = "Start sniffing";
            }
            else
            {
                started = true;
                mStopStartButton.Image = Properties.Resources.Button_Blank_Red_icon;
                mStopStartButton.Text = "Stop sniffing";
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("Readme.txt"))
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Readme.txt");
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SessionForm session = mDockPanel.ActiveDocument as SessionForm;
            if (session != null)
            {
                session.RunSaveCMD();
            }
        }

        private void importJavapropertiesFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmImportProps().ShowDialog();
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                bool okay = false;
                foreach (var file in files)
                {
                    switch (System.IO.Path.GetExtension(file))
                    {
                        case ".msb":
                        case ".pcap":
                        case ".txt":
                            okay = true;
                            continue;
                    }
                }

                e.Effect = okay ? DragDropEffects.Move : DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                if (!System.IO.File.Exists(file)) continue;

                switch (System.IO.Path.GetExtension(file))
                {
                    case ".msb":
                        {
                            SessionForm session = NewSession();
                            session.OpenReadOnly(file);
                            session.Show(mDockPanel, DockState.Document);
                            mSearchForm.RefreshOpcodes(false);
                            break;
                        }
                    case ".pcap":
                        {
                            device = new CaptureFileReaderDevice(file);
                            device.Open();
                            ParseImportedFile();
                            break;
                        }
                    case ".txt":
                        {
                            ReadMSnifferFile(file);
                            break;
                        }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Try to close all sessions
            List<SessionForm> sessionForms = new List<SessionForm>();

            foreach (var form in mDockPanel.Contents)
                if (form is SessionForm)
                    sessionForms.Add(form as SessionForm);

            int sessions = sessionForms.Count;
            bool doSaveQuestioning = true;
            if (sessions > 5)
            {
                doSaveQuestioning = MessageBox.Show("You've got " + sessions + " sessions open. Say 'Yes' if you want to get a question for each session, 'No' if you want to quit MapleShark.", "MapleShark", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes;
            }

            while (doSaveQuestioning && sessionForms.Count > 0)
            {
                SessionForm ses = sessionForms[0];
                if (!ses.Saved)
                {
                    ses.Focus();
                    DialogResult result = MessageBox.Show(string.Format("Do you want to save the session '{0}'?", ses.Text), "MapleShark", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        ses.RunSaveCMD();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;

                        return;
                    }
                }
                //mDockPanel.Contents.Remove(ses);
                sessionForms.Remove(ses);
            }

            DefinitionsContainer.Instance.Save();
    }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowSetupForm() == System.Windows.Forms.DialogResult.OK)
            {
                // Restart sniffing
                var lastTimerState = mTimer.Enabled;
                if (lastTimerState) mTimer.Enabled = false;

                SetupAdapter();

                if (lastTimerState) mTimer.Enabled = true;
            }
        }

        private void importMSnifferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select MSniffer logfile";
            ofd.Filter = "All files|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                ReadMSnifferFile(ofd.FileName);
        }

        private void ReadMSnifferFile(string filename)
        {
            SessionForm currentSession = null;
            Regex captureRegex = new Regex(@"MapleStory ([^\(]+)\(版本([0-9\.]+)\).*");
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line == "") continue;

                    if (line[0] == '1')
                    {
                        // Most likely capturing text
                        var matches = captureRegex.Match(line);
                        if (matches.Captures.Count == 0) continue;

                        Console.WriteLine("Version: {1} : {0}  ", matches.Groups[2].Value, matches.Groups[1].Value);

                        if (currentSession != null)
                            currentSession.Show(mDockPanel, DockState.Document);

                        currentSession = NewSession();
                        currentSession.SetMapleInfo((ushort)(double.Parse(matches.Groups[2].Value)), "", 8, matches.Groups[2].Value, 0);

                    }
                    //else if (line[0] == '[' && currentSession != null)
                    else if (currentSession != null)
                        currentSession.ParseMSnifferLine(line);
                }
            }

            if (currentSession != null)
                currentSession.Show(mDockPanel, DockState.Document);
        }
        /// <summary>
        /// 输出封包配置 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////var inf = new                Tools.IniFiles();
            //foreach (var i in Config.send)
            //{

            //    Tools.IniFiles.Write("sendops.properties.txt", "Main", i.Key, i.Value, "");

            //    //Tools. INIClass.IniWriteValue("recvops.properties.txt", "Main", i.Key, i.Value);
            //}
            //foreach (var i in Config.recv)
            //{

            //    Tools.IniFiles.Write("recvops.properties.txt", "Main", i.Key, i.Value, "");

            //    //Tools. INIClass.IniWriteValue("recvops.properties.txt", "Main", i.Key, i.Value);
            //}
        }

        private void converScripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GUI.ConverterScriptForm().Show(this);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text.Length == 0)
            {
                PropertyForm.Properties.SelectedObject = null;
            }
            else
            {
                var buffer = tools.HexTool.getByteArrayFromHexString(toolStripTextBox1.Text);
                if (buffer != null&& buffer.Length!=0)
                {
                    var aaaaa = new StructureSegment(buffer, 0, buffer.Length, MapleLocale.CHINA);
                    PropertyForm.Properties.SelectedObject= aaaaa;
                }
                else
                {
                    PropertyForm.Properties.SelectedObject = null;
                }
            }
        }

        //private void toolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    Config.LoadProperties();
        //}


        private void outToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (outToolStripMenuItem.Checked) mDummyOutputWindow.Show();
            else mDummyOutputWindow.Hide();
        }
    }
}
