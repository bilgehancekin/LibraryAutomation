namespace Kutuphane
{
    partial class YazarIslemleri
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
            this.buttonEditWriter = new System.Windows.Forms.Button();
            this.buttonDeleteWriter = new System.Windows.Forms.Button();
            this.dateTimeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textNameSurname = new System.Windows.Forms.TextBox();
            this.buttonAddWriter = new System.Windows.Forms.Button();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBiography = new System.Windows.Forms.RichTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridWriter = new System.Windows.Forms.DataGridView();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelBiography = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWriter)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditWriter
            // 
            this.buttonEditWriter.Location = new System.Drawing.Point(540, 395);
            this.buttonEditWriter.Name = "buttonEditWriter";
            this.buttonEditWriter.Size = new System.Drawing.Size(166, 42);
            this.buttonEditWriter.TabIndex = 68;
            this.buttonEditWriter.Text = "Yazar Düzenle";
            this.buttonEditWriter.UseVisualStyleBackColor = true;
            this.buttonEditWriter.Click += new System.EventHandler(this.buttonEditWriter_Click);
            // 
            // buttonDeleteWriter
            // 
            this.buttonDeleteWriter.Location = new System.Drawing.Point(309, 395);
            this.buttonDeleteWriter.Name = "buttonDeleteWriter";
            this.buttonDeleteWriter.Size = new System.Drawing.Size(166, 42);
            this.buttonDeleteWriter.TabIndex = 67;
            this.buttonDeleteWriter.Text = "Yazar Sil";
            this.buttonDeleteWriter.UseVisualStyleBackColor = true;
            this.buttonDeleteWriter.Click += new System.EventHandler(this.buttonDeleteWriter_Click);
            // 
            // dateTimeBirthDate
            // 
            this.dateTimeBirthDate.Location = new System.Drawing.Point(15, 80);
            this.dateTimeBirthDate.Name = "dateTimeBirthDate";
            this.dateTimeBirthDate.Size = new System.Drawing.Size(103, 20);
            this.dateTimeBirthDate.TabIndex = 65;
            // 
            // textNameSurname
            // 
            this.textNameSurname.Location = new System.Drawing.Point(15, 33);
            this.textNameSurname.Name = "textNameSurname";
            this.textNameSurname.Size = new System.Drawing.Size(100, 20);
            this.textNameSurname.TabIndex = 64;
            // 
            // buttonAddWriter
            // 
            this.buttonAddWriter.Location = new System.Drawing.Point(59, 395);
            this.buttonAddWriter.Name = "buttonAddWriter";
            this.buttonAddWriter.Size = new System.Drawing.Size(166, 42);
            this.buttonAddWriter.TabIndex = 60;
            this.buttonAddWriter.Text = "Yazar Ekle";
            this.buttonAddWriter.UseVisualStyleBackColor = true;
            this.buttonAddWriter.Click += new System.EventHandler(this.buttonAddWriter_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(36, 16);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(39, 13);
            this.labelSurname.TabIndex = 59;
            this.labelSurname.Text = "Soyadı";
            // 
            // textBiography
            // 
            this.textBiography.Location = new System.Drawing.Point(142, 33);
            this.textBiography.Name = "textBiography";
            this.textBiography.Size = new System.Drawing.Size(573, 67);
            this.textBiography.TabIndex = 58;
            this.textBiography.Text = "";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(22, 13);
            this.labelName.TabIndex = 56;
            this.labelName.Text = "Adı";
            // 
            // dataGridWriter
            // 
            this.dataGridWriter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWriter.Location = new System.Drawing.Point(59, 116);
            this.dataGridWriter.Name = "dataGridWriter";
            this.dataGridWriter.Size = new System.Drawing.Size(647, 261);
            this.dataGridWriter.TabIndex = 55;
            this.dataGridWriter.SelectionChanged += new System.EventHandler(this.dataGridWriter_SelectionChanged);
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(10, 63);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(70, 13);
            this.labelBirthDate.TabIndex = 53;
            this.labelBirthDate.Text = "Doğum Tarihi";
            // 
            // labelBiography
            // 
            this.labelBiography.AutoSize = true;
            this.labelBiography.Location = new System.Drawing.Point(148, 16);
            this.labelBiography.Name = "labelBiography";
            this.labelBiography.Size = new System.Drawing.Size(47, 13);
            this.labelBiography.TabIndex = 57;
            this.labelBiography.Text = "Biyografi";
            // 
            // YazarIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 452);
            this.Controls.Add(this.buttonEditWriter);
            this.Controls.Add(this.buttonDeleteWriter);
            this.Controls.Add(this.dateTimeBirthDate);
            this.Controls.Add(this.textNameSurname);
            this.Controls.Add(this.buttonAddWriter);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBiography);
            this.Controls.Add(this.labelBiography);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridWriter);
            this.Controls.Add(this.labelBirthDate);
            this.Name = "YazarIslemleri";
            this.Text = "Yazar İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWriter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditWriter;
        private System.Windows.Forms.Button buttonDeleteWriter;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDate;
        private System.Windows.Forms.TextBox textNameSurname;
        private System.Windows.Forms.Button buttonAddWriter;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.RichTextBox textBiography;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridWriter;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelBiography;
    }
}