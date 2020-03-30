namespace WindowsFormsApplication1
{
    partial class frmTopicPicker
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.lblScience = new System.Windows.Forms.Label();
            this.lblSport = new System.Windows.Forms.Label();
            this.lblGeography = new System.Windows.Forms.Label();
            this.lblAnimals = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.currentTokens = new System.Windows.Forms.Label();
            this.tokenAmount = new System.Windows.Forms.Label();
            this.lblRandomTopic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "RANDOM TOPIC PICKER";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(392, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 96);
            this.button1.TabIndex = 2;
            this.button1.Text = "Press here to randomly select a topic!!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.ForeColor = System.Drawing.Color.Blue;
            this.lblGeneral.Location = new System.Drawing.Point(693, 158);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(245, 29);
            this.lblGeneral.TabIndex = 3;
            this.lblGeneral.Text = "General Knowledge";
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScience.ForeColor = System.Drawing.Color.Yellow;
            this.lblScience.Location = new System.Drawing.Point(625, 564);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(306, 29);
            this.lblScience.TabIndex = 4;
            this.lblScience.Text = "Science, Tech and Maths";
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSport.ForeColor = System.Drawing.Color.Red;
            this.lblSport.Location = new System.Drawing.Point(31, 361);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(76, 29);
            this.lblSport.TabIndex = 5;
            this.lblSport.Text = "Sport";
            // 
            // lblGeography
            // 
            this.lblGeography.AutoSize = true;
            this.lblGeography.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeography.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblGeography.Location = new System.Drawing.Point(12, 526);
            this.lblGeography.Name = "lblGeography";
            this.lblGeography.Size = new System.Drawing.Size(272, 29);
            this.lblGeography.TabIndex = 6;
            this.lblGeography.Text = "Geography and Travel";
            // 
            // lblAnimals
            // 
            this.lblAnimals.AutoSize = true;
            this.lblAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAnimals.Location = new System.Drawing.Point(37, 158);
            this.lblAnimals.Name = "lblAnimals";
            this.lblAnimals.Size = new System.Drawing.Size(240, 29);
            this.lblAnimals.TabIndex = 7;
            this.lblAnimals.Text = "Animals and Nature";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFood.Location = new System.Drawing.Point(844, 432);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(74, 29);
            this.lblFood.TabIndex = 8;
            this.lblFood.Text = "Food";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooks.ForeColor = System.Drawing.Color.Gray;
            this.lblBooks.Location = new System.Drawing.Point(803, 290);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(86, 29);
            this.lblBooks.TabIndex = 9;
            this.lblBooks.Text = "Books";
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMusic.Location = new System.Drawing.Point(436, 133);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(81, 29);
            this.lblMusic.TabIndex = 10;
            this.lblMusic.Text = "Music";
            // 
            // currentTokens
            // 
            this.currentTokens.AutoSize = true;
            this.currentTokens.BackColor = System.Drawing.Color.White;
            this.currentTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTokens.Location = new System.Drawing.Point(751, 112);
            this.currentTokens.Name = "currentTokens";
            this.currentTokens.Size = new System.Drawing.Size(150, 24);
            this.currentTokens.TabIndex = 19;
            this.currentTokens.Text = "Current Tokens :";
            this.currentTokens.Click += new System.EventHandler(this.currentTokens_Click);
            // 
            // tokenAmount
            // 
            this.tokenAmount.AutoSize = true;
            this.tokenAmount.BackColor = System.Drawing.Color.White;
            this.tokenAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenAmount.ForeColor = System.Drawing.Color.Black;
            this.tokenAmount.Location = new System.Drawing.Point(901, 112);
            this.tokenAmount.Name = "tokenAmount";
            this.tokenAmount.Size = new System.Drawing.Size(24, 24);
            this.tokenAmount.TabIndex = 20;
            this.tokenAmount.Text = "X";
            this.tokenAmount.Click += new System.EventHandler(this.tokenAmount_Click);
            // 
            // lblRandomTopic
            // 
            this.lblRandomTopic.AutoSize = true;
            this.lblRandomTopic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRandomTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomTopic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRandomTopic.Location = new System.Drawing.Point(457, 316);
            this.lblRandomTopic.Name = "lblRandomTopic";
            this.lblRandomTopic.Size = new System.Drawing.Size(72, 61);
            this.lblRandomTopic.TabIndex = 29;
            this.lblRandomTopic.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(224, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 268);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // bttnContinue
            // 
            this.bttnContinue.BackColor = System.Drawing.Color.Aqua;
            this.bttnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnContinue.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnContinue.Location = new System.Drawing.Point(742, 579);
            this.bttnContinue.Name = "bttnContinue";
            this.bttnContinue.Size = new System.Drawing.Size(176, 82);
            this.bttnContinue.TabIndex = 32;
            this.bttnContinue.Text = "Continue >>>";
            this.bttnContinue.UseVisualStyleBackColor = false;
            this.bttnContinue.Click += new System.EventHandler(this.bttnContinue_Click);
            // 
            // frmTopicPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(950, 673);
            this.Controls.Add(this.bttnContinue);
            this.Controls.Add(this.lblRandomTopic);
            this.Controls.Add(this.tokenAmount);
            this.Controls.Add(this.currentTokens);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lblAnimals);
            this.Controls.Add(this.lblGeography);
            this.Controls.Add(this.lblSport);
            this.Controls.Add(this.lblScience);
            this.Controls.Add(this.lblGeneral);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTopicPicker";
            this.Text = "Random Topic Picker";
            this.Load += new System.EventHandler(this.frmCharecterSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.Label lblGeography;
        private System.Windows.Forms.Label lblAnimals;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Label currentTokens;
        private System.Windows.Forms.Label tokenAmount;
        private System.Windows.Forms.Label lblRandomTopic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnContinue;
    }
}