namespace Kutuphane
{
    partial class KitapTuruIslemleri
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
            this.buttonEditBookType = new System.Windows.Forms.Button();
            this.buttonDeleteBookType = new System.Windows.Forms.Button();
            this.textNameSurname = new System.Windows.Forms.TextBox();
            this.buttonAddBookType = new System.Windows.Forms.Button();
            this.textExplanation = new System.Windows.Forms.RichTextBox();
            this.labelExplanation = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridBookType = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookType)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditBookType
            // 
            this.buttonEditBookType.Location = new System.Drawing.Point(540, 388);
            this.buttonEditBookType.Name = "buttonEditBookType";
            this.buttonEditBookType.Size = new System.Drawing.Size(166, 42);
            this.buttonEditBookType.TabIndex = 79;
            this.buttonEditBookType.Text = "Kitap Türü Düzenle";
            this.buttonEditBookType.UseVisualStyleBackColor = true;
            this.buttonEditBookType.Click += new System.EventHandler(this.buttonEditBookType_Click);
            // 
            // buttonDeleteBookType
            // 
            this.buttonDeleteBookType.Location = new System.Drawing.Point(309, 388);
            this.buttonDeleteBookType.Name = "buttonDeleteBookType";
            this.buttonDeleteBookType.Size = new System.Drawing.Size(166, 42);
            this.buttonDeleteBookType.TabIndex = 78;
            this.buttonDeleteBookType.Text = "Kitap Türü Sil";
            this.buttonDeleteBookType.UseVisualStyleBackColor = true;
            this.buttonDeleteBookType.Click += new System.EventHandler(this.buttonDeleteBookType_Click);
            // 
            // textNameSurname
            // 
            this.textNameSurname.Location = new System.Drawing.Point(15, 26);
            this.textNameSurname.Name = "textNameSurname";
            this.textNameSurname.Size = new System.Drawing.Size(100, 20);
            this.textNameSurname.TabIndex = 76;
            // 
            // buttonAddBookType
            // 
            this.buttonAddBookType.Location = new System.Drawing.Point(59, 388);
            this.buttonAddBookType.Name = "buttonAddBookType";
            this.buttonAddBookType.Size = new System.Drawing.Size(166, 42);
            this.buttonAddBookType.TabIndex = 75;
            this.buttonAddBookType.Text = "Kitap Türü Ekle";
            this.buttonAddBookType.UseVisualStyleBackColor = true;
            this.buttonAddBookType.Click += new System.EventHandler(this.buttonAddBookType_Click);
            // 
            // textExplanation
            // 
            this.textExplanation.Location = new System.Drawing.Point(133, 26);
            this.textExplanation.Name = "textExplanation";
            this.textExplanation.Size = new System.Drawing.Size(573, 67);
            this.textExplanation.TabIndex = 73;
            this.textExplanation.Text = "";
            // 
            // labelExplanation
            // 
            this.labelExplanation.AutoSize = true;
            this.labelExplanation.Location = new System.Drawing.Point(130, 9);
            this.labelExplanation.Name = "labelExplanation";
            this.labelExplanation.Size = new System.Drawing.Size(50, 13);
            this.labelExplanation.TabIndex = 72;
            this.labelExplanation.Text = "Açıklama";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(22, 13);
            this.labelName.TabIndex = 71;
            this.labelName.Text = "Adı";
            // 
            // dataGridBookType
            // 
            this.dataGridBookType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBookType.Location = new System.Drawing.Point(59, 109);
            this.dataGridBookType.Name = "dataGridBookType";
            this.dataGridBookType.Size = new System.Drawing.Size(647, 261);
            this.dataGridBookType.TabIndex = 70;
            this.dataGridBookType.SelectionChanged += new System.EventHandler(this.dataGridBookType_SelectionChanged);
            // 
            // KitapTuruIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.buttonEditBookType);
            this.Controls.Add(this.buttonDeleteBookType);
            this.Controls.Add(this.textNameSurname);
            this.Controls.Add(this.buttonAddBookType);
            this.Controls.Add(this.textExplanation);
            this.Controls.Add(this.labelExplanation);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridBookType);
            this.Name = "KitapTuruIslemleri";
            this.Text = "KitapTuruIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditBookType;
        private System.Windows.Forms.Button buttonDeleteBookType;
        private System.Windows.Forms.TextBox textNameSurname;
        private System.Windows.Forms.Button buttonAddBookType;
        private System.Windows.Forms.RichTextBox textExplanation;
        private System.Windows.Forms.Label labelExplanation;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridBookType;
    }
}