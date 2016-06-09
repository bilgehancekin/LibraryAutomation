using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class KitapIslemleri : Form
    {
        kutuphaneDataContext context = new kutuphaneDataContext();
        public KitapIslemleri()
        {
            InitializeComponent();
            comboBoxWriterNameFill();
            comboBoxBookTypeNameFill();
            gridBookFill();
        }

        int selectedId = 0;
        private void comboBoxWriterNameFill()
        {
            Dictionary<int, string> test = new Dictionary<int, string>();          
            var writers = from w in context.Writers
                            select w;
            foreach (var writer in writers) 
            {
                test.Add(writer.Id, writer.NameSurname);
            }
            if (test.Count > 0)
            {
                comboBoxWriterName.DataSource = new BindingSource(test, null);
                comboBoxWriterName.DisplayMember = "Value";
                comboBoxWriterName.ValueMember = "Key";
                comboBoxWriterName.SelectedIndex = -1;
            }
        }

        private void comboBoxBookTypeNameFill()
        {
            Dictionary<int, string> test = new Dictionary<int, string>();
            var booktypes = from bt in context.BookTypes
                        select bt;
            foreach (var booktype in booktypes)
            {
                test.Add(booktype.Id, booktype.Name);
            }
            if (test.Count > 0)
            {
                comboBoxBookTypeName.DataSource = new BindingSource(test, null);
                comboBoxBookTypeName.DisplayMember = "Value";
                comboBoxBookTypeName.ValueMember = "Key";
                comboBoxBookTypeName.SelectedIndex = -1;
            }
        }

        void gridBookFill()
        {
            var books = from b in context.Books
                               join bt in context.BookTypes
                               on b.TypeId equals bt.Id
                               join w in context.Writers
                               on b.WriterId equals w.Id
                               select new { BookCode = b.Id ,ISBN = b.ISBN, Name = b.Name,Publisher = b.Publisher,Type = bt.Name, Writer=w.NameSurname, PageNumber = b.PageNumber, Price = b.Price ,Summary = b.Summary };
            dataGridBook.DataSource = books;
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.ISBN = textISBN.Text;
            book.Name = textBookName.Text;
            book.Publisher = textPublisher.Text;
            book.Summary = textSummary.Text;
            book.Price = float.Parse(textPrice.Text);
            book.PageNumber = int.Parse(textPageNumber.Text);
            book.TypeId = ((KeyValuePair<int, string>)comboBoxBookTypeName.SelectedItem).Key;
            book.WriterId =((KeyValuePair<int, string>)comboBoxWriterName.SelectedItem).Key;
            context.Books.InsertOnSubmit(book);
            context.SubmitChanges();

            gridBookFill();
            textClear();
            MessageBox.Show("Kitap Başarıyla Eklendi");
        }

        private void textClear()
        {
            selectedId = 0;
            textBookName.Text="";
            textISBN.Text="";
            textPageNumber.Text="";
            textSummary.Text="";
            comboBoxWriterName.SelectedIndex = -1;
            textPrice.Text = ""; 
            comboBoxBookTypeName.SelectedIndex = -1;
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var booksToErase = from b in context.Books where b.Id == selectedId select b;
                foreach (var bookToErase in booksToErase)
                {
                    var borrowsToErase = from br in context.Borrows where br.BookId == bookToErase.Id select br;
                    foreach (var br in borrowsToErase)
                    {
                        context.Borrows.DeleteOnSubmit(br);
                    }
                    context.Books.DeleteOnSubmit(bookToErase);
                }
                MessageBox.Show("Kitap Başarıyla Silindi");
                context.SubmitChanges();
                gridBookFill();
                textClear();
            }
            else
            {
                MessageBox.Show("Lütfen Silmek Üzere Bir Kitap Seçin!");
            }

        }

        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var bookToUpdates = from b in context.Books where b.Id == selectedId select b;
                foreach (Book bookToUpdate in bookToUpdates)
                {
                    bookToUpdate.ISBN = textISBN.Text;
                    bookToUpdate.Name = textBookName.Text;
                    bookToUpdate.PageNumber = int.Parse(textPageNumber.Text);
                    bookToUpdate.Price = float.Parse(textPrice.Text);
                    bookToUpdate.Publisher = textPublisher.Text;
                    bookToUpdate.Summary = textSummary.Text;
                    bookToUpdate.TypeId = ((KeyValuePair<int, string>)comboBoxBookTypeName.SelectedItem).Key;
                    bookToUpdate.WriterId = ((KeyValuePair<int, string>)comboBoxWriterName.SelectedItem).Key;
                }
                MessageBox.Show("Kitap Başarıyla Düzenlendi");
                context.SubmitChanges();
                gridBookFill();
                textClear();
            }
            else
            {
                MessageBox.Show("Lütfen Düzenlemek Üzere Bir Kitap Seçin!");
            }
        }

        private void dataGridBook_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridBook.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridBook.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridBook.Rows[selectedrowindex];
                selectedId = int.Parse(selectedRow.Cells["BookCode"].Value.ToString());
                textISBN.Text = Convert.ToString(selectedRow.Cells["ISBN"].Value);
                textBookName.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                textPageNumber.Text = Convert.ToString(selectedRow.Cells["PageNumber"].Value);
                textPublisher.Text = Convert.ToString(selectedRow.Cells["Publisher"].Value);
                textSummary.Text = Convert.ToString(selectedRow.Cells["Summary"].Value);
                textPrice.Text = Convert.ToString(selectedRow.Cells["Price"].Value);
                comboBoxBookTypeName.SelectedItem = comboBoxBookTypeName.Items.OfType<KeyValuePair<int, string>>().ToList().FirstOrDefault(i => i.Value == Convert.ToString(selectedRow.Cells["Type"].Value));
                comboBoxWriterName.SelectedItem = comboBoxWriterName.Items.OfType<KeyValuePair<int, string>>().ToList().FirstOrDefault(i => i.Value == Convert.ToString(selectedRow.Cells["Writer"].Value));
            }
        }
    }
}
