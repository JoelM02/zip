namespace WindowsFormsApplication1
{
    partial class WelcomeMenu
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
            this.lbllnkPlay = new System.Windows.Forms.LinkLabel();
            this.lbllnkExit = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllnkPlay
            // 
            this.lbllnkPlay.ActiveLinkColor = System.Drawing.Color.Green;
            this.lbllnkPlay.AutoSize = true;
            this.lbllnkPlay.BackColor = System.Drawing.Color.Transparent;
            this.lbllnkPlay.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllnkPlay.LinkColor = System.Drawing.Color.Blue;
            this.lbllnkPlay.Location = new System.Drawing.Point(507, 149);
            this.lbllnkPlay.Name = "lbllnkPlay";
            this.lbllnkPlay.Size = new System.Drawing.Size(64, 29);
            this.lbllnkPlay.TabIndex = 0;
            this.lbllnkPlay.TabStop = true;
            this.lbllnkPlay.Text = "Play";
            this.lbllnkPlay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllnkPlay_LinkClicked);
            // 
            // lbllnkExit
            // 
            this.lbllnkExit.ActiveLinkColor = System.Drawing.Color.Green;
            this.lbllnkExit.AutoSize = true;
            this.lbllnkExit.BackColor = System.Drawing.Color.Transparent;
            this.lbllnkExit.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllnkExit.LinkColor = System.Drawing.Color.Blue;
            this.lbllnkExit.Location = new System.Drawing.Point(511, 230);
            this.lbllnkExit.Name = "lbllnkExit";
            this.lbllnkExit.Size = new System.Drawing.Size(60, 29);
            this.lbllnkExit.TabIndex = 1;
            this.lbllnkExit.TabStop = true;
            this.lbllnkExit.Text = "Exit";
            this.lbllnkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllnkExit_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.quizzybizzygood;
            this.pictureBox1.Location = new System.Drawing.Point(12, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(837, 448);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbllnkExit);
            this.Controls.Add(this.lbllnkPlay);
            this.Name = "WelcomeMenu";
            this.Text = "WelcomeMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbllnkPlay;
        private System.Windows.Forms.LinkLabel lbllnkExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}