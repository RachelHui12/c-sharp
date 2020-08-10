namespace polygon
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.输入多边形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多边形1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多边形2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.面积ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.着色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.凹凸ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.定位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.凸包ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.双操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.求交ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.求并ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.求差ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1161, 682);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.输入多边形ToolStripMenuItem,
            this.单操作ToolStripMenuItem,
            this.双操作ToolStripMenuItem,
            this.清屏ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1185, 39);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 输入多边形ToolStripMenuItem
            // 
            this.输入多边形ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.多边形1ToolStripMenuItem,
            this.多边形2ToolStripMenuItem});
            this.输入多边形ToolStripMenuItem.Name = "输入多边形ToolStripMenuItem";
            this.输入多边形ToolStripMenuItem.Size = new System.Drawing.Size(154, 35);
            this.输入多边形ToolStripMenuItem.Text = "输入多边形";
            // 
            // 多边形1ToolStripMenuItem
            // 
            this.多边形1ToolStripMenuItem.Name = "多边形1ToolStripMenuItem";
            this.多边形1ToolStripMenuItem.Size = new System.Drawing.Size(233, 44);
            this.多边形1ToolStripMenuItem.Text = "多边形1";
            this.多边形1ToolStripMenuItem.Click += new System.EventHandler(this.polygon1_click);
            // 
            // 多边形2ToolStripMenuItem
            // 
            this.多边形2ToolStripMenuItem.Name = "多边形2ToolStripMenuItem";
            this.多边形2ToolStripMenuItem.Size = new System.Drawing.Size(233, 44);
            this.多边形2ToolStripMenuItem.Text = "多边形2";
            this.多边形2ToolStripMenuItem.Click += new System.EventHandler(this.polygon2_click);
            // 
            // 单操作ToolStripMenuItem
            // 
            this.单操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.面积ToolStripMenuItem,
            this.着色ToolStripMenuItem,
            this.凹凸ToolStripMenuItem,
            this.定位ToolStripMenuItem,
            this.凸包ToolStripMenuItem});
            this.单操作ToolStripMenuItem.Name = "单操作ToolStripMenuItem";
            this.单操作ToolStripMenuItem.Size = new System.Drawing.Size(106, 35);
            this.单操作ToolStripMenuItem.Text = "单操作";
            // 
            // 面积ToolStripMenuItem
            // 
            this.面积ToolStripMenuItem.Name = "面积ToolStripMenuItem";
            this.面积ToolStripMenuItem.Size = new System.Drawing.Size(195, 44);
            this.面积ToolStripMenuItem.Text = "面积";
            this.面积ToolStripMenuItem.Click += new System.EventHandler(this.area_click);
            // 
            // 着色ToolStripMenuItem
            // 
            this.着色ToolStripMenuItem.Name = "着色ToolStripMenuItem";
            this.着色ToolStripMenuItem.Size = new System.Drawing.Size(195, 44);
            this.着色ToolStripMenuItem.Text = "着色";
            this.着色ToolStripMenuItem.Click += new System.EventHandler(this.fill_color_click);
            // 
            // 凹凸ToolStripMenuItem
            // 
            this.凹凸ToolStripMenuItem.Name = "凹凸ToolStripMenuItem";
            this.凹凸ToolStripMenuItem.Size = new System.Drawing.Size(195, 44);
            this.凹凸ToolStripMenuItem.Text = "凹凸";
            this.凹凸ToolStripMenuItem.Click += new System.EventHandler(this.Convexity);
            // 
            // 定位ToolStripMenuItem
            // 
            this.定位ToolStripMenuItem.Name = "定位ToolStripMenuItem";
            this.定位ToolStripMenuItem.Size = new System.Drawing.Size(195, 44);
            this.定位ToolStripMenuItem.Text = "定位";
            this.定位ToolStripMenuItem.Click += new System.EventHandler(this.location_click);
            // 
            // 凸包ToolStripMenuItem
            // 
            this.凸包ToolStripMenuItem.Name = "凸包ToolStripMenuItem";
            this.凸包ToolStripMenuItem.Size = new System.Drawing.Size(195, 44);
            this.凸包ToolStripMenuItem.Text = "凸包";
            // 
            // 双操作ToolStripMenuItem
            // 
            this.双操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.求交ToolStripMenuItem,
            this.求并ToolStripMenuItem,
            this.求差ToolStripMenuItem});
            this.双操作ToolStripMenuItem.Name = "双操作ToolStripMenuItem";
            this.双操作ToolStripMenuItem.Size = new System.Drawing.Size(106, 35);
            this.双操作ToolStripMenuItem.Text = "双操作";
            // 
            // 求交ToolStripMenuItem
            // 
            this.求交ToolStripMenuItem.Name = "求交ToolStripMenuItem";
            this.求交ToolStripMenuItem.Size = new System.Drawing.Size(195, 44);
            this.求交ToolStripMenuItem.Text = "求交";
            // 
            // 求并ToolStripMenuItem
            // 
            this.求并ToolStripMenuItem.Name = "求并ToolStripMenuItem";
            this.求并ToolStripMenuItem.Size = new System.Drawing.Size(195, 44);
            this.求并ToolStripMenuItem.Text = "求并";
            // 
            // 求差ToolStripMenuItem
            // 
            this.求差ToolStripMenuItem.Name = "求差ToolStripMenuItem";
            this.求差ToolStripMenuItem.Size = new System.Drawing.Size(195, 44);
            this.求差ToolStripMenuItem.Text = "求差";
            // 
            // 清屏ToolStripMenuItem
            // 
            this.清屏ToolStripMenuItem.Name = "清屏ToolStripMenuItem";
            this.清屏ToolStripMenuItem.Size = new System.Drawing.Size(82, 35);
            this.清屏ToolStripMenuItem.Text = "清屏";
            this.清屏ToolStripMenuItem.Click += new System.EventHandler(this.clear_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 735);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 输入多边形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多边形1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多边形2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 面积ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 着色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 凹凸ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 定位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 凸包ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 双操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 求交ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 求并ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 求差ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清屏ToolStripMenuItem;
    }
}

