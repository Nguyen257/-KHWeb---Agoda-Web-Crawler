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
            this.rtxt1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegion = new System.Windows.Forms.Button();
            this.btnCityL = new System.Windows.Forms.Button();
            this.btnCityID = new System.Windows.Forms.Button();
            this.btnHotelID = new System.Windows.Forms.Button();
            this.btnCrawlerComment = new System.Windows.Forms.Button();
            this.btnCountry = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(1032, 229);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(106, 34);
            this.btnOutput.TabIndex = 0;
            this.btnOutput.Text = "Output Folder";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // rtxt1
            // 
            this.rtxt1.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtxt1.Location = new System.Drawing.Point(12, 88);
            this.rtxt1.Name = "rtxt1";
            this.rtxt1.Size = new System.Drawing.Size(1014, 423);
            this.rtxt1.TabIndex = 4;
            this.rtxt1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1032, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Input Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegion
            // 
            this.btnRegion.Location = new System.Drawing.Point(140, 23);
            this.btnRegion.Name = "btnRegion";
            this.btnRegion.Size = new System.Drawing.Size(122, 34);
            this.btnRegion.TabIndex = 10;
            this.btnRegion.Text = "Lấy Region Link";
            this.btnRegion.UseVisualStyleBackColor = true;
            this.btnRegion.Click += new System.EventHandler(this.btnRegion_Click);
            // 
            // btnCityL
            // 
            this.btnCityL.Location = new System.Drawing.Point(268, 23);
            this.btnCityL.Name = "btnCityL";
            this.btnCityL.Size = new System.Drawing.Size(122, 34);
            this.btnCityL.TabIndex = 11;
            this.btnCityL.Text = "Lấy City Link";
            this.btnCityL.UseVisualStyleBackColor = true;
            this.btnCityL.Click += new System.EventHandler(this.btnCityL_Click);
            // 
            // btnCityID
            // 
            this.btnCityID.Location = new System.Drawing.Point(396, 23);
            this.btnCityID.Name = "btnCityID";
            this.btnCityID.Size = new System.Drawing.Size(122, 34);
            this.btnCityID.TabIndex = 12;
            this.btnCityID.Text = "Lấy CityID";
            this.btnCityID.UseVisualStyleBackColor = true;
            this.btnCityID.Click += new System.EventHandler(this.btnCityID_Click);
            // 
            // btnHotelID
            // 
            this.btnHotelID.Location = new System.Drawing.Point(524, 23);
            this.btnHotelID.Name = "btnHotelID";
            this.btnHotelID.Size = new System.Drawing.Size(122, 34);
            this.btnHotelID.TabIndex = 13;
            this.btnHotelID.Text = "Lấy HotelID";
            this.btnHotelID.UseVisualStyleBackColor = true;
            this.btnHotelID.Click += new System.EventHandler(this.btnHotelID_Click);
            // 
            // btnCrawlerComment
            // 
            this.btnCrawlerComment.Location = new System.Drawing.Point(652, 23);
            this.btnCrawlerComment.Name = "btnCrawlerComment";
            this.btnCrawlerComment.Size = new System.Drawing.Size(122, 34);
            this.btnCrawlerComment.TabIndex = 14;
            this.btnCrawlerComment.Text = "Crawler Comment";
            this.btnCrawlerComment.UseVisualStyleBackColor = true;
            this.btnCrawlerComment.Click += new System.EventHandler(this.btnCrawlerComment_Click);
            // 
            // btnCountry
            // 
            this.btnCountry.Location = new System.Drawing.Point(12, 23);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(122, 34);
            this.btnCountry.TabIndex = 15;
            this.btnCountry.Text = "Lấy Country Link";
            this.btnCountry.UseVisualStyleBackColor = true;
            this.btnCountry.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(791, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Đọc File Output";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCountry);
            this.Controls.Add(this.btnCrawlerComment);
            this.Controls.Add(this.btnHotelID);
            this.Controls.Add(this.btnCityID);
            this.Controls.Add(this.btnCityL);
            this.Controls.Add(this.btnRegion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rtxt1);
            this.Controls.Add(this.btnOutput);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgodaWebCrawler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.RichTextBox rtxt1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRegion;
        private System.Windows.Forms.Button btnCityL;
        private System.Windows.Forms.Button btnCityID;
        private System.Windows.Forms.Button btnHotelID;
        private System.Windows.Forms.Button btnCrawlerComment;
        private System.Windows.Forms.Button btnCountry;
        private System.Windows.Forms.Button button1;
    }
}

