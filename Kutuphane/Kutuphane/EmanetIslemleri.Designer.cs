namespace Kutuphane
{
    partial class EmanetIslemleri
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
            this.labelEstimatedReturnDate = new System.Windows.Forms.Label();
            this.labelBorrowDate = new System.Windows.Forms.Label();
            this.dataGridBorrow = new System.Windows.Forms.DataGridView();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelMemberName = new System.Windows.Forms.Label();
            this.buttonAddBorrow = new System.Windows.Forms.Button();
            this.dateTimeEstimatedReturn = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBorrow = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBookNames = new System.Windows.Forms.ComboBox();
            this.comboBoxMemberNames = new System.Windows.Forms.ComboBox();
            this.buttonDeleteBorrow = new System.Windows.Forms.Button();
            this.buttonEditBorrow = new System.Windows.Forms.Button();
            this.buttonRecieveBorrow = new System.Windows.Forms.Button();
            this.dateTimeReturn = new System.Windows.Forms.DateTimePicker();
            this.labelReturnDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEstimatedReturnDate
            // 
            this.labelEstimatedReturnDate.AutoSize = true;
            this.labelEstimatedReturnDate.Location = new System.Drawing.Point(12, 147);
            this.labelEstimatedReturnDate.Name = "labelEstimatedReturnDate";
            this.labelEstimatedReturnDate.Size = new System.Drawing.Size(55, 13);
            this.labelEstimatedReturnDate.TabIndex = 34;
            this.labelEstimatedReturnDate.Text = "Bitiş Tarihi";
            // 
            // labelBorrowDate
            // 
            this.labelBorrowDate.AutoSize = true;
            this.labelBorrowDate.Location = new System.Drawing.Point(12, 108);
            this.labelBorrowDate.Name = "labelBorrowDate";
            this.labelBorrowDate.Size = new System.Drawing.Size(82, 13);
            this.labelBorrowDate.TabIndex = 30;
            this.labelBorrowDate.Text = "Baslangıç Tarihi";
            // 
            // dataGridBorrow
            // 
            this.dataGridBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBorrow.Location = new System.Drawing.Point(132, 25);
            this.dataGridBorrow.Name = "dataGridBorrow";
            this.dataGridBorrow.Size = new System.Drawing.Size(518, 209);
            this.dataGridBorrow.TabIndex = 29;
            this.dataGridBorrow.SelectionChanged += new System.EventHandler(this.dataGridBorrow_SelectionChanged);
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(12, 25);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(49, 13);
            this.labelBookName.TabIndex = 26;
            this.labelBookName.Text = "Kitap Adı";
            // 
            // labelMemberName
            // 
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.Location = new System.Drawing.Point(12, 67);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(44, 13);
            this.labelMemberName.TabIndex = 25;
            this.labelMemberName.Text = "Üye Adı";
            // 
            // buttonAddBorrow
            // 
            this.buttonAddBorrow.Location = new System.Drawing.Point(15, 263);
            this.buttonAddBorrow.Name = "buttonAddBorrow";
            this.buttonAddBorrow.Size = new System.Drawing.Size(126, 55);
            this.buttonAddBorrow.TabIndex = 36;
            this.buttonAddBorrow.Text = "Emanet Ekle";
            this.buttonAddBorrow.UseVisualStyleBackColor = true;
            this.buttonAddBorrow.Click += new System.EventHandler(this.buttonAddBorrow_Click);
            // 
            // dateTimeEstimatedReturn
            // 
            this.dateTimeEstimatedReturn.Location = new System.Drawing.Point(12, 163);
            this.dateTimeEstimatedReturn.Name = "dateTimeEstimatedReturn";
            this.dateTimeEstimatedReturn.Size = new System.Drawing.Size(114, 20);
            this.dateTimeEstimatedReturn.TabIndex = 47;
            // 
            // dateTimeBorrow
            // 
            this.dateTimeBorrow.Location = new System.Drawing.Point(12, 124);
            this.dateTimeBorrow.Name = "dateTimeBorrow";
            this.dateTimeBorrow.Size = new System.Drawing.Size(114, 20);
            this.dateTimeBorrow.TabIndex = 46;
            // 
            // comboBoxBookNames
            // 
            this.comboBoxBookNames.FormattingEnabled = true;
            this.comboBoxBookNames.Location = new System.Drawing.Point(15, 43);
            this.comboBoxBookNames.Name = "comboBoxBookNames";
            this.comboBoxBookNames.Size = new System.Drawing.Size(111, 21);
            this.comboBoxBookNames.TabIndex = 48;
            // 
            // comboBoxMemberNames
            // 
            this.comboBoxMemberNames.FormattingEnabled = true;
            this.comboBoxMemberNames.Location = new System.Drawing.Point(15, 84);
            this.comboBoxMemberNames.Name = "comboBoxMemberNames";
            this.comboBoxMemberNames.Size = new System.Drawing.Size(111, 21);
            this.comboBoxMemberNames.TabIndex = 49;
            // 
            // buttonDeleteBorrow
            // 
            this.buttonDeleteBorrow.Location = new System.Drawing.Point(186, 263);
            this.buttonDeleteBorrow.Name = "buttonDeleteBorrow";
            this.buttonDeleteBorrow.Size = new System.Drawing.Size(126, 55);
            this.buttonDeleteBorrow.TabIndex = 50;
            this.buttonDeleteBorrow.Text = "Emanet Sil";
            this.buttonDeleteBorrow.UseVisualStyleBackColor = true;
            this.buttonDeleteBorrow.Click += new System.EventHandler(this.buttonDeleteBorrow_Click);
            // 
            // buttonEditBorrow
            // 
            this.buttonEditBorrow.Location = new System.Drawing.Point(356, 263);
            this.buttonEditBorrow.Name = "buttonEditBorrow";
            this.buttonEditBorrow.Size = new System.Drawing.Size(126, 55);
            this.buttonEditBorrow.TabIndex = 51;
            this.buttonEditBorrow.Text = "Emanet Düzenle";
            this.buttonEditBorrow.UseVisualStyleBackColor = true;
            this.buttonEditBorrow.Click += new System.EventHandler(this.buttonEditBorrow_Click);
            // 
            // buttonRecieveBorrow
            // 
            this.buttonRecieveBorrow.Location = new System.Drawing.Point(524, 263);
            this.buttonRecieveBorrow.Name = "buttonRecieveBorrow";
            this.buttonRecieveBorrow.Size = new System.Drawing.Size(126, 55);
            this.buttonRecieveBorrow.TabIndex = 52;
            this.buttonRecieveBorrow.Text = "Teslim Al";
            this.buttonRecieveBorrow.UseVisualStyleBackColor = true;
            this.buttonRecieveBorrow.Click += new System.EventHandler(this.buttonRecieveBorrow_Click);
            // 
            // dateTimeReturn
            // 
            this.dateTimeReturn.Location = new System.Drawing.Point(15, 202);
            this.dateTimeReturn.Name = "dateTimeReturn";
            this.dateTimeReturn.Size = new System.Drawing.Size(111, 20);
            this.dateTimeReturn.TabIndex = 54;
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Location = new System.Drawing.Point(12, 186);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(66, 13);
            this.labelReturnDate.TabIndex = 55;
            this.labelReturnDate.Text = "Teslim Tarihi";
            // 
            // EmanetIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 340);
            this.Controls.Add(this.labelReturnDate);
            this.Controls.Add(this.dateTimeReturn);
            this.Controls.Add(this.buttonRecieveBorrow);
            this.Controls.Add(this.buttonEditBorrow);
            this.Controls.Add(this.buttonDeleteBorrow);
            this.Controls.Add(this.comboBoxMemberNames);
            this.Controls.Add(this.comboBoxBookNames);
            this.Controls.Add(this.dateTimeEstimatedReturn);
            this.Controls.Add(this.dateTimeBorrow);
            this.Controls.Add(this.buttonAddBorrow);
            this.Controls.Add(this.labelEstimatedReturnDate);
            this.Controls.Add(this.labelBorrowDate);
            this.Controls.Add(this.dataGridBorrow);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.labelMemberName);
            this.Name = "EmanetIslemleri";
            this.Text = "Emanet İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEstimatedReturnDate;
        private System.Windows.Forms.Label labelBorrowDate;
        private System.Windows.Forms.DataGridView dataGridBorrow;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.Button buttonAddBorrow;
        private System.Windows.Forms.DateTimePicker dateTimeEstimatedReturn;
        private System.Windows.Forms.DateTimePicker dateTimeBorrow;
        private System.Windows.Forms.ComboBox comboBoxBookNames;
        private System.Windows.Forms.ComboBox comboBoxMemberNames;
        private System.Windows.Forms.Button buttonDeleteBorrow;
        private System.Windows.Forms.Button buttonEditBorrow;
        private System.Windows.Forms.Button buttonRecieveBorrow;
        private System.Windows.Forms.DateTimePicker dateTimeReturn;
        private System.Windows.Forms.Label labelReturnDate;
    }
}