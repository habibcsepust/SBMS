namespace SBMS
{
    partial class PurchaseReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.purchaseReportDataGridView = new System.Windows.Forms.DataGridView();
            this.startDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.showButton = new System.Windows.Forms.Button();
            this.salesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseModuleViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseModuleViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "End Date";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(605, 44);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // purchaseReportDataGridView
            // 
            this.purchaseReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseReportDataGridView.Location = new System.Drawing.Point(43, 171);
            this.purchaseReportDataGridView.Name = "purchaseReportDataGridView";
            this.purchaseReportDataGridView.Size = new System.Drawing.Size(842, 194);
            this.purchaseReportDataGridView.TabIndex = 3;
            this.purchaseReportDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseReportDataGridView_CellContentClick);
            // 
            // startDateTimePicker1
            // 
            this.startDateTimePicker1.Location = new System.Drawing.Point(101, 47);
            this.startDateTimePicker1.Name = "startDateTimePicker1";
            this.startDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker1.TabIndex = 4;
            // 
            // endDateTimePicker2
            // 
            this.endDateTimePicker2.Location = new System.Drawing.Point(388, 47);
            this.endDateTimePicker2.Name = "endDateTimePicker2";
            this.endDateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker2.TabIndex = 4;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(605, 82);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // salesViewBindingSource
            // 
            this.salesViewBindingSource.DataSource = typeof(SBMS.ViewModel.SalesView);
            // 
            // purchaseModuleViewBindingSource
            // 
            this.purchaseModuleViewBindingSource.DataSource = typeof(SBMS.ViewModel.PurchaseModuleView);
            // 
            // PurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.endDateTimePicker2);
            this.Controls.Add(this.startDateTimePicker1);
            this.Controls.Add(this.purchaseReportDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseReport";
            this.Text = "PurchaseReport";
            this.Load += new System.EventHandler(this.PurchaseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseModuleViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView purchaseReportDataGridView;
        private System.Windows.Forms.DateTimePicker startDateTimePicker1;
        private System.Windows.Forms.DateTimePicker endDateTimePicker2;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource purchaseModuleViewBindingSource;
        private System.Windows.Forms.BindingSource salesViewBindingSource;
    }
}