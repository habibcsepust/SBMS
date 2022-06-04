namespace SBMS
{
    partial class OrderUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.cpTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.aQuantityTextBox = new System.Windows.Forms.TextBox();
            this.reorderTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.orderDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deliveryDateTimePicker2);
            this.groupBox1.Controls.Add(this.orderDateTimePicker1);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.statusTextBox);
            this.groupBox1.Controls.Add(this.reorderTextBox);
            this.groupBox1.Controls.Add(this.aQuantityTextBox);
            this.groupBox1.Controls.Add(this.productComboBox);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(90, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.totalPriceTextBox);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.remarksTextBox);
            this.groupBox2.Controls.Add(this.cpTextBox);
            this.groupBox2.Controls.Add(this.supplierComboBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(90, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Location = new System.Drawing.Point(90, 328);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.Size = new System.Drawing.Size(821, 158);
            this.orderDataGridView.TabIndex = 2;
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Location = new System.Drawing.Point(835, 493);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 32);
            this.orderButton.TabIndex = 3;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Order Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Available Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(408, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Reorder Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(408, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(408, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Delivery Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Supplier";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Last CP(TK)";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Remarks";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(418, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Quantity";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(418, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total Price(TK)";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(136, 12);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(225, 24);
            this.categoryComboBox.TabIndex = 1;
            // 
            // productComboBox
            // 
            this.productComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(136, 39);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(225, 24);
            this.productComboBox.TabIndex = 1;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(104, 19);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(225, 24);
            this.supplierComboBox.TabIndex = 1;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.Location = new System.Drawing.Point(136, 69);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(225, 23);
            this.codeTextBox.TabIndex = 2;
            // 
            // cpTextBox
            // 
            this.cpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpTextBox.Location = new System.Drawing.Point(104, 55);
            this.cpTextBox.Name = "cpTextBox";
            this.cpTextBox.Size = new System.Drawing.Size(225, 23);
            this.cpTextBox.TabIndex = 2;
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarksTextBox.Location = new System.Drawing.Point(104, 84);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(660, 38);
            this.remarksTextBox.TabIndex = 2;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(539, 24);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(225, 23);
            this.quantityTextBox.TabIndex = 2;
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTextBox.Location = new System.Drawing.Point(539, 55);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(225, 23);
            this.totalPriceTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(689, 128);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 28);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // aQuantityTextBox
            // 
            this.aQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aQuantityTextBox.Location = new System.Drawing.Point(573, 19);
            this.aQuantityTextBox.Name = "aQuantityTextBox";
            this.aQuantityTextBox.Size = new System.Drawing.Size(225, 23);
            this.aQuantityTextBox.TabIndex = 2;
            // 
            // reorderTextBox
            // 
            this.reorderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderTextBox.Location = new System.Drawing.Point(573, 42);
            this.reorderTextBox.Name = "reorderTextBox";
            this.reorderTextBox.Size = new System.Drawing.Size(225, 23);
            this.reorderTextBox.TabIndex = 2;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextBox.Location = new System.Drawing.Point(573, 70);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(225, 23);
            this.statusTextBox.TabIndex = 2;
            // 
            // orderDateTimePicker1
            // 
            this.orderDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateTimePicker1.Location = new System.Drawing.Point(136, 97);
            this.orderDateTimePicker1.Name = "orderDateTimePicker1";
            this.orderDateTimePicker1.Size = new System.Drawing.Size(225, 23);
            this.orderDateTimePicker1.TabIndex = 3;
            // 
            // deliveryDateTimePicker2
            // 
            this.deliveryDateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryDateTimePicker2.Location = new System.Drawing.Point(573, 96);
            this.deliveryDateTimePicker2.Name = "deliveryDateTimePicker2";
            this.deliveryDateTimePicker2.Size = new System.Drawing.Size(225, 23);
            this.deliveryDateTimePicker2.TabIndex = 4;
            // 
            // OrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderUI";
            this.Text = "OrderUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.TextBox cpTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker deliveryDateTimePicker2;
        private System.Windows.Forms.DateTimePicker orderDateTimePicker1;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox reorderTextBox;
        private System.Windows.Forms.TextBox aQuantityTextBox;
    }
}