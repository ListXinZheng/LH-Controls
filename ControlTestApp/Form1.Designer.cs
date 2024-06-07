namespace ControlTestApp
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
            this.lH_TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lH_TabControl1
            // 
            this.lH_TabControl1.Controls.Add(this.tabPage1);
            this.lH_TabControl1.Controls.Add(this.tabPage2);
            this.lH_TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.lH_TabControl1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lH_TabControl1.ItemSize = new System.Drawing.Size(150, 35);
            this.lH_TabControl1.Location = new System.Drawing.Point(173, 45);
            this.lH_TabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.lH_TabControl1.Name = "lH_TabControl1";
            this.lH_TabControl1.Padding = new System.Drawing.Point(0, 0);
            this.lH_TabControl1.SelectedIndex = 0;
            this.lH_TabControl1.SelectedTabForeColor = System.Drawing.Color.White;
            this.lH_TabControl1.SelectFont = new System.Drawing.Font("微软雅黑", 16F);
            this.lH_TabControl1.SelectTabBackColor = System.Drawing.Color.Green;
            this.lH_TabControl1.Size = new System.Drawing.Size(472, 301);
            this.lH_TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.lH_TabControl1.TabIndex = 0;
            this.lH_TabControl1.UnSeclectedtabForeColor = System.Drawing.Color.Red;
            this.lH_TabControl1.UnSelectFont = new System.Drawing.Font("微软雅黑", 12F);
            this.lH_TabControl1.UnSelectTabBackColor = System.Drawing.Color.Blue;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Blue;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(464, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Green;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(464, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lH_TabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.lH_TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LH_Controls.Controls.LH_TabControl lH_TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

