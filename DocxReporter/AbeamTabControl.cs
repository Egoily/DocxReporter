using System.Drawing;
using System.Windows.Forms;

namespace DocxSearcher
{
    public class AbeamTabControl : TabControl
    {

        public AbeamTabControl()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.Alignment = TabAlignment.Left;
            this.SizeMode = TabSizeMode.Fixed;
            this.Multiline = true;
            this.ItemSize = new Size(50, 210);
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            Graphics g = e.Graphics;
            Font font = new Font("微软雅黑", 10.0f);
            SolidBrush brush = new SolidBrush(Color.Black);
            RectangleF tRectangleF = GetTabRect(e.Index);
            StringFormat sf = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Near
            };
            g.DrawString(this.Controls[e.Index].Text, font, brush, tRectangleF, sf);
            g.Dispose();
        }
    }
}
