
namespace SupplementManagement
{
    partial class GoodReceive
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
            this.listViewLastBill = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.selectTypeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.choosePaymentBox = new System.Windows.Forms.ComboBox();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.selectItemBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPayTxt = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewLastBill
            // 
            this.listViewLastBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewLastBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLastBill.HideSelection = false;
            this.listViewLastBill.Location = new System.Drawing.Point(572, 111);
            this.listViewLastBill.Name = "listViewLastBill";
            this.listViewLastBill.Size = new System.Drawing.Size(487, 343);
            this.listViewLastBill.TabIndex = 13;
            this.listViewLastBill.UseCompatibleStateImageBehavior = false;
            this.listViewLastBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 236;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Inventory";
            this.columnHeader6.Width = 113;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Price";
            this.columnHeader7.Width = 132;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewBill);
            this.panel2.Location = new System.Drawing.Point(19, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 343);
            this.panel2.TabIndex = 12;
            // 
            // listViewBill
            // 
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBill.FullRowSelect = true;
            this.listViewBill.HideSelection = false;
            this.listViewBill.LabelWrap = false;
            this.listViewBill.Location = new System.Drawing.Point(0, 0);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(544, 343);
            this.listViewBill.TabIndex = 0;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            this.listViewBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 263;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 112;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.selectTypeBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.choosePaymentBox);
            this.panel4.Controls.Add(this.quantityBox);
            this.panel4.Controls.Add(this.btnAddItem);
            this.panel4.Controls.Add(this.selectItemBox);
            this.panel4.Location = new System.Drawing.Point(19, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1040, 94);
            this.panel4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Item:";
            // 
            // selectTypeBox
            // 
            this.selectTypeBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTypeBox.FormattingEnabled = true;
            this.selectTypeBox.Location = new System.Drawing.Point(78, 7);
            this.selectTypeBox.Name = "selectTypeBox";
            this.selectTypeBox.Size = new System.Drawing.Size(356, 30);
            this.selectTypeBox.TabIndex = 0;
            this.selectTypeBox.SelectedIndexChanged += new System.EventHandler(this.selectTypeBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pay as :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity :";
            // 
            // choosePaymentBox
            // 
            this.choosePaymentBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePaymentBox.FormattingEnabled = true;
            this.choosePaymentBox.Items.AddRange(new object[] {
            "Cashes",
            "Credit Cards",
            "MoMo"});
            this.choosePaymentBox.Location = new System.Drawing.Point(702, 8);
            this.choosePaymentBox.Name = "choosePaymentBox";
            this.choosePaymentBox.Size = new System.Drawing.Size(174, 30);
            this.choosePaymentBox.TabIndex = 4;
            this.choosePaymentBox.Text = "Cashes";
            // 
            // quantityBox
            // 
            this.quantityBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.Location = new System.Drawing.Point(702, 48);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(174, 30);
            this.quantityBox.TabIndex = 3;
            this.quantityBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(896, 7);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(141, 69);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // selectItemBox
            // 
            this.selectItemBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectItemBox.FormattingEnabled = true;
            this.selectItemBox.Location = new System.Drawing.Point(78, 47);
            this.selectItemBox.Name = "selectItemBox";
            this.selectItemBox.Size = new System.Drawing.Size(356, 30);
            this.selectItemBox.TabIndex = 1;
            this.selectItemBox.SelectedIndexChanged += new System.EventHandler(this.selectItemBox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.clearBtn);
            this.panel3.Controls.Add(this.btnDeleteItem);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.totalPayTxt);
            this.panel3.Controls.Add(this.btnCheckIn);
            this.panel3.Location = new System.Drawing.Point(19, 460);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 99);
            this.panel3.TabIndex = 10;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(613, 23);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(110, 60);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(497, 23);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(110, 60);
            this.btnDeleteItem.TabIndex = 7;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Pay";
            // 
            // totalPayTxt
            // 
            this.totalPayTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalPayTxt.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayTxt.ForeColor = System.Drawing.Color.Red;
            this.totalPayTxt.Location = new System.Drawing.Point(8, 44);
            this.totalPayTxt.Name = "totalPayTxt";
            this.totalPayTxt.ReadOnly = true;
            this.totalPayTxt.Size = new System.Drawing.Size(254, 39);
            this.totalPayTxt.TabIndex = 5;
            this.totalPayTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCheckIn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(864, 12);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(160, 81);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 27);
            this.label6.TabIndex = 21;
            this.label6.Text = "VNĐ";
            // 
            // GoodReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 572);
            this.Controls.Add(this.listViewLastBill);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "GoodReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoodReceive";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewLastBill;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox choosePaymentBox;
        private System.Windows.Forms.NumericUpDown quantityBox;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox selectItemBox;
        private System.Windows.Forms.ComboBox selectTypeBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalPayTxt;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label6;
    }
}