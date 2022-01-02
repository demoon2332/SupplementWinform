
namespace SupplementManagement
{
    partial class CurrentDelivery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewBill = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDetail = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.orderDateTxt = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPayTxt = new System.Windows.Forms.TextBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.usernameTxt = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBill
            // 
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader12});
            this.listViewBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBill.FullRowSelect = true;
            this.listViewBill.HideSelection = false;
            this.listViewBill.LabelWrap = false;
            this.listViewBill.Location = new System.Drawing.Point(1, 79);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(668, 346);
            this.listViewBill.TabIndex = 2;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            this.listViewBill.View = System.Windows.Forms.View.Details;
            this.listViewBill.SelectedIndexChanged += new System.EventHandler(this.listViewBill_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 46;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Customer\'s ID";
            this.columnHeader6.Width = 124;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Payment";
            this.columnHeader7.Width = 106;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "statusPayment";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Delivery";
            this.columnHeader9.Width = 111;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "OrderAt";
            this.columnHeader12.Width = 145;
            // 
            // listViewDetail
            // 
            this.listViewDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewDetail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDetail.FullRowSelect = true;
            this.listViewDetail.HideSelection = false;
            this.listViewDetail.LabelWrap = false;
            this.listViewDetail.Location = new System.Drawing.Point(675, 79);
            this.listViewDetail.Name = "listViewDetail";
            this.listViewDetail.Size = new System.Drawing.Size(644, 346);
            this.listViewDetail.TabIndex = 3;
            this.listViewDetail.UseCompatibleStateImageBehavior = false;
            this.listViewDetail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unit";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Inventory";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "IntoMoney";
            this.columnHeader11.Width = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Deliverying:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detail Receipt:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.customerTextBox);
            this.panel3.Controls.Add(this.orderDateTxt);
            this.panel3.Controls.Add(this.cancelBtn);
            this.panel3.Controls.Add(this.addressTextBox);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.phoneTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.totalPayTxt);
            this.panel3.Controls.Add(this.doneBtn);
            this.panel3.Location = new System.Drawing.Point(1, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1286, 226);
            this.panel3.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "VNĐ";
            // 
            // customerTextBox
            // 
            this.customerTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.customerTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextBox.ForeColor = System.Drawing.Color.Black;
            this.customerTextBox.Location = new System.Drawing.Point(120, 7);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.ReadOnly = true;
            this.customerTextBox.Size = new System.Drawing.Size(315, 39);
            this.customerTextBox.TabIndex = 19;
            this.customerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // orderDateTxt
            // 
            this.orderDateTxt.AutoSize = true;
            this.orderDateTxt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateTxt.Location = new System.Drawing.Point(481, 185);
            this.orderDateTxt.Name = "orderDateTxt";
            this.orderDateTxt.Size = new System.Drawing.Size(103, 27);
            this.orderDateTxt.TabIndex = 18;
            this.orderDateTxt.Text = "Order At:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.cancelBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cancelBtn.Location = new System.Drawing.Point(907, 135);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(160, 81);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.addressTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressTextBox.Location = new System.Drawing.Point(120, 63);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(315, 39);
            this.addressTextBox.TabIndex = 15;
            this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 27);
            this.label11.TabIndex = 14;
            this.label11.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Customer:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.phoneTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.ForeColor = System.Drawing.Color.Black;
            this.phoneTextBox.Location = new System.Drawing.Point(566, 12);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(319, 39);
            this.phoneTextBox.TabIndex = 9;
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Pay";
            // 
            // totalPayTxt
            // 
            this.totalPayTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalPayTxt.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayTxt.ForeColor = System.Drawing.Color.Red;
            this.totalPayTxt.Location = new System.Drawing.Point(8, 177);
            this.totalPayTxt.Name = "totalPayTxt";
            this.totalPayTxt.ReadOnly = true;
            this.totalPayTxt.Size = new System.Drawing.Size(361, 39);
            this.totalPayTxt.TabIndex = 5;
            this.totalPayTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(249)))), ((int)(((byte)(59)))));
            this.doneBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(173)))), ((int)(((byte)(43)))));
            this.doneBtn.Location = new System.Drawing.Point(1079, 135);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(160, 81);
            this.doneBtn.TabIndex = 3;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.AutoSize = true;
            this.usernameTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(924, 9);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(94, 22);
            this.usernameTxt.TabIndex = 22;
            this.usernameTxt.Text = "Username:";
            // 
            // CurrentDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1327, 655);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewDetail);
            this.Controls.Add(this.listViewBill);
            this.Name = "CurrentDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrentDelivery";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView listViewDetail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Label orderDateTxt;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalPayTxt;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label usernameTxt;
    }
}