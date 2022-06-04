namespace SBMS
{
    partial class ProductUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.reorderTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.productViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.showAllButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reorder Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(279, 44);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(175, 24);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.ValueMember = "Id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(SBMS.Model.Category);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.Location = new System.Drawing.Point(278, 79);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(175, 23);
            this.codeTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(279, 114);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(175, 23);
            this.nameTextBox.TabIndex = 2;
            // 
            // reorderTextBox
            // 
            this.reorderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderTextBox.Location = new System.Drawing.Point(279, 152);
            this.reorderTextBox.Name = "reorderTextBox";
            this.reorderTextBox.Size = new System.Drawing.Size(175, 23);
            this.reorderTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(279, 189);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(175, 42);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(377, 237);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(77, 30);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // productViewBindingSource
            // 
            this.productViewBindingSource.DataSource = typeof(SBMS.ViewModel.ProductView);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(SBMS.Model.Product);
            // 
            // productViewBindingSource1
            // 
            this.productViewBindingSource1.DataSource = typeof(SBMS.ViewModel.ProductView);
            // 
            // showAllButton
            // 
            this.showAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllButton.Location = new System.Drawing.Point(638, 252);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(107, 35);
            this.showAllButton.TabIndex = 6;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(598, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(126, 20);
            this.searchTextBox.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(730, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(58, 20);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SBMS.Model.Product);
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataSource = typeof(SBMS.Model.Product);
            // 
            // productBindingSource3
            // 
            this.productBindingSource3.DataSource = typeof(SBMS.Model.Product);
            // 
            // showDataGridView
            // 
            this.showDataGridView.AutoGenerateColumns = false;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.showDataGridView.DataSource = this.productViewBindingSource2;
            this.showDataGridView.Location = new System.Drawing.Point(61, 293);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(684, 130);
            this.showDataGridView.TabIndex = 9;
            this.showDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDataGridView_CellContentClick);
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            this.serialDataGridViewTextBoxColumn.HeaderText = "Serial";
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // productViewBindingSource2
            // 
            this.productViewBindingSource2.DataSource = typeof(SBMS.ViewModel.ProductView);
            // 
            // productBindingSource4
            // 
            this.productBindingSource4.DataSource = typeof(SBMS.Model.Product);
            // 
            // ProductUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.reorderTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductUI";
            this.Text = "ProductUI";
            this.Load += new System.EventHandler(this.ProductUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox reorderTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource productViewBindingSource;
        private System.Windows.Forms.BindingSource productViewBindingSource1;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.BindingSource productBindingSource3;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource4;
        private System.Windows.Forms.BindingSource productViewBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}