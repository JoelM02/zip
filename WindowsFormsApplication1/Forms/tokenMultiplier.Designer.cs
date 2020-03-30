namespace WindowsFormsApplication1
{
    partial class tokenMultiplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTopicSelected = new System.Windows.Forms.Label();
            this.tokenAmount = new System.Windows.Forms.Label();
            this.currentTokens = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRisk1 = new System.Windows.Forms.Button();
            this.buttonRisk2 = new System.Windows.Forms.Button();
            this.buttonRisk3 = new System.Windows.Forms.Button();
            this.arrowPointDown = new System.Windows.Forms.PictureBox();
            this.continueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPointDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(134, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOKEN MULTIPLIER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(410, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Category";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTopicSelected
            // 
            this.lblTopicSelected.AutoSize = true;
            this.lblTopicSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicSelected.ForeColor = System.Drawing.Color.White;
            this.lblTopicSelected.Location = new System.Drawing.Point(408, 579);
            this.lblTopicSelected.Name = "lblTopicSelected";
            this.lblTopicSelected.Size = new System.Drawing.Size(152, 31);
            this.lblTopicSelected.TabIndex = 4;
            this.lblTopicSelected.Text = "TOPICXXX";
            this.lblTopicSelected.Click += new System.EventHandler(this.lblTopicSelected_Click);
            // 
            // tokenAmount
            // 
            this.tokenAmount.AutoSize = true;
            this.tokenAmount.BackColor = System.Drawing.Color.White;
            this.tokenAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenAmount.ForeColor = System.Drawing.Color.Black;
            this.tokenAmount.Location = new System.Drawing.Point(169, 162);
            this.tokenAmount.Name = "tokenAmount";
            this.tokenAmount.Size = new System.Drawing.Size(24, 24);
            this.tokenAmount.TabIndex = 22;
            this.tokenAmount.Text = "X";
            this.tokenAmount.Click += new System.EventHandler(this.tokenAmount_Click);
            // 
            // currentTokens
            // 
            this.currentTokens.AutoSize = true;
            this.currentTokens.BackColor = System.Drawing.Color.White;
            this.currentTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTokens.Location = new System.Drawing.Point(23, 162);
            this.currentTokens.Name = "currentTokens";
            this.currentTokens.Size = new System.Drawing.Size(150, 24);
            this.currentTokens.TabIndex = 21;
            this.currentTokens.Text = "Current Tokens :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.question_mark1;
            this.pictureBox1.Location = new System.Drawing.Point(838, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonRisk1
            // 
            this.buttonRisk1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRisk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRisk1.Location = new System.Drawing.Point(414, 171);
            this.buttonRisk1.Name = "buttonRisk1";
            this.buttonRisk1.Size = new System.Drawing.Size(149, 83);
            this.buttonRisk1.TabIndex = 24;
            this.buttonRisk1.Text = "Risk ONE Token";
            this.buttonRisk1.UseVisualStyleBackColor = false;
            this.buttonRisk1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRisk2
            // 
            this.buttonRisk2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRisk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRisk2.Location = new System.Drawing.Point(414, 273);
            this.buttonRisk2.Name = "buttonRisk2";
            this.buttonRisk2.Size = new System.Drawing.Size(149, 83);
            this.buttonRisk2.TabIndex = 25;
            this.buttonRisk2.Text = "Risk TWO Tokens";
            this.buttonRisk2.UseVisualStyleBackColor = false;
            this.buttonRisk2.Click += new System.EventHandler(this.buttonRisk2_Click);
            // 
            // buttonRisk3
            // 
            this.buttonRisk3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRisk3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRisk3.Location = new System.Drawing.Point(414, 378);
            this.buttonRisk3.Name = "buttonRisk3";
            this.buttonRisk3.Size = new System.Drawing.Size(149, 83);
            this.buttonRisk3.TabIndex = 26;
            this.buttonRisk3.Text = "Risk THREE Tokens";
            this.buttonRisk3.UseVisualStyleBackColor = false;
            this.buttonRisk3.Click += new System.EventHandler(this.buttonRisk3_Click);
            // 
            // arrowPointDown
            // 
            this.arrowPointDown.Image = global::WindowsFormsApplication1.Properties.Resources.arrow;
            this.arrowPointDown.Location = new System.Drawing.Point(471, 522);
            this.arrowPointDown.Name = "arrowPointDown";
            this.arrowPointDown.Size = new System.Drawing.Size(34, 36);
            this.arrowPointDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowPointDown.TabIndex = 27;
            this.arrowPointDown.TabStop = false;
            this.arrowPointDown.Click += new System.EventHandler(this.arrowPointDown_Click);
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Aqua;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(760, 567);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(176, 82);
            this.continueButton.TabIndex = 28;
            this.continueButton.Text = "Continue to Question>>>";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // tokenMultiplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(950, 673);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.arrowPointDown);
            this.Controls.Add(this.buttonRisk3);
            this.Controls.Add(this.buttonRisk2);
            this.Controls.Add(this.buttonRisk1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tokenAmount);
            this.Controls.Add(this.currentTokens);
            this.Controls.Add(this.lblTopicSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tokenMultiplier";
            this.Text = "tokenMultiplier";
            this.Load += new System.EventHandler(this.tokenMultiplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPointDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTopicSelected;
        private System.Windows.Forms.Label tokenAmount;
        private System.Windows.Forms.Label currentTokens;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRisk1;
        private System.Windows.Forms.Button buttonRisk2;
        private System.Windows.Forms.Button buttonRisk3;
        private System.Windows.Forms.PictureBox arrowPointDown;
        private System.Windows.Forms.Button continueButton;
    }
}