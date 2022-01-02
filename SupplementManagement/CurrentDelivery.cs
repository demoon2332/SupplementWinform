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
    public partial class CurrentDelivery : Form
    {
        private static long currentBillID;
        private static string username;
        public CurrentDelivery(string name)
        {
            username = name;
            InitializeComponent();
            usernameTxt.Text += " "+username;
            loadShippingOrder();
        }

        private void loadShippingOrder()
        {
            listViewBill.Items.Clear();
            List<GoodExport> list = GoodExportDAO.Instance.getShippingOrders();
            foreach (GoodExport item in list)
            {
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
            foreach (DetailReceipt item in list)
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


        private void doneDelivery()
        {
            GoodExportDAO.Instance.doneExport(username,currentBillID);
            loadShippingOrder();
            listViewDetail.Items.Clear();
        }

        private void cancelDelivery()
        {
            GoodExportDAO.Instance.cancelExport(username,currentBillID);
            loadShippingOrder();
            listViewDetail.Items.Clear();
        }

        private void checkOut()
        {
            doneDelivery();
        }







        // handle event:
        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (listViewBill.SelectedItems == null)
            {
                MessageBox.Show("Please choose order to check out.");
                return;
            }

            String bill = "This Receive detail is : \n";
            foreach (ListViewItem i in listViewDetail.Items)
            {

                bill += "+ " + i.SubItems[0].Text + ": " + "\t" + i.SubItems[3].Text + "\n";
            }
            // add totalPay at the end :
            bill += "Total to pay : " + totalPayTxt.Text;
            // add payment at the end : 
            //bill += "\n\nPayment : " + choosePaymentBox.Text;
            if (MessageBox.Show(bill + "\nHave this Delivery been doned ?", "Confirm Finish Deliverying", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                checkOut();
            }
        }


        private void listViewBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBill.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewBill.SelectedItems[0];
                long id = Int64.Parse(item.SubItems[0].Text);
                long cid = Int64.Parse(item.SubItems[1].Text);
                loadCustomerInformation(cid);
                loadDetailExport(id);
                currentBillID = id;
                orderDateTxt.Text = "Order At:" + item.SubItems[5].Text;
            }
            else
            {
                customerTextBox.Clear();
                phoneTextBox.Clear();
                addressTextBox.Clear();
                orderDateTxt.Text = "Order At: ";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("\nDo you want cancel this Delivery Receipt  ?\n You should call the deliverer first.", "Cancel Deliverying", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                cancelDelivery();
            }
        }
    }

}
