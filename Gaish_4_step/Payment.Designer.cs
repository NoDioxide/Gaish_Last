namespace Gaish_4_step
{
    partial class Payment
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
            this.components = new System.ComponentModel.Container();
            this.labelPayment = new System.Windows.Forms.Label();
            this.buttonToPay = new System.Windows.Forms.Button();
            this.labelHowMuchPay = new System.Windows.Forms.Label();
            this.panelDown = new System.Windows.Forms.Panel();
            this.panelAnim1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelOplataYspex = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.radioButtonTinkoff = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSberBank = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelEXIT = new System.Windows.Forms.Label();
            this.panelDown.SuspendLayout();
            this.panelAnim1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPayment.Location = new System.Drawing.Point(12, 17);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(131, 20);
            this.labelPayment.TabIndex = 0;
            this.labelPayment.Text = "Сумма к оплате:";
            // 
            // buttonToPay
            // 
            this.buttonToPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonToPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonToPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonToPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonToPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToPay.Location = new System.Drawing.Point(142, 169);
            this.buttonToPay.Name = "buttonToPay";
            this.buttonToPay.Size = new System.Drawing.Size(97, 23);
            this.buttonToPay.TabIndex = 3;
            this.buttonToPay.Text = "Оплатить";
            this.buttonToPay.UseVisualStyleBackColor = false;
            this.buttonToPay.Visible = false;
            this.buttonToPay.Click += new System.EventHandler(this.buttonToPay_Click);
            // 
            // labelHowMuchPay
            // 
            this.labelHowMuchPay.AutoSize = true;
            this.labelHowMuchPay.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHowMuchPay.Location = new System.Drawing.Point(39, 17);
            this.labelHowMuchPay.Name = "labelHowMuchPay";
            this.labelHowMuchPay.Size = new System.Drawing.Size(0, 20);
            this.labelHowMuchPay.TabIndex = 4;
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelDown.Controls.Add(this.panelAnim1);
            this.panelDown.Controls.Add(this.buttonToPay);
            this.panelDown.Controls.Add(this.panelTop);
            this.panelDown.Controls.Add(this.groupBox1);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDown.Location = new System.Drawing.Point(0, 0);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(374, 260);
            this.panelDown.TabIndex = 7;
            // 
            // panelAnim1
            // 
            this.panelAnim1.BackColor = System.Drawing.Color.White;
            this.panelAnim1.Controls.Add(this.pictureBox1);
            this.panelAnim1.Controls.Add(this.labelEXIT);
            this.panelAnim1.Controls.Add(this.labelOplataYspex);
            this.panelAnim1.Location = new System.Drawing.Point(0, 269);
            this.panelAnim1.Name = "panelAnim1";
            this.panelAnim1.Size = new System.Drawing.Size(374, 333);
            this.panelAnim1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gaish_4_step.Properties.Resources.Dynamic_Status_Update_Animation;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // labelOplataYspex
            // 
            this.labelOplataYspex.AutoSize = true;
            this.labelOplataYspex.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.labelOplataYspex.Location = new System.Drawing.Point(75, 136);
            this.labelOplataYspex.Name = "labelOplataYspex";
            this.labelOplataYspex.Size = new System.Drawing.Size(223, 20);
            this.labelOplataYspex.TabIndex = 1;
            this.labelOplataYspex.Text = "Оплата успешно завершена!";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelTop.Controls.Add(this.labelPayment);
            this.panelTop.Controls.Add(this.radioButtonTinkoff);
            this.panelTop.Controls.Add(this.radioButton1);
            this.panelTop.Controls.Add(this.radioButtonSberBank);
            this.panelTop.Controls.Add(this.labelHowMuchPay);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(374, 100);
            this.panelTop.TabIndex = 6;
            // 
            // radioButtonTinkoff
            // 
            this.radioButtonTinkoff.AutoSize = true;
            this.radioButtonTinkoff.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTinkoff.Location = new System.Drawing.Point(15, 72);
            this.radioButtonTinkoff.Name = "radioButtonTinkoff";
            this.radioButtonTinkoff.Size = new System.Drawing.Size(326, 24);
            this.radioButtonTinkoff.TabIndex = 7;
            this.radioButtonTinkoff.TabStop = true;
            this.radioButtonTinkoff.Text = "Реквизиты Tinkoff: 2200 7004 4661 9768";
            this.radioButtonTinkoff.UseVisualStyleBackColor = true;
            this.radioButtonTinkoff.CheckedChanged += new System.EventHandler(this.radioButtonTinkoff_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(16, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Просто";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButtonSberBank
            // 
            this.radioButtonSberBank.AutoSize = true;
            this.radioButtonSberBank.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSberBank.Location = new System.Drawing.Point(15, 48);
            this.radioButtonSberBank.Name = "radioButtonSberBank";
            this.radioButtonSberBank.Size = new System.Drawing.Size(348, 24);
            this.radioButtonSberBank.TabIndex = 6;
            this.radioButtonSberBank.TabStop = true;
            this.radioButtonSberBank.Text = "Реквизиты СберБанк: 4279 3806 2399 5505";
            this.radioButtonSberBank.UseVisualStyleBackColor = true;
            this.radioButtonSberBank.CheckedChanged += new System.EventHandler(this.radioButtonSberBank_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(136, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 45);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelEXIT
            // 
            this.labelEXIT.AutoSize = true;
            this.labelEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEXIT.Location = new System.Drawing.Point(344, 62);
            this.labelEXIT.Name = "labelEXIT";
            this.labelEXIT.Size = new System.Drawing.Size(30, 29);
            this.labelEXIT.TabIndex = 10;
            this.labelEXIT.Text = "X";
            this.labelEXIT.Click += new System.EventHandler(this.labelEXIT_Click_1);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 260);
            this.Controls.Add(this.panelDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.Text = "PaymentPanel";
            this.panelDown.ResumeLayout(false);
            this.panelAnim1.ResumeLayout(false);
            this.panelAnim1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Button buttonToPay;
        private System.Windows.Forms.Label labelHowMuchPay;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.RadioButton radioButtonTinkoff;
        private System.Windows.Forms.RadioButton radioButtonSberBank;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelAnim1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelOplataYspex;
        private System.Windows.Forms.Label labelEXIT;
    }
}