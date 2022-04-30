namespace svg2vsdx_gui
{
    partial class Svg2Vsdx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Svg2Vsdx));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button_OpenFile = new System.Windows.Forms.Button();
            this.Button_Run = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.runprocess = new System.Windows.Forms.Label();
            this.About1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "svg文件路径";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(359, 21);
            this.textBox1.TabIndex = 1;
            // 
            // Button_OpenFile
            // 
            this.Button_OpenFile.Location = new System.Drawing.Point(495, 18);
            this.Button_OpenFile.Name = "Button_OpenFile";
            this.Button_OpenFile.Size = new System.Drawing.Size(75, 23);
            this.Button_OpenFile.TabIndex = 2;
            this.Button_OpenFile.Text = "打开";
            this.Button_OpenFile.UseVisualStyleBackColor = true;
            this.Button_OpenFile.Click += new System.EventHandler(this.Button_OpenFile_Click);
            // 
            // Button_Run
            // 
            this.Button_Run.Location = new System.Drawing.Point(576, 18);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(75, 23);
            this.Button_Run.TabIndex = 3;
            this.Button_Run.Text = "转换";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "转换进度";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(117, 54);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(358, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // runprocess
            // 
            this.runprocess.AutoSize = true;
            this.runprocess.Location = new System.Drawing.Point(497, 61);
            this.runprocess.Name = "runprocess";
            this.runprocess.Size = new System.Drawing.Size(35, 12);
            this.runprocess.TabIndex = 6;
            this.runprocess.Text = "(0/0)";
            // 
            // About1
            // 
            this.About1.AutoSize = true;
            this.About1.Location = new System.Drawing.Point(643, 96);
            this.About1.Name = "About1";
            this.About1.Size = new System.Drawing.Size(29, 12);
            this.About1.TabIndex = 7;
            this.About1.TabStop = true;
            this.About1.Text = "关于";
            this.About1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.About1_LinkClicked);
            // 
            // Svg2Vsdx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(684, 117);
            this.Controls.Add(this.About1);
            this.Controls.Add(this.runprocess);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.Button_OpenFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Svg2Vsdx";
            this.Text = "Svg2Vsdx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Button_OpenFile;
        private System.Windows.Forms.Button Button_Run;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label runprocess;
        private System.Windows.Forms.LinkLabel About1;
    }
}

