using System.Windows.Forms;

namespace MapleShark
{
    public sealed class DoubleBufferedListView : ListView// BrightIdeasSoftware.ObjectListView
    {
        public DoubleBufferedListView()
            : base()
        {
            DoubleBuffered = true;
        }
    }
}