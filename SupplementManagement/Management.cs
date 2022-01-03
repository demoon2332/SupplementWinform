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
    public partial class Management : Form
    {
        private string username;
        public Management(string username)
        {
            this.username = username;
            InitializeComponent();

            Account currentAcc = AccountDAO.Instance.GetAccountByUsername(username);
            if(currentAcc == null)
            {
                MessageBox.Show("Can't find users");
                return;
            }
            usernameTxt.Text += " " + currentAcc.Username.ToString();
            usernameStatistic.Text += " " + currentAcc.Username.ToString();
            loadImportTable();
            loadExportTable();
        }


        // Event for Menu Tabs
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile f = new AccountProfile(username);
            f.ShowDialog();
        }

        private void goodReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodReceive f = new GoodReceive(username);
            f.ShowDialog();
        }

        private void goodDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodDelivery f = new GoodDelivery(username);
            f.ShowDialog();
        }
        private void deliveryingGoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentDelivery f = new CurrentDelivery(username);
            f.ShowDialog();
        }




        // Statistic Tabs 
        public void loadImportTable()
        {
            String query = "Exec getImportStatistic";
            ImportTable.DataSource = DataProvider.Instance.ExecuteQuery(query);
            //ImportTable.AutoResizeColumns();
        }
        public void loadExportTable()
        {
            String query = "Exec getExportStatistic";
            ExportTable.DataSource = DataProvider.Instance.ExecuteQuery(query);
            ExportTable.AutoResizeColumns();
        }

        private void ImportTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= ImportTable.RowCount)
            {
                return;
            }
            DataGridViewRow row = ImportTable.Rows[index];
            long id = (long)row.Cells[0].Value;
            loadDetail(id, "import");
        }


        public void loadDetail(long id,string typeDetail)
        {
            detailListView.Items.Clear();
            totalPay.Text = "";

          
            if (typeDetail == "import")
            {
                List<DetailReceipt> list = GoodImportDAO.Instance.GetDetailImport(id);
                float total = 0;
                foreach (DetailReceipt item in list)
                {
                    ListViewItem viewItem = new ListViewItem(id.ToString());
                    viewItem.SubItems.Add(item.Pid.ToString());
                    viewItem.SubItems.Add(item.Name.ToString());
                    viewItem.SubItems.Add(item.Unit.ToString());
                    viewItem.SubItems.Add(item.Price.ToString());
                    viewItem.SubItems.Add(item.Type.ToString());
                    viewItem.SubItems.Add(item.Quantity.ToString());
                    viewItem.SubItems.Add(item.Inventory.ToString());
                    viewItem.SubItems.Add(item.IntoMoney.ToString());
                    detailListView.Items.Add(viewItem);
                    total += item.IntoMoney;
                }
                totalPay.Text = total.ToString() + " VNĐ";
                
            }
            else if(typeDetail == "export")
            {
                List<DetailReceipt> list = GoodExportDAO.Instance.GetDetailExport(id);
                float total = 0;
                foreach (DetailReceipt item in list)
                {
                    ListViewItem viewItem = new ListViewItem(id.ToString());
                    viewItem.SubItems.Add(item.Pid.ToString());
                    viewItem.SubItems.Add(item.Name.ToString());
                    viewItem.SubItems.Add(item.Unit.ToString());
                    viewItem.SubItems.Add(item.Price.ToString());
                    viewItem.SubItems.Add(item.Type.ToString());
                    viewItem.SubItems.Add(item.Quantity.ToString());
                    viewItem.SubItems.Add(item.Inventory.ToString());
                    viewItem.SubItems.Add(item.IntoMoney.ToString());
                    detailListView.Items.Add(viewItem);
                    total += item.IntoMoney;
                }
                totalPay.Text = total.ToString() + " VNĐ";
            }
        }

        private void ExportTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0 || index >= ExportTable.RowCount)
            {
                return;
            }
            DataGridViewRow row = ExportTable.Rows[index];
            long id = (long)row.Cells[0].Value;
            loadDetail(id, "export");
        }


        // button event :

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string start = startDateTime.Value.ToString("MM/dd/yyyy");
            string end = endDateTime.Value.ToString("MM/dd/yyyy");
            MessageBox.Show("Start:" + start + "\nEnd:" + end);

            String query = "Exec getExportStatisticByDate @start ,  @end ";
            ExportTable.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { start, end });

            query = "Exec getImportStatisticByDate @start ,  @end ";
            ImportTable.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { start, end }); ;
        }

        private void getLastestBtn_Click(object sender, EventArgs e)
        {
            loadExportTable();
            loadImportTable();
        }

    }
}