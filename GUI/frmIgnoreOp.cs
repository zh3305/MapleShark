using BrightIdeasSoftware;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleShark.GUI
{
    public partial class frmIgnoreOp : Form
    {
        List<Definition> definition;
        public frmIgnoreOp(List<Definition> df)
        {
            InitializeComponent();
            definition = df;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Outbound.AspectToStringConverter = delegate (object cellValue) {
                return ((bool)cellValue) ? "Recv" : "Send";
            };
            olvSimple.AddObjects(definition);
        }

        private void textBoxFilterSimple_TextChanged(object sender, EventArgs e)
        {
            //Coordinator.TimedFilter(this.ListView, ((TextBox)sender).Text);
            //TimedFilter(olv, txt, 0);
            TimedFilter(olvSimple, ((TextBox)sender).Text,0);

        }
        public void TimedFilter(ObjectListView olv, string txt, int matchKind)
        {
            TextMatchFilter filter = null;
            if (!String.IsNullOrEmpty(txt))
            {
                switch (matchKind)
                {
                    case 0:
                    default:
                        filter = TextMatchFilter.Contains(olv, txt);
                        break;
                    case 1:
                        filter = TextMatchFilter.Prefix(olv, txt);
                        break;
                    case 2:
                        filter = TextMatchFilter.Regex(olv, txt);
                        break;
                }
            }

            // Text highlighting requires at least a default renderer
            if (olv.DefaultRenderer == null)
                olv.DefaultRenderer = new HighlightTextRenderer(filter);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            olv.AdditionalFilter = filter;
            //olv.Invalidate();
            stopWatch.Stop();

            //IList objects = olv.Objects as IList;
            //if (objects == null)
            //    this.ToolStripStatus1 = prefixForNextSelectionMessage =
            //        String.Format("Filtered in {0}ms", stopWatch.ElapsedMilliseconds);
            //else
            //    this.ToolStripStatus1 = prefixForNextSelectionMessage =
            //        String.Format("Filtered {0} items down to {1} items in {2}ms",
            //                      objects.Count,
            //                      olv.Items.Count,
            //                      stopWatch.ElapsedMilliseconds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjectListView olv = Outbound.ListView as ObjectListView;
            if (olv == null || olv.IsDisposed)
                return;

            // Collect all the checked values
            ArrayList chosenValues = new ArrayList();
            //foreach (object x in checkedList.CheckedItems)
            //{
            //    ICluster cluster = x as ICluster;
            //    if (cluster != null)
            //    {
            //chosenValues.Add(cluster.ClusterKey);
            chosenValues.Add(false);
            //    }
            //}
            Outbound.ValuesChosenForFiltering = chosenValues;

            olv.UpdateColumnFiltering();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ObjectListView olv = Outbound.ListView as ObjectListView;
            if (olv == null || olv.IsDisposed)
                return;
            ArrayList chosenValues = new ArrayList();
            chosenValues.Add(true);
            Outbound.ValuesChosenForFiltering = chosenValues;
            olv.UpdateColumnFiltering();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Outbound.UseFiltering = false;
            olvSimple.UpdateColumnFiltering();
        }
    }
}
