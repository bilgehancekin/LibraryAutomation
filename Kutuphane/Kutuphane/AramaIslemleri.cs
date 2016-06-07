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
    public partial class AramaIslemleri : Form
    {
        static kutuphaneDataContext context = new kutuphaneDataContext();
        public AramaIslemleri()
        {
            InitializeComponent();
            comboBoxBookTypeFill();
            comboBoxBookNameFill();
            comboBoxMemberNameFill();
            comboBoxWriterNameFill();
            labelBorrowSearchExplanation.MaximumSize = new Size((tabControlSearch.Size.Width * 80 / 100), 0);
            labelBorrowSearchExplanation.AutoSize = true;
            labelBookSearchExplanation.MaximumSize = new Size((tabControlSearch.Size.Width * 80 / 100), 0);
            labelBookSearchExplanation.AutoSize = true;
            labelMemberSearchExplanation.MaximumSize = new Size((tabControlSearch.Size.Width * 80 / 100), 0);
            labelMemberSearchExplanation.AutoSize = true;
        }

        private void textClear() 
        {
            textBirthPlace.Text = "";
            textBookName.Text = "";
            textISBN.Text = "";
            textMemberName.Text = "";
            textPublisher.Text = "";
            textSSN.Text = "";
            textPrice.Text = "";
            comboBoxWriterName.SelectedIndex = -1;
            comboBoxBookName.SelectedIndex = -1;
            comboBoxBookType.SelectedIndex = -1;
            comboBoxMemberName.SelectedIndex = -1;
            dateTimeBirthDateGreater.Value = DateTime.Now;
            dateTimeBirthDateSmaller.Value = DateTime.Now;
        }
       
        private void comboBoxBookNameFill()
        {
            Dictionary<int, string> test = new Dictionary<int, string>();
            var books = from b in context.Books
                        select b;
            foreach (var book in books)
            {
                test.Add(book.Id, book.Name);
            }
            if (test.Count > 0)
            {
                comboBoxBookName.DataSource = new BindingSource(test, null);
                comboBoxBookName.DisplayMember = "Value";
                comboBoxBookName.ValueMember = "Key";
                comboBoxBookName.SelectedIndex = -1;
            }
        }
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

        private void comboBoxMemberNameFill()
        {
            Dictionary<int, string> test = new Dictionary<int, string>();
            var members = from m in context.Members
                          select m;
            foreach (var member in members)
            {
                test.Add(member.Id, member.NameSurname);
            }
            if (test.Count > 0)
            {
                comboBoxMemberName.DataSource = new BindingSource(test, null);
                comboBoxMemberName.DisplayMember = "Value";
                comboBoxMemberName.ValueMember = "Key";
                comboBoxMemberName.SelectedIndex = -1;
            }
        }


        private void comboBoxBookTypeFill()
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
                comboBoxBookType.DataSource = new BindingSource(test, null);
                comboBoxBookType.DisplayMember = "Value";
                comboBoxBookType.ValueMember = "Key";
                comboBoxBookType.SelectedIndex = -1;
            }
        }

        private void buttonBookSearch_Click(object sender, EventArgs e)
        {
            labelBookSearchExplanation.Text = "";
            var books = from b in context.Books
                       join bt in context.BookTypes
                       on b.TypeId equals bt.Id
                       join w in context.Writers
                       on b.WriterId equals w.Id
                       select new { BookCode = b.Id, ISBN = b.ISBN,
                           Name = b.Name, Publisher = b.Publisher,
                           TypeCode = bt.Id,Type = bt.Name,
                           WriterCode = w.Id, Writer = w.NameSurname,
                           PageNumber = b.PageNumber, Price = b.Price,
                           Summary = b.Summary };
            var temp = books.ToList();
            if (!string.IsNullOrEmpty(textISBN.Text))
            {
                labelBookSearchExplanation.Text += "ISBN Numarası '" + textISBN.Text + "' olan, ";
                temp = temp.Where(x => x.ISBN == textISBN.Text).ToList();
            }
            if (!string.IsNullOrEmpty(textBookName.Text))
            {
                labelBookSearchExplanation.Text += "Adı '" + textBookName.Text + "' kelimesini içeren, ";
                temp = temp.Where(x => x.Name.Contains(textBookName.Text)).ToList();
            }
            if (!string.IsNullOrEmpty(textPublisher.Text))
            {
                labelBookSearchExplanation.Text += "Yayıncı Adı '" + textPublisher.Text + "' kelimesini içeren, ";
                temp = temp.Where(x => x.Publisher.Contains(textPublisher.Text)).ToList();
            }
            if (!string.IsNullOrEmpty(textPrice.Text))
            {
                labelBookSearchExplanation.Text += "Fiyatı '" + textPrice.Text + "' olan, ";
                temp = temp.Where(x => x.Price == double.Parse(textPrice.Text)).ToList();
            }
            if (comboBoxBookType.SelectedIndex != -1 && comboBoxBookType.SelectedItem != null)
            {
                labelBookSearchExplanation.Text += "Türü '" + ((KeyValuePair<int, string>)comboBoxBookType.SelectedItem).Value + "' olan, ";
                temp = temp.Where(x => x.TypeCode == ((KeyValuePair<int, string>)comboBoxBookType.SelectedItem).Key).ToList();
            }
            if (comboBoxWriterName.SelectedIndex != -1 && comboBoxWriterName.SelectedItem != null)
            {
                labelBookSearchExplanation.Text += "Yazarı '" + ((KeyValuePair<int, string>)comboBoxWriterName.SelectedItem).Value + "' olan, ";
                temp = temp.Where(x => x.WriterCode == ((KeyValuePair<int, string>)comboBoxWriterName.SelectedItem).Key).ToList();
            }
            labelBookSearchExplanation.Text = labelBookSearchExplanation.Text.Substring(0, (labelBookSearchExplanation.Text.Length - 2));
            labelBookSearchExplanation.Text += " " + temp.Count.ToString() + " adet kitap bulundu.";
            dataGridBookSearch.DataSource = temp;
            this.dataGridBookSearch.Columns["WriterCode"].Visible = false;
            this.dataGridBookSearch.Columns["TypeCode"].Visible = false;
            textClear();
        }

        private void buttonMemberSearch_Click(object sender, EventArgs e)
        {
            labelMemberSearchExplanation.Text = "";
            var temp = context.Members.ToList();
            if (!string.IsNullOrEmpty(textSSN.Text))
            {
                labelMemberSearchExplanation.Text += "TC Kimlik Numarası '" + textSSN.Text + "' olan, ";
                temp = temp.Where(x => x.SSN == textISBN.Text).ToList();
            }
            if (!string.IsNullOrEmpty(textMemberName.Text))
            {
                labelMemberSearchExplanation.Text += "Adı '" + textMemberName.Text + "' kelimesini içeren, ";
                temp = temp.Where(x => x.NameSurname.Contains(textMemberName.Text)).ToList();
            }
            if (!string.IsNullOrEmpty(textBirthPlace.Text))
            {
                labelMemberSearchExplanation.Text += "Doğum Yeri '" + textBirthPlace.Text + "' kelimesini içeren, ";
                temp = temp.Where(x => x.BirthPlace.Contains(textPublisher.Text)).ToList();
            }
            if (dateTimeBirthDateGreater.Value.Date != DateTime.Today.Date)
            {
                labelMemberSearchExplanation.Text += "Doğum Tarihi '" + dateTimeBirthDateGreater.Value.ToShortDateString() + "' tarihinden büyük olan, ";
                temp = temp.Where(x => x.BirthDate > dateTimeBirthDateGreater.Value).ToList();
            }
            if (dateTimeBirthDateSmaller.Value.Date != DateTime.Today.Date)
            {
                labelMemberSearchExplanation.Text+= "Doğum Tarihi '"+dateTimeBirthDateSmaller.Value.ToShortDateString()+"' tarihinden küçük olan, ";
                temp = temp.Where(x => x.BirthDate < dateTimeBirthDateSmaller.Value).ToList();
            }
            if (dateTimeMembershipGreater.Value.Date != DateTime.Today.Date)
            {
                labelMemberSearchExplanation.Text += "Üyelik Tarihi '" + dateTimeMembershipGreater.Value.ToShortDateString() + "' tarihinden büyük olan, ";
                temp = temp.Where(x => x.MembershipStartDate > dateTimeMembershipGreater.Value).ToList();
            }
            if (dateTimeMembershipSmaller.Value.Date != DateTime.Today.Date)
            {
                labelMemberSearchExplanation.Text += "Üyelik Tarihi '" + dateTimeMembershipSmaller.Value.ToShortDateString() + "' tarihinden küçük olan, ";
                temp = temp.Where(x => x.MembershipStartDate < dateTimeMembershipSmaller.Value).ToList();
            }
            labelMemberSearchExplanation.Text = labelMemberSearchExplanation.Text.Substring(0, (labelMemberSearchExplanation.Text.Length - 2));
            labelMemberSearchExplanation.Text += " " + temp.Count.ToString() + " adet üye bulundu.";
            dataGridMemberSearch.DataSource = temp;
            textClear();
        }

        private void buttonBorrowSearch_Click(object sender, EventArgs e)
        {
            labelBorrowSearchExplanation.Text = "";
            var borrows = from b in context.Borrows
                          join m in context.Members
                          on b.MemberId equals m.Id
                          join bk in context.Books
                          on b.BookId equals bk.Id
                          select new
                          {
                              BorrowCode = b.Id,
                              MemberCode = m.Id,
                              MemberName = m.NameSurname,
                              BookCode = bk.Id,
                              BookName = bk.Name,
                              BorrowDate = b.BorrowDate,
                              EstimatedReturnDate = b.EstimatedReturnDate,
                              ReturnDate = b.ReturnDate
                          };
            var temp = borrows.ToList();
            if (comboBoxBookName.SelectedIndex != -1 && comboBoxBookName.SelectedItem != null)
            {
                labelBorrowSearchExplanation.Text += "Kitap Adı '" + ((KeyValuePair<int, string>)comboBoxBookName.SelectedItem).Value + "' olan, ";
                temp = temp.Where(x => x.BookCode == ((KeyValuePair<int, string>)comboBoxBookName.SelectedItem).Key).ToList();
            }
            if (comboBoxMemberName.SelectedIndex != -1 && comboBoxMemberName.SelectedItem != null)
            {
                labelBorrowSearchExplanation.Text += "Emanet Alan Üye Adı '" + ((KeyValuePair<int, string>)comboBoxMemberName.SelectedItem).Value + "' olan, ";
                temp = temp.Where(x => x.MemberCode == ((KeyValuePair<int, string>)comboBoxMemberName.SelectedItem).Key).ToList();
            }
            if (dateTimeBorrowDateGreater.Value.Date != DateTime.Today.Date)
            {
                labelBorrowSearchExplanation.Text += "Emanet Tarihi '" + dateTimeBorrowDateGreater.Value.ToShortDateString() + "' tarihinden büyük olan, ";
                temp = temp.Where(x => x.BorrowDate > dateTimeBorrowDateGreater.Value).ToList();
            }
            if (dateTimeBorrowDateSmaller.Value.Date != DateTime.Today.Date)
            {
                labelBorrowSearchExplanation.Text += "Emanet Tarihi '" + dateTimeBorrowDateSmaller.Value.ToShortDateString() + "' tarihinden küçük olan, ";
                temp = temp.Where(x => x.BorrowDate < dateTimeBorrowDateSmaller.Value).ToList();
            }
            if (dateTimeReturnDateGreater.Value.Date != DateTime.Today.Date)
            {
                labelBorrowSearchExplanation.Text += "Teslim Tarihi '" + dateTimeReturnDateGreater.Value.ToShortDateString() + "' tarihinden büyük olan, ";
                temp = temp.Where(x => x.ReturnDate > dateTimeReturnDateGreater.Value).ToList();
            }
            if (dateTimeReturnDateSmaller.Value.Date != DateTime.Today.Date)
            {
                labelBorrowSearchExplanation.Text += "Teslim Tarihi '" + dateTimeReturnDateSmaller.Value.ToShortDateString() + "' tarihinden küçük olan, ";
                temp = temp.Where(x => x.ReturnDate < dateTimeReturnDateSmaller.Value).ToList();
            }
            labelBorrowSearchExplanation.Text = labelBorrowSearchExplanation.Text.Substring(0, (labelBorrowSearchExplanation.Text.Length - 2));
            labelBorrowSearchExplanation.Text += " " + temp.Count.ToString() + " adet emanet bulundu.";
            dataGridBorrowSearch.DataSource = temp;
            this.dataGridBorrowSearch.Columns["BookCode"].Visible = false;
            this.dataGridBorrowSearch.Columns["MemberCode"].Visible = false;
            textClear();
        }
    }
}
