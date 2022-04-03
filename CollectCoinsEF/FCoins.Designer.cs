namespace CollectCoinsEF
{
    partial class FCoins
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveFileDialogDB = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogDB = new System.Windows.Forms.OpenFileDialog();
            this.bNewBD = new System.Windows.Forms.Button();
            this.bOpenBD = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.dGridCoins = new System.Windows.Forms.DataGridView();
            this.bAddCoin = new System.Windows.Forms.Button();
            this.bEditCoin = new System.Windows.Forms.Button();
            this.bReCreateBD = new System.Windows.Forms.Button();
            this.bDeleteCoin = new System.Windows.Forms.Button();
            this.pBoxPhoto = new System.Windows.Forms.PictureBox();
            this.bPhotoPrev = new System.Windows.Forms.Button();
            this.bPhotoNext = new System.Windows.Forms.Button();
            this.tNameCoin = new System.Windows.Forms.TextBox();
            this.tCountryCoin = new System.Windows.Forms.TextBox();
            this.tYearCoin = new System.Windows.Forms.TextBox();
            this.tMatherialCoin = new System.Windows.Forms.TextBox();
            this.tStateCoin = new System.Windows.Forms.TextBox();
            this.tCirculationCoin = new System.Windows.Forms.TextBox();
            this.tDescCoin = new System.Windows.Forms.TextBox();
            this.tBitkinCoin = new System.Windows.Forms.TextBox();
            this.tDiametrCoin = new System.Windows.Forms.TextBox();
            this.tTypeCoin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogDB
            // 
            this.openFileDialogDB.FileName = "openFileDialog1";
            // 
            // bNewBD
            // 
            this.bNewBD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bNewBD.Location = new System.Drawing.Point(1809, 678);
            this.bNewBD.Name = "bNewBD";
            this.bNewBD.Size = new System.Drawing.Size(326, 113);
            this.bNewBD.TabIndex = 0;
            this.bNewBD.Text = "Создать новую БД";
            this.bNewBD.UseVisualStyleBackColor = true;
            this.bNewBD.Click += new System.EventHandler(this.bSaveBD_Click);
            // 
            // bOpenBD
            // 
            this.bOpenBD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpenBD.Location = new System.Drawing.Point(1809, 800);
            this.bOpenBD.Name = "bOpenBD";
            this.bOpenBD.Size = new System.Drawing.Size(326, 100);
            this.bOpenBD.TabIndex = 2;
            this.bOpenBD.Text = "Открыть БД";
            this.bOpenBD.UseVisualStyleBackColor = true;
            this.bOpenBD.Click += new System.EventHandler(this.bOpenBD_Click);
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bClose.Location = new System.Drawing.Point(1809, 917);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(326, 132);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // dGridCoins
            // 
            this.dGridCoins.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dGridCoins.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridCoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridCoins.Location = new System.Drawing.Point(17, 72);
            this.dGridCoins.MultiSelect = false;
            this.dGridCoins.Name = "dGridCoins";
            this.dGridCoins.ReadOnly = true;
            this.dGridCoins.RowHeadersWidth = 62;
            this.dGridCoins.RowTemplate.Height = 33;
            this.dGridCoins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridCoins.Size = new System.Drawing.Size(1769, 358);
            this.dGridCoins.TabIndex = 4;
            this.dGridCoins.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridCoins_CellClick);
            this.dGridCoins.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGridCoins_ColumnHeaderMouseClick);
            // 
            // bAddCoin
            // 
            this.bAddCoin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAddCoin.Location = new System.Drawing.Point(1824, 72);
            this.bAddCoin.Name = "bAddCoin";
            this.bAddCoin.Size = new System.Drawing.Size(329, 94);
            this.bAddCoin.TabIndex = 5;
            this.bAddCoin.Text = "Добавить монету";
            this.bAddCoin.UseVisualStyleBackColor = true;
            this.bAddCoin.Click += new System.EventHandler(this.bAddCoin_Click);
            // 
            // bEditCoin
            // 
            this.bEditCoin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEditCoin.Location = new System.Drawing.Point(1824, 342);
            this.bEditCoin.Name = "bEditCoin";
            this.bEditCoin.Size = new System.Drawing.Size(329, 88);
            this.bEditCoin.TabIndex = 6;
            this.bEditCoin.Text = "Редактировать монету";
            this.bEditCoin.UseVisualStyleBackColor = true;
            this.bEditCoin.Click += new System.EventHandler(this.bEditCoin_Click);
            // 
            // bReCreateBD
            // 
            this.bReCreateBD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bReCreateBD.Location = new System.Drawing.Point(1809, 567);
            this.bReCreateBD.Name = "bReCreateBD";
            this.bReCreateBD.Size = new System.Drawing.Size(326, 105);
            this.bReCreateBD.TabIndex = 7;
            this.bReCreateBD.Text = "Пересоздать БД";
            this.bReCreateBD.UseVisualStyleBackColor = true;
            this.bReCreateBD.Click += new System.EventHandler(this.bReCreateBD_Click);
            // 
            // bDeleteCoin
            // 
            this.bDeleteCoin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bDeleteCoin.Location = new System.Drawing.Point(1824, 207);
            this.bDeleteCoin.Name = "bDeleteCoin";
            this.bDeleteCoin.Size = new System.Drawing.Size(274, 88);
            this.bDeleteCoin.TabIndex = 8;
            this.bDeleteCoin.Text = "Удалить монету";
            this.bDeleteCoin.UseVisualStyleBackColor = true;
            this.bDeleteCoin.Click += new System.EventHandler(this.bDeleteCoin_Click);
            // 
            // pBoxPhoto
            // 
            this.pBoxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pBoxPhoto.Location = new System.Drawing.Point(344, 436);
            this.pBoxPhoto.Name = "pBoxPhoto";
            this.pBoxPhoto.Size = new System.Drawing.Size(977, 336);
            this.pBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxPhoto.TabIndex = 9;
            this.pBoxPhoto.TabStop = false;
            // 
            // bPhotoPrev
            // 
            this.bPhotoPrev.Location = new System.Drawing.Point(283, 436);
            this.bPhotoPrev.Name = "bPhotoPrev";
            this.bPhotoPrev.Size = new System.Drawing.Size(55, 336);
            this.bPhotoPrev.TabIndex = 10;
            this.bPhotoPrev.Text = "<";
            this.bPhotoPrev.UseVisualStyleBackColor = true;
            this.bPhotoPrev.Click += new System.EventHandler(this.bPhotoPrev_Click);
            // 
            // bPhotoNext
            // 
            this.bPhotoNext.Location = new System.Drawing.Point(1327, 436);
            this.bPhotoNext.Name = "bPhotoNext";
            this.bPhotoNext.Size = new System.Drawing.Size(52, 336);
            this.bPhotoNext.TabIndex = 11;
            this.bPhotoNext.Text = ">";
            this.bPhotoNext.UseVisualStyleBackColor = true;
            this.bPhotoNext.Click += new System.EventHandler(this.bPhotoNext_Click);
            // 
            // tNameCoin
            // 
            this.tNameCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tNameCoin.Location = new System.Drawing.Point(418, 778);
            this.tNameCoin.Name = "tNameCoin";
            this.tNameCoin.ReadOnly = true;
            this.tNameCoin.Size = new System.Drawing.Size(1363, 39);
            this.tNameCoin.TabIndex = 15;
            // 
            // tCountryCoin
            // 
            this.tCountryCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tCountryCoin.Location = new System.Drawing.Point(188, 827);
            this.tCountryCoin.Name = "tCountryCoin";
            this.tCountryCoin.ReadOnly = true;
            this.tCountryCoin.Size = new System.Drawing.Size(703, 39);
            this.tCountryCoin.TabIndex = 16;
            // 
            // tYearCoin
            // 
            this.tYearCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tYearCoin.Location = new System.Drawing.Point(1100, 827);
            this.tYearCoin.Name = "tYearCoin";
            this.tYearCoin.ReadOnly = true;
            this.tYearCoin.Size = new System.Drawing.Size(252, 39);
            this.tYearCoin.TabIndex = 17;
            // 
            // tMatherialCoin
            // 
            this.tMatherialCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tMatherialCoin.Location = new System.Drawing.Point(496, 883);
            this.tMatherialCoin.Name = "tMatherialCoin";
            this.tMatherialCoin.ReadOnly = true;
            this.tMatherialCoin.Size = new System.Drawing.Size(395, 39);
            this.tMatherialCoin.TabIndex = 18;
            // 
            // tStateCoin
            // 
            this.tStateCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tStateCoin.Location = new System.Drawing.Point(175, 884);
            this.tStateCoin.Name = "tStateCoin";
            this.tStateCoin.ReadOnly = true;
            this.tStateCoin.Size = new System.Drawing.Size(145, 39);
            this.tStateCoin.TabIndex = 19;
            // 
            // tCirculationCoin
            // 
            this.tCirculationCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tCirculationCoin.Location = new System.Drawing.Point(1516, 831);
            this.tCirculationCoin.Name = "tCirculationCoin";
            this.tCirculationCoin.ReadOnly = true;
            this.tCirculationCoin.Size = new System.Drawing.Size(265, 39);
            this.tCirculationCoin.TabIndex = 20;
            // 
            // tDescCoin
            // 
            this.tDescCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tDescCoin.Location = new System.Drawing.Point(17, 937);
            this.tDescCoin.Multiline = true;
            this.tDescCoin.Name = "tDescCoin";
            this.tDescCoin.ReadOnly = true;
            this.tDescCoin.Size = new System.Drawing.Size(1764, 112);
            this.tDescCoin.TabIndex = 21;
            // 
            // tBitkinCoin
            // 
            this.tBitkinCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBitkinCoin.Location = new System.Drawing.Point(1587, 879);
            this.tBitkinCoin.Name = "tBitkinCoin";
            this.tBitkinCoin.ReadOnly = true;
            this.tBitkinCoin.Size = new System.Drawing.Size(194, 39);
            this.tBitkinCoin.TabIndex = 22;
            // 
            // tDiametrCoin
            // 
            this.tDiametrCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tDiametrCoin.Location = new System.Drawing.Point(1100, 882);
            this.tDiametrCoin.Name = "tDiametrCoin";
            this.tDiametrCoin.ReadOnly = true;
            this.tDiametrCoin.Size = new System.Drawing.Size(197, 39);
            this.tDiametrCoin.TabIndex = 23;
            // 
            // tTypeCoin
            // 
            this.tTypeCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tTypeCoin.Location = new System.Drawing.Point(11, 778);
            this.tTypeCoin.Name = "tTypeCoin";
            this.tTypeCoin.ReadOnly = true;
            this.tTypeCoin.Size = new System.Drawing.Size(401, 39);
            this.tTypeCoin.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 832);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 38);
            this.label3.TabIndex = 25;
            this.label3.Text = "Государство:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(897, 825);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 38);
            this.label4.TabIndex = 26;
            this.label4.Text = "Год выпуска:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(326, 884);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 38);
            this.label5.TabIndex = 27;
            this.label5.Text = "Материал:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 884);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 38);
            this.label6.TabIndex = 28;
            this.label6.Text = "Состояние:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1358, 832);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 38);
            this.label7.TabIndex = 29;
            this.label7.Text = "Тираж, шт:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(897, 884);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 38);
            this.label8.TabIndex = 30;
            this.label8.Text = "Диаметр, мм:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1320, 884);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 38);
            this.label9.TabIndex = 31;
            this.label9.Text = "Номер по Биткину:";
            // 
            // tSearch
            // 
            this.tSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tSearch.Location = new System.Drawing.Point(782, 12);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(1004, 45);
            this.tSearch.TabIndex = 33;
            this.tSearch.TextChanged += new System.EventHandler(this.tSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(648, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 38);
            this.label10.TabIndex = 34;
            this.label10.Text = "Найти:";
            // 
            // FCoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2165, 1057);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tTypeCoin);
            this.Controls.Add(this.tDiametrCoin);
            this.Controls.Add(this.tBitkinCoin);
            this.Controls.Add(this.tDescCoin);
            this.Controls.Add(this.tCirculationCoin);
            this.Controls.Add(this.tStateCoin);
            this.Controls.Add(this.tMatherialCoin);
            this.Controls.Add(this.tYearCoin);
            this.Controls.Add(this.tCountryCoin);
            this.Controls.Add(this.tNameCoin);
            this.Controls.Add(this.bPhotoNext);
            this.Controls.Add(this.bPhotoPrev);
            this.Controls.Add(this.pBoxPhoto);
            this.Controls.Add(this.bDeleteCoin);
            this.Controls.Add(this.bReCreateBD);
            this.Controls.Add(this.bEditCoin);
            this.Controls.Add(this.bAddCoin);
            this.Controls.Add(this.dGridCoins);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bOpenBD);
            this.Controls.Add(this.bNewBD);
            this.Name = "FCoins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Коллекция монет и бон FE version";
            ((System.ComponentModel.ISupportInitialize)(this.dGridCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SaveFileDialog saveFileDialogDB;
        private OpenFileDialog openFileDialogDB;
        private Button bNewBD;
        private Button bOpenBD;
        private Button bClose;
        private DataGridView dGridCoins;
        private Button bAddCoin;
        private Button bEditCoin;
        private Button bReCreateBD;
        private Button bDeleteCoin;
        private PictureBox pBoxPhoto;
        private Button bPhotoPrev;
        private Button bPhotoNext;
        private TextBox tNameCoin;
        private TextBox tCountryCoin;
        private TextBox tYearCoin;
        private TextBox tMatherialCoin;
        private TextBox tStateCoin;
        private TextBox tCirculationCoin;
        private TextBox tDescCoin;
        private TextBox tBitkinCoin;
        private TextBox tDiametrCoin;
        private TextBox tTypeCoin;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tSearch;
        private Label label10;
    }
}