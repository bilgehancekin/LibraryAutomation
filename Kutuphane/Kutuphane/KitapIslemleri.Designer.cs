namespace Kutuphane
{
    partial class KitapIslemleri
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
            this.textISBN = new System.Windows.Forms.TextBox();
            this.textBookName = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelWriterName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.dataGridBook = new System.Windows.Forms.DataGridView();
            this.labelBookType = new System.Windows.Forms.Label();
            this.comboBoxBookTypeName = new System.Windows.Forms.ComboBox();
            this.labelSummary = new System.Windows.Forms.Label();
            this.textSummary = new System.Windows.Forms.RichTextBox();
            this.labelPageNumber = new System.Windows.Forms.Label();
            this.textPageNumber = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.comboBoxWriterName = new System.Windows.Forms.ComboBox();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.textPublisher = new System.Windows.Forms.TextBox();
            this.labelPublisher = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).BeginInit();
            this.SuspendLayout();
            // 
            // textISBN
            // 
            this.textISBN.Location = new System.Drawing.Point(29, 24);
            this.textISBN.Name = "textISBN";
            this.textISBN.Size = new System.Drawing.Size(100, 20);
            this.textISBN.TabIndex = 5;
            // 
            // textBookName
            // 
            this.textBookName.Location = new System.Drawing.Point(172, 24);
            this.textBookName.Name = "textBookName";
            this.textBookName.Size = new System.Drawing.Size(100, 20);
            this.textBookName.TabIndex = 6;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(439, 24);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 20);
            this.textPrice.TabIndex = 8;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(26, 8);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 9;
            this.labelISBN.Text = "ISBN";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(169, 8);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(49, 13);
            this.labelBookName.TabIndex = 10;
            this.labelBookName.Text = "Kitap Adı";
            // 
            // labelWriterName
            // 
            this.labelWriterName.AutoSize = true;
            this.labelWriterName.Location = new System.Drawing.Point(301, 8);
            this.labelWriterName.Name = "labelWriterName";
            this.labelWriterName.Size = new System.Drawing.Size(63, 13);
            this.labelWriterName.TabIndex = 11;
            this.labelWriterName.Text = "Kitap Yazarı";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(436, 8);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(29, 13);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "Fiyat";
            // 
            // dataGridBook
            // 
            this.dataGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBook.Location = new System.Drawing.Point(29, 172);
            this.dataGridBook.Name = "dataGridBook";
            this.dataGridBook.Size = new System.Drawing.Size(520, 209);
            this.dataGridBook.TabIndex = 13;
            this.dataGridBook.SelectionChanged += new System.EventHandler(this.dataGridBook_SelectionChanged);
            // 
            // labelBookType
            // 
            this.labelBookType.AutoSize = true;
            this.labelBookType.Location = new System.Drawing.Point(26, 47);
            this.labelBookType.Name = "labelBookType";
            this.labelBookType.Size = new System.Drawing.Size(56, 13);
            this.labelBookType.TabIndex = 14;
            this.labelBookType.Text = "Kitap Türü";
            // 
            // comboBoxBookTypeName
            // 
            this.comboBoxBookTypeName.FormattingEnabled = true;
            this.comboBoxBookTypeName.Location = new System.Drawing.Point(29, 63);
            this.comboBoxBookTypeName.Name = "comboBoxBookTypeName";
            this.comboBoxBookTypeName.Size = new System.Drawing.Size(100, 21);
            this.comboBoxBookTypeName.TabIndex = 15;
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(169, 59);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(58, 13);
            this.labelSummary.TabIndex = 16;
            this.labelSummary.Text = "Kitap Özeti";
            // 
            // textSummary
            // 
            this.textSummary.Location = new System.Drawing.Point(170, 75);
            this.textSummary.Name = "textSummary";
            this.textSummary.Size = new System.Drawing.Size(368, 71);
            this.textSummary.TabIndex = 17;
            this.textSummary.Text = "";
            // 
            // labelPageNumber
            // 
            this.labelPageNumber.AutoSize = true;
            this.labelPageNumber.Location = new System.Drawing.Point(26, 87);
            this.labelPageNumber.Name = "labelPageNumber";
            this.labelPageNumber.Size = new System.Drawing.Size(64, 13);
            this.labelPageNumber.TabIndex = 18;
            this.labelPageNumber.Text = "Sayfa Sayısı";
            // 
            // textPageNumber
            // 
            this.textPageNumber.Location = new System.Drawing.Point(29, 103);
            this.textPageNumber.Name = "textPageNumber";
            this.textPageNumber.Size = new System.Drawing.Size(100, 20);
            this.textPageNumber.TabIndex = 19;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(32, 397);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(130, 42);
            this.buttonAddBook.TabIndex = 20;
            this.buttonAddBook.Text = "Kitap Ekle";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // comboBoxWriterName
            // 
            this.comboBoxWriterName.FormattingEnabled = true;
            this.comboBoxWriterName.Location = new System.Drawing.Point(304, 24);
            this.comboBoxWriterName.Name = "comboBoxWriterName";
            this.comboBoxWriterName.Size = new System.Drawing.Size(106, 21);
            this.comboBoxWriterName.TabIndex = 21;
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(222, 397);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(130, 42);
            this.buttonDeleteBook.TabIndex = 22;
            this.buttonDeleteBook.Text = "Kitap Sil";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Location = new System.Drawing.Point(396, 396);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(130, 42);
            this.buttonEditBook.TabIndex = 23;
            this.buttonEditBook.Text = "Kitap Düzenle";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            this.buttonEditBook.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // textPublisher
            // 
            this.textPublisher.Location = new System.Drawing.Point(29, 142);
            this.textPublisher.Name = "textPublisher";
            this.textPublisher.Size = new System.Drawing.Size(100, 20);
            this.textPublisher.TabIndex = 25;
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(26, 126);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(41, 13);
            this.labelPublisher.TabIndex = 24;
            this.labelPublisher.Text = "Yayıncı";
            // 
            // KitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.textPublisher);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.comboBoxWriterName);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.textPageNumber);
            this.Controls.Add(this.labelPageNumber);
            this.Controls.Add(this.textSummary);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.comboBoxBookTypeName);
            this.Controls.Add(this.labelBookType);
            this.Controls.Add(this.dataGridBook);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelWriterName);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textBookName);
            this.Controls.Add(this.textISBN);
            this.Name = "KitapIslemleri";
            this.Text = "Kitap İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.TextBox textBookName;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelWriterName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.DataGridView dataGridBook;
        private System.Windows.Forms.Label labelBookType;
        private System.Windows.Forms.ComboBox comboBoxBookTypeName;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.RichTextBox textSummary;
        private System.Windows.Forms.Label labelPageNumber;
        private System.Windows.Forms.TextBox textPageNumber;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.ComboBox comboBoxWriterName;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.TextBox textPublisher;
        private System.Windows.Forms.Label labelPublisher;
    }
}