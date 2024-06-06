using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LH_Controls.Controls
{
    public class LH_TabControl:TabControl
    {
        private Color _unselectedtabforecolor = Color.Red;
        [Browsable(true)]
        [Category("LH")]
        [Description("未选中标签的文本前景色")]
        public Color UnSeclectedtabForeColor
        {
            get { return _unselectedtabforecolor; }
            set { _unselectedtabforecolor = value;this.Invalidate(); }
        }
        private Color _selectedtabforecolor = Color.White;
        [Browsable(true)]
        [Category("LH")]
        [Description("选中标签的文本前景色")]
        public Color SelectedTabForeColor
        {
            get { return _selectedtabforecolor; }
            set { _selectedtabforecolor = value; this.Invalidate(); }
        }
        private Color _unselecttabbackcolor = Color.Blue;
        [Browsable(true)]
        [Category("LH")]
        [Description("未选中标签的文本背景色")]
        public Color UnSelectTabBackColor
        {
            get { return _unselecttabbackcolor; }
            set { _unselecttabbackcolor = value; this.Invalidate(); }
        }
        private Color _selecttabbackcolor = Color.Green;
        [Browsable(true)]
        [Category("LH")]
        [Description("选中标签的文本背景色")]
        public Color SelectTabBackColor
        {
            get { return _selecttabbackcolor; }
            set { _selecttabbackcolor = value; this.Invalidate(); }
        }
        private Font _unselectfont = new Font("微软雅黑",12);
        [Browsable(true)]
        [Category("LH")]
        [Description("未选中标签的字体")]
        public Font UnSelectFont
        {
            get { return _unselectfont; }
            set { _unselectfont = value; this.Invalidate(); }
        }
        private Font _selectfont = new Font("微软雅黑", 16);
        [Browsable(true)]
        [Category("LH")]
        [Description("选中标签的字体")]
        public Font SelectFont
        {
            get { return _selectfont; }
            set { _selectfont = value; this.Invalidate(); }
        }
        public LH_TabControl()
        {
            this.SetStyle(ControlStyles.UserPaint,true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint,true);
            this.SetStyle(ControlStyles.Selectable,true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer,true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.SizeMode = TabSizeMode.Fixed;
            this.Padding = new Point(0,0);
            this.Margin = new Padding(0,0,0,0);
            this.Font = new Font("微软雅黑", 12);
        }
        private void SetGraphicsStyle(Graphics g)
        {
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            SetGraphicsStyle(graphics);
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
                    graphics.FillRectangle(new SolidBrush(_selecttabbackcolor), rect);
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Center;
                    graphics.DrawString(TabPages[i].Text, _selectfont, new SolidBrush(_selectedtabforecolor), rect, stringFormat);
                }
                else if (i == TabPages.Count - 1)
                {
                    graphics.FillRectangle(new SolidBrush(_unselecttabbackcolor), rect.X,rect.Y,this.Width - rect.X-4,rect.Height);
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    graphics.DrawString(TabPages[i].Text, _unselectfont, new SolidBrush(_unselectedtabforecolor), rect, stringFormat);
                }
                else
                {
                    graphics.FillRectangle(new SolidBrush(_unselecttabbackcolor), rect); 
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    graphics.DrawString(TabPages[i].Text, _unselectfont, new SolidBrush(_unselectedtabforecolor), rect, stringFormat);
                }
            }
            base.OnPaint(e);
        }
    }
}
