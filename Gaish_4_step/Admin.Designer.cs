namespace Gaish_4_step
{
    partial class Admin
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
            this.labelEXIT = new System.Windows.Forms.Label();
            this.pictureBoxEraser = new System.Windows.Forms.PictureBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelPanelTop = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelDown = new System.Windows.Forms.Panel();
            this.labelManagement = new System.Windows.Forms.Label();
            this.groupBoxManagement = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.textBoxBasePrice = new System.Windows.Forms.TextBox();
            this.labelBasePrice = new System.Windows.Forms.Label();
            this.textBoxMastHas = new System.Windows.Forms.TextBox();
            this.labelMastHas = new System.Windows.Forms.Label();
            this.textBoxWoodTypes = new System.Windows.Forms.TextBox();
            this.labelWoodTypes = new System.Windows.Forms.Label();
            this.textBoxRowerCapacity = new System.Windows.Forms.TextBox();
            this.labelRowerCapacity = new System.Windows.Forms.Label();
            this.textBoxShipType = new System.Windows.Forms.TextBox();
            this.labelShipType = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxProfuctName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.groupBoxInInfoBox = new System.Windows.Forms.GroupBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxProcess = new System.Windows.Forms.TextBox();
            this.labelProcess = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelDown.SuspendLayout();
            this.groupBoxManagement.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.groupBoxInInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelTop.Controls.Add(this.labelEXIT);
            this.panelTop.Controls.Add(this.pictureBoxEraser);
            this.panelTop.Controls.Add(this.pictureBoxRefresh);
            this.panelTop.Controls.Add(this.pictureBoxSearch);
            this.panelTop.Controls.Add(this.textBoxSearch);
            this.panelTop.Controls.Add(this.labelPanelTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 100);
            this.panelTop.TabIndex = 0;
            // 
            // labelEXIT
            // 
            this.labelEXIT.AutoSize = true;
            this.labelEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEXIT.Location = new System.Drawing.Point(770, -1);
            this.labelEXIT.Name = "labelEXIT";
            this.labelEXIT.Size = new System.Drawing.Size(30, 29);
            this.labelEXIT.TabIndex = 3;
            this.labelEXIT.Text = "X";
            this.labelEXIT.Click += new System.EventHandler(this.labelEXIT_Click);
            // 
            // pictureBoxEraser
            // 
            this.pictureBoxEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEraser.Image = global::Gaish_4_step.Properties.Resources._8542033_eraser_erase_delete_icon;
            this.pictureBoxEraser.Location = new System.Drawing.Point(484, 26);
            this.pictureBoxEraser.Name = "pictureBoxEraser";
            this.pictureBoxEraser.Size = new System.Drawing.Size(36, 41);
            this.pictureBoxEraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEraser.TabIndex = 4;
            this.pictureBoxEraser.TabStop = false;
            this.pictureBoxEraser.Click += new System.EventHandler(this.pictureBoxEraser_Click);
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRefresh.Image = global::Gaish_4_step.Properties.Resources._9104189_replay_repeat_refresh_update_reload_icon;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(526, 26);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(36, 41);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRefresh.TabIndex = 3;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxSearch.Image = global::Gaish_4_step.Properties.Resources._9035096_search_icon;
            this.pictureBoxSearch.Location = new System.Drawing.Point(759, 28);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(36, 41);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearch.TabIndex = 2;
            this.pictureBoxSearch.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(568, 35);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(187, 32);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelPanelTop
            // 
            this.labelPanelTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPanelTop.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPanelTop.Location = new System.Drawing.Point(0, 0);
            this.labelPanelTop.Name = "labelPanelTop";
            this.labelPanelTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPanelTop.Size = new System.Drawing.Size(234, 100);
            this.labelPanelTop.TabIndex = 0;
            this.labelPanelTop.Text = "Админская панель Для работы с Базой Данных";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(794, 256);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelDown.Controls.Add(this.labelManagement);
            this.panelDown.Controls.Add(this.groupBoxManagement);
            this.panelDown.Controls.Add(this.dataGridView1);
            this.panelDown.Controls.Add(this.groupBoxInfo);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDown.Location = new System.Drawing.Point(0, 0);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(800, 577);
            this.panelDown.TabIndex = 2;
            // 
            // labelManagement
            // 
            this.labelManagement.AutoSize = true;
            this.labelManagement.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.labelManagement.Location = new System.Drawing.Point(588, 378);
            this.labelManagement.Name = "labelManagement";
            this.labelManagement.Size = new System.Drawing.Size(190, 21);
            this.labelManagement.TabIndex = 9;
            this.labelManagement.Text = "Управление записями:";
            // 
            // groupBoxManagement
            // 
            this.groupBoxManagement.Controls.Add(this.buttonSave);
            this.groupBoxManagement.Controls.Add(this.buttonEdit);
            this.groupBoxManagement.Controls.Add(this.buttonDel);
            this.groupBoxManagement.Controls.Add(this.buttonNew);
            this.groupBoxManagement.Location = new System.Drawing.Point(575, 398);
            this.groupBoxManagement.Name = "groupBoxManagement";
            this.groupBoxManagement.Size = new System.Drawing.Size(213, 167);
            this.groupBoxManagement.TabIndex = 8;
            this.groupBoxManagement.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.Location = new System.Drawing.Point(119, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoSize = true;
            this.buttonEdit.Location = new System.Drawing.Point(6, 55);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(88, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.AutoSize = true;
            this.buttonDel.Location = new System.Drawing.Point(119, 13);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(88, 23);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.AutoSize = true;
            this.buttonNew.Location = new System.Drawing.Point(6, 13);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(88, 23);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Новая запись";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.textBoxProcess);
            this.groupBoxInfo.Controls.Add(this.labelProcess);
            this.groupBoxInfo.Controls.Add(this.textBoxBasePrice);
            this.groupBoxInfo.Controls.Add(this.labelBasePrice);
            this.groupBoxInfo.Controls.Add(this.textBoxMastHas);
            this.groupBoxInfo.Controls.Add(this.labelMastHas);
            this.groupBoxInfo.Controls.Add(this.textBoxWoodTypes);
            this.groupBoxInfo.Controls.Add(this.labelWoodTypes);
            this.groupBoxInfo.Controls.Add(this.textBoxRowerCapacity);
            this.groupBoxInfo.Controls.Add(this.labelRowerCapacity);
            this.groupBoxInfo.Controls.Add(this.textBoxShipType);
            this.groupBoxInfo.Controls.Add(this.labelShipType);
            this.groupBoxInfo.Controls.Add(this.textBoxColor);
            this.groupBoxInfo.Controls.Add(this.labelColor);
            this.groupBoxInfo.Controls.Add(this.textBoxProfuctName);
            this.groupBoxInfo.Controls.Add(this.labelProductName);
            this.groupBoxInfo.Controls.Add(this.textBoxID);
            this.groupBoxInfo.Controls.Add(this.labelID);
            this.groupBoxInfo.Controls.Add(this.pictureBoxInfo);
            this.groupBoxInfo.Controls.Add(this.groupBoxInInfoBox);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 374);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(550, 191);
            this.groupBoxInfo.TabIndex = 7;
            this.groupBoxInfo.TabStop = false;
            // 
            // textBoxBasePrice
            // 
            this.textBoxBasePrice.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.textBoxBasePrice.Location = new System.Drawing.Point(342, 72);
            this.textBoxBasePrice.Name = "textBoxBasePrice";
            this.textBoxBasePrice.ReadOnly = true;
            this.textBoxBasePrice.Size = new System.Drawing.Size(100, 25);
            this.textBoxBasePrice.TabIndex = 24;
            // 
            // labelBasePrice
            // 
            this.labelBasePrice.AutoSize = true;
            this.labelBasePrice.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBasePrice.Location = new System.Drawing.Point(340, 43);
            this.labelBasePrice.Name = "labelBasePrice";
            this.labelBasePrice.Size = new System.Drawing.Size(95, 19);
            this.labelBasePrice.TabIndex = 23;
            this.labelBasePrice.Text = "Базовая цена";
            // 
            // textBoxMastHas
            // 
            this.textBoxMastHas.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.textBoxMastHas.Location = new System.Drawing.Point(447, 10);
            this.textBoxMastHas.Multiline = true;
            this.textBoxMastHas.Name = "textBoxMastHas";
            this.textBoxMastHas.ReadOnly = true;
            this.textBoxMastHas.Size = new System.Drawing.Size(100, 25);
            this.textBoxMastHas.TabIndex = 22;
            this.textBoxMastHas.Text = "";
            // 
            // labelMastHas
            // 
            this.labelMastHas.AutoSize = true;
            this.labelMastHas.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMastHas.Location = new System.Drawing.Point(341, 12);
            this.labelMastHas.Name = "labelMastHas";
            this.labelMastHas.Size = new System.Drawing.Size(110, 19);
            this.labelMastHas.TabIndex = 21;
            this.labelMastHas.Text = "Наличие мачты";
            // 
            // textBoxWoodTypes
            // 
            this.textBoxWoodTypes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.textBoxWoodTypes.Location = new System.Drawing.Point(217, 72);
            this.textBoxWoodTypes.Name = "textBoxWoodTypes";
            this.textBoxWoodTypes.Size = new System.Drawing.Size(110, 25);
            this.textBoxWoodTypes.TabIndex = 20;
            // 
            // labelWoodTypes
            // 
            this.labelWoodTypes.AutoSize = true;
            this.labelWoodTypes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWoodTypes.Location = new System.Drawing.Point(151, 74);
            this.labelWoodTypes.Name = "labelWoodTypes";
            this.labelWoodTypes.Size = new System.Drawing.Size(47, 19);
            this.labelWoodTypes.TabIndex = 19;
            this.labelWoodTypes.Text = "Сорта";
            // 
            // textBoxRowerCapacity
            // 
            this.textBoxRowerCapacity.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.textBoxRowerCapacity.Location = new System.Drawing.Point(217, 41);
            this.textBoxRowerCapacity.Name = "textBoxRowerCapacity";
            this.textBoxRowerCapacity.Size = new System.Drawing.Size(110, 25);
            this.textBoxRowerCapacity.TabIndex = 18;
            // 
            // labelRowerCapacity
            // 
            this.labelRowerCapacity.AutoSize = true;
            this.labelRowerCapacity.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRowerCapacity.Location = new System.Drawing.Point(136, 43);
            this.labelRowerCapacity.Name = "labelRowerCapacity";
            this.labelRowerCapacity.Size = new System.Drawing.Size(64, 19);
            this.labelRowerCapacity.TabIndex = 17;
            this.labelRowerCapacity.Text = "Гребцов";
            // 
            // textBoxShipType
            // 
            this.textBoxShipType.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.textBoxShipType.Location = new System.Drawing.Point(218, 10);
            this.textBoxShipType.Name = "textBoxShipType";
            this.textBoxShipType.Size = new System.Drawing.Size(109, 25);
            this.textBoxShipType.TabIndex = 16;
            // 
            // labelShipType
            // 
            this.labelShipType.AutoSize = true;
            this.labelShipType.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShipType.Location = new System.Drawing.Point(136, 13);
            this.labelShipType.Name = "labelShipType";
            this.labelShipType.Size = new System.Drawing.Size(75, 19);
            this.labelShipType.TabIndex = 15;
            this.labelShipType.Text = "Тип лодки";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.textBoxColor.Location = new System.Drawing.Point(113, 141);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(81, 25);
            this.textBoxColor.TabIndex = 14;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(6, 143);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(41, 19);
            this.labelColor.TabIndex = 13;
            this.labelColor.Text = "Цвет";
            // 
            // textBoxProfuctName
            // 
            this.textBoxProfuctName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.textBoxProfuctName.Location = new System.Drawing.Point(114, 103);
            this.textBoxProfuctName.Name = "textBoxProfuctName";
            this.textBoxProfuctName.Size = new System.Drawing.Size(127, 25);
            this.textBoxProfuctName.TabIndex = 12;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductName.Location = new System.Drawing.Point(6, 105);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(105, 38);
            this.labelProductName.TabIndex = 11;
            this.labelProductName.Text = "Наименование\r\nтовара";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.textBoxID.Location = new System.Drawing.Point(115, 72);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(31, 25);
            this.textBoxID.TabIndex = 10;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(6, 74);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 19);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "ID";
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Image = global::Gaish_4_step.Properties.Resources._326659_info_icon;
            this.pictureBoxInfo.Location = new System.Drawing.Point(4, 10);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInfo.TabIndex = 5;
            this.pictureBoxInfo.TabStop = false;
            // 
            // groupBoxInInfoBox
            // 
            this.groupBoxInInfoBox.Controls.Add(this.labelInfo);
            this.groupBoxInInfoBox.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInInfoBox.Name = "groupBoxInInfoBox";
            this.groupBoxInInfoBox.Size = new System.Drawing.Size(130, 65);
            this.groupBoxInInfoBox.TabIndex = 9;
            this.groupBoxInInfoBox.TabStop = false;
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(58, 24);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(69, 23);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Запись:";
            // 
            // textBoxProcess
            // 
            this.textBoxProcess.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.textBoxProcess.Location = new System.Drawing.Point(280, 142);
            this.textBoxProcess.Name = "textBoxProcess";
            this.textBoxProcess.Size = new System.Drawing.Size(158, 25);
            this.textBoxProcess.TabIndex = 26;
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcess.Location = new System.Drawing.Point(214, 144);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(65, 19);
            this.labelProcess.TabIndex = 25;
            this.labelProcess.Text = "Процесс";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "AdminPanel";
            this.Activated += new System.EventHandler(this.Admin_Activated);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelDown.ResumeLayout(false);
            this.panelDown.PerformLayout();
            this.groupBoxManagement.ResumeLayout(false);
            this.groupBoxManagement.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            this.groupBoxInInfoBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelPanelTop;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxEraser;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxManagement;
        private System.Windows.Forms.Label labelManagement;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.GroupBox groupBoxInInfoBox;
        private System.Windows.Forms.TextBox textBoxBasePrice;
        private System.Windows.Forms.Label labelBasePrice;
        private System.Windows.Forms.TextBox textBoxMastHas;
        private System.Windows.Forms.Label labelMastHas;
        private System.Windows.Forms.TextBox textBoxWoodTypes;
        private System.Windows.Forms.Label labelWoodTypes;
        private System.Windows.Forms.TextBox textBoxRowerCapacity;
        private System.Windows.Forms.Label labelRowerCapacity;
        private System.Windows.Forms.TextBox textBoxShipType;
        private System.Windows.Forms.Label labelShipType;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxProfuctName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelEXIT;
        private System.Windows.Forms.TextBox textBoxProcess;
        private System.Windows.Forms.Label labelProcess;
    }
}