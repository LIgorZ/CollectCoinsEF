namespace CollectCoinsEF
{
    partial class FAddEditCoin
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
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tTypeCoin = new System.Windows.Forms.TextBox();
            this.tYearCoin = new System.Windows.Forms.TextBox();
            this.tMatherialCoin = new System.Windows.Forms.TextBox();
            this.tDiametrCoin = new System.Windows.Forms.TextBox();
            this.tCountryCoin = new System.Windows.Forms.TextBox();
            this.tStateCoin = new System.Windows.Forms.TextBox();
            this.tCirculationCoin = new System.Windows.Forms.TextBox();
            this.tBitkinCoin = new System.Windows.Forms.TextBox();
            this.tDescCoin = new System.Windows.Forms.TextBox();
            this.tNameCoin = new System.Windows.Forms.TextBox();
            this.dGridPhoto = new System.Windows.Forms.DataGridView();
            this.pB_Photo = new System.Windows.Forms.PictureBox();
            this.bAddPhoto = new System.Windows.Forms.Button();
            this.bDeletePhoto = new System.Windows.Forms.Button();
            this.oFilePhoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dGridPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // bOK
            // 
            this.bOK.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOK.Location = new System.Drawing.Point(21, 1088);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(339, 122);
            this.bOK.TabIndex = 0;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCancel.Location = new System.Drawing.Point(631, 1088);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(380, 122);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Отменить";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 38);
            this.label8.TabIndex = 17;
            this.label8.Text = "Состояние";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 38);
            this.label7.TabIndex = 16;
            this.label7.Text = "Страна";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 38);
            this.label6.TabIndex = 15;
            this.label6.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 38);
            this.label5.TabIndex = 14;
            this.label5.Text = "Диаметр, мм";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "Материал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тип монеты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Наименование монеты";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 38);
            this.label9.TabIndex = 18;
            this.label9.Text = "Тираж, шт.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 540);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 38);
            this.label10.TabIndex = 18;
            this.label10.Text = "Номер по Биткину";
            // 
            // tTypeCoin
            // 
            this.tTypeCoin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tTypeCoin.Location = new System.Drawing.Point(371, 85);
            this.tTypeCoin.Name = "tTypeCoin";
            this.tTypeCoin.Size = new System.Drawing.Size(640, 45);
            this.tTypeCoin.TabIndex = 19;
            // 
            // tYearCoin
            // 
            this.tYearCoin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tYearCoin.Location = new System.Drawing.Point(371, 152);
            this.tYearCoin.Name = "tYearCoin";
            this.tYearCoin.Size = new System.Drawing.Size(640, 45);
            this.tYearCoin.TabIndex = 19;
            // 
            // tMatherialCoin
            // 
            this.tMatherialCoin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tMatherialCoin.Location = new System.Drawing.Point(371, 220);
            this.tMatherialCoin.Name = "tMatherialCoin";
            this.tMatherialCoin.Size = new System.Drawing.Size(640, 45);
            this.tMatherialCoin.TabIndex = 19;
            // 
            // tDiametrCoin
            // 
            this.tDiametrCoin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tDiametrCoin.Location = new System.Drawing.Point(371, 283);
            this.tDiametrCoin.Name = "tDiametrCoin";
            this.tDiametrCoin.Size = new System.Drawing.Size(640, 45);
            this.tDiametrCoin.TabIndex = 19;
            // 
            // tCountryCoin
            // 
            this.tCountryCoin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tCountryCoin.Location = new System.Drawing.Point(371, 346);
            this.tCountryCoin.Name = "tCountryCoin";
            this.tCountryCoin.Size = new System.Drawing.Size(640, 45);
            this.tCountryCoin.TabIndex = 19;
            // 
            // tStateCoin
            // 
            this.tStateCoin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tStateCoin.Location = new System.Drawing.Point(371, 408);
            this.tStateCoin.Name = "tStateCoin";
            this.tStateCoin.Size = new System.Drawing.Size(640, 45);
            this.tStateCoin.TabIndex = 19;
            // 
            // tCirculationCoin
            // 
            this.tCirculationCoin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tCirculationCoin.Location = new System.Drawing.Point(371, 469);
            this.tCirculationCoin.Name = "tCirculationCoin";
            this.tCirculationCoin.Size = new System.Drawing.Size(640, 45);
            this.tCirculationCoin.TabIndex = 19;
            // 
            // tBitkinCoin
            // 
            this.tBitkinCoin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBitkinCoin.Location = new System.Drawing.Point(371, 533);
            this.tBitkinCoin.Name = "tBitkinCoin";
            this.tBitkinCoin.Size = new System.Drawing.Size(640, 45);
            this.tBitkinCoin.TabIndex = 19;
            // 
            // tDescCoin
            // 
            this.tDescCoin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tDescCoin.Location = new System.Drawing.Point(371, 593);
            this.tDescCoin.Multiline = true;
            this.tDescCoin.Name = "tDescCoin";
            this.tDescCoin.Size = new System.Drawing.Size(640, 147);
            this.tDescCoin.TabIndex = 19;
            // 
            // tNameCoin
            // 
            this.tNameCoin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tNameCoin.Location = new System.Drawing.Point(371, 28);
            this.tNameCoin.Name = "tNameCoin";
            this.tNameCoin.Size = new System.Drawing.Size(640, 45);
            this.tNameCoin.TabIndex = 19;
            // 
            // dGridPhoto
            // 
            this.dGridPhoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridPhoto.Location = new System.Drawing.Point(302, 797);
            this.dGridPhoto.Name = "dGridPhoto";
            this.dGridPhoto.RowHeadersWidth = 62;
            this.dGridPhoto.RowTemplate.Height = 33;
            this.dGridPhoto.Size = new System.Drawing.Size(481, 225);
            this.dGridPhoto.TabIndex = 20;
            this.dGridPhoto.Click += new System.EventHandler(this.dGridPhoto_Click);
            // 
            // pB_Photo
            // 
            this.pB_Photo.Cursor = System.Windows.Forms.Cursors.No;
            this.pB_Photo.Location = new System.Drawing.Point(806, 797);
            this.pB_Photo.Name = "pB_Photo";
            this.pB_Photo.Size = new System.Drawing.Size(205, 225);
            this.pB_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Photo.TabIndex = 21;
            this.pB_Photo.TabStop = false;
            // 
            // bAddPhoto
            // 
            this.bAddPhoto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAddPhoto.Location = new System.Drawing.Point(21, 797);
            this.bAddPhoto.Name = "bAddPhoto";
            this.bAddPhoto.Size = new System.Drawing.Size(258, 63);
            this.bAddPhoto.TabIndex = 22;
            this.bAddPhoto.Text = "Добавить фото";
            this.bAddPhoto.UseVisualStyleBackColor = true;
            this.bAddPhoto.Click += new System.EventHandler(this.bAddPhoto_Click);
            // 
            // bDeletePhoto
            // 
            this.bDeletePhoto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bDeletePhoto.Location = new System.Drawing.Point(21, 958);
            this.bDeletePhoto.Name = "bDeletePhoto";
            this.bDeletePhoto.Size = new System.Drawing.Size(258, 64);
            this.bDeletePhoto.TabIndex = 23;
            this.bDeletePhoto.Text = "Удалить фото";
            this.bDeletePhoto.UseVisualStyleBackColor = true;
            this.bDeletePhoto.Click += new System.EventHandler(this.bDeletePhoto_Click);
            // 
            // oFilePhoto
            // 
            this.oFilePhoto.FileName = "openFileDialog1";
            // 
            // FAddEditCoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 1259);
            this.Controls.Add(this.bDeletePhoto);
            this.Controls.Add(this.bAddPhoto);
            this.Controls.Add(this.pB_Photo);
            this.Controls.Add(this.dGridPhoto);
            this.Controls.Add(this.tDescCoin);
            this.Controls.Add(this.tBitkinCoin);
            this.Controls.Add(this.tCirculationCoin);
            this.Controls.Add(this.tStateCoin);
            this.Controls.Add(this.tCountryCoin);
            this.Controls.Add(this.tDiametrCoin);
            this.Controls.Add(this.tMatherialCoin);
            this.Controls.Add(this.tYearCoin);
            this.Controls.Add(this.tNameCoin);
            this.Controls.Add(this.tTypeCoin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.Name = "FAddEditCoin";
            this.Text = "Монета";
            ((System.ComponentModel.ISupportInitialize)(this.dGridPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bOK;
        private Button bCancel;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label10;
        private TextBox tTypeCoin;
        private TextBox tYearCoin;
        private TextBox tMatherialCoin;
        private TextBox tDiametrCoin;
        private TextBox tCountryCoin;
        private TextBox tStateCoin;
        private TextBox tCirculationCoin;
        private TextBox tBitkinCoin;
        private TextBox tDescCoin;
        private TextBox tNameCoin;
        private DataGridView dGridPhoto;
        private PictureBox pB_Photo;
        private Button bAddPhoto;
        private Button bDeletePhoto;
        private OpenFileDialog oFilePhoto;
    }
}