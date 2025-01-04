namespace WindowsFormsApp15
{
    partial class FormAdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminHome));
            this.pictureBoxDeco = new System.Windows.Forms.PictureBox();
            this.buttonClientOrder = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonClientData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeco)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDeco
            // 
            this.pictureBoxDeco.Location = new System.Drawing.Point(154, -6);
            this.pictureBoxDeco.Name = "pictureBoxDeco";
            this.pictureBoxDeco.Size = new System.Drawing.Size(399, 414);
            this.pictureBoxDeco.TabIndex = 26;
            this.pictureBoxDeco.TabStop = false;
            // 
            // buttonClientOrder
            // 
            this.buttonClientOrder.BackColor = System.Drawing.Color.Yellow;
            this.buttonClientOrder.Location = new System.Drawing.Point(362, 190);
            this.buttonClientOrder.Name = "buttonClientOrder";
            this.buttonClientOrder.Size = new System.Drawing.Size(101, 31);
            this.buttonClientOrder.TabIndex = 32;
            this.buttonClientOrder.Text = "Client Order";
            this.buttonClientOrder.UseVisualStyleBackColor = false;
            this.buttonClientOrder.Click += new System.EventHandler(this.buttonClientOrder_Click_1);
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonPayment.Location = new System.Drawing.Point(291, 237);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(122, 31);
            this.buttonPayment.TabIndex = 31;
            this.buttonPayment.Text = "Other Details";
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click_1);
            // 
            // buttonClientData
            // 
            this.buttonClientData.BackColor = System.Drawing.Color.Orange;
            this.buttonClientData.Location = new System.Drawing.Point(238, 190);
            this.buttonClientData.Name = "buttonClientData";
            this.buttonClientData.Size = new System.Drawing.Size(100, 31);
            this.buttonClientData.TabIndex = 30;
            this.buttonClientData.Text = "Client Data";
            this.buttonClientData.UseVisualStyleBackColor = false;
            this.buttonClientData.Click += new System.EventHandler(this.buttonClientData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(277, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Sellect One Button To Continue";
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(332, 287);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLabelLogout.TabIndex = 34;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // FormAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1326, 626);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClientOrder);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.buttonClientData);
            this.Controls.Add(this.pictureBoxDeco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdminHome";
            this.Text = "Admin Home Page";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxDeco;
        private System.Windows.Forms.Button buttonClientOrder;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Button buttonClientData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
    }
}