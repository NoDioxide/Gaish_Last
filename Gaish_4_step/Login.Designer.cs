﻿namespace Gaish_4_step
{
    partial class Login
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
            this.panelDOWN = new System.Windows.Forms.Panel();
            this.AdminButtonLog = new System.Windows.Forms.Button();
            this.UserButtonLog = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.picturePassword = new System.Windows.Forms.PictureBox();
            this.UserTB = new System.Windows.Forms.TextBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.panelTOP = new System.Windows.Forms.Panel();
            this.labelEXIT = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPDD = new System.Windows.Forms.Label();
            this.panelDOWN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.panelTOP.SuspendLayout();
            this.SuspendLayout();
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
            this.panelDOWN.Size = new System.Drawing.Size(431, 450);
            this.panelDOWN.TabIndex = 0;
            this.panelDOWN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDOWN_MouseDown);
            this.panelDOWN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDOWN_MouseMove);
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
            this.AdminButtonLog.Click += new System.EventHandler(this.AdminButtonLog_Click);
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
            this.UserButtonLog.Click += new System.EventHandler(this.UserButtonLog_Click);
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
            // UserTB
            // 
            this.UserTB.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserTB.Location = new System.Drawing.Point(103, 163);
            this.UserTB.Multiline = true;
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(271, 37);
            this.UserTB.TabIndex = 3;
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
            // panelTOP
            // 
            this.panelTOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelTOP.Controls.Add(this.labelEXIT);
            this.panelTOP.Controls.Add(this.labelLogin);
            this.panelTOP.Controls.Add(this.labelPDD);
            this.panelTOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTOP.Location = new System.Drawing.Point(0, 0);
            this.panelTOP.Name = "panelTOP";
            this.panelTOP.Size = new System.Drawing.Size(431, 98);
            this.panelTOP.TabIndex = 1;
            this.panelTOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTOP_MouseDown);
            this.panelTOP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTOP_MouseMove);
            // 
            // labelEXIT
            // 
            this.labelEXIT.AutoSize = true;
            this.labelEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEXIT.Location = new System.Drawing.Point(401, 0);
            this.labelEXIT.Name = "labelEXIT";
            this.labelEXIT.Size = new System.Drawing.Size(30, 29);
            this.labelEXIT.TabIndex = 2;
            this.labelEXIT.Text = "X";
            this.labelEXIT.Click += new System.EventHandler(this.labelEXIT_Click);
            this.labelEXIT.MouseEnter += new System.EventHandler(this.labelEXIT_MouseEnter);
            this.labelEXIT.MouseLeave += new System.EventHandler(this.labelEXIT_MouseLeave);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(108, 37);
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
            this.labelPDD.Location = new System.Drawing.Point(98, 9);
            this.labelPDD.Name = "labelPDD";
            this.labelPDD.Size = new System.Drawing.Size(237, 28);
            this.labelPDD.TabIndex = 0;
            this.labelPDD.Text = "Учёт нарушений ПДД";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.panelDOWN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panelDOWN.ResumeLayout(false);
            this.panelDOWN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.panelTOP.ResumeLayout(false);
            this.panelTOP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDOWN;
        private System.Windows.Forms.Label labelPDD;
        private System.Windows.Forms.Panel panelTOP;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.TextBox UserTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.PictureBox picturePassword;
        private System.Windows.Forms.Button UserButtonLog;
        private System.Windows.Forms.Button AdminButtonLog;
        private System.Windows.Forms.Label labelEXIT;
    }
}