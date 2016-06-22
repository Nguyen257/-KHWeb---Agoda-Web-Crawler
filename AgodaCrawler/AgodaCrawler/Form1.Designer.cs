namespace AgodaCrawler
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnCrawler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.rtxt1 = new System.Windows.Forms.RichTextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(1064, 23);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 0;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnCrawler
            // 
            this.btnCrawler.Location = new System.Drawing.Point(936, 23);
            this.btnCrawler.Name = "btnCrawler";
            this.btnCrawler.Size = new System.Drawing.Size(75, 23);
            this.btnCrawler.TabIndex = 1;
            this.btnCrawler.Text = "Crawler";
            this.btnCrawler.UseVisualStyleBackColor = true;
            this.btnCrawler.Click += new System.EventHandler(this.btnCrawler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL :";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(104, 25);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(667, 20);
            this.txtUrl.TabIndex = 3;
            // 
            // rtxt1
            // 
            this.rtxt1.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtxt1.Location = new System.Drawing.Point(16, 120);
            this.rtxt1.Name = "rtxt1";
            this.rtxt1.Size = new System.Drawing.Size(1132, 387);
            this.rtxt1.TabIndex = 4;
            this.rtxt1.Text = "";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(16, 59);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 25);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "     ";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiaChi.Location = new System.Drawing.Point(18, 101);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(132, 16);
            this.lbDiaChi.TabIndex = 6;
            this.lbDiaChi.Text = "                               ";
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(740, 59);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(279, 20);
            this.lbDiem.TabIndex = 7;
            this.lbDiem.Text = "                                                      ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(936, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.rtxt1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrawler);
            this.Controls.Add(this.btnOutput);
            this.Name = "MainForm";
            this.Text = "AgodaWebCrawler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnCrawler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.RichTextBox rtxt1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Button button1;
    }
}

