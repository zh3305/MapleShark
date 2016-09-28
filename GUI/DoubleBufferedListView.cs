using System.Windows.Forms;

namespace MapleShark
{
    public sealed class DoubleBufferedListView : BrightIdeasSoftware.ObjectListView
    {
        public DoubleBufferedListView()
            : base()
        {
            DoubleBuffered = true;
        }
    }
}