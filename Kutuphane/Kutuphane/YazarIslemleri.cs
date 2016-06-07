using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class YazarIslemleri : Form
    {
        int selectedId = 0;
        kutuphaneDataContext context = new kutuphaneDataContext();
        public YazarIslemleri()
        {
            InitializeComponent();
            gridWriterFill();
        }

        void gridWriterFill()
        {
            var writers = from b in context.Writers
                          select new { WriterCode = b.Id, BirthDate = b.BirthDate, Name = b.NameSurname, Biography = b.Biography };
            dataGridWriter.DataSource = writers;
        }

        private void textClear()
        {
            selectedId = 0;
            textNameSurname.Text = "";
            textBiography.Text = "";
            dateTimeBirthDate.Value = DateTime.Today;
        }

        private void buttonAddWriter_Click(object sender, EventArgs e)
        {
            using (context)
            {
                Writer writer = new Writer();
                writer.NameSurname = textNameSurname.Text;
                writer.Biography = textBiography.Text;
                writer.BirthDate = dateTimeBirthDate.Value;
                context.Writers.InsertOnSubmit(writer);
                context.SubmitChanges();
            }
            gridWriterFill();
            textClear();
            MessageBox.Show("Yazar Başarıyla Eklendi");
        }

        private void buttonDeleteWriter_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var writersToErase = from w in context.Writers where w.Id == selectedId select w;
                
                foreach (var writerToErase in writersToErase)
                {
                    var booksToErase = from b in context.Books where b.WriterId == writerToErase.Id select b;
                    foreach (var book in booksToErase)
                    {
                        var borrowsToErase = from br in context.Borrows where br.BookId == book.Id select br;
                        foreach (var borrow in borrowsToErase)
                        {
                            context.Borrows.DeleteOnSubmit(borrow);
                        }
                        context.Books.DeleteOnSubmit(book);
                    }               
                    context.Writers.DeleteOnSubmit(writerToErase);
                }
                MessageBox.Show("Yazar Başarıyla Silindi");
                context.SubmitChanges();
                gridWriterFill();
                textClear();
            }
            else
            {
                MessageBox.Show("Lütfen Silmek Üzere Bir Yazar Seçin!");
            }
        }

        private void buttonEditWriter_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var writersToUpdate = from w in context.Writers where w.Id == selectedId select w;
                foreach (Writer writerToUpdate in writersToUpdate)
                {
                    writerToUpdate.NameSurname = textNameSurname.Text;
                    writerToUpdate.Biography = textBiography.Text;
                    writerToUpdate.BirthDate = dateTimeBirthDate.Value;
                }
                MessageBox.Show("Yazar Başarıyla Düzenlendi");
                context.SubmitChanges();
                gridWriterFill();
                textClear();
            }
            else
            {
                MessageBox.Show("Lütfen Düzenlemek Üzere Bir Yazar Seçin!");
            }
        }

        private void dataGridWriter_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridWriter.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridWriter.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridWriter.Rows[selectedrowindex];
                selectedId = int.Parse(selectedRow.Cells["WriterCode"].Value.ToString());
                textNameSurname.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                textBiography.Text = Convert.ToString(selectedRow.Cells["Biography"].Value);
                dateTimeBirthDate.Value = DateTime.Parse(selectedRow.Cells["BirthDate"].Value.ToString());
            }
        }
    }
}
