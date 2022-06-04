namespace SBMS
{
    partial class StockModule
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.showButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "End Date";
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(148, 51);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(168, 20);
            this.productTextBox.TabIndex = 1;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(148, 101);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(168, 20);
            this.categoryTextBox.TabIndex = 1;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(480, 48);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.startDateTimePicker.TabIndex = 2;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(480, 101);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.endDateTimePicker.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(588, 127);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(91, 202);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(572, 150);
            this.showDataGridView.TabIndex = 5;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(589, 173);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // StockModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockModule";
            this.Text = "StockModule";
            this.Load += new System.EventHandler(this.StockModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Button showButton;
    }
}