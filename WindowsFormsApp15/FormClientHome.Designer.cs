namespace WindowsFormsApp15
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.pictureBoxDeco = new System.Windows.Forms.PictureBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeco)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDeco
            // 
            this.pictureBoxDeco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxDeco.Image = global::WindowsFormsApp15.Properties.Resources.Border;
            this.pictureBoxDeco.InitialImage = global::WindowsFormsApp15.Properties.Resources.Border;
            this.pictureBoxDeco.Location = new System.Drawing.Point(200, -6);
            this.pictureBoxDeco.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxDeco.Name = "pictureBoxDeco";
            this.pictureBoxDeco.Size = new System.Drawing.Size(532, 510);
            this.pictureBoxDeco.TabIndex = 0;
            this.pictureBoxDeco.TabStop = false;
            this.pictureBoxDeco.Click += new System.EventHandler(this.pictureBoxDeco_Click);
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.Orange;
            this.buttonView.Location = new System.Drawing.Point(317, 234);
            this.buttonView.Margin = new System.Windows.Forms.Padding(4);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(133, 38);
            this.buttonView.TabIndex = 1;
            this.buttonView.Text = "View Order";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.Yellow;
            this.buttonOrder.Location = new System.Drawing.Point(483, 234);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(135, 38);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Place Order";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonUpdate.Location = new System.Drawing.Point(388, 292);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(163, 38);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update Profile";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(368, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Select One Button To Continue";
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(443, 358);
            this.linkLabelLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(48, 16);
            this.linkLabelLogout.TabIndex = 35;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 554);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.pictureBoxDeco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form8";
            this.Text = "Client Home Page";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDeco;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
    }
}