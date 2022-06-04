namespace SBMS
{
    partial class SalesReportUI
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
            this.showButton = new System.Windows.Forms.Button();
            this.endDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.salesReportDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(618, 78);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 12;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // endDateTimePicker2
            // 
            this.endDateTimePicker2.Location = new System.Drawing.Point(401, 43);
            this.endDateTimePicker2.Name = "endDateTimePicker2";
            this.endDateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker2.TabIndex = 10;
            // 
            // startDateTimePicker1
            // 
            this.startDateTimePicker1.Location = new System.Drawing.Point(114, 43);
            this.startDateTimePicker1.Name = "startDateTimePicker1";
            this.startDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker1.TabIndex = 11;
            // 
            // salesReportDataGridView
            // 
            this.salesReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesReportDataGridView.Location = new System.Drawing.Point(56, 142);
            this.salesReportDataGridView.Name = "salesReportDataGridView";
            this.salesReportDataGridView.Size = new System.Drawing.Size(687, 174);
            this.salesReportDataGridView.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(618, 40);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start Date";
            // 
            // SalesReportUI
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
            this.Name = "SalesReportUI";
            this.Text = "SalesReportUI";
            this.Load += new System.EventHandler(this.SalesReportUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesReportDataGridView)).EndInit();
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
    }
}