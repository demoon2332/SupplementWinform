using SupplementManagement.DAO;
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
    public partial class ResetPassword : Form
    {
        private string username;
        public ResetPassword(string username)
        {
            this.username = username;
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (this.newPassTxt.Text.ToString() != confirmPassTxt.Text.ToString())
            {
                MessageBox.Show("Password and confirm passowrd are unmatch !");
                return;
            }
            string newPass = Hash.Hash_SHA1(newPassTxt.Text.ToString());
            if (AccountDAO.Instance.resetPassword(username, newPass))
            {
                MessageBox.Show("Reset Password successfully.");
            }
            else
                MessageBox.Show("Reset Password fail.");
        }
    }
}
