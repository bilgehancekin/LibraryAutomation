namespace Kutuphane
{
    partial class KutuphaneGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KutuphaneGiris));
            this.buttonMembers = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonBorrows = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBookTypes = new System.Windows.Forms.Button();
            this.buttonWriters = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMembers
            // 
            this.buttonMembers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMembers.BackgroundImage")));
            this.buttonMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMembers.Location = new System.Drawing.Point(131, 3);
            this.buttonMembers.Name = "buttonMembers";
            this.buttonMembers.Size = new System.Drawing.Size(122, 202);
            this.buttonMembers.TabIndex = 0;
            this.buttonMembers.Text = "Üye İşlemleri";
            this.buttonMembers.UseVisualStyleBackColor = true;
            this.buttonMembers.Click += new System.EventHandler(this.buttonMembers_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBooks.BackgroundImage")));
            this.buttonBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBooks.Location = new System.Drawing.Point(3, 3);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(122, 202);
            this.buttonBooks.TabIndex = 1;
            this.buttonBooks.Text = "Kitap İşlemleri";
            this.buttonBooks.UseVisualStyleBackColor = true;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonBorrows
            // 
            this.buttonBorrows.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBorrows.BackgroundImage")));
            this.buttonBorrows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBorrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBorrows.Location = new System.Drawing.Point(259, 3);
            this.buttonBorrows.Name = "buttonBorrows";
            this.buttonBorrows.Size = new System.Drawing.Size(123, 202);
            this.buttonBorrows.TabIndex = 2;
            this.buttonBorrows.Text = "Emanet İşlemleri";
            this.buttonBorrows.UseVisualStyleBackColor = true;
            this.buttonBorrows.Click += new System.EventHandler(this.buttonBorrows_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.buttonWriters, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonBookTypes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonBooks, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMembers, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSearch, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonBorrows, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 416);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSearch.Location = new System.Drawing.Point(259, 211);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(123, 202);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Arama İşlemleri";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonBookTypes
            // 
            this.buttonBookTypes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBookTypes.BackgroundImage")));
            this.buttonBookTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBookTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBookTypes.Location = new System.Drawing.Point(131, 211);
            this.buttonBookTypes.Name = "buttonBookTypes";
            this.buttonBookTypes.Size = new System.Drawing.Size(122, 202);
            this.buttonBookTypes.TabIndex = 4;
            this.buttonBookTypes.Text = "Kitap Türü İşlemleri";
            this.buttonBookTypes.UseVisualStyleBackColor = true;
            this.buttonBookTypes.Click += new System.EventHandler(this.buttonBookTypes_Click);
            // 
            // buttonWriters
            // 
            this.buttonWriters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWriters.BackgroundImage")));
            this.buttonWriters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWriters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonWriters.Location = new System.Drawing.Point(3, 211);
            this.buttonWriters.Name = "buttonWriters";
            this.buttonWriters.Size = new System.Drawing.Size(122, 202);
            this.buttonWriters.TabIndex = 5;
            this.buttonWriters.Text = "Yazar İşlemleri";
            this.buttonWriters.UseVisualStyleBackColor = true;
            this.buttonWriters.Click += new System.EventHandler(this.buttonWriters_Click);
            // 
            // KutuphaneGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KutuphaneGiris";
            this.Text = "KutuphaneGiris";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KutuphaneGiris_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMembers;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonBorrows;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonWriters;
        private System.Windows.Forms.Button buttonBookTypes;
    }
}