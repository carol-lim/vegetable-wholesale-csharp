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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminViewPayment));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VegeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegeOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cookiesDataSet = new WindowsFormsApp15.vege_wholesaleDataSet();
            this.vege_OrderTableAdapter = new WindowsFormsApp15.cookiesDataSetTableAdapters.Vege_OrderTableAdapter();
            this.buttonBack = new System.Windows.Forms.Button();
            this.vegetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vegetableTableAdapter = new WindowsFormsApp15.cookiesDataSetTableAdapters.VegetableTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp15.cookiesDataSetTableAdapters.TableAdapterManager();
            this.vegetableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegeOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.VegeID,
            this.unitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vegeOrderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(460, 139);
            this.dataGridView1.TabIndex = 3;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VegeID
            // 
            this.VegeID.DataPropertyName = "VegeID";
            this.VegeID.HeaderText = "VegeID";
            this.VegeID.Name = "VegeID";
            this.VegeID.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vegeOrderBindingSource
            // 
            this.vegeOrderBindingSource.DataMember = "Vege_Order";
            this.vegeOrderBindingSource.DataSource = this.cookiesDataSet;
            // 
            // cookiesDataSet
            // 
            this.cookiesDataSet.DataSetName = "cookiesDataSet";
            this.cookiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vege_OrderTableAdapter
            // 
            this.vege_OrderTableAdapter.ClearBeforeFill = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(409, 204);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(68, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // vegetableBindingSource
            // 
            this.vegetableBindingSource.DataMember = "Vegetable";
            this.vegetableBindingSource.DataSource = this.cookiesDataSet;
            // 
            // vegetableTableAdapter
            // 
            this.vegetableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp15.cookiesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vege_OrderTableAdapter = this.vege_OrderTableAdapter;
            this.tableAdapterManager.VegetableTableAdapter = this.vegetableTableAdapter;
            // 
            // vegetableDataGridView
            // 
            this.vegetableDataGridView.AllowUserToAddRows = false;
            this.vegetableDataGridView.AllowUserToDeleteRows = false;
            this.vegetableDataGridView.AutoGenerateColumns = false;
            this.vegetableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vegetableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.vegetableDataGridView.DataSource = this.vegetableBindingSource;
            this.vegetableDataGridView.Location = new System.Drawing.Point(17, 204);
            this.vegetableDataGridView.Name = "vegetableDataGridView";
            this.vegetableDataGridView.ReadOnly = true;
            this.vegetableDataGridView.Size = new System.Drawing.Size(361, 191);
            this.vegetableDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "VegeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "VegeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VegeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "VegeName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VegePricePerKG";
            this.dataGridViewTextBoxColumn3.HeaderText = "VegePricePerKG";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vegetable Data";
            // 
            // FormAdminViewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.vegetableDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdminViewPayment";
            this.Text = "Admin View Payment & Vegetable Data ";
            this.Load += new System.EventHandler(this.FormViewPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegeOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableDataGridView)).EndInit();
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
    }
}