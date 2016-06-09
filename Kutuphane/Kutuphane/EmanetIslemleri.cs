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
    public partial class EmanetIslemleri : Form
    {
        kutuphaneDataContext context = new kutuphaneDataContext();
        public EmanetIslemleri()
        {
            InitializeComponent();
            comboBoxBookNameFill();
            comboBoxMemberNameFill();
            gridBorrowFill();
        }

        int selectedId = 0;
        void gridBorrowFill()
        {
            var borrows = from b in context.Borrows
                          join m in context.Members
                          on b.MemberId equals m.Id
                          join bk in context.Books
                          on b.BookId equals bk.Id
                          select new {BorrowCode=b.Id, MemberName = m.NameSurname,
                              BookName = bk.Name,
                              BorrowDate = b.BorrowDate,
                              EstimatedReturnDate = b.EstimatedReturnDate,
                              ReturnDate = b.ReturnDate };
            dataGridBorrow.DataSource = borrows;
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
                comboBoxBookNames.DataSource = new BindingSource(test, null);
                comboBoxBookNames.DisplayMember = "Value";
                comboBoxBookNames.ValueMember = "Key";
                comboBoxBookNames.SelectedIndex = -1;
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
                comboBoxMemberNames.DataSource = new BindingSource(test, null);
                comboBoxMemberNames.DisplayMember = "Value";
                comboBoxMemberNames.ValueMember = "Key";
                comboBoxMemberNames.SelectedIndex = -1;
            }
        }

        private void buttonAddBorrow_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.MemberId = ((KeyValuePair<int, string>)comboBoxMemberNames.SelectedItem).Key;
            borrow.BookId = ((KeyValuePair<int, string>)comboBoxBookNames.SelectedItem).Key;
            borrow.BorrowDate = dateTimeBorrow.Value;
            borrow.EstimatedReturnDate  = dateTimeEstimatedReturn.Value;
            borrow.ReturnDate = dateTimeReturn.Value;
            context.Borrows.InsertOnSubmit(borrow);
            context.SubmitChanges();
            
            MessageBox.Show("Emanet Başarıyla Eklendi");
            gridBorrowFill();
            textClear();
        }

        private void textClear()
        {
            comboBoxBookNames.SelectedIndex = -1;
            comboBoxMemberNames.SelectedIndex = -1;
            dateTimeBorrow.Value = DateTime.Today;
            dateTimeEstimatedReturn.Value = DateTime.Today;
            selectedId = 0;
        }

        private void buttonDeleteBorrow_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var borrowsToErase = from b in context.Borrows
                                     where b.Id == selectedId
                                     select b;
                foreach (var borrowToErase in borrowsToErase)
                {
                    context.Borrows.DeleteOnSubmit(borrowToErase);
                }
                MessageBox.Show("Emanet Başarıyla Silindi");
                context.SubmitChanges();
                gridBorrowFill();
                textClear();
            }
            else
            {
                MessageBox.Show("Lütfen Silinmek Üzere Bir Emanet Seçiniz!");
            }
        }

        private void buttonEditBorrow_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var borrowsToUpdate = from b in context.Borrows
                                      where b.Id == selectedId
                                      select b;
                foreach (Borrow borrowToUpdate in borrowsToUpdate)
                {
                    borrowToUpdate.BookId = ((KeyValuePair<int, string>)comboBoxBookNames.SelectedItem).Key;
                    borrowToUpdate.MemberId = ((KeyValuePair<int, string>)comboBoxMemberNames.SelectedItem).Key;
                    borrowToUpdate.BorrowDate = dateTimeBorrow.Value;
                    borrowToUpdate.EstimatedReturnDate = dateTimeEstimatedReturn.Value;
                    borrowToUpdate.ReturnDate = dateTimeReturn.Value;
                }
                MessageBox.Show("Emanet Başarıyla Güncellendi");
                context.SubmitChanges();
                gridBorrowFill();
                textClear();
            }
            else
            {
                MessageBox.Show("Lütfen Düzenlemek Üzere Bir Emanet Seçiniz!");
            }
        }

        private void buttonRecieveBorrow_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var borrowsToUpdate = from b in context.Borrows
                                      where b.Id == selectedId
                                      select b;
                foreach (Borrow borrowToUpdate in borrowsToUpdate)
                {
                    borrowToUpdate.ReturnDate = dateTimeReturn.Value;
                }
                MessageBox.Show("Emanet Başarıyla Teslim Alındı");
                context.SubmitChanges();
                textClear();
            }
            else
            {
                MessageBox.Show("Lütfen Teslim Alınmak Üzere Bir Emanet Seçiniz!");
            }
        }

        private void dataGridBorrow_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridBorrow.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridBorrow.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridBorrow.Rows[selectedrowindex];
                selectedId = int.Parse(selectedRow.Cells["BorrowCode"].Value.ToString());
                comboBoxBookNames.SelectedItem = comboBoxBookNames.Items.OfType<KeyValuePair<int, string>>().ToList().FirstOrDefault(i => i.Value == Convert.ToString(selectedRow.Cells["BookName"].Value));
                comboBoxMemberNames.SelectedItem = comboBoxMemberNames.Items.OfType<KeyValuePair<int, string>>().ToList().FirstOrDefault(i => i.Value == Convert.ToString(selectedRow.Cells["MemberName"].Value));
                dateTimeBorrow.Value = DateTime.Parse(selectedRow.Cells["BorrowDate"].Value.ToString());
                dateTimeEstimatedReturn.Value = DateTime.Parse(selectedRow.Cells["EstimatedReturnDate"].Value.ToString());


            }
        }
    }
}
