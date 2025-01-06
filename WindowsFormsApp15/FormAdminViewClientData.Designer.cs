namespace WindowsFormsApp15
{
    partial class FormAdminViewClientData
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cookiesDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cookiesDataSet1 = new WindowsFormsApp15.cookiesDataSet();
            this.clientTableAdapter1 = new WindowsFormsApp15.cookiesDataSetTableAdapters.ClientTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.cookiesDataSet2 = new WindowsFormsApp15.cookiesDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientPasswordDataGridViewTextBoxColumn,
            this.clientPhoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientPasswordDataGridViewTextBoxColumn
            // 
            this.clientPasswordDataGridViewTextBoxColumn.DataPropertyName = "ClientPassword";
            this.clientPasswordDataGridViewTextBoxColumn.HeaderText = "ClientPassword";
            this.clientPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientPasswordDataGridViewTextBoxColumn.Name = "clientPasswordDataGridViewTextBoxColumn";
            this.clientPasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientPhoneDataGridViewTextBoxColumn
            // 
            this.clientPhoneDataGridViewTextBoxColumn.DataPropertyName = "ClientPhone";
            this.clientPhoneDataGridViewTextBoxColumn.HeaderText = "ClientPhone";
            this.clientPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientPhoneDataGridViewTextBoxColumn.Name = "clientPhoneDataGridViewTextBoxColumn";
            this.clientPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Client";
            this.bindingSource1.DataSource = this.cookiesDataSet1BindingSource;
            // 
            // cookiesDataSet1BindingSource
            // 
            this.cookiesDataSet1BindingSource.DataSource = this.cookiesDataSet1;
            this.cookiesDataSet1BindingSource.Position = 0;
            // 
            // cookiesDataSet1
            // 
            this.cookiesDataSet1.DataSetName = "cookiesDataSet";
            this.cookiesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Client Data";
            // 
            // cookiesDataSet2
            // 
            this.cookiesDataSet2.DataSetName = "cookiesDataSet";
            this.cookiesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sort By";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(454, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // FormAdminViewClientData
            // 
            this.ClientSize = new System.Drawing.Size(901, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAdminViewClientData";
            this.Load += new System.EventHandler(this.FormAdminViewClientData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button buttonBack;
        private vege_wholesaleDataSet cookiesDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private cookiesDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cookiesDataSet cookiesDataSet1;
        private System.Windows.Forms.BindingSource cookiesDataSet1BindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private cookiesDataSetTableAdapters.ClientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private cookiesDataSet cookiesDataSet2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}