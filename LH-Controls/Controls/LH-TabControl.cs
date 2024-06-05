using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LH_Controls.Controls
{
    public class LH_TabControl:TabControl
    {
        public LH_TabControl()
        {
            this.SetStyle(ControlStyles.UserPaint,true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint,true);
            this.SetStyle(ControlStyles.Selectable,true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer,true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.DrawItem += LH_TabControl_DrawItem;
            this.SizeMode = TabSizeMode.Fixed;
        }
        private void LH_TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rect =this.GetTabRect(e.Index);
            graphics.DrawRectangle(Pens.Black, rect);
            if (e.Index == this.SelectedIndex)
            {
                graphics.FillRectangle(new SolidBrush(Color.Green), rect);
                graphics.DrawRectangle(Pens.Black, rect);
                StringFormat stringFormat = new StringFormat();
                stringFormat.LineAlignment = StringAlignment.Center;
                stringFormat.Alignment = StringAlignment.Center;
                graphics.DrawString(TabPages[e.Index].Text, this.Font, new SolidBrush(Color.White), new PointF(rect.X + 3, rect.Y + 6), stringFormat);
            }
            else
            {
                graphics.FillRectangle(new SolidBrush(Color.Blue), rect);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                graphics.DrawString(TabPages[e.Index].Text, this.Font, new SolidBrush(Color.Red), new PointF(rect.X + 3, rect.Y + 6), stringFormat);

            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            for (int i = 0; i < TabPages.Count; i++)
            {
                Rectangle rect = this.GetTabRect(i);
                if (i == 0)
                {
                    rect.Inflate(-2, 2);
                }
                else
                {
                    rect.Inflate(2, 2);
                }
                if (i == this.SelectedIndex)
                {
                    graphics.FillRectangle(new SolidBrush(Color.Green), rect);
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Center;
                    graphics.DrawString(TabPages[i].Text, new Font("宋体",16,FontStyle.Bold), new SolidBrush(Color.White), rect, stringFormat);
                }
                else if (i == TabPages.Count - 1)
                {
                    graphics.FillRectangle(new SolidBrush(Color.Blue), rect.X,rect.Y,this.Width - rect.X,rect.Height);
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    graphics.DrawString(TabPages[i].Text, this.Font, new SolidBrush(Color.Red), rect, stringFormat);
                }
                else
                {
                    graphics.FillRectangle(new SolidBrush(Color.Blue), rect); 
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    graphics.DrawString(TabPages[i].Text, this.Font, new SolidBrush(Color.Red), rect, stringFormat);
                }
            }
            //graphics.FillRectangle();
            base.OnPaint(e);
        }
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.FillRectangle(new SolidBrush(Color.Blue),this.ClientRectangle);
            base.OnPaintBackground(pevent);
        }
    }
}
