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
    public partial class KitapTuruIslemleri : Form
    {
        int selectedId = 0;
        kutuphaneDataContext context = new kutuphaneDataContext();
        public KitapTuruIslemleri()
        {
            InitializeComponent();
            gridBookTypeFill();
        }

        void gridBookTypeFill()
        {
            var booktypes = from b in context.BookTypes
                          select new { TypeCode = b.Id, Name = b.Name, Explanation = b.Explanation };
            dataGridBookType.DataSource = booktypes;
        }

        private void textClear()
        {
            selectedId = 0;
            textNameSurname.Text = "";
            textExplanation.Text = "";
        }

        private void buttonAddBookType_Click(object sender, EventArgs e)
        {
            using (context)
            {
                BookType bookType = new BookType();
                bookType.Name = textNameSurname.Text;
                bookType.Explanation = textExplanation.Text;
                context.BookTypes.InsertOnSubmit(bookType);
                context.SubmitChanges();
            }
            gridBookTypeFill();
            textClear();
            MessageBox.Show("Kitap Türü Başarıyla Eklendi");
        }

        private void buttonDeleteBookType_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var bookTypesToErase = from bt in context.BookTypes where bt.Id == selectedId select bt;

                foreach (var bookTypeToErase in bookTypesToErase)
                {
                    var booksToErase = from b in context.Books where b.TypeId== bookTypeToErase.Id select b;
                    foreach (var book in booksToErase)
                    {
                        var borrowsToErase = from br in context.Borrows where br.BookId == book.Id select br;
                        foreach (var borrow in borrowsToErase)
                        {
                            context.Borrows.DeleteOnSubmit(borrow);
                        }
                        context.Books.DeleteOnSubmit(book);
                    }
                    context.BookTypes.DeleteOnSubmit(bookTypeToErase);
                }
                MessageBox.Show("Kitap Türü Başarıyla Silindi");
                context.SubmitChanges();
                gridBookTypeFill();
                textClear();
            }
            else
            {
                MessageBox.Show("Lütfen Silmek Üzere Bir Kitap Türü Seçin!");
            }
        }

        private void buttonEditBookType_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var booktypesToUpdate = from bt in context.BookTypes where bt.Id == selectedId select bt;
                foreach (BookType bookTypeToUpdate in booktypesToUpdate)
                {
                    bookTypeToUpdate.Name = textNameSurname.Text;
                    bookTypeToUpdate.Explanation = textExplanation.Text;
                }
                MessageBox.Show("Kitap Türü Başarıyla Düzenlendi");
                context.SubmitChanges();
                gridBookTypeFill();
                textClear();
            }
            else
            {
                MessageBox.Show("Lütfen Düzenlemek Üzere Bir Kitap Türü Seçin!");
            }
        }

        private void dataGridBookType_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridBookType.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridBookType.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridBookType.Rows[selectedrowindex];
                selectedId = int.Parse(selectedRow.Cells["TypeCode"].Value.ToString());
                textNameSurname.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                textExplanation.Text = Convert.ToString(selectedRow.Cells["Explanation"].Value);        
            }
        }
    }
}
