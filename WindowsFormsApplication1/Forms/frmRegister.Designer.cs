namespace WindowsFormsApplication1
{
    partial class frmRegister
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
            this.lblRegisterTitle = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.bttnCreateUser = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtBxConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtBxCreatePassword = new System.Windows.Forms.TextBox();
            this.txtbxNewUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegisterTitle
            // 
            this.lblRegisterTitle.AutoSize = true;
            this.lblRegisterTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterTitle.ForeColor = System.Drawing.Color.White;
            this.lblRegisterTitle.Location = new System.Drawing.Point(215, 43);
            this.lblRegisterTitle.Name = "lblRegisterTitle";
            this.lblRegisterTitle.Size = new System.Drawing.Size(87, 24);
            this.lblRegisterTitle.TabIndex = 0;
            this.lblRegisterTitle.Text = "Register";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Black;
            this.lblRegister.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(7, 126);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(118, 20);
            this.lblRegister.TabIndex = 1;
            this.lblRegister.Text = "New Username";
            this.lblRegister.Click += new System.EventHandler(this.label2_Click);
            // 
            // bttnCreateUser
            // 
            this.bttnCreateUser.BackColor = System.Drawing.Color.White;
            this.bttnCreateUser.Location = new System.Drawing.Point(93, 357);
            this.bttnCreateUser.Name = "bttnCreateUser";
            this.bttnCreateUser.Size = new System.Drawing.Size(109, 74);
            this.bttnCreateUser.TabIndex = 3;
            this.bttnCreateUser.Text = "Create New User";
            this.bttnCreateUser.UseVisualStyleBackColor = false;
            this.bttnCreateUser.Click += new System.EventHandler(this.bttnCreateUser_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.BackColor = System.Drawing.Color.White;
            this.bttnCancel.Location = new System.Drawing.Point(312, 357);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(109, 74);
            this.bttnCancel.TabIndex = 4;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = false;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.BackColor = System.Drawing.Color.Black;
            this.lblCreatePassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatePassword.ForeColor = System.Drawing.Color.White;
            this.lblCreatePassword.Location = new System.Drawing.Point(7, 194);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(130, 20);
            this.lblCreatePassword.TabIndex = 5;
            this.lblCreatePassword.Text = "Create Password";
            this.lblCreatePassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Black;
            this.lblConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(7, 263);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(137, 20);
            this.lblConfirmPassword.TabIndex = 6;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtBxConfirmPassword
            // 
            this.txtBxConfirmPassword.Location = new System.Drawing.Point(182, 257);
            this.txtBxConfirmPassword.Multiline = true;
            this.txtBxConfirmPassword.Name = "txtBxConfirmPassword";
            this.txtBxConfirmPassword.Size = new System.Drawing.Size(163, 33);
            this.txtBxConfirmPassword.TabIndex = 9;
            this.txtBxConfirmPassword.Click += new System.EventHandler(this.ConfirmPSClick);
            this.txtBxConfirmPassword.Leave += new System.EventHandler(this.ConfrimPSLeave);
            // 
            // txtBxCreatePassword
            // 
            this.txtBxCreatePassword.Location = new System.Drawing.Point(182, 190);
            this.txtBxCreatePassword.Multiline = true;
            this.txtBxCreatePassword.Name = "txtBxCreatePassword";
            this.txtBxCreatePassword.Size = new System.Drawing.Size(163, 31);
            this.txtBxCreatePassword.TabIndex = 10;
            this.txtBxCreatePassword.Click += new System.EventHandler(this.CreatePSClick);
            this.txtBxCreatePassword.Leave += new System.EventHandler(this.CreatePSLeave);
            // 
            // txtbxNewUsername
            // 
            this.txtbxNewUsername.Location = new System.Drawing.Point(182, 119);
            this.txtbxNewUsername.Multiline = true;
            this.txtbxNewUsername.Name = "txtbxNewUsername";
            this.txtbxNewUsername.Size = new System.Drawing.Size(163, 32);
            this.txtbxNewUsername.TabIndex = 11;
            this.txtbxNewUsername.Click += new System.EventHandler(this.NewUSClick);
            this.txtbxNewUsername.Leave += new System.EventHandler(this.NewUNLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.quizzybizzygood;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbxNewUsername);
            this.Controls.Add(this.txtBxCreatePassword);
            this.Controls.Add(this.txtBxConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblCreatePassword);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnCreateUser);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblRegisterTitle);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegisterTitle;
        private System.Windows.Forms.Button bttnCreateUser;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Label lblCreatePassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtBxConfirmPassword;
        private System.Windows.Forms.TextBox txtBxCreatePassword;
        private System.Windows.Forms.TextBox txtbxNewUsername;
        public System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}