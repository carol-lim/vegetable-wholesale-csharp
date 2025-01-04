namespace WindowsFormsApp15
{
    partial class FormAdminViewClientOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminViewClientOrder));
            this.buttonAsc = new System.Windows.Forms.Button();
            this.buttonDesc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAsc
            // 
            this.buttonAsc.Location = new System.Drawing.Point(319, 11);
            this.buttonAsc.Name = "buttonAsc";
            this.buttonAsc.Size = new System.Drawing.Size(75, 23);
            this.buttonAsc.TabIndex = 12;
            this.buttonAsc.Text = "Ascending";
            this.buttonAsc.UseVisualStyleBackColor = true;
            this.buttonAsc.Click += new System.EventHandler(this.buttonAsc_Click);
            // 
            // buttonDesc
            // 
            this.buttonDesc.Location = new System.Drawing.Point(400, 11);
            this.buttonDesc.Name = "buttonDesc";
            this.buttonDesc.Size = new System.Drawing.Size(75, 23);
            this.buttonDesc.TabIndex = 11;
            this.buttonDesc.Text = "Desceding";
            this.buttonDesc.UseVisualStyleBackColor = true;
            this.buttonDesc.Click += new System.EventHandler(this.buttonDesc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "All Orders";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AllowUserToDeleteRows = false;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(15, 46);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.Size = new System.Drawing.Size(460, 318);
            this.dataGridViewOrder.TabIndex = 9;
            this.dataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(400, 370);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sort By Date";
            // 
            // FormAdminViewClientOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAsc);
            this.Controls.Add(this.buttonDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdminViewClientOrder";
            this.Text = "Admin View Client Order ";
            this.Load += new System.EventHandler(this.FormViewClientOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAsc;
        private System.Windows.Forms.Button buttonDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label2;
    }
}