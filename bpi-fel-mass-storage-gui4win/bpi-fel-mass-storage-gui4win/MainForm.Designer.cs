namespace bpi_fel_mass_storage_gui4win
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DetectDevTyp = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Launch = new System.Windows.Forms.Button();
            this.DetectBox = new System.Windows.Forms.GroupBox();
            this.DetectOut = new System.Windows.Forms.Label();
            this.DetectBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetectDevTyp
            // 
            this.DetectDevTyp.Location = new System.Drawing.Point(277, 62);
            this.DetectDevTyp.Name = "DetectDevTyp";
            this.DetectDevTyp.Size = new System.Drawing.Size(111, 37);
            this.DetectDevTyp.TabIndex = 0;
            this.DetectDevTyp.Text = "Detect Device";
            this.DetectDevTyp.UseVisualStyleBackColor = true;
            this.DetectDevTyp.Click += new System.EventHandler(this.DetectDevTyp_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(511, 62);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(111, 37);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(12, 62);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(111, 37);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Launch
            // 
            this.Launch.Location = new System.Drawing.Point(394, 62);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(111, 37);
            this.Launch.TabIndex = 3;
            this.Launch.Text = "Launch";
            this.Launch.UseVisualStyleBackColor = true;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // DetectBox
            // 
            this.DetectBox.Controls.Add(this.DetectOut);
            this.DetectBox.Location = new System.Drawing.Point(12, 5);
            this.DetectBox.Name = "DetectBox";
            this.DetectBox.Size = new System.Drawing.Size(610, 44);
            this.DetectBox.TabIndex = 4;
            this.DetectBox.TabStop = false;
            this.DetectBox.Text = "Device Info";
            // 
            // DetectOut
            // 
            this.DetectOut.AutoSize = true;
            this.DetectOut.Location = new System.Drawing.Point(12, 20);
            this.DetectOut.Name = "DetectOut";
            this.DetectOut.Size = new System.Drawing.Size(221, 12);
            this.DetectOut.TabIndex = 0;
            this.DetectOut.Text = "INFO: Press the Detect Device first!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 111);
            this.Controls.Add(this.DetectBox);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DetectDevTyp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BPI FEL USB Mass Storage Launcher";
            this.DetectBox.ResumeLayout(false);
            this.DetectBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DetectDevTyp;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Launch;
        private System.Windows.Forms.GroupBox DetectBox;
        private System.Windows.Forms.Label DetectOut;
    }
}

