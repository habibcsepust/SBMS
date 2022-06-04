namespace SBMS
{
    partial class CategoryUI
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
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.sLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.showButton = new System.Windows.Forms.Button();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.Location = new System.Drawing.Point(233, 43);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(167, 23);
            this.codeTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(233, 77);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(167, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(314, 103);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(86, 26);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(552, 14);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(122, 20);
            this.searchTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(680, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(61, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AutoGenerateColumns = false;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sLDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.categoryDataGridView.DataSource = this.categoryBindingSource2;
            this.categoryDataGridView.Location = new System.Drawing.Point(148, 198);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryDataGridView.Size = new System.Drawing.Size(477, 150);
            this.categoryDataGridView.TabIndex = 7;
            this.categoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGridView_CellContentClick_2);
            // 
            // sLDataGridViewTextBoxColumn
            // 
            this.sLDataGridViewTextBoxColumn.DataPropertyName = "SL";
            this.sLDataGridViewTextBoxColumn.HeaderText = "SL";
            this.sLDataGridViewTextBoxColumn.Name = "sLDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryBindingSource2
            // 
            this.categoryBindingSource2.DataSource = typeof(SBMS.Model.Category);
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(525, 142);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(99, 41);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(SBMS.Model.Category);
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataSource = typeof(SBMS.Model.Category);
            // 
            // CategoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CategoryUI";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.CategoryUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.BindingSource categoryBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}

