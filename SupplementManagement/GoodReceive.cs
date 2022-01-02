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
    public partial class GoodReceive : Form
    {
        private string username;
        public GoodReceive(string username)
        {
            this.username = username;
            InitializeComponent();
            loadTypesList();
        }

        private void listViewLastBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GoodReceive_Load(object sender, EventArgs e)
        {

        }

        private void loadTypesList()
        {
            List<Type> list = TypeDAO.Instance.getAllTypesList();

            selectTypeBox.DataSource = list;
            selectTypeBox.DisplayMember = "Name";
        }

        private void loadItemsList(byte idType)
        {
            List<Product> list = ProductDAO.Instance.getAllItemsByType(idType);

            selectItemBox.DataSource = list;
            selectItemBox.DisplayMember = "Name";
        }

        private void loadProduct(long id)
        {
            if (listViewLastBill.Items.Count  > listViewBill.Items.Count)
            {
                int lastIndex = listViewLastBill.Items.Count - 1;
                listViewLastBill.Items.RemoveAt(lastIndex);
            }
                //listViewLastBill.Items.Clear();
                Product item = ProductDAO.Instance.GetProductById(id);
            ListViewItem viewItem = new ListViewItem(item.Name.ToString());
            viewItem.SubItems.Add(item.Inventory.ToString());
            viewItem.SubItems.Add(item.Price.ToString());
            viewItem.Tag = item.ID.ToString();
            listViewLastBill.Items.Add(viewItem);
           
        }

        void addProductToTable(long id)
        {
            Product item = ProductDAO.Instance.GetProductById(id);
            ListViewItem viewItem = new ListViewItem(item.Name.ToString());
            viewItem.SubItems.Add(quantityBox.Value.ToString());
            viewItem.SubItems.Add(item.Price.ToString());
            float sum = (int)quantityBox.Value * (float)item.Price;
            viewItem.SubItems.Add(sum.ToString());
            viewItem.Tag = item.ID.ToString();
            // tag --> use to add to ImportDetail 

            // get item's quantity in billTable if the item is already added to table 
            string itemName = selectItemBox.Text;
            int orderQuantity = Int16.Parse(quantityBox.Value.ToString());

            Product tempItem = ProductDAO.Instance.GetProductById(id);
            int quantityInStorage = tempItem.Inventory;
            foreach (ListViewItem i in listViewBill.Items)
            {
                if (i.SubItems[0].Text.ToString() == itemName)
                {


                    // can update quantity
                    i.SubItems[1].Text = (Int16.Parse(i.SubItems[1].Text.ToString()) + orderQuantity).ToString();
                    // after update quantity --> update totalPay
                    float itemPrice = (float)Convert.ToDouble(i.SubItems[2].Text.ToString());
                    //  extraPay is the money from new duplicate item to added ( price * quantity)
                    float extraPay = itemPrice * orderQuantity;
                    totalPayTxt.Text = ((float)Convert.ToDouble(totalPayTxt.Text.ToString()) + extraPay).ToString("C").Substring(1);
                    return;
                }
            }
            listViewBill.Items.Add(viewItem);


            float total = 0;
            if (totalPayTxt.Text.Length > 0)
            {
                total = (float)Convert.ToDouble(totalPayTxt.Text.ToString());
            }
            total += (float)Convert.ToDouble(item.Price * Int16.Parse(quantityBox.Value.ToString()));
            totalPayTxt.Text = total.ToString("C").Substring(1);
        }

        void clearBill()
        {
            listViewBill.Items.Clear();
            listViewLastBill.Items.Clear();
            quantityBox.Value = 1;
            choosePaymentBox.SelectedIndex = 0;
            totalPayTxt.Text = "";
        }

        private bool writeImport()
        {
            Account acc = AccountDAO.Instance.GetAccountByUsername(username);
            return GoodImportDAO.Instance.writeImport(acc.Id);
        }

        private bool writeImportDetail()
        {
            long idBill = GoodImportDAO.Instance.getIdOfLastestImport();
            foreach (ListViewItem item in listViewBill.Items)
            {
                if (item.Tag == null)
                {
                    MessageBox.Show("Invalid Product ID ( tag is null)");
                    return false;
                }
                int idItem = Int16.Parse(item.Tag.ToString());
                int quantity = Int16.Parse(item.SubItems[1].Text.ToString());
                if (quantity < 1)
                    return false;
                try
                {
                    GoodImportDAO.Instance.writeImportDetail(idBill, idItem, quantity);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: Something went wrong , we can't make this import detail.");
                    return false;
                }
            }
            return true;
        }
        private void updateStorage()
        {
            foreach(ListViewItem i in listViewBill.Items)
            {
                long id = Int64.Parse(i.Tag.ToString());
                int quantity = Int16.Parse(i.SubItems[1].Text);
                ProductDAO.Instance.updateStorage(id, quantity);
            }
        }

        private void checkIn()
        {
            if (writeImport())
            {
                if (writeImportDetail())
                {
                    updateStorage();
                    clearBill();
                    MessageBox.Show("Making Import Receipt Successfully.");
                }               
            }
            else
            {
                MessageBox.Show("Something went wrong , we can't make this import receipt.");

            }
        }



        // **** Handle event 

        // choose type event : 
        private void selectTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte id = 0;
            selectItemBox.Text = "";

            ComboBox box = sender as ComboBox;
            if (box.SelectedItem == null)
            {
                return;
            }
            Type selected = box.SelectedItem as Type;
            if (selected == null)
            {
                return;
            }
            id = selected.ID;
            loadItemsList(id);
        }


        //choose item event:
        private void selectItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            long id = 0;
            ComboBox box = sender as ComboBox;
            if (box.SelectedItem == null)
            {
                return;
            }
            Product selected = box.SelectedItem as Product;
            if (selected == null)
            {
                return;
            }
            id = selected.ID;
            btnAddItem.Tag = id.ToString();
            // load informatiom of product
            loadProduct(id);
        }


        // event when Click Add Btn
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int quantity = (int)quantityBox.Value;
            if (btnAddItem.Tag == null)
                return;
            //Item item = ItemDAO.Instance.GetItemById(Int16.Parse(btnAddItem.Tag.ToString()));
            addProductToTable(Int16.Parse(btnAddItem.Tag.ToString()));
            // reset quantity
            quantityBox.Value = 1;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listViewBill.SelectedItems.Count > 0 ? listViewBill.SelectedItems[0] : null;
            if (item != null)
            {

                DialogResult result = MessageBox.Show("Delete " + item.SubItems[0].Text + "?", "Are you sure to remove this product ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    float newTotalPay = (float)Convert.ToDouble(totalPayTxt.Text.ToString());
                    int quantity = Int16.Parse(listViewBill.SelectedItems[0].SubItems[1].Text.ToString());
                    float price = (float)Convert.ToDouble(listViewBill.SelectedItems[0].SubItems[2].Text.ToString());
                    newTotalPay = newTotalPay - price * quantity;
                    totalPayTxt.Text = newTotalPay.ToString();
                    listViewLastBill.Items.RemoveAt(listViewBill.SelectedItems[0].Index);
                    listViewBill.Items.Remove(listViewBill.SelectedItems[0]);
                    
                    
                }
                else
                {
                    return;
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear the Bill ?", "Confirm Clear Bill", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                clearBill();
            }
            else
            {
                return;
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            String bill = "Your Receive detail is : \n";
            foreach (ListViewItem i in listViewBill.Items)
            {
                int itemId = Int16.Parse(i.Tag.ToString());
                int itemQuantity = Int16.Parse(i.SubItems[1].Text);
                bill +="+ "+ i.SubItems[0].Text + ": " + "\t" + i.SubItems[1].Text + "\n";
            }
            // add totalPay at the end :
            bill += "Total to pay : " + totalPayTxt.Text+" VNĐ";
            // add payment at the end : 
            bill += "\n\nPayment : " + choosePaymentBox.Text;
            if (MessageBox.Show(bill + "\nDo you want continuous  ?", "Confirm Check In", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                checkIn();
            }
        }


    }
}
