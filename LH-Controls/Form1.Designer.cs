namespace LH_Controls
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lH_TabControl1 = new LH_Controls.Controls.LH_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lH_TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lH_TabControl1
            // 
            this.lH_TabControl1.Controls.Add(this.tabPage1);
            this.lH_TabControl1.Controls.Add(this.tabPage2);
            this.lH_TabControl1.Controls.Add(this.tabPage3);
            this.lH_TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.lH_TabControl1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lH_TabControl1.ItemSize = new System.Drawing.Size(200, 70);
            this.lH_TabControl1.Location = new System.Drawing.Point(189, 48);
            this.lH_TabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.lH_TabControl1.Name = "lH_TabControl1";
            this.lH_TabControl1.Padding = new System.Drawing.Point(0, 0);
            this.lH_TabControl1.SelectedIndex = 0;
            this.lH_TabControl1.SelectedTabForeColor = System.Drawing.Color.Green;
            this.lH_TabControl1.SelectFont = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lH_TabControl1.SelectTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lH_TabControl1.Size = new System.Drawing.Size(881, 529);
            this.lH_TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.lH_TabControl1.TabIndex = 0;
            this.lH_TabControl1.UnSeclectedtabForeColor = System.Drawing.Color.Red;
            this.lH_TabControl1.UnSelectFont = new System.Drawing.Font("微软雅黑", 14F);
            this.lH_TabControl1.UnSelectTabBackColor = System.Drawing.Color.MidnightBlue;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage1.Location = new System.Drawing.Point(4, 74);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(873, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "测试1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 74);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(873, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "测试2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SeaGreen;
            this.tabPage3.Location = new System.Drawing.Point(4, 74);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(873, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "压力测试";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1278, 763);
            this.Controls.Add(this.lH_TabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.lH_TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.LH_TabControl lH_TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

