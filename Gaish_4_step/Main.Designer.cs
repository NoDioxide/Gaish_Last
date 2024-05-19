namespace Gaish_4_step
{
    partial class Main
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
            this.UserButtonLog = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UserTB = new System.Windows.Forms.TextBox();
            this.panelDOWN = new System.Windows.Forms.Panel();
            this.AdminButtonLog = new System.Windows.Forms.Button();
            this.panelTOP = new System.Windows.Forms.Panel();
            this.labelEXIT = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPDD = new System.Windows.Forms.Label();
            this.picturePassword = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.panelDOWN.SuspendLayout();
            this.panelTOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // UserButtonLog
            // 
            this.UserButtonLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UserButtonLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserButtonLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UserButtonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserButtonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserButtonLog.Location = new System.Drawing.Point(115, 335);
            this.UserButtonLog.Name = "UserButtonLog";
            this.UserButtonLog.Size = new System.Drawing.Size(220, 44);
            this.UserButtonLog.TabIndex = 6;
            this.UserButtonLog.Text = "Войти как Пользователь";
            this.UserButtonLog.UseVisualStyleBackColor = true;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTB.Location = new System.Drawing.Point(103, 272);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(271, 39);
            this.PasswordTB.TabIndex = 5;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // UserTB
            // 
            this.UserTB.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserTB.Location = new System.Drawing.Point(103, 163);
            this.UserTB.Multiline = true;
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(271, 37);
            this.UserTB.TabIndex = 3;
            // 
            // panelDOWN
            // 
            this.panelDOWN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelDOWN.Controls.Add(this.AdminButtonLog);
            this.panelDOWN.Controls.Add(this.UserButtonLog);
            this.panelDOWN.Controls.Add(this.PasswordTB);
            this.panelDOWN.Controls.Add(this.picturePassword);
            this.panelDOWN.Controls.Add(this.UserTB);
            this.panelDOWN.Controls.Add(this.pictureUser);
            this.panelDOWN.Controls.Add(this.panelTOP);
            this.panelDOWN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDOWN.Location = new System.Drawing.Point(0, 0);
            this.panelDOWN.Name = "panelDOWN";
            this.panelDOWN.Size = new System.Drawing.Size(1207, 642);
            this.panelDOWN.TabIndex = 1;
            // 
            // AdminButtonLog
            // 
            this.AdminButtonLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AdminButtonLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AdminButtonLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AdminButtonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButtonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminButtonLog.Location = new System.Drawing.Point(115, 394);
            this.AdminButtonLog.Name = "AdminButtonLog";
            this.AdminButtonLog.Size = new System.Drawing.Size(220, 44);
            this.AdminButtonLog.TabIndex = 7;
            this.AdminButtonLog.Text = "Войти как Администратор";
            this.AdminButtonLog.UseVisualStyleBackColor = true;
            // 
            // panelTOP
            // 
            this.panelTOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelTOP.Controls.Add(this.labelEXIT);
            this.panelTOP.Controls.Add(this.labelLogin);
            this.panelTOP.Controls.Add(this.labelPDD);
            this.panelTOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTOP.Location = new System.Drawing.Point(0, 0);
            this.panelTOP.Name = "panelTOP";
            this.panelTOP.Size = new System.Drawing.Size(1207, 98);
            this.panelTOP.TabIndex = 1;
            // 
            // labelEXIT
            // 
            this.labelEXIT.AutoSize = true;
            this.labelEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEXIT.Location = new System.Drawing.Point(770, 0);
            this.labelEXIT.Name = "labelEXIT";
            this.labelEXIT.Size = new System.Drawing.Size(30, 29);
            this.labelEXIT.TabIndex = 2;
            this.labelEXIT.Text = "X";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(316, 37);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(227, 41);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Авторизация";
            // 
            // labelPDD
            // 
            this.labelPDD.AutoSize = true;
            this.labelPDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelPDD.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPDD.ForeColor = System.Drawing.Color.Black;
            this.labelPDD.Location = new System.Drawing.Point(306, 9);
            this.labelPDD.Name = "labelPDD";
            this.labelPDD.Size = new System.Drawing.Size(237, 28);
            this.labelPDD.TabIndex = 0;
            this.labelPDD.Text = "Учёт нарушений ПДД";
            // 
            // picturePassword
            // 
            this.picturePassword.Image = global::Gaish_4_step.Properties.Resources._3671803_closed_lock_icon;
            this.picturePassword.Location = new System.Drawing.Point(22, 253);
            this.picturePassword.Name = "picturePassword";
            this.picturePassword.Size = new System.Drawing.Size(75, 75);
            this.picturePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePassword.TabIndex = 4;
            this.picturePassword.TabStop = false;
            // 
            // pictureUser
            // 
            this.pictureUser.Image = global::Gaish_4_step.Properties.Resources._285645_user_icon;
            this.pictureUser.Location = new System.Drawing.Point(22, 144);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(75, 75);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 2;
            this.pictureUser.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 642);
            this.Controls.Add(this.panelDOWN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panelDOWN.ResumeLayout(false);
            this.panelDOWN.PerformLayout();
            this.panelTOP.ResumeLayout(false);
            this.panelTOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserButtonLog;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.PictureBox picturePassword;
        private System.Windows.Forms.TextBox UserTB;
        private System.Windows.Forms.Panel panelDOWN;
        private System.Windows.Forms.Button AdminButtonLog;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Panel panelTOP;
        private System.Windows.Forms.Label labelEXIT;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPDD;
    }
}