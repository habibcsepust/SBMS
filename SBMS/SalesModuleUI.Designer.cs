namespace SBMS
{
    partial class SalesModuleUI
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
            this.searchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.payableAmountTextBox = new System.Windows.Forms.TextBox();
            this.discountAmountTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.grandTotalTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.salesViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.totalMRPTextBox = new System.Windows.Forms.TextBox();
            this.MRPTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.aQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.supplierPurchaseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.stockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loyaltyPointTextBox = new System.Windows.Forms.TextBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesViewBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierPurchaseDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchDateTimePicker
            // 
            this.searchDateTimePicker.Location = new System.Drawing.Point(814, 36);
            this.searchDateTimePicker.Name = "searchDateTimePicker";
            this.searchDateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.searchDateTimePicker.TabIndex = 11;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(976, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(61, 23);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(814, 10);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(156, 20);
            this.searchTextBox.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteButton);
            this.groupBox3.Controls.Add(this.submitButton);
            this.groupBox3.Controls.Add(this.salesDataGridView);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.payableAmountTextBox);
            this.groupBox3.Controls.Add(this.discountAmountTextBox);
            this.groupBox3.Controls.Add(this.discountTextBox);
            this.groupBox3.Controls.Add(this.grandTotalTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(449, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 451);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Details";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(396, 227);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(192, 39);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete Selected Item";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(375, 415);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 30);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Location = new System.Drawing.Point(6, 20);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.Size = new System.Drawing.Size(582, 201);
            this.salesDataGridView.TabIndex = 0;
            this.salesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataGridView_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Payable Amount(TK)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Discount Amount(TK)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Discount(%)";
            // 
            // payableAmountTextBox
            // 
            this.payableAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payableAmountTextBox.Location = new System.Drawing.Point(235, 389);
            this.payableAmountTextBox.Name = "payableAmountTextBox";
            this.payableAmountTextBox.Size = new System.Drawing.Size(215, 23);
            this.payableAmountTextBox.TabIndex = 2;
            // 
            // discountAmountTextBox
            // 
            this.discountAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountAmountTextBox.Location = new System.Drawing.Point(235, 347);
            this.discountAmountTextBox.Name = "discountAmountTextBox";
            this.discountAmountTextBox.Size = new System.Drawing.Size(215, 23);
            this.discountAmountTextBox.TabIndex = 2;
            // 
            // discountTextBox
            // 
            this.discountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextBox.Location = new System.Drawing.Point(235, 308);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(215, 23);
            this.discountTextBox.TabIndex = 2;
            // 
            // grandTotalTextBox
            // 
            this.grandTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalTextBox.Location = new System.Drawing.Point(235, 273);
            this.grandTotalTextBox.Name = "grandTotalTextBox";
            this.grandTotalTextBox.Size = new System.Drawing.Size(215, 23);
            this.grandTotalTextBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Grand Total(TK)";
            // 
            // salesViewBindingSource1
            // 
            this.salesViewBindingSource1.DataSource = typeof(SBMS.ViewModel.SalesView);
            // 
            // salesViewBindingSource
            // 
            this.salesViewBindingSource.DataSource = typeof(SBMS.ViewModel.SalesView);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.totalMRPTextBox);
            this.groupBox2.Controls.Add(this.MRPTextBox);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.aQuantityTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.productComboBox);
            this.groupBox2.Controls.Add(this.categoryComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Category);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(-5, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 336);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(299, 221);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 33);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total MRP(TK)";
            // 
            // totalMRPTextBox
            // 
            this.totalMRPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMRPTextBox.Location = new System.Drawing.Point(159, 195);
            this.totalMRPTextBox.Name = "totalMRPTextBox";
            this.totalMRPTextBox.Size = new System.Drawing.Size(215, 23);
            this.totalMRPTextBox.TabIndex = 2;
            // 
            // MRPTextBox
            // 
            this.MRPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRPTextBox.Location = new System.Drawing.Point(159, 167);
            this.MRPTextBox.Name = "MRPTextBox";
            this.MRPTextBox.Size = new System.Drawing.Size(215, 23);
            this.MRPTextBox.TabIndex = 2;
            this.MRPTextBox.TextChanged += new System.EventHandler(this.MRPTextBox_TextChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(159, 137);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(215, 23);
            this.quantityTextBox.TabIndex = 2;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // aQuantityTextBox
            // 
            this.aQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aQuantityTextBox.Location = new System.Drawing.Point(159, 102);
            this.aQuantityTextBox.Name = "aQuantityTextBox";
            this.aQuantityTextBox.Size = new System.Drawing.Size(215, 23);
            this.aQuantityTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "MRP(TK)";
            // 
            // productComboBox
            // 
            this.productComboBox.DataSource = this.supplierPurchaseDetailsBindingSource;
            this.productComboBox.DisplayMember = "Product";
            this.productComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(159, 62);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(215, 24);
            this.productComboBox.TabIndex = 1;
            this.productComboBox.ValueMember = "ProductId";
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            // 
            // supplierPurchaseDetailsBindingSource
            // 
            this.supplierPurchaseDetailsBindingSource.DataSource = typeof(SBMS.Model.SupplierPurchaseDetails);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(159, 32);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(215, 24);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Available Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Product";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(13, 32);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(73, 17);
            this.Category.TabIndex = 0;
            this.Category.Text = "Category";
            // 
            // stockBindingSource1
            // 
            this.stockBindingSource1.DataSource = typeof(SBMS.Model.Stock);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(SBMS.Model.Stock);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.loyaltyPointTextBox);
            this.groupBox1.Controls.Add(this.customerComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-5, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(141, 48);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(215, 26);
            this.dateTimePicker.TabIndex = 3;
            // 
            // loyaltyPointTextBox
            // 
            this.loyaltyPointTextBox.Enabled = false;
            this.loyaltyPointTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loyaltyPointTextBox.Location = new System.Drawing.Point(141, 85);
            this.loyaltyPointTextBox.Name = "loyaltyPointTextBox";
            this.loyaltyPointTextBox.Size = new System.Drawing.Size(215, 23);
            this.loyaltyPointTextBox.TabIndex = 2;
            this.loyaltyPointTextBox.Text = "0";
            // 
            // customerComboBox
            // 
            this.customerComboBox.DisplayMember = "Name";
            this.customerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(141, 17);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(215, 24);
            this.customerComboBox.TabIndex = 1;
            this.customerComboBox.ValueMember = "Id";
            this.customerComboBox.SelectedIndexChanged += new System.EventHandler(this.customerComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loyalty Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(SBMS.Model.Category);
            // 
            // SalesModuleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 525);
            this.Controls.Add(this.searchDateTimePicker);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesModuleUI";
            this.Text = "SalesModuleUI";
            this.Load += new System.EventHandler(this.SalesModuleUI_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesViewBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierPurchaseDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker searchDateTimePicker;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox payableAmountTextBox;
        private System.Windows.Forms.TextBox discountAmountTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox grandTotalTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalMRPTextBox;
        private System.Windows.Forms.TextBox MRPTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox aQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox loyaltyPointTextBox;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.BindingSource stockBindingSource1;
        private System.Windows.Forms.BindingSource salesViewBindingSource;
        private System.Windows.Forms.BindingSource salesViewBindingSource1;
        private System.Windows.Forms.BindingSource supplierPurchaseDetailsBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}