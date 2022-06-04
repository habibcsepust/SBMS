namespace SBMS
{
    partial class SalesModuleReportUI
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
            this.showButton = new System.Windows.Forms.Button();
            this.endDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.salesReportDataGridView = new System.Windows.Forms.DataGridView();
            this.sLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(713, 116);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 19;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // endDateTimePicker2
            // 
            this.endDateTimePicker2.Location = new System.Drawing.Point(401, 37);
            this.endDateTimePicker2.Name = "endDateTimePicker2";
            this.endDateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker2.TabIndex = 17;
            // 
            // startDateTimePicker1
            // 
            this.startDateTimePicker1.Location = new System.Drawing.Point(114, 37);
            this.startDateTimePicker1.Name = "startDateTimePicker1";
            this.startDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker1.TabIndex = 18;
            // 
            // salesReportDataGridView
            // 
            this.salesReportDataGridView.AutoGenerateColumns = false;
            this.salesReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sLDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.soldQtyDataGridViewTextBoxColumn,
            this.mRPDataGridViewTextBoxColumn,
            this.totalMRPDataGridViewTextBoxColumn,
            this.cPDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn});
            this.salesReportDataGridView.DataSource = this.salesViewBindingSource;
            this.salesReportDataGridView.Location = new System.Drawing.Point(12, 145);
            this.salesReportDataGridView.Name = "salesReportDataGridView";
            this.salesReportDataGridView.Size = new System.Drawing.Size(776, 206);
            this.salesReportDataGridView.TabIndex = 16;
            // 
            // sLDataGridViewTextBoxColumn
            // 
            this.sLDataGridViewTextBoxColumn.DataPropertyName = "SL";
            this.sLDataGridViewTextBoxColumn.HeaderText = "SL";
            this.sLDataGridViewTextBoxColumn.Name = "sLDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // soldQtyDataGridViewTextBoxColumn
            // 
            this.soldQtyDataGridViewTextBoxColumn.DataPropertyName = "SoldQty";
            this.soldQtyDataGridViewTextBoxColumn.HeaderText = "SoldQty";
            this.soldQtyDataGridViewTextBoxColumn.Name = "soldQtyDataGridViewTextBoxColumn";
            // 
            // mRPDataGridViewTextBoxColumn
            // 
            this.mRPDataGridViewTextBoxColumn.DataPropertyName = "MRP";
            this.mRPDataGridViewTextBoxColumn.HeaderText = "MRP";
            this.mRPDataGridViewTextBoxColumn.Name = "mRPDataGridViewTextBoxColumn";
            // 
            // totalMRPDataGridViewTextBoxColumn
            // 
            this.totalMRPDataGridViewTextBoxColumn.DataPropertyName = "TotalMRP";
            this.totalMRPDataGridViewTextBoxColumn.HeaderText = "TotalMRP";
            this.totalMRPDataGridViewTextBoxColumn.Name = "totalMRPDataGridViewTextBoxColumn";
            // 
            // cPDataGridViewTextBoxColumn
            // 
            this.cPDataGridViewTextBoxColumn.DataPropertyName = "CP";
            this.cPDataGridViewTextBoxColumn.HeaderText = "CP";
            this.cPDataGridViewTextBoxColumn.Name = "cPDataGridViewTextBoxColumn";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "Profit";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            // 
            // salesViewBindingSource
            // 
            this.salesViewBindingSource.DataSource = typeof(SBMS.ViewModel.SalesView);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(618, 34);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Start Date";
            // 
            // SalesModuleReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.endDateTimePicker2);
            this.Controls.Add(this.startDateTimePicker1);
            this.Controls.Add(this.salesReportDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalesModuleReportUI";
            this.Text = "SalesModuleReportUI";
            this.Load += new System.EventHandler(this.SalesModuleReportUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DateTimePicker endDateTimePicker2;
        private System.Windows.Forms.DateTimePicker startDateTimePicker1;
        private System.Windows.Forms.DataGridView salesReportDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salesViewBindingSource;
    }
}