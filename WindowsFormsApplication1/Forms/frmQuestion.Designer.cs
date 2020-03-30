namespace WindowsFormsApplication1
{
    partial class frmQuestion
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblRiskAmount = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.bttnA = new System.Windows.Forms.Button();
            this.bttnB = new System.Windows.Forms.Button();
            this.bttnC = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.tokenAmount = new System.Windows.Forms.Label();
            this.currentTokens = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUESTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "CATEGORY:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "RISK AMOUNT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "QUESTION:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategory.Location = new System.Drawing.Point(361, 183);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(236, 33);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "CATEGORYXXX";
            // 
            // lblRiskAmount
            // 
            this.lblRiskAmount.AutoSize = true;
            this.lblRiskAmount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRiskAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiskAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRiskAmount.Location = new System.Drawing.Point(382, 248);
            this.lblRiskAmount.Name = "lblRiskAmount";
            this.lblRiskAmount.Size = new System.Drawing.Size(265, 33);
            this.lblRiskAmount.TabIndex = 8;
            this.lblRiskAmount.Text = "RISKAMOUNTXXX";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuestion.Location = new System.Drawing.Point(287, 321);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(641, 24);
            this.lblQuestion.TabIndex = 9;
            this.lblQuestion.Text = "What is the average length of a question, lots of many words test test test test";
            // 
            // bttnA
            // 
            this.bttnA.Location = new System.Drawing.Point(174, 491);
            this.bttnA.Name = "bttnA";
            this.bttnA.Size = new System.Drawing.Size(148, 62);
            this.bttnA.TabIndex = 10;
            this.bttnA.Text = "button1";
            this.bttnA.UseVisualStyleBackColor = true;
            this.bttnA.Click += new System.EventHandler(this.bttnA_Click);
            // 
            // bttnB
            // 
            this.bttnB.Location = new System.Drawing.Point(403, 491);
            this.bttnB.Name = "bttnB";
            this.bttnB.Size = new System.Drawing.Size(148, 62);
            this.bttnB.TabIndex = 11;
            this.bttnB.Text = "alskdjhawlrfu ghsarlkfuhas fiushflais hsadf;i";
            this.bttnB.UseVisualStyleBackColor = true;
            this.bttnB.Click += new System.EventHandler(this.bttnB_Click);
            // 
            // bttnC
            // 
            this.bttnC.Location = new System.Drawing.Point(633, 491);
            this.bttnC.Name = "bttnC";
            this.bttnC.Size = new System.Drawing.Size(148, 62);
            this.bttnC.TabIndex = 12;
            this.bttnC.Text = "button3";
            this.bttnC.UseVisualStyleBackColor = true;
            this.bttnC.Click += new System.EventHandler(this.bttnC_Click);
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Aqua;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(748, 579);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(176, 82);
            this.continueButton.TabIndex = 29;
            this.continueButton.Text = "Continue>>>";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // tokenAmount
            // 
            this.tokenAmount.AutoSize = true;
            this.tokenAmount.BackColor = System.Drawing.Color.White;
            this.tokenAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenAmount.ForeColor = System.Drawing.Color.Black;
            this.tokenAmount.Location = new System.Drawing.Point(863, 135);
            this.tokenAmount.Name = "tokenAmount";
            this.tokenAmount.Size = new System.Drawing.Size(24, 24);
            this.tokenAmount.TabIndex = 30;
            this.tokenAmount.Text = "X";
            // 
            // currentTokens
            // 
            this.currentTokens.AutoSize = true;
            this.currentTokens.BackColor = System.Drawing.Color.White;
            this.currentTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTokens.Location = new System.Drawing.Point(713, 135);
            this.currentTokens.Name = "currentTokens";
            this.currentTokens.Size = new System.Drawing.Size(150, 24);
            this.currentTokens.TabIndex = 31;
            this.currentTokens.Text = "Current Tokens :";
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(950, 673);
            this.Controls.Add(this.currentTokens);
            this.Controls.Add(this.tokenAmount);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.bttnC);
            this.Controls.Add(this.bttnB);
            this.Controls.Add(this.bttnA);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblRiskAmount);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQuestion";
            this.Text = "Question";
            this.Load += new System.EventHandler(this.frmQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblRiskAmount;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button bttnA;
        private System.Windows.Forms.Button bttnB;
        private System.Windows.Forms.Button bttnC;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label tokenAmount;
        private System.Windows.Forms.Label currentTokens;
    }
}