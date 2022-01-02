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
using Type = SupplementManagement.DTO.Type;

namespace SupplementManagement
{
    public partial class GoodDelivery : Form
    {
        private static long currentBillID;
        private string username;
        public GoodDelivery(string username)
        {
            this.username = username;
            InitializeComponent();
            loadWaitingOrder();
            username2.Text = "Username: "+username.ToUpperInvariant();
        }

        private void loadWaitingOrder()
        {
            listViewBill.Items.Clear();
            List<GoodExport> list = GoodExportDAO.Instance.getWaitingOrders();
            foreach(GoodExport item in list){
                ListViewItem viewItem = new ListViewItem(item.ID.ToString());
                viewItem.SubItems.Add(item.CID.ToString());
                viewItem.SubItems.Add(item.PaymentType.ToString());
                viewItem.SubItems.Add(item.StatusPayment.ToString());
                viewItem.SubItems.Add(item.StatusDelivery.ToString());
                viewItem.SubItems.Add(item.ExportDate.ToString());
                listViewBill.Items.Add(viewItem);
            }
        }

        private void loadDetailExport(long id)
        {
            listViewDetail.Items.Clear();
            float total = 0;
            List<DetailReceipt> list = GoodExportDAO.Instance.GetDetailExport(id);
            foreach(DetailReceipt item in list)
            {
                ListViewItem viewItem = new ListViewItem(item.Name.ToString());
                viewItem.SubItems.Add(item.Unit.ToString());
                viewItem.SubItems.Add(item.Price.ToString());
                viewItem.SubItems.Add(item.Quantity.ToString());
                viewItem.SubItems.Add(item.Inventory.ToString());
                viewItem.SubItems.Add(item.IntoMoney.ToString());
                viewItem.Tag = item.Pid.ToString();
                total += item.IntoMoney;
                listViewDetail.Items.Add(viewItem);
            }
            totalPayTxt.Text = total.ToString("C").Substring(1);
        }

        private void loadCustomerInformation(long id)
        {
            Customer cus = CustomerDAO.Instance.getCustomerById(id);
          
            customerTextBox.Text = cus.Name;
            phoneTextBox.Text = cus.Phone;
            addressTextBox.Text = cus.Address;           
        }


        


        private void confirmImport()
        {
            GoodExportDAO.Instance.confirmExport(currentBillID);
            loadWaitingOrder();
            listViewDetail.Items.Clear();
        }

        private void destroyImport()
        {
            GoodExportDAO.Instance.cancelExport(currentBillID);
            loadWaitingOrder();
            listViewDetail.Items.Clear();
        }

        private void updateStorage()
        {

            foreach (ListViewItem i in listViewDetail.Items)
            {
                long id = Int64.Parse(i.Tag.ToString());
                int quantity = -Int16.Parse(i.SubItems[3].Text);
                ProductDAO.Instance.updateStorage(id, quantity);
            }
        }

        private void checkOut()
        {
            confirmImport();
            updateStorage();
        }







        // handle event:
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if(listViewBill.SelectedItems == null)
            {
                MessageBox.Show("Please choose order to check out.");
                return;
            }

            String bill = "The Receive detail is : \n";
            foreach (ListViewItem i in listViewDetail.Items)
            {

                bill += "+ " + i.SubItems[0].Text + ": " + "\t" + i.SubItems[3].Text + "\n";
            }
            // add totalPay at the end :
            bill += "Total to pay : " + totalPayTxt.Text;
            // add payment at the end : 
            //bill += "\n\nPayment : " + choosePaymentBox.Text;
            if (MessageBox.Show(bill + "\nDo you want continuous  ?", "Confirm Check In", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                checkOut();
            }
        }


        private void listViewBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBill.SelectedItems.Count > 0 )
            {
                ListViewItem item = listViewBill.SelectedItems[0];
                long id = Int64.Parse(item.SubItems[0].Text);
                long cid = Int64.Parse(item.SubItems[1].Text);
                loadCustomerInformation(cid);
                loadDetailExport(id);
                currentBillID = id;
                orderDateTxt.Text = "Order At:" +item.SubItems[5].Text;
            }
            else
            {
                customerTextBox.Clear();
                phoneTextBox.Clear();
                addressTextBox.Clear();
                orderDateTxt.Text = "Order At: ";
            }
        }

        private void destroyBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("\nDo you want destroy this Export Receipt  ?", "Confirm Destroy Receipt", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                destroyImport();
            }
        }
    }
}
