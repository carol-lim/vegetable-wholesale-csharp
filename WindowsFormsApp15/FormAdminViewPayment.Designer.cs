namespace WindowsFormsApp15
{
    partial class FormAdminViewPayment
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cookiesDataSet1 = new WindowsFormsApp15.cookiesDataSet();
            this.cookiesDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vege_OrderTableAdapter1 = new WindowsFormsApp15.cookiesDataSetTableAdapters.Vege_OrderTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vegetableTableAdapter1 = new WindowsFormsApp15.cookiesDataSetTableAdapters.VegetableTableAdapter();
            this.vegeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegePricePerKGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.vegeIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(546, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // cookiesDataSet1
            // 
            this.cookiesDataSet1.DataSetName = "cookiesDataSet";
            this.cookiesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cookiesDataSet1BindingSource
            // 
            this.cookiesDataSet1BindingSource.DataSource = this.cookiesDataSet1;
            this.cookiesDataSet1BindingSource.Position = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Vege_Order";
            this.bindingSource1.DataSource = this.cookiesDataSet1BindingSource;
            // 
            // vege_OrderTableAdapter1
            // 
            this.vege_OrderTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vegeIDDataGridViewTextBoxColumn1,
            this.vegeNameDataGridViewTextBoxColumn,
            this.vegePricePerKGDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.bindingSource2;
            this.dataGridView3.Location = new System.Drawing.Point(12, 276);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(432, 150);
            this.dataGridView3.TabIndex = 1;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Vegetable";
            this.bindingSource2.DataSource = this.cookiesDataSet1BindingSource;
            // 
            // vegetableTableAdapter1
            // 
            this.vegetableTableAdapter1.ClearBeforeFill = true;
            // 
            // vegeIDDataGridViewTextBoxColumn1
            // 
            this.vegeIDDataGridViewTextBoxColumn1.DataPropertyName = "VegeID";
            this.vegeIDDataGridViewTextBoxColumn1.HeaderText = "VegeID";
            this.vegeIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.vegeIDDataGridViewTextBoxColumn1.Name = "vegeIDDataGridViewTextBoxColumn1";
            this.vegeIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // vegeNameDataGridViewTextBoxColumn
            // 
            this.vegeNameDataGridViewTextBoxColumn.DataPropertyName = "VegeName";
            this.vegeNameDataGridViewTextBoxColumn.HeaderText = "VegeName";
            this.vegeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vegeNameDataGridViewTextBoxColumn.Name = "vegeNameDataGridViewTextBoxColumn";
            this.vegeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // vegePricePerKGDataGridViewTextBoxColumn
            // 
            this.vegePricePerKGDataGridViewTextBoxColumn.DataPropertyName = "VegePricePerKG";
            this.vegePricePerKGDataGridViewTextBoxColumn.HeaderText = "VegePricePerKG";
            this.vegePricePerKGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vegePricePerKGDataGridViewTextBoxColumn.Name = "vegePricePerKGDataGridViewTextBoxColumn";
            this.vegePricePerKGDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn4.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // vegeIDDataGridViewTextBoxColumn
            // 
            this.vegeIDDataGridViewTextBoxColumn.DataPropertyName = "VegeID";
            this.vegeIDDataGridViewTextBoxColumn.HeaderText = "VegeID";
            this.vegeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vegeIDDataGridViewTextBoxColumn.Name = "vegeIDDataGridViewTextBoxColumn";
            this.vegeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn5.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Details";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vegetable Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormAdminViewPayment
            // 
            this.ClientSize = new System.Drawing.Size(722, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormAdminViewPayment";
            this.Load += new System.EventHandler(this.FormAdminViewPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VegeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vegeOrderBindingSource;
        private vege_wholesaleDataSet cookiesDataSet;
        private cookiesDataSetTableAdapters.Vege_OrderTableAdapter vege_OrderTableAdapter;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.BindingSource vegetableBindingSource;
        private cookiesDataSetTableAdapters.VegetableTableAdapter vegetableTableAdapter;
        private cookiesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vegetableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource cookiesDataSet1BindingSource;
        private cookiesDataSet cookiesDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private cookiesDataSetTableAdapters.Vege_OrderTableAdapter vege_OrderTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource bindingSource2;
        private cookiesDataSetTableAdapters.VegetableTableAdapter vegetableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn vegeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn vegeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vegeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vegePricePerKGDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}