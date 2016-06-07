namespace Kutuphane
{
    partial class AramaIslemleri
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
            this.tabControlSearch = new System.Windows.Forms.TabControl();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.comboBoxBookType = new System.Windows.Forms.ComboBox();
            this.buttonBookSearch = new System.Windows.Forms.Button();
            this.dataGridBookSearch = new System.Windows.Forms.DataGridView();
            this.textPublisher = new System.Windows.Forms.TextBox();
            this.labelBookType = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.textBookName = new System.Windows.Forms.TextBox();
            this.textISBN = new System.Windows.Forms.TextBox();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.tabPageMember = new System.Windows.Forms.TabPage();
            this.buttonMemberSearch = new System.Windows.Forms.Button();
            this.dataGridMemberSearch = new System.Windows.Forms.DataGridView();
            this.textBirthPlace = new System.Windows.Forms.TextBox();
            this.labelBirthPlace = new System.Windows.Forms.Label();
            this.textMemberName = new System.Windows.Forms.TextBox();
            this.textSSN = new System.Windows.Forms.TextBox();
            this.labelMemberName = new System.Windows.Forms.Label();
            this.labelSSN = new System.Windows.Forms.Label();
            this.tabPageBorrow = new System.Windows.Forms.TabPage();
            this.comboBoxMemberName = new System.Windows.Forms.ComboBox();
            this.comboBoxBookName = new System.Windows.Forms.ComboBox();
            this.buttonBorrowSearch = new System.Windows.Forms.Button();
            this.dataGridBorrowSearch = new System.Windows.Forms.DataGridView();
            this.labelMember_Name = new System.Windows.Forms.Label();
            this.labelBook_Name = new System.Windows.Forms.Label();
            this.comboBoxWriterName = new System.Windows.Forms.ComboBox();
            this.labelWriter = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelBirthDateGreater = new System.Windows.Forms.Label();
            this.labelBirthDateSmaller = new System.Windows.Forms.Label();
            this.dateTimeBirthDateGreater = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBirthDateSmaller = new System.Windows.Forms.DateTimePicker();
            this.dateTimeMembershipSmaller = new System.Windows.Forms.DateTimePicker();
            this.dateTimeMembershipGreater = new System.Windows.Forms.DateTimePicker();
            this.labelMembershipSmaller = new System.Windows.Forms.Label();
            this.labelMembershipGreater = new System.Windows.Forms.Label();
            this.labelMemberSearchExplanation = new System.Windows.Forms.Label();
            this.labelBookSearchExplanation = new System.Windows.Forms.Label();
            this.dateTimeBorrowDateSmaller = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBorrowDateGreater = new System.Windows.Forms.DateTimePicker();
            this.labelBorrowDateSmaller = new System.Windows.Forms.Label();
            this.labelBorrowDateGreater = new System.Windows.Forms.Label();
            this.dateTimeReturnDateSmaller = new System.Windows.Forms.DateTimePicker();
            this.dateTimeReturnDateGreater = new System.Windows.Forms.DateTimePicker();
            this.labelReturnDateSmaller = new System.Windows.Forms.Label();
            this.labelReturnDateGreater = new System.Windows.Forms.Label();
            this.labelBorrowSearchExplanation = new System.Windows.Forms.Label();
            this.tabControlSearch.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookSearch)).BeginInit();
            this.tabPageMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMemberSearch)).BeginInit();
            this.tabPageBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBorrowSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSearch
            // 
            this.tabControlSearch.Controls.Add(this.tabPageBook);
            this.tabControlSearch.Controls.Add(this.tabPageMember);
            this.tabControlSearch.Controls.Add(this.tabPageBorrow);
            this.tabControlSearch.Location = new System.Drawing.Point(12, 12);
            this.tabControlSearch.Name = "tabControlSearch";
            this.tabControlSearch.SelectedIndex = 0;
            this.tabControlSearch.Size = new System.Drawing.Size(792, 463);
            this.tabControlSearch.TabIndex = 0;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.labelBookSearchExplanation);
            this.tabPageBook.Controls.Add(this.textPrice);
            this.tabPageBook.Controls.Add(this.labelPrice);
            this.tabPageBook.Controls.Add(this.comboBoxWriterName);
            this.tabPageBook.Controls.Add(this.labelWriter);
            this.tabPageBook.Controls.Add(this.comboBoxBookType);
            this.tabPageBook.Controls.Add(this.buttonBookSearch);
            this.tabPageBook.Controls.Add(this.dataGridBookSearch);
            this.tabPageBook.Controls.Add(this.textPublisher);
            this.tabPageBook.Controls.Add(this.labelBookType);
            this.tabPageBook.Controls.Add(this.labelPublisher);
            this.tabPageBook.Controls.Add(this.textBookName);
            this.tabPageBook.Controls.Add(this.textISBN);
            this.tabPageBook.Controls.Add(this.labelBookName);
            this.tabPageBook.Controls.Add(this.labelISBN);
            this.tabPageBook.Location = new System.Drawing.Point(4, 22);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(784, 437);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Text = "Kitap";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // comboBoxBookType
            // 
            this.comboBoxBookType.FormattingEnabled = true;
            this.comboBoxBookType.Location = new System.Drawing.Point(231, 43);
            this.comboBoxBookType.Name = "comboBoxBookType";
            this.comboBoxBookType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxBookType.TabIndex = 10;
            // 
            // buttonBookSearch
            // 
            this.buttonBookSearch.Location = new System.Drawing.Point(519, 20);
            this.buttonBookSearch.Name = "buttonBookSearch";
            this.buttonBookSearch.Size = new System.Drawing.Size(245, 47);
            this.buttonBookSearch.TabIndex = 9;
            this.buttonBookSearch.Text = "Kitap Ara";
            this.buttonBookSearch.UseVisualStyleBackColor = true;
            this.buttonBookSearch.Click += new System.EventHandler(this.buttonBookSearch_Click);
            // 
            // dataGridBookSearch
            // 
            this.dataGridBookSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBookSearch.Location = new System.Drawing.Point(18, 125);
            this.dataGridBookSearch.Name = "dataGridBookSearch";
            this.dataGridBookSearch.Size = new System.Drawing.Size(746, 303);
            this.dataGridBookSearch.TabIndex = 8;
            // 
            // textPublisher
            // 
            this.textPublisher.Location = new System.Drawing.Point(398, 17);
            this.textPublisher.Name = "textPublisher";
            this.textPublisher.Size = new System.Drawing.Size(100, 20);
            this.textPublisher.TabIndex = 6;
            // 
            // labelBookType
            // 
            this.labelBookType.AutoSize = true;
            this.labelBookType.Location = new System.Drawing.Point(190, 46);
            this.labelBookType.Name = "labelBookType";
            this.labelBookType.Size = new System.Drawing.Size(23, 13);
            this.labelBookType.TabIndex = 5;
            this.labelBookType.Text = "Tür";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(357, 20);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(41, 13);
            this.labelPublisher.TabIndex = 4;
            this.labelPublisher.Text = "Yayıncı";
            // 
            // textBookName
            // 
            this.textBookName.Location = new System.Drawing.Point(56, 43);
            this.textBookName.Name = "textBookName";
            this.textBookName.Size = new System.Drawing.Size(100, 20);
            this.textBookName.TabIndex = 3;
            // 
            // textISBN
            // 
            this.textISBN.Location = new System.Drawing.Point(56, 17);
            this.textISBN.Name = "textISBN";
            this.textISBN.Size = new System.Drawing.Size(100, 20);
            this.textISBN.TabIndex = 2;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(15, 46);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(20, 13);
            this.labelBookName.TabIndex = 1;
            this.labelBookName.Text = "Ad";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(15, 20);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 0;
            this.labelISBN.Text = "ISBN";
            // 
            // tabPageMember
            // 
            this.tabPageMember.Controls.Add(this.labelMemberSearchExplanation);
            this.tabPageMember.Controls.Add(this.dateTimeMembershipSmaller);
            this.tabPageMember.Controls.Add(this.dateTimeMembershipGreater);
            this.tabPageMember.Controls.Add(this.labelMembershipSmaller);
            this.tabPageMember.Controls.Add(this.labelMembershipGreater);
            this.tabPageMember.Controls.Add(this.dateTimeBirthDateSmaller);
            this.tabPageMember.Controls.Add(this.dateTimeBirthDateGreater);
            this.tabPageMember.Controls.Add(this.labelBirthDateSmaller);
            this.tabPageMember.Controls.Add(this.labelBirthDateGreater);
            this.tabPageMember.Controls.Add(this.buttonMemberSearch);
            this.tabPageMember.Controls.Add(this.dataGridMemberSearch);
            this.tabPageMember.Controls.Add(this.textBirthPlace);
            this.tabPageMember.Controls.Add(this.labelBirthPlace);
            this.tabPageMember.Controls.Add(this.textMemberName);
            this.tabPageMember.Controls.Add(this.textSSN);
            this.tabPageMember.Controls.Add(this.labelMemberName);
            this.tabPageMember.Controls.Add(this.labelSSN);
            this.tabPageMember.Location = new System.Drawing.Point(4, 22);
            this.tabPageMember.Name = "tabPageMember";
            this.tabPageMember.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMember.Size = new System.Drawing.Size(784, 437);
            this.tabPageMember.TabIndex = 1;
            this.tabPageMember.Text = "Üye";
            this.tabPageMember.UseVisualStyleBackColor = true;
            // 
            // buttonMemberSearch
            // 
            this.buttonMemberSearch.Location = new System.Drawing.Point(609, 37);
            this.buttonMemberSearch.Name = "buttonMemberSearch";
            this.buttonMemberSearch.Size = new System.Drawing.Size(144, 47);
            this.buttonMemberSearch.TabIndex = 19;
            this.buttonMemberSearch.Text = "Üye Ara";
            this.buttonMemberSearch.UseVisualStyleBackColor = true;
            this.buttonMemberSearch.Click += new System.EventHandler(this.buttonMemberSearch_Click);
            // 
            // dataGridMemberSearch
            // 
            this.dataGridMemberSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMemberSearch.Location = new System.Drawing.Point(15, 164);
            this.dataGridMemberSearch.Name = "dataGridMemberSearch";
            this.dataGridMemberSearch.Size = new System.Drawing.Size(757, 264);
            this.dataGridMemberSearch.TabIndex = 18;
            // 
            // textBirthPlace
            // 
            this.textBirthPlace.Location = new System.Drawing.Point(80, 77);
            this.textBirthPlace.Name = "textBirthPlace";
            this.textBirthPlace.Size = new System.Drawing.Size(100, 20);
            this.textBirthPlace.TabIndex = 17;
            // 
            // labelBirthPlace
            // 
            this.labelBirthPlace.AutoSize = true;
            this.labelBirthPlace.Location = new System.Drawing.Point(12, 80);
            this.labelBirthPlace.Name = "labelBirthPlace";
            this.labelBirthPlace.Size = new System.Drawing.Size(62, 13);
            this.labelBirthPlace.TabIndex = 15;
            this.labelBirthPlace.Text = "Doğum Yeri";
            // 
            // textMemberName
            // 
            this.textMemberName.Location = new System.Drawing.Point(80, 51);
            this.textMemberName.Name = "textMemberName";
            this.textMemberName.Size = new System.Drawing.Size(100, 20);
            this.textMemberName.TabIndex = 14;
            // 
            // textSSN
            // 
            this.textSSN.Location = new System.Drawing.Point(80, 25);
            this.textSSN.Name = "textSSN";
            this.textSSN.Size = new System.Drawing.Size(100, 20);
            this.textSSN.TabIndex = 13;
            // 
            // labelMemberName
            // 
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.Location = new System.Drawing.Point(12, 54);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(20, 13);
            this.labelMemberName.TabIndex = 12;
            this.labelMemberName.Text = "Ad";
            // 
            // labelSSN
            // 
            this.labelSSN.AutoSize = true;
            this.labelSSN.Location = new System.Drawing.Point(12, 28);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(38, 13);
            this.labelSSN.TabIndex = 11;
            this.labelSSN.Text = "TC No";
            // 
            // tabPageBorrow
            // 
            this.tabPageBorrow.Controls.Add(this.labelBorrowSearchExplanation);
            this.tabPageBorrow.Controls.Add(this.dateTimeReturnDateSmaller);
            this.tabPageBorrow.Controls.Add(this.dateTimeReturnDateGreater);
            this.tabPageBorrow.Controls.Add(this.labelReturnDateSmaller);
            this.tabPageBorrow.Controls.Add(this.labelReturnDateGreater);
            this.tabPageBorrow.Controls.Add(this.dateTimeBorrowDateSmaller);
            this.tabPageBorrow.Controls.Add(this.dateTimeBorrowDateGreater);
            this.tabPageBorrow.Controls.Add(this.labelBorrowDateSmaller);
            this.tabPageBorrow.Controls.Add(this.labelBorrowDateGreater);
            this.tabPageBorrow.Controls.Add(this.comboBoxMemberName);
            this.tabPageBorrow.Controls.Add(this.comboBoxBookName);
            this.tabPageBorrow.Controls.Add(this.buttonBorrowSearch);
            this.tabPageBorrow.Controls.Add(this.dataGridBorrowSearch);
            this.tabPageBorrow.Controls.Add(this.labelMember_Name);
            this.tabPageBorrow.Controls.Add(this.labelBook_Name);
            this.tabPageBorrow.Location = new System.Drawing.Point(4, 22);
            this.tabPageBorrow.Name = "tabPageBorrow";
            this.tabPageBorrow.Size = new System.Drawing.Size(784, 437);
            this.tabPageBorrow.TabIndex = 2;
            this.tabPageBorrow.Text = "Emanet";
            this.tabPageBorrow.UseVisualStyleBackColor = true;
            // 
            // comboBoxMemberName
            // 
            this.comboBoxMemberName.FormattingEnabled = true;
            this.comboBoxMemberName.Location = new System.Drawing.Point(81, 66);
            this.comboBoxMemberName.Name = "comboBoxMemberName";
            this.comboBoxMemberName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMemberName.TabIndex = 29;
            // 
            // comboBoxBookName
            // 
            this.comboBoxBookName.FormattingEnabled = true;
            this.comboBoxBookName.Location = new System.Drawing.Point(81, 39);
            this.comboBoxBookName.Name = "comboBoxBookName";
            this.comboBoxBookName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBookName.TabIndex = 28;
            // 
            // buttonBorrowSearch
            // 
            this.buttonBorrowSearch.Location = new System.Drawing.Point(642, 31);
            this.buttonBorrowSearch.Name = "buttonBorrowSearch";
            this.buttonBorrowSearch.Size = new System.Drawing.Size(109, 47);
            this.buttonBorrowSearch.TabIndex = 27;
            this.buttonBorrowSearch.Text = "Emanet Ara";
            this.buttonBorrowSearch.UseVisualStyleBackColor = true;
            this.buttonBorrowSearch.Click += new System.EventHandler(this.buttonBorrowSearch_Click);
            // 
            // dataGridBorrowSearch
            // 
            this.dataGridBorrowSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBorrowSearch.Location = new System.Drawing.Point(18, 154);
            this.dataGridBorrowSearch.Name = "dataGridBorrowSearch";
            this.dataGridBorrowSearch.Size = new System.Drawing.Size(757, 274);
            this.dataGridBorrowSearch.TabIndex = 26;
            // 
            // labelMember_Name
            // 
            this.labelMember_Name.AutoSize = true;
            this.labelMember_Name.Location = new System.Drawing.Point(26, 69);
            this.labelMember_Name.Name = "labelMember_Name";
            this.labelMember_Name.Size = new System.Drawing.Size(44, 13);
            this.labelMember_Name.TabIndex = 21;
            this.labelMember_Name.Text = "Üye Adı";
            // 
            // labelBook_Name
            // 
            this.labelBook_Name.AutoSize = true;
            this.labelBook_Name.Location = new System.Drawing.Point(26, 42);
            this.labelBook_Name.Name = "labelBook_Name";
            this.labelBook_Name.Size = new System.Drawing.Size(49, 13);
            this.labelBook_Name.TabIndex = 20;
            this.labelBook_Name.Text = "Kitap Adı";
            // 
            // comboBoxWriterName
            // 
            this.comboBoxWriterName.FormattingEnabled = true;
            this.comboBoxWriterName.Location = new System.Drawing.Point(231, 17);
            this.comboBoxWriterName.Name = "comboBoxWriterName";
            this.comboBoxWriterName.Size = new System.Drawing.Size(100, 21);
            this.comboBoxWriterName.TabIndex = 12;
            // 
            // labelWriter
            // 
            this.labelWriter.AutoSize = true;
            this.labelWriter.Location = new System.Drawing.Point(190, 20);
            this.labelWriter.Name = "labelWriter";
            this.labelWriter.Size = new System.Drawing.Size(34, 13);
            this.labelWriter.TabIndex = 11;
            this.labelWriter.Text = "Yazar";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(398, 43);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 20);
            this.textPrice.TabIndex = 14;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(357, 46);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(29, 13);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "Fiyat";
            // 
            // labelBirthDateGreater
            // 
            this.labelBirthDateGreater.AutoSize = true;
            this.labelBirthDateGreater.Location = new System.Drawing.Point(212, 19);
            this.labelBirthDateGreater.Name = "labelBirthDateGreater";
            this.labelBirthDateGreater.Size = new System.Drawing.Size(161, 13);
            this.labelBirthDateGreater.TabIndex = 20;
            this.labelBirthDateGreater.Text = "Doğum Tarihi Şu Tarihten Büyük";
            // 
            // labelBirthDateSmaller
            // 
            this.labelBirthDateSmaller.AutoSize = true;
            this.labelBirthDateSmaller.Location = new System.Drawing.Point(212, 71);
            this.labelBirthDateSmaller.Name = "labelBirthDateSmaller";
            this.labelBirthDateSmaller.Size = new System.Drawing.Size(162, 13);
            this.labelBirthDateSmaller.TabIndex = 21;
            this.labelBirthDateSmaller.Text = "Doğum Tarihi Şu Tarihten Küçük";
            // 
            // dateTimeBirthDateGreater
            // 
            this.dateTimeBirthDateGreater.Location = new System.Drawing.Point(215, 42);
            this.dateTimeBirthDateGreater.Name = "dateTimeBirthDateGreater";
            this.dateTimeBirthDateGreater.Size = new System.Drawing.Size(158, 20);
            this.dateTimeBirthDateGreater.TabIndex = 45;
            // 
            // dateTimeBirthDateSmaller
            // 
            this.dateTimeBirthDateSmaller.Location = new System.Drawing.Point(215, 92);
            this.dateTimeBirthDateSmaller.Name = "dateTimeBirthDateSmaller";
            this.dateTimeBirthDateSmaller.Size = new System.Drawing.Size(158, 20);
            this.dateTimeBirthDateSmaller.TabIndex = 46;
            // 
            // dateTimeMembershipSmaller
            // 
            this.dateTimeMembershipSmaller.Location = new System.Drawing.Point(411, 92);
            this.dateTimeMembershipSmaller.Name = "dateTimeMembershipSmaller";
            this.dateTimeMembershipSmaller.Size = new System.Drawing.Size(158, 20);
            this.dateTimeMembershipSmaller.TabIndex = 50;
            // 
            // dateTimeMembershipGreater
            // 
            this.dateTimeMembershipGreater.Location = new System.Drawing.Point(411, 42);
            this.dateTimeMembershipGreater.Name = "dateTimeMembershipGreater";
            this.dateTimeMembershipGreater.Size = new System.Drawing.Size(158, 20);
            this.dateTimeMembershipGreater.TabIndex = 49;
            // 
            // labelMembershipSmaller
            // 
            this.labelMembershipSmaller.AutoSize = true;
            this.labelMembershipSmaller.Location = new System.Drawing.Point(408, 71);
            this.labelMembershipSmaller.Name = "labelMembershipSmaller";
            this.labelMembershipSmaller.Size = new System.Drawing.Size(157, 13);
            this.labelMembershipSmaller.TabIndex = 48;
            this.labelMembershipSmaller.Text = "Üyelik Tarihi Şu Tarihten Küçük";
            // 
            // labelMembershipGreater
            // 
            this.labelMembershipGreater.AutoSize = true;
            this.labelMembershipGreater.Location = new System.Drawing.Point(408, 19);
            this.labelMembershipGreater.Name = "labelMembershipGreater";
            this.labelMembershipGreater.Size = new System.Drawing.Size(156, 13);
            this.labelMembershipGreater.TabIndex = 47;
            this.labelMembershipGreater.Text = "Üyelik Tarihi Şu Tarihten Büyük";
            // 
            // labelMemberSearchExplanation
            // 
            this.labelMemberSearchExplanation.AutoSize = true;
            this.labelMemberSearchExplanation.Location = new System.Drawing.Point(19, 128);
            this.labelMemberSearchExplanation.Name = "labelMemberSearchExplanation";
            this.labelMemberSearchExplanation.Size = new System.Drawing.Size(0, 13);
            this.labelMemberSearchExplanation.TabIndex = 51;
            // 
            // labelBookSearchExplanation
            // 
            this.labelBookSearchExplanation.AutoSize = true;
            this.labelBookSearchExplanation.Location = new System.Drawing.Point(15, 81);
            this.labelBookSearchExplanation.Name = "labelBookSearchExplanation";
            this.labelBookSearchExplanation.Size = new System.Drawing.Size(0, 13);
            this.labelBookSearchExplanation.TabIndex = 15;
            // 
            // dateTimeBorrowDateSmaller
            // 
            this.dateTimeBorrowDateSmaller.Location = new System.Drawing.Point(241, 86);
            this.dateTimeBorrowDateSmaller.Name = "dateTimeBorrowDateSmaller";
            this.dateTimeBorrowDateSmaller.Size = new System.Drawing.Size(158, 20);
            this.dateTimeBorrowDateSmaller.TabIndex = 50;
            // 
            // dateTimeBorrowDateGreater
            // 
            this.dateTimeBorrowDateGreater.Location = new System.Drawing.Point(241, 36);
            this.dateTimeBorrowDateGreater.Name = "dateTimeBorrowDateGreater";
            this.dateTimeBorrowDateGreater.Size = new System.Drawing.Size(158, 20);
            this.dateTimeBorrowDateGreater.TabIndex = 49;
            // 
            // labelBorrowDateSmaller
            // 
            this.labelBorrowDateSmaller.AutoSize = true;
            this.labelBorrowDateSmaller.Location = new System.Drawing.Point(238, 65);
            this.labelBorrowDateSmaller.Name = "labelBorrowDateSmaller";
            this.labelBorrowDateSmaller.Size = new System.Drawing.Size(164, 13);
            this.labelBorrowDateSmaller.TabIndex = 48;
            this.labelBorrowDateSmaller.Text = "Emanet Tarihi Şu Tarihten Küçük";
            // 
            // labelBorrowDateGreater
            // 
            this.labelBorrowDateGreater.AutoSize = true;
            this.labelBorrowDateGreater.Location = new System.Drawing.Point(238, 13);
            this.labelBorrowDateGreater.Name = "labelBorrowDateGreater";
            this.labelBorrowDateGreater.Size = new System.Drawing.Size(163, 13);
            this.labelBorrowDateGreater.TabIndex = 47;
            this.labelBorrowDateGreater.Text = "Emanet Tarihi Şu Tarihten Büyük";
            // 
            // dateTimeReturnDateSmaller
            // 
            this.dateTimeReturnDateSmaller.Location = new System.Drawing.Point(437, 86);
            this.dateTimeReturnDateSmaller.Name = "dateTimeReturnDateSmaller";
            this.dateTimeReturnDateSmaller.Size = new System.Drawing.Size(158, 20);
            this.dateTimeReturnDateSmaller.TabIndex = 54;
            // 
            // dateTimeReturnDateGreater
            // 
            this.dateTimeReturnDateGreater.Location = new System.Drawing.Point(437, 36);
            this.dateTimeReturnDateGreater.Name = "dateTimeReturnDateGreater";
            this.dateTimeReturnDateGreater.Size = new System.Drawing.Size(158, 20);
            this.dateTimeReturnDateGreater.TabIndex = 53;
            // 
            // labelReturnDateSmaller
            // 
            this.labelReturnDateSmaller.AutoSize = true;
            this.labelReturnDateSmaller.Location = new System.Drawing.Point(434, 65);
            this.labelReturnDateSmaller.Name = "labelReturnDateSmaller";
            this.labelReturnDateSmaller.Size = new System.Drawing.Size(158, 13);
            this.labelReturnDateSmaller.TabIndex = 52;
            this.labelReturnDateSmaller.Text = "Teslim Tarihi Şu Tarihten Küçük";
            // 
            // labelReturnDateGreater
            // 
            this.labelReturnDateGreater.AutoSize = true;
            this.labelReturnDateGreater.Location = new System.Drawing.Point(434, 13);
            this.labelReturnDateGreater.Name = "labelReturnDateGreater";
            this.labelReturnDateGreater.Size = new System.Drawing.Size(157, 13);
            this.labelReturnDateGreater.TabIndex = 51;
            this.labelReturnDateGreater.Text = "Teslim Tarihi Şu Tarihten Büyük";
            // 
            // labelBorrowSearchExplanation
            // 
            this.labelBorrowSearchExplanation.AutoSize = true;
            this.labelBorrowSearchExplanation.Location = new System.Drawing.Point(26, 115);
            this.labelBorrowSearchExplanation.Name = "labelBorrowSearchExplanation";
            this.labelBorrowSearchExplanation.Size = new System.Drawing.Size(0, 13);
            this.labelBorrowSearchExplanation.TabIndex = 55;
            // 
            // AramaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 474);
            this.Controls.Add(this.tabControlSearch);
            this.Name = "AramaIslemleri";
            this.Text = "Arama İşlemleri";
            this.tabControlSearch.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            this.tabPageBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookSearch)).EndInit();
            this.tabPageMember.ResumeLayout(false);
            this.tabPageMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMemberSearch)).EndInit();
            this.tabPageBorrow.ResumeLayout(false);
            this.tabPageBorrow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBorrowSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSearch;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.TextBox textBookName;
        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TabPage tabPageMember;
        private System.Windows.Forms.TabPage tabPageBorrow;
        private System.Windows.Forms.Button buttonBookSearch;
        private System.Windows.Forms.DataGridView dataGridBookSearch;
        private System.Windows.Forms.TextBox textPublisher;
        private System.Windows.Forms.Label labelBookType;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.ComboBox comboBoxBookType;
        private System.Windows.Forms.Button buttonMemberSearch;
        private System.Windows.Forms.DataGridView dataGridMemberSearch;
        private System.Windows.Forms.TextBox textBirthPlace;
        private System.Windows.Forms.Label labelBirthPlace;
        private System.Windows.Forms.TextBox textMemberName;
        private System.Windows.Forms.TextBox textSSN;
        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.Label labelSSN;
        private System.Windows.Forms.Button buttonBorrowSearch;
        private System.Windows.Forms.DataGridView dataGridBorrowSearch;
        private System.Windows.Forms.Label labelMember_Name;
        private System.Windows.Forms.Label labelBook_Name;
        private System.Windows.Forms.ComboBox comboBoxMemberName;
        private System.Windows.Forms.ComboBox comboBoxBookName;
        private System.Windows.Forms.ComboBox comboBoxWriterName;
        private System.Windows.Forms.Label labelWriter;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelBirthDateSmaller;
        private System.Windows.Forms.Label labelBirthDateGreater;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDateSmaller;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDateGreater;
        private System.Windows.Forms.Label labelMemberSearchExplanation;
        private System.Windows.Forms.DateTimePicker dateTimeMembershipSmaller;
        private System.Windows.Forms.DateTimePicker dateTimeMembershipGreater;
        private System.Windows.Forms.Label labelMembershipSmaller;
        private System.Windows.Forms.Label labelMembershipGreater;
        private System.Windows.Forms.Label labelBookSearchExplanation;
        private System.Windows.Forms.Label labelBorrowSearchExplanation;
        private System.Windows.Forms.DateTimePicker dateTimeReturnDateSmaller;
        private System.Windows.Forms.DateTimePicker dateTimeReturnDateGreater;
        private System.Windows.Forms.Label labelReturnDateSmaller;
        private System.Windows.Forms.Label labelReturnDateGreater;
        private System.Windows.Forms.DateTimePicker dateTimeBorrowDateSmaller;
        private System.Windows.Forms.DateTimePicker dateTimeBorrowDateGreater;
        private System.Windows.Forms.Label labelBorrowDateSmaller;
        private System.Windows.Forms.Label labelBorrowDateGreater;
    }
}