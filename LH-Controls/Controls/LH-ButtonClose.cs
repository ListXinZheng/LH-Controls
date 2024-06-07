using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace Hzzh.UI
{
    [DefaultEvent("Click")]
    public partial class btn_Close : UserControl
    {
        public btn_Close()
        {
            InitializeComponent();
            this.Invalidate();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            this.Paint += Btn_Close_Paint;
            this.MouseEnter += Btn_Close_MouseEnter;
            this.MouseLeave += Btn_Close_MouseLeave;
            this.SizeChanged += Btn_Close_SizeChanged;
        }
        private Matrix matrix = new Matrix();
        private void Btn_Close_SizeChanged(object sender, EventArgs e)
        {
            宽度 = this.Size.Width;
            this.Invalidate();
        }

        private Color color;
        [Category("新加属性"), Description("控件的背景颜色")]
        public Color 背景颜色
        {
            get { return color; }
            set { color = value;BackColor = value; this.Validate(); }
        }
        private void Btn_Close_MouseLeave(object sender, EventArgs e)
        {
            MouseHasEnter = false;
            ChangeColor = false;
            this.BackColor = color;
            this.CreateGraphics().Transform.Reset();
            this.Invalidate();
        }
        Graphics g;
        private bool MouseHasEnter;
        private bool ChangeColor;
        private void Btn_Close_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.Transform = matrix;
            Pen p = new Pen(ChangeColor ? entercolor : leavecolor, MouseHasEnter ? enterlength : leavelength);
            PointF lu = new PointF() { X = 5, Y = 5 };
            PointF rd = new PointF() { X = this.Width - 5, Y = this.Height - 5 };
            PointF ru = new PointF() { X = this.Width - 5, Y = 5 };
            PointF ld = new PointF() { X = 5, Y = this.Height - 5 };
            g.DrawLine(p, lu, rd);
            g.DrawLine(p, ru, ld);
        }
        private Color entercolor = Color.Red;
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
                if (value >5 || value <1)
                {
                    value = 3;
                } enterlength = value; this.Invalidate(); }
        }
        private int leavelength = 1;
        [Category("新加属性"), Description("鼠标离开时粗细")]
        public int 鼠标离开时粗细
        {
            get { return leavelength; }
            set {
                if (value > 4 || value < 1)
                {
                    value = 3;
                }
                leavelength = value;this.Invalidate(); }
        }

        private void Btn_Close_MouseEnter(object sender, EventArgs e)
        {
            MouseHasEnter = true;
            if (UseFlash)
            {
                IAsyncResult result = Task.Run(() => {
                    Graphics gra = this.CreateGraphics();
                    matrix = gra.Transform.Clone();
                    for (int i = 0; i < 6; i++)
                    {
                        matrix.RotateAt(15, new PointF(this.Height / 2, this.wide / 2));
                        gra.Transform = matrix;
                        this.Invalidate();
                        Thread.Sleep(FlashTime);
                    }
                });
                result.AsyncWaitHandle.WaitOne();
            }
            ChangeColor = true;
            this.Invalidate();
        }
        private bool useflash = true;
        [Category("新加属性"), Description("是否使用旋转")]
        public bool UseFlash
        {
            get { return useflash; }
            set { useflash = value; }
        }

        private int flashtime = 30;
        [Category("新加属性"), Description("转换时间")]
        public int FlashTime
        {
            get { return flashtime; }
            set {
                if (value <10 || value >1000)
                {
                    value = 30;
                }
                flashtime = value; }
        }

        private int wide;
        [Category("新加属性"), Description("控件的长宽")]
        public int 宽度
        {
            get { return wide; }
            set
            {
                if (value < 10)
                {
                    value = 10;
                }
                wide = value;
                this.Width = value;
                this.Height = value;
                this.Invalidate();
            }
        }
    }
}
