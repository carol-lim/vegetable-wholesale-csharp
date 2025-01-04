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
            this.pictureBoxDeco.Image = global::WindowsFormsApp15.Properties.Resources.Border;
            this.pictureBoxDeco.InitialImage = global::WindowsFormsApp15.Properties.Resources.Van;
            this.pictureBoxDeco.Location = new System.Drawing.Point(205, -7);
            this.pictureBoxDeco.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxDeco.Name = "pictureBoxDeco";
            this.pictureBoxDeco.Size = new System.Drawing.Size(532, 510);
            this.pictureBoxDeco.TabIndex = 26;
            this.pictureBoxDeco.TabStop = false;
            // 
            // buttonClientOrder
            // 
            this.buttonClientOrder.BackColor = System.Drawing.Color.Yellow;
            this.buttonClientOrder.Location = new System.Drawing.Point(483, 234);
            this.buttonClientOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClientOrder.Name = "buttonClientOrder";
            this.buttonClientOrder.Size = new System.Drawing.Size(135, 38);
            this.buttonClientOrder.TabIndex = 32;
            this.buttonClientOrder.Text = "Client Order";
            this.buttonClientOrder.UseVisualStyleBackColor = false;
            this.buttonClientOrder.Click += new System.EventHandler(this.buttonClientOrder_Click_1);
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonPayment.Location = new System.Drawing.Point(388, 292);
            this.buttonPayment.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(163, 38);
            this.buttonPayment.TabIndex = 31;
            this.buttonPayment.Text = "Other Details";
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click_1);
            // 
            // buttonClientData
            // 
            this.buttonClientData.BackColor = System.Drawing.Color.Orange;
            this.buttonClientData.Location = new System.Drawing.Point(317, 234);
            this.buttonClientData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClientData.Name = "buttonClientData";
            this.buttonClientData.Size = new System.Drawing.Size(133, 38);
            this.buttonClientData.TabIndex = 30;
            this.buttonClientData.Text = "Client Data";
            this.buttonClientData.UseVisualStyleBackColor = false;
            this.buttonClientData.Click += new System.EventHandler(this.buttonClientData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(369, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Sellect One Button To Continue";
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(443, 353);
            this.linkLabelLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(48, 16);
            this.linkLabelLogout.TabIndex = 34;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // FormAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1414, 616);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClientOrder);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.buttonClientData);
            this.Controls.Add(this.pictureBoxDeco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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