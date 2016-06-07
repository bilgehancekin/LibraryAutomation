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
    public partial class UyeIslemleri : Form
    {
        kutuphaneDataContext context = new kutuphaneDataContext();
        public UyeIslemleri()
        {
            InitializeComponent();
            gridMemberFill();
        }

        int selectedId = 0;
        void gridMemberFill()
        {
            var allMembers = context.Members;
            dataGridMember.DataSource = allMembers;
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            using (context)
            {
                Member member = new Member();
                member.SSN = textSSN.Text;
                member.NameSurname = textNameSurname.Text;
                member.EMail = textEMail.Text;
                member.BirthPlace = textBirthPlace.Text;
                member.BirthDate = dateTimeBirthDate.Value;
                member.Adress = textAddress.Text;
                member.MembershipStartDate = dateTimeMembershipStart.Value;
                context.Members.InsertOnSubmit(member);
                context.SubmitChanges();
            }
            gridMemberFill();
            textClear();
            MessageBox.Show("Okuyucu Başarıyla Eklendi");
        }
        private void textClear()
        {
            selectedId = 0;
            textSSN.Text = "";
            textNameSurname.Text = "";
            dateTimeBirthDate.Value = DateTime.Today;
            textBirthPlace.Text = "";
            textAddress.Text = "";
            textTelephoneNumber.Text = "";
            textEMail.Text = "";
            dateTimeMembershipStart.Value = DateTime.Today;
        }

        private void dataGridMember_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridMember.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridMember.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridMember.Rows[selectedrowindex];
                selectedId = int.Parse(selectedRow.Cells["Id"].Value.ToString());
                textSSN.Text = Convert.ToString(selectedRow.Cells["SSN"].Value);
                textNameSurname.Text = Convert.ToString(selectedRow.Cells["NameSurname"].Value);
                textEMail.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
                textBirthPlace.Text = Convert.ToString(selectedRow.Cells["BirthPlace"].Value);
                textAddress.Text = Convert.ToString(selectedRow.Cells["Adress"].Value);
                textTelephoneNumber.Text = Convert.ToString(selectedRow.Cells["TelephoneNumber"].Value);
                dateTimeBirthDate.Value = DateTime.Parse(selectedRow.Cells["BirthDate"].Value.ToString());
                dateTimeMembershipStart.Value = DateTime.Parse(selectedRow.Cells["MembershipStartDate"].Value.ToString());
                
            }
        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var membersToErase = from m in context.Members where m.Id == selectedId select m;
                foreach (var memberToErase in membersToErase)
                {
                    var borrowsToErase = from br in context.Borrows where br.MemberId == memberToErase.Id select br;
                    foreach (var br in borrowsToErase)
                    {
                        context.Borrows.DeleteOnSubmit(br);
                    }
                    context.Members.DeleteOnSubmit(memberToErase);
                }
                MessageBox.Show("Okuyucu Başarıyla Silindi");
                context.SubmitChanges();
                gridMemberFill();
                textClear();
            }
            else
            {
                MessageBox.Show("Lütfen Silinmek Üzere Bir Okuyucu Seçin!");
            }
        }

        private void buttonEditMember_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var memberToUpdates = from m in context.Members where m.Id == selectedId select m;
                foreach (Member memberToUpdate in memberToUpdates)
                {
                    memberToUpdate.SSN = textSSN.Text;
                    memberToUpdate.NameSurname = textNameSurname.Text;
                    memberToUpdate.EMail = textEMail.Text;
                    memberToUpdate.BirthPlace = textBirthPlace.Text;
                    memberToUpdate.BirthDate = dateTimeBirthDate.Value;
                    memberToUpdate.Adress = textAddress.Text;
                    memberToUpdate.MembershipStartDate = dateTimeMembershipStart.Value;
                }
                MessageBox.Show("Okuyucu Başarıyla Düzenlendi");
                context.SubmitChanges();
                gridMemberFill();
                textClear();
            }
            else
            {
                MessageBox.Show("Lütfen Düzenlemek Üzere Bir Okuyucu Seçin!");
            }
        }
    }
}
