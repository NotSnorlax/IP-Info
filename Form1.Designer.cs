﻿namespace IPgrab
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ip = new System.Windows.Forms.Label();
			this.anycast = new System.Windows.Forms.Label();
			this.city = new System.Windows.Forms.Label();
			this.region = new System.Windows.Forms.Label();
			this.country = new System.Windows.Forms.Label();
			this.loc = new System.Windows.Forms.Label();
			this.org = new System.Windows.Forms.Label();
			this.postal = new System.Windows.Forms.Label();
			this.timezone = new System.Windows.Forms.Label();
			this.readme = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(458, 70);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::IPgrab.Properties.Resources.ipgrabiconbigtransparent2;
			this.pictureBox1.Location = new System.Drawing.Point(391, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(13, 40);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Welcome, enter IP to look up.";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP Info";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 150);
			this.label3.TabIndex = 1;
			this.label3.Text = "IP:\r\nAnycast:\r\nCity:\r\nRegion:\r\nCountry:\r\nLoc:\r\nOrg:\r\nPostal:\r\nTimezone:\r\nReadme:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ip
			// 
			this.ip.AutoEllipsis = true;
			this.ip.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ip.Location = new System.Drawing.Point(79, 85);
			this.ip.Name = "ip";
			this.ip.Size = new System.Drawing.Size(347, 14);
			this.ip.TabIndex = 2;
			this.ip.Text = "[ip]";
			// 
			// anycast
			// 
			this.anycast.AutoEllipsis = true;
			this.anycast.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.anycast.Location = new System.Drawing.Point(79, 100);
			this.anycast.Name = "anycast";
			this.anycast.Size = new System.Drawing.Size(347, 14);
			this.anycast.TabIndex = 3;
			this.anycast.Text = "[anycast]";
			// 
			// city
			// 
			this.city.AutoEllipsis = true;
			this.city.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.city.Location = new System.Drawing.Point(79, 115);
			this.city.Name = "city";
			this.city.Size = new System.Drawing.Size(347, 14);
			this.city.TabIndex = 4;
			this.city.Text = "[city]";
			// 
			// region
			// 
			this.region.AutoEllipsis = true;
			this.region.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.region.Location = new System.Drawing.Point(79, 130);
			this.region.Name = "region";
			this.region.Size = new System.Drawing.Size(347, 14);
			this.region.TabIndex = 5;
			this.region.Text = "[region]";
			// 
			// country
			// 
			this.country.AutoEllipsis = true;
			this.country.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.country.Location = new System.Drawing.Point(79, 145);
			this.country.Name = "country";
			this.country.Size = new System.Drawing.Size(347, 14);
			this.country.TabIndex = 6;
			this.country.Text = "[country]";
			// 
			// loc
			// 
			this.loc.AutoEllipsis = true;
			this.loc.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loc.Location = new System.Drawing.Point(79, 160);
			this.loc.Name = "loc";
			this.loc.Size = new System.Drawing.Size(347, 14);
			this.loc.TabIndex = 7;
			this.loc.Text = "[loc]";
			// 
			// org
			// 
			this.org.AutoEllipsis = true;
			this.org.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.org.Location = new System.Drawing.Point(79, 175);
			this.org.Name = "org";
			this.org.Size = new System.Drawing.Size(347, 14);
			this.org.TabIndex = 8;
			this.org.Text = "[org]";
			// 
			// postal
			// 
			this.postal.AutoEllipsis = true;
			this.postal.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.postal.Location = new System.Drawing.Point(79, 190);
			this.postal.Name = "postal";
			this.postal.Size = new System.Drawing.Size(347, 14);
			this.postal.TabIndex = 9;
			this.postal.Text = "[postal]";
			// 
			// timezone
			// 
			this.timezone.AutoEllipsis = true;
			this.timezone.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timezone.Location = new System.Drawing.Point(79, 205);
			this.timezone.Name = "timezone";
			this.timezone.Size = new System.Drawing.Size(347, 14);
			this.timezone.TabIndex = 10;
			this.timezone.Text = "[timezone]";
			// 
			// readme
			// 
			this.readme.AutoEllipsis = true;
			this.readme.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.readme.Location = new System.Drawing.Point(79, 220);
			this.readme.Name = "readme";
			this.readme.Size = new System.Drawing.Size(347, 14);
			this.readme.TabIndex = 11;
			this.readme.Text = "[readme]";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(16, 253);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(116, 15);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "xxx.xxx.xxx.xxx";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button1.Location = new System.Drawing.Point(138, 247);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 26);
			this.button1.TabIndex = 1;
			this.button1.Text = "Connect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button2.Location = new System.Drawing.Point(371, 247);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 26);
			this.button2.TabIndex = 12;
			this.button2.Text = "Copy all";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.Red;
			this.button3.Location = new System.Drawing.Point(287, 247);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 26);
			this.button3.TabIndex = 13;
			this.button3.Text = "Exit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button13
			// 
			this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
			this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button13.Location = new System.Drawing.Point(432, 220);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(14, 14);
			this.button13.TabIndex = 11;
			this.button13.UseVisualStyleBackColor = false;
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button9.Location = new System.Drawing.Point(432, 205);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(14, 14);
			this.button9.TabIndex = 10;
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button10.Location = new System.Drawing.Point(432, 190);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(14, 14);
			this.button10.TabIndex = 9;
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button11.Location = new System.Drawing.Point(432, 175);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(14, 14);
			this.button11.TabIndex = 8;
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// button12
			// 
			this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button12.Location = new System.Drawing.Point(432, 160);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(14, 14);
			this.button12.TabIndex = 7;
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button8.Location = new System.Drawing.Point(432, 145);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(14, 14);
			this.button8.TabIndex = 6;
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button7.Location = new System.Drawing.Point(432, 130);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(14, 14);
			this.button7.TabIndex = 5;
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button6.Location = new System.Drawing.Point(432, 115);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(14, 14);
			this.button6.TabIndex = 4;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button5.Location = new System.Drawing.Point(432, 100);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(14, 14);
			this.button5.TabIndex = 3;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button4.Location = new System.Drawing.Point(432, 85);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(14, 14);
			this.button4.TabIndex = 2;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(458, 286);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.readme);
			this.Controls.Add(this.timezone);
			this.Controls.Add(this.postal);
			this.Controls.Add(this.org);
			this.Controls.Add(this.loc);
			this.Controls.Add(this.country);
			this.Controls.Add(this.region);
			this.Controls.Add(this.city);
			this.Controls.Add(this.anycast);
			this.Controls.Add(this.ip);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "IP Info";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ip;
        private System.Windows.Forms.Label anycast;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label region;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label loc;
        private System.Windows.Forms.Label org;
        private System.Windows.Forms.Label postal;
        private System.Windows.Forms.Label timezone;
        private System.Windows.Forms.Label readme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

