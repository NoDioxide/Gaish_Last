namespace Gaish_4_step
{
    partial class User
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxEraser = new System.Windows.Forms.PictureBox();
            this.buttonToTB = new System.Windows.Forms.Button();
            this.textBoxCarNumber = new System.Windows.Forms.TextBox();
            this.textBoxPatron = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelDown = new System.Windows.Forms.Panel();
            this.buttonToPay = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelEXIT = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEraser)).BeginInit();
            this.panelDown.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelTop.Controls.Add(this.labelEXIT);
            this.panelTop.Controls.Add(this.pictureBoxEraser);
            this.panelTop.Controls.Add(this.buttonToTB);
            this.panelTop.Controls.Add(this.textBoxCarNumber);
            this.panelTop.Controls.Add(this.textBoxPatron);
            this.panelTop.Controls.Add(this.textBoxFirstName);
            this.panelTop.Controls.Add(this.textBoxLastName);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(552, 100);
            this.panelTop.TabIndex = 7;
            // 
            // pictureBoxEraser
            // 
            this.pictureBoxEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEraser.Image = global::Gaish_4_step.Properties.Resources._8542033_eraser_erase_delete_icon;
            this.pictureBoxEraser.Location = new System.Drawing.Point(513, 59);
            this.pictureBoxEraser.Name = "pictureBoxEraser";
            this.pictureBoxEraser.Size = new System.Drawing.Size(36, 41);
            this.pictureBoxEraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEraser.TabIndex = 6;
            this.pictureBoxEraser.TabStop = false;
            this.pictureBoxEraser.Click += new System.EventHandler(this.pictureBoxEraser_Click);
            // 
            // buttonToTB
            // 
            this.buttonToTB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonToTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonToTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonToTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonToTB.Location = new System.Drawing.Point(217, 71);
            this.buttonToTB.Name = "buttonToTB";
            this.buttonToTB.Size = new System.Drawing.Size(112, 23);
            this.buttonToTB.TabIndex = 6;
            this.buttonToTB.Text = "Нажми меня";
            this.buttonToTB.UseVisualStyleBackColor = true;
            this.buttonToTB.Click += new System.EventHandler(this.buttonToTB_Click);
            // 
            // textBoxCarNumber
            // 
            this.textBoxCarNumber.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCarNumber.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCarNumber.Location = new System.Drawing.Point(411, 36);
            this.textBoxCarNumber.Name = "textBoxCarNumber";
            this.textBoxCarNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarNumber.TabIndex = 5;
            this.textBoxCarNumber.Text = "Номер автомобиля";
            this.textBoxCarNumber.Enter += new System.EventHandler(this.textBoxCarNumber_Enter);
            this.textBoxCarNumber.Leave += new System.EventHandler(this.textBoxCarNumber_Leave);
            // 
            // textBoxPatron
            // 
            this.textBoxPatron.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatron.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPatron.Location = new System.Drawing.Point(287, 36);
            this.textBoxPatron.Name = "textBoxPatron";
            this.textBoxPatron.Size = new System.Drawing.Size(100, 20);
            this.textBoxPatron.TabIndex = 4;
            this.textBoxPatron.Text = "Отчество";
            this.textBoxPatron.Enter += new System.EventHandler(this.textBoxPatron_Enter);
            this.textBoxPatron.Leave += new System.EventHandler(this.textBoxPatron_Leave);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxFirstName.Location = new System.Drawing.Point(162, 36);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 3;
            this.textBoxFirstName.Text = "Имя";
            this.textBoxFirstName.Enter += new System.EventHandler(this.textBoxFirstName_Enter);
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBoxFirstName_Leave);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxLastName.Location = new System.Drawing.Point(36, 36);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.Text = "Фамилия";
            this.textBoxLastName.Enter += new System.EventHandler(this.textBoxLastName_Enter);
            this.textBoxLastName.Leave += new System.EventHandler(this.textBoxLastName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Напишите своё ФИО и номер Вашего автомобиля";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 20);
            this.textBox1.TabIndex = 1;
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelDown.Controls.Add(this.textBoxResult);
            this.panelDown.Controls.Add(this.groupBox1);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDown.Location = new System.Drawing.Point(0, 100);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(552, 350);
            this.panelDown.TabIndex = 8;
            // 
            // buttonToPay
            // 
            this.buttonToPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonToPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonToPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonToPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToPay.Location = new System.Drawing.Point(6, 10);
            this.buttonToPay.Name = "buttonToPay";
            this.buttonToPay.Size = new System.Drawing.Size(180, 59);
            this.buttonToPay.TabIndex = 7;
            this.buttonToPay.Text = "Перейти к Оплате";
            this.buttonToPay.UseVisualStyleBackColor = true;
            this.buttonToPay.Visible = false;
            this.buttonToPay.Click += new System.EventHandler(this.buttonToPay_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(36, 133);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(475, 110);
            this.textBoxResult.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonToPay);
            this.groupBox1.Location = new System.Drawing.Point(195, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // labelEXIT
            // 
            this.labelEXIT.AutoSize = true;
            this.labelEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEXIT.Location = new System.Drawing.Point(522, 0);
            this.labelEXIT.Name = "labelEXIT";
            this.labelEXIT.Size = new System.Drawing.Size(30, 29);
            this.labelEXIT.TabIndex = 9;
            this.labelEXIT.Text = "X";
            this.labelEXIT.Click += new System.EventHandler(this.labelEXIT_Click_1);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.Text = "UserPanel";
            this.Load += new System.EventHandler(this.User_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEraser)).EndInit();
            this.panelDown.ResumeLayout(false);
            this.panelDown.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.TextBox textBoxCarNumber;
        private System.Windows.Forms.TextBox textBoxPatron;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToTB;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.PictureBox pictureBoxEraser;
        private System.Windows.Forms.Button buttonToPay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelEXIT;
    }
}