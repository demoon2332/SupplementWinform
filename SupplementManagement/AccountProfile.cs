using SupplementManagement.DAO;
using SupplementManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplementManagement
{
    public partial class AccountProfile : Form
    {
        private string username;
        public AccountProfile(string username)
        {
            this.username = username;
            InitializeComponent();
            loadInformation(username);
        }

        void loadInformation(string username)
        {
            Account acc = AccountDAO.Instance.GetAccountByUsername(username);
            if(acc==null)
            {
                MessageBox.Show("User is not existed.");
                return;
            }
            userNameTxt.Text = acc.Username;
            displayNameTxt.Text = acc.DisplayName;
            phoneTxt.Text = acc.Phone;
            dateBirthTxt.Text = acc.Birth;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string disName = displayNameTxt.Text;
            string phone = phoneTxt.Text;
            string birth = dateBirthTxt.Text;
            if (AccountDAO.Instance.updateAccount(username, disName, phone, birth))
            {
                MessageBox.Show("Update successfully.");
            }
            else
            {
                MessageBox.Show("Something went wrong, can't update this information.\nPlease try again.");
            }
        }

        private void resetPassBtn_Click(object sender, EventArgs e)
        {
            ResetPassword form = new ResetPassword(username);
            form.ShowDialog();
        }
    }
}
