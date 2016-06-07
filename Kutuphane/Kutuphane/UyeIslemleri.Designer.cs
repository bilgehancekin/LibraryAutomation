namespace Kutuphane
{
    partial class UyeIslemleri
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
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.RichTextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridMember = new System.Windows.Forms.DataGridView();
            this.labelTelephoneNumber = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelBirthPlace = new System.Windows.Forms.Label();
            this.labelSSN = new System.Windows.Forms.Label();
            this.textTelephoneNumber = new System.Windows.Forms.TextBox();
            this.textBirthPlace = new System.Windows.Forms.TextBox();
            this.textSSN = new System.Windows.Forms.TextBox();
            this.textEMail = new System.Windows.Forms.TextBox();
            this.labelEMail = new System.Windows.Forms.Label();
            this.labelMembershipStartDate = new System.Windows.Forms.Label();
            this.textNameSurname = new System.Windows.Forms.TextBox();
            this.dateTimeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeMembershipStart = new System.Windows.Forms.DateTimePicker();
            this.buttonDeleteMember = new System.Windows.Forms.Button();
            this.buttonEditMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Location = new System.Drawing.Point(56, 399);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(166, 42);
            this.buttonAddMember.TabIndex = 36;
            this.buttonAddMember.Text = "Üye Ekle";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(32, 52);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(39, 13);
            this.labelSurname.TabIndex = 34;
            this.labelSurname.Text = "Soyadı";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(10, 304);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(725, 78);
            this.textAddress.TabIndex = 33;
            this.textAddress.Text = "";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(9, 288);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(34, 13);
            this.labelAddress.TabIndex = 32;
            this.labelAddress.Text = "Adres";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(22, 13);
            this.labelName.TabIndex = 30;
            this.labelName.Text = "Adı";
            // 
            // dataGridMember
            // 
            this.dataGridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMember.Location = new System.Drawing.Point(162, 24);
            this.dataGridMember.Name = "dataGridMember";
            this.dataGridMember.Size = new System.Drawing.Size(572, 261);
            this.dataGridMember.TabIndex = 29;
            this.dataGridMember.SelectionChanged += new System.EventHandler(this.dataGridMember_SelectionChanged);
            // 
            // labelTelephoneNumber
            // 
            this.labelTelephoneNumber.AutoSize = true;
            this.labelTelephoneNumber.Location = new System.Drawing.Point(7, 171);
            this.labelTelephoneNumber.Name = "labelTelephoneNumber";
            this.labelTelephoneNumber.Size = new System.Drawing.Size(43, 13);
            this.labelTelephoneNumber.TabIndex = 28;
            this.labelTelephoneNumber.Text = "Telefon";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(7, 131);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(70, 13);
            this.labelBirthDate.TabIndex = 27;
            this.labelBirthDate.Text = "Doğum Tarihi";
            // 
            // labelBirthPlace
            // 
            this.labelBirthPlace.AutoSize = true;
            this.labelBirthPlace.Location = new System.Drawing.Point(9, 92);
            this.labelBirthPlace.Name = "labelBirthPlace";
            this.labelBirthPlace.Size = new System.Drawing.Size(62, 13);
            this.labelBirthPlace.TabIndex = 26;
            this.labelBirthPlace.Text = "Doğum Yeri";
            this.labelBirthPlace.UseMnemonic = false;
            // 
            // labelSSN
            // 
            this.labelSSN.AutoSize = true;
            this.labelSSN.Location = new System.Drawing.Point(9, 13);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(68, 13);
            this.labelSSN.TabIndex = 25;
            this.labelSSN.Text = "TC Kimlik No";
            // 
            // textTelephoneNumber
            // 
            this.textTelephoneNumber.Location = new System.Drawing.Point(12, 187);
            this.textTelephoneNumber.Name = "textTelephoneNumber";
            this.textTelephoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textTelephoneNumber.TabIndex = 24;
            // 
            // textBirthPlace
            // 
            this.textBirthPlace.Location = new System.Drawing.Point(12, 108);
            this.textBirthPlace.Name = "textBirthPlace";
            this.textBirthPlace.Size = new System.Drawing.Size(100, 20);
            this.textBirthPlace.TabIndex = 23;
            // 
            // textSSN
            // 
            this.textSSN.Location = new System.Drawing.Point(12, 29);
            this.textSSN.Name = "textSSN";
            this.textSSN.Size = new System.Drawing.Size(100, 20);
            this.textSSN.TabIndex = 22;
            // 
            // textEMail
            // 
            this.textEMail.Location = new System.Drawing.Point(12, 226);
            this.textEMail.Name = "textEMail";
            this.textEMail.Size = new System.Drawing.Size(100, 20);
            this.textEMail.TabIndex = 41;
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Location = new System.Drawing.Point(9, 210);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(41, 13);
            this.labelEMail.TabIndex = 40;
            this.labelEMail.Text = "EPosta";
            // 
            // labelMembershipStartDate
            // 
            this.labelMembershipStartDate.AutoSize = true;
            this.labelMembershipStartDate.Location = new System.Drawing.Point(9, 249);
            this.labelMembershipStartDate.Name = "labelMembershipStartDate";
            this.labelMembershipStartDate.Size = new System.Drawing.Size(65, 13);
            this.labelMembershipStartDate.TabIndex = 39;
            this.labelMembershipStartDate.Text = "Uyelik Tarihi";
            // 
            // textNameSurname
            // 
            this.textNameSurname.Location = new System.Drawing.Point(11, 69);
            this.textNameSurname.Name = "textNameSurname";
            this.textNameSurname.Size = new System.Drawing.Size(100, 20);
            this.textNameSurname.TabIndex = 43;
            // 
            // dateTimeBirthDate
            // 
            this.dateTimeBirthDate.Location = new System.Drawing.Point(12, 148);
            this.dateTimeBirthDate.Name = "dateTimeBirthDate";
            this.dateTimeBirthDate.Size = new System.Drawing.Size(103, 20);
            this.dateTimeBirthDate.TabIndex = 44;
            // 
            // dateTimeMembershipStart
            // 
            this.dateTimeMembershipStart.Location = new System.Drawing.Point(12, 265);
            this.dateTimeMembershipStart.Name = "dateTimeMembershipStart";
            this.dateTimeMembershipStart.Size = new System.Drawing.Size(103, 20);
            this.dateTimeMembershipStart.TabIndex = 45;
            // 
            // buttonDeleteMember
            // 
            this.buttonDeleteMember.Location = new System.Drawing.Point(306, 399);
            this.buttonDeleteMember.Name = "buttonDeleteMember";
            this.buttonDeleteMember.Size = new System.Drawing.Size(166, 42);
            this.buttonDeleteMember.TabIndex = 46;
            this.buttonDeleteMember.Text = "Üye Sil";
            this.buttonDeleteMember.UseVisualStyleBackColor = true;
            this.buttonDeleteMember.Click += new System.EventHandler(this.buttonDeleteMember_Click);
            // 
            // buttonEditMember
            // 
            this.buttonEditMember.Location = new System.Drawing.Point(537, 399);
            this.buttonEditMember.Name = "buttonEditMember";
            this.buttonEditMember.Size = new System.Drawing.Size(166, 42);
            this.buttonEditMember.TabIndex = 47;
            this.buttonEditMember.Text = "Üye Düzenle";
            this.buttonEditMember.UseVisualStyleBackColor = true;
            this.buttonEditMember.Click += new System.EventHandler(this.buttonEditMember_Click);
            // 
            // UyeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 462);
            this.Controls.Add(this.buttonEditMember);
            this.Controls.Add(this.buttonDeleteMember);
            this.Controls.Add(this.dateTimeMembershipStart);
            this.Controls.Add(this.dateTimeBirthDate);
            this.Controls.Add(this.textNameSurname);
            this.Controls.Add(this.textEMail);
            this.Controls.Add(this.labelEMail);
            this.Controls.Add(this.labelMembershipStartDate);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridMember);
            this.Controls.Add(this.labelTelephoneNumber);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelBirthPlace);
            this.Controls.Add(this.labelSSN);
            this.Controls.Add(this.textTelephoneNumber);
            this.Controls.Add(this.textBirthPlace);
            this.Controls.Add(this.textSSN);
            this.Name = "UyeIslemleri";
            this.Text = "Üye İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.RichTextBox textAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridMember;
        private System.Windows.Forms.Label labelTelephoneNumber;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelBirthPlace;
        private System.Windows.Forms.Label labelSSN;
        private System.Windows.Forms.TextBox textTelephoneNumber;
        private System.Windows.Forms.TextBox textBirthPlace;
        private System.Windows.Forms.TextBox textSSN;
        private System.Windows.Forms.TextBox textEMail;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.Label labelMembershipStartDate;
        private System.Windows.Forms.TextBox textNameSurname;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDate;
        private System.Windows.Forms.DateTimePicker dateTimeMembershipStart;
        private System.Windows.Forms.Button buttonDeleteMember;
        private System.Windows.Forms.Button buttonEditMember;
    }
}