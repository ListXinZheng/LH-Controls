using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hzzh.Terminal.UI.App.Control
{
    [DefaultEvent("Click")]
    public partial class btn_About : UserControl
    {
        public btn_About()
        {
            InitializeComponent();
            this.Invalidate();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            this.Paint += Btn_About_Paint;
            this.MouseEnter += Btn_About_MouseEnter;
            this.MouseLeave += Btn_About_MouseLeave;
        }
       
        private void Btn_About_MouseLeave(object sender, EventArgs e)
        {
            MouseHasEnter = false;
            this.Invalidate();
        }
        Graphics g;
        private bool MouseHasEnter;
        private void Btn_About_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen p = new Pen(MouseHasEnter? entercolor: leavecolor, MouseHasEnter ? enterlength : leavelength);
            PointF l1 = new PointF() { X = borderlength, Y = borderlength };
            PointF r1 = new PointF() { X = Width - borderlength, Y = borderlength };
            PointF l2 = new PointF() { X = borderlength, Y = this.Height/2 };
            PointF r2 = new PointF() { X = Width - borderlength, Y = this.Height / 2 };
            PointF l3 = new PointF() { X = borderlength, Y = this.Height- borderlength };
            PointF r3 = new PointF() { X = Width - borderlength, Y = this.Height - borderlength };
            g.DrawLine(p, l1, r1);
            g.DrawLine(p, l2, r2);
            g.DrawLine(p, l3, r3);
        }
        private int borderlength = 10;
        [Category("新加属性"), Description("距离四周多远")]
        public int BorderLength
        {
            get { return borderlength; }
            set { borderlength = value; this.Invalidate(); }
        }

        private Color entercolor = Color.Black;
        [Category("新加属性"), Description("鼠标进入时图标颜色")]
        public Color 鼠标进入时颜色
        {
            get { return entercolor; }
            set { entercolor = value; this.Invalidate(); }
        }
        private Color leavecolor = Color.Black;
        [Category("新加属性"), Description("鼠标离开时图标颜色")]
        public Color 鼠标离开时颜色
        {
            get { return leavecolor; }
            set { leavecolor = value; this.Invalidate(); }
        }

        private int enterlength = 3;
        [Category("新加属性"), Description("鼠标进入时粗细")]
        public int 鼠标进入时粗细
        {
            get { return enterlength; }
            set
            {
                if (value > 5 || value < 1)
                {
                    value = 3;
                }
                enterlength = value; this.Invalidate();
            }
        }
        private int leavelength = 1;
        [Category("新加属性"), Description("鼠标离开时粗细")]
        public int 鼠标离开时粗细
        {
            get { return leavelength; }
            set
            {
                if (value > 4 || value < 1)
                {
                    value = 3;
                }
                leavelength = value; this.Invalidate();
            }
        }

        private void Btn_About_MouseEnter(object sender, EventArgs e)
        {
            MouseHasEnter = true;
            this.Invalidate();
        }
    }
}
