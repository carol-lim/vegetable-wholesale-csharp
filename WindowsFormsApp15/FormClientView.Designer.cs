namespace WindowsFormsApp15
{
    partial class FormClientView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientView));
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelOrder = new System.Windows.Forms.Label();
            this.listBoxRecord = new System.Windows.Forms.ListBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(403, 40);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(89, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(25, 40);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(0, 13);
            this.labelOrder.TabIndex = 3;
            // 
            // listBoxRecord
            // 
            this.listBoxRecord.FormattingEnabled = true;
            this.listBoxRecord.Location = new System.Drawing.Point(28, 58);
            this.listBoxRecord.Name = "listBoxRecord";
            this.listBoxRecord.Size = new System.Drawing.Size(262, 95);
            this.listBoxRecord.TabIndex = 4;
            this.listBoxRecord.SelectedIndexChanged += new System.EventHandler(this.listBoxRecord_SelectedIndexChanged);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(403, 79);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(89, 23);
            this.buttonView.TabIndex = 5;
            this.buttonView.Text = "View Vegetable";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vegetables Ordered ";
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Location = new System.Drawing.Point(28, 196);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(0, 13);
            this.labelRecord.TabIndex = 7;
            // 
            // FormClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.listBoxRecord);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClientView";
            this.Text = "Client View Order Record";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.ListBox listBoxRecord;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRecord;
    }
}