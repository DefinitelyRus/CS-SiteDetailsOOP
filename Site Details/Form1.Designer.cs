﻿namespace Site_Details
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.titleLabel = new System.Windows.Forms.Label();
			this.aboutButton = new System.Windows.Forms.Button();
			this.rulesButton = new System.Windows.Forms.Button();
			this.displayText = new System.Windows.Forms.TextBox();
			this.rateButton = new System.Windows.Forms.Button();
			this.opt5 = new System.Windows.Forms.Button();
			this.opt4 = new System.Windows.Forms.Button();
			this.opt3 = new System.Windows.Forms.Button();
			this.opt2 = new System.Windows.Forms.Button();
			this.opt1 = new System.Windows.Forms.Button();
			this.opt5Label = new System.Windows.Forms.Label();
			this.opt4Label = new System.Windows.Forms.Label();
			this.opt3Label = new System.Windows.Forms.Label();
			this.opt2Label = new System.Windows.Forms.Label();
			this.opt1Label = new System.Windows.Forms.Label();
			this.rateUsLabel = new System.Windows.Forms.Label();
			this.submitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Font = new System.Drawing.Font("Segoe UI Black", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.titleLabel.Location = new System.Drawing.Point(12, 12);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(615, 80);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "Yummyteh fud da sai\'";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// aboutButton
			// 
			this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
			this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.aboutButton.FlatAppearance.BorderSize = 0;
			this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.aboutButton.Font = new System.Drawing.Font("Segoe UI Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.aboutButton.Location = new System.Drawing.Point(633, 12);
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(160, 80);
			this.aboutButton.TabIndex = 2;
			this.aboutButton.Text = "About Us";
			this.aboutButton.UseVisualStyleBackColor = false;
			this.aboutButton.Click += new System.EventHandler(this.AboutBtn_OnClick);
			// 
			// rulesButton
			// 
			this.rulesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.rulesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.rulesButton.FlatAppearance.BorderSize = 0;
			this.rulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rulesButton.Font = new System.Drawing.Font("Segoe UI Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.rulesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
			this.rulesButton.Location = new System.Drawing.Point(799, 12);
			this.rulesButton.Name = "rulesButton";
			this.rulesButton.Size = new System.Drawing.Size(160, 80);
			this.rulesButton.TabIndex = 3;
			this.rulesButton.Text = "Rules";
			this.rulesButton.UseVisualStyleBackColor = false;
			this.rulesButton.Click += new System.EventHandler(this.RulesBtn_OnClick);
			// 
			// displayText
			// 
			this.displayText.AcceptsReturn = true;
			this.displayText.AcceptsTab = true;
			this.displayText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.displayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.displayText.Font = new System.Drawing.Font("Segoe UI Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.displayText.ForeColor = System.Drawing.Color.Silver;
			this.displayText.Location = new System.Drawing.Point(12, 112);
			this.displayText.Multiline = true;
			this.displayText.Name = "displayText";
			this.displayText.PlaceholderText = "dummy.";
			this.displayText.ReadOnly = true;
			this.displayText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.displayText.Size = new System.Drawing.Size(1115, 466);
			this.displayText.TabIndex = 4;
			this.displayText.TabStop = false;
			// 
			// rateButton
			// 
			this.rateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.rateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.rateButton.FlatAppearance.BorderSize = 0;
			this.rateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rateButton.Font = new System.Drawing.Font("Segoe UI Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.rateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
			this.rateButton.Location = new System.Drawing.Point(965, 12);
			this.rateButton.Name = "rateButton";
			this.rateButton.Size = new System.Drawing.Size(160, 80);
			this.rateButton.TabIndex = 5;
			this.rateButton.Text = "Rate Us";
			this.rateButton.UseVisualStyleBackColor = false;
			this.rateButton.Click += new System.EventHandler(this.RateBtn_OnClick);
			// 
			// opt5
			// 
			this.opt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.opt5.FlatAppearance.BorderSize = 0;
			this.opt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.opt5.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.opt5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
			this.opt5.Location = new System.Drawing.Point(198, 165);
			this.opt5.Name = "opt5";
			this.opt5.Size = new System.Drawing.Size(927, 60);
			this.opt5.TabIndex = 6;
			this.opt5.Text = "Never gonna give you up";
			this.opt5.UseVisualStyleBackColor = false;
			this.opt5.Visible = false;
			this.opt5.Click += new System.EventHandler(this.Rate5Btn_OnClick);
			// 
			// opt4
			// 
			this.opt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.opt4.FlatAppearance.BorderSize = 0;
			this.opt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.opt4.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.opt4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
			this.opt4.Location = new System.Drawing.Point(198, 231);
			this.opt4.Name = "opt4";
			this.opt4.Size = new System.Drawing.Size(927, 60);
			this.opt4.TabIndex = 7;
			this.opt4.Text = "Never gonna let you down";
			this.opt4.UseVisualStyleBackColor = false;
			this.opt4.Visible = false;
			this.opt4.Click += new System.EventHandler(this.Rate4Btn_OnClick);
			// 
			// opt3
			// 
			this.opt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.opt3.FlatAppearance.BorderSize = 0;
			this.opt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.opt3.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.opt3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
			this.opt3.Location = new System.Drawing.Point(198, 297);
			this.opt3.Name = "opt3";
			this.opt3.Size = new System.Drawing.Size(927, 60);
			this.opt3.TabIndex = 8;
			this.opt3.Text = "Never gonna run around";
			this.opt3.UseVisualStyleBackColor = false;
			this.opt3.Visible = false;
			this.opt3.Click += new System.EventHandler(this.Rate3Btn_OnClick);
			// 
			// opt2
			// 
			this.opt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.opt2.FlatAppearance.BorderSize = 0;
			this.opt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.opt2.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.opt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
			this.opt2.Location = new System.Drawing.Point(198, 363);
			this.opt2.Name = "opt2";
			this.opt2.Size = new System.Drawing.Size(927, 60);
			this.opt2.TabIndex = 9;
			this.opt2.Text = "and desert you";
			this.opt2.UseVisualStyleBackColor = false;
			this.opt2.Visible = false;
			this.opt2.Click += new System.EventHandler(this.Rate2Btn_OnClick);
			// 
			// opt1
			// 
			this.opt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.opt1.FlatAppearance.BorderSize = 0;
			this.opt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.opt1.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.opt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
			this.opt1.Location = new System.Drawing.Point(198, 429);
			this.opt1.Name = "opt1";
			this.opt1.Size = new System.Drawing.Size(927, 60);
			this.opt1.TabIndex = 10;
			this.opt1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
			this.opt1.UseVisualStyleBackColor = false;
			this.opt1.Visible = false;
			this.opt1.Click += new System.EventHandler(this.Rate1Btn_OnClick);
			// 
			// opt5Label
			// 
			this.opt5Label.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.opt5Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.opt5Label.Location = new System.Drawing.Point(12, 165);
			this.opt5Label.Name = "opt5Label";
			this.opt5Label.Size = new System.Drawing.Size(180, 60);
			this.opt5Label.TabIndex = 11;
			this.opt5Label.Text = "5 stars";
			this.opt5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.opt5Label.Visible = false;
			// 
			// opt4Label
			// 
			this.opt4Label.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.opt4Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.opt4Label.Location = new System.Drawing.Point(12, 231);
			this.opt4Label.Name = "opt4Label";
			this.opt4Label.Size = new System.Drawing.Size(180, 60);
			this.opt4Label.TabIndex = 12;
			this.opt4Label.Text = "4 stars";
			this.opt4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.opt4Label.Visible = false;
			// 
			// opt3Label
			// 
			this.opt3Label.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.opt3Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.opt3Label.Location = new System.Drawing.Point(12, 297);
			this.opt3Label.Name = "opt3Label";
			this.opt3Label.Size = new System.Drawing.Size(180, 60);
			this.opt3Label.TabIndex = 13;
			this.opt3Label.Text = "3 stars";
			this.opt3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.opt3Label.Visible = false;
			// 
			// opt2Label
			// 
			this.opt2Label.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.opt2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.opt2Label.Location = new System.Drawing.Point(12, 363);
			this.opt2Label.Name = "opt2Label";
			this.opt2Label.Size = new System.Drawing.Size(180, 60);
			this.opt2Label.TabIndex = 14;
			this.opt2Label.Text = "2 stars";
			this.opt2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.opt2Label.Visible = false;
			// 
			// opt1Label
			// 
			this.opt1Label.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.opt1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.opt1Label.Location = new System.Drawing.Point(12, 429);
			this.opt1Label.Name = "opt1Label";
			this.opt1Label.Size = new System.Drawing.Size(180, 60);
			this.opt1Label.TabIndex = 15;
			this.opt1Label.Text = "1 star";
			this.opt1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.opt1Label.Visible = false;
			// 
			// rateUsLabel
			// 
			this.rateUsLabel.Font = new System.Drawing.Font("Segoe UI Black", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.rateUsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.rateUsLabel.Location = new System.Drawing.Point(198, 112);
			this.rateUsLabel.Name = "rateUsLabel";
			this.rateUsLabel.Size = new System.Drawing.Size(927, 50);
			this.rateUsLabel.TabIndex = 16;
			this.rateUsLabel.Text = "Rate Us!";
			this.rateUsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rateUsLabel.Visible = false;
			// 
			// submitButton
			// 
			this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
			this.submitButton.FlatAppearance.BorderSize = 0;
			this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.submitButton.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.submitButton.Location = new System.Drawing.Point(578, 495);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(164, 83);
			this.submitButton.TabIndex = 17;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = false;
			this.submitButton.Visible = false;
			this.submitButton.Click += new System.EventHandler(this.SubmitBtn_OnClick);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.ClientSize = new System.Drawing.Size(1139, 587);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.rateUsLabel);
			this.Controls.Add(this.opt1Label);
			this.Controls.Add(this.opt2Label);
			this.Controls.Add(this.opt3Label);
			this.Controls.Add(this.opt4Label);
			this.Controls.Add(this.opt5Label);
			this.Controls.Add(this.opt1);
			this.Controls.Add(this.opt2);
			this.Controls.Add(this.opt3);
			this.Controls.Add(this.opt4);
			this.Controls.Add(this.opt5);
			this.Controls.Add(this.rateButton);
			this.Controls.Add(this.displayText);
			this.Controls.Add(this.rulesButton);
			this.Controls.Add(this.aboutButton);
			this.Controls.Add(this.titleLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MdiChildrenMinimizedAnchorBottom = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "yummytehfuddasaidotcomnyaaa~";
			this.Load += new System.EventHandler(this.Form1_OnLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public Label titleLabel;
        public Button aboutButton;
        public Button rulesButton;
        public Button rateButton;
        public Button opt5;
        public Button opt4;
        public Button opt3;
        public Button opt2;
        public Button opt1;
        public Label opt5Label;
        public Label opt4Label;
        public Label opt3Label;
        public Label opt2Label;
        public Label opt1Label;
        public TextBox displayText;
		public Label rateUsLabel;
		public Button submitButton;
	}
}