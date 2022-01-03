
namespace SupplementManagement
{
    partial class Management
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
            this.components = new System.ComponentModel.Container();
            this.usernameTxt = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodReceiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryingGoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ImportTable = new System.Windows.Forms.DataGridView();
            this.ExportTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.endDateTime = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.startDateTime = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalPay = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.detailListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchBtn = new System.Windows.Forms.Button();
            this.getLastestBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTxt
            // 
            this.usernameTxt.AutoSize = true;
            this.usernameTxt.Location = new System.Drawing.Point(653, 13);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(77, 17);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.Text = "Username:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.goodReceiveToolStripMenuItem,
            this.goodDeliveryToolStripMenuItem,
            this.deliveryingGoodToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1509, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.adminToolStripMenuItem.Text = "Statistic";
            // 
            // goodReceiveToolStripMenuItem
            // 
            this.goodReceiveToolStripMenuItem.Name = "goodReceiveToolStripMenuItem";
            this.goodReceiveToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.goodReceiveToolStripMenuItem.Text = "Good Receive";
            this.goodReceiveToolStripMenuItem.Click += new System.EventHandler(this.goodReceiveToolStripMenuItem_Click);
            // 
            // goodDeliveryToolStripMenuItem
            // 
            this.goodDeliveryToolStripMenuItem.Name = "goodDeliveryToolStripMenuItem";
            this.goodDeliveryToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.goodDeliveryToolStripMenuItem.Text = "Good Delivery";
            this.goodDeliveryToolStripMenuItem.Click += new System.EventHandler(this.goodDeliveryToolStripMenuItem_Click);
            // 
            // deliveryingGoodToolStripMenuItem
            // 
            this.deliveryingGoodToolStripMenuItem.Name = "deliveryingGoodToolStripMenuItem";
            this.deliveryingGoodToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.deliveryingGoodToolStripMenuItem.Text = "Current Deliveries";
            this.deliveryingGoodToolStripMenuItem.Click += new System.EventHandler(this.deliveryingGoodToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ImportTable);
            this.panel2.Controls.Add(this.ExportTable);
            this.panel2.Location = new System.Drawing.Point(0, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1509, 425);
            this.panel2.TabIndex = 3;
            // 
            // ImportTable
            // 
            this.ImportTable.AllowUserToAddRows = false;
            this.ImportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportTable.Location = new System.Drawing.Point(0, 0);
            this.ImportTable.Name = "ImportTable";
            this.ImportTable.RowHeadersWidth = 51;
            this.ImportTable.RowTemplate.Height = 24;
            this.ImportTable.Size = new System.Drawing.Size(635, 419);
            this.ImportTable.TabIndex = 3;
            this.ImportTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ImportTable_CellClick);
            // 
            // ExportTable
            // 
            this.ExportTable.AllowUserToAddRows = false;
            this.ExportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExportTable.Location = new System.Drawing.Point(641, 0);
            this.ExportTable.Name = "ExportTable";
            this.ExportTable.RowHeadersWidth = 51;
            this.ExportTable.RowTemplate.Height = 24;
            this.ExportTable.Size = new System.Drawing.Size(856, 422);
            this.ExportTable.TabIndex = 2;
            this.ExportTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExportTable_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.endDateTime);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 53);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "To:";
            // 
            // endDateTime
            // 
            this.endDateTime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTime.Location = new System.Drawing.Point(125, 10);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(394, 34);
            this.endDateTime.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.startDateTime);
            this.panel3.Location = new System.Drawing.Point(12, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 53);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // startDateTime
            // 
            this.startDateTime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTime.Location = new System.Drawing.Point(125, 12);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(394, 34);
            this.startDateTime.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.totalPay);
            this.panel4.Controls.Add(this.label);
            this.panel4.Location = new System.Drawing.Point(12, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 57);
            this.panel4.TabIndex = 7;
            // 
            // totalPay
            // 
            this.totalPay.Enabled = false;
            this.totalPay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPay.Location = new System.Drawing.Point(128, 12);
            this.totalPay.Name = "totalPay";
            this.totalPay.Size = new System.Drawing.Size(391, 34);
            this.totalPay.TabIndex = 1;
            this.totalPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Thanhoa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(4, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(118, 29);
            this.label.TabIndex = 0;
            this.label.Text = "Total Pay:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.detailListView);
            this.panel5.Location = new System.Drawing.Point(596, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(913, 247);
            this.panel5.TabIndex = 8;
            // 
            // detailListView
            // 
            this.detailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.detailListView.FullRowSelect = true;
            this.detailListView.HideSelection = false;
            this.detailListView.Location = new System.Drawing.Point(6, 11);
            this.detailListView.Name = "detailListView";
            this.detailListView.Size = new System.Drawing.Size(895, 225);
            this.detailListView.TabIndex = 1;
            this.detailListView.UseCompatibleStateImageBehavior = false;
            this.detailListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 57;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PID";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 223;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.Width = 93;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Quantity";
            this.columnHeader7.Width = 72;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Inventory";
            this.columnHeader8.Width = 91;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "IntoMoney";
            this.columnHeader9.Width = 136;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(12, 178);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(127, 48);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // getLastestBtn
            // 
            this.getLastestBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getLastestBtn.Location = new System.Drawing.Point(159, 179);
            this.getLastestBtn.Name = "getLastestBtn";
            this.getLastestBtn.Size = new System.Drawing.Size(162, 48);
            this.getLastestBtn.TabIndex = 10;
            this.getLastestBtn.Text = "Get Latest ";
            this.getLastestBtn.UseVisualStyleBackColor = true;
            this.getLastestBtn.Click += new System.EventHandler(this.getLastestBtn_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1509, 719);
            this.Controls.Add(this.getLastestBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.usernameTxt);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImportTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodReceiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodDeliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker endDateTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker startDateTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox totalPay;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ToolStripMenuItem deliveryingGoodToolStripMenuItem;
        private System.Windows.Forms.DataGridView ExportTable;
        private System.Windows.Forms.DataGridView ImportTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView detailListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button getLastestBtn;
    }
}

