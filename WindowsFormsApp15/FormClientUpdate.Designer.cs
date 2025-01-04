namespace WindowsFormsApp15
{
    partial class FormClientUpdate
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
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label clientNameLabel;
            System.Windows.Forms.Label clientPasswordLabel;
            System.Windows.Forms.Label clientPhoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientUpdate));
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelClientID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.pictureBoxDeco = new System.Windows.Forms.PictureBox();
            clientIDLabel = new System.Windows.Forms.Label();
            clientNameLabel = new System.Windows.Forms.Label();
            clientPasswordLabel = new System.Windows.Forms.Label();
            clientPhoneLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeco)).BeginInit();
            this.SuspendLayout();
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(7, 77);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(47, 13);
            clientIDLabel.TabIndex = 11;
            clientIDLabel.Text = "Client ID";
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Location = new System.Drawing.Point(7, 110);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new System.Drawing.Size(55, 13);
            clientNameLabel.TabIndex = 13;
            clientNameLabel.Text = "Username";
            // 
            // clientPasswordLabel
            // 
            clientPasswordLabel.AutoSize = true;
            clientPasswordLabel.Location = new System.Drawing.Point(7, 187);
            clientPasswordLabel.Name = "clientPasswordLabel";
            clientPasswordLabel.Size = new System.Drawing.Size(53, 13);
            clientPasswordLabel.TabIndex = 15;
            clientPasswordLabel.Text = "Password";
            // 
            // clientPhoneLabel
            // 
            clientPhoneLabel.AutoSize = true;
            clientPhoneLabel.Location = new System.Drawing.Point(7, 149);
            clientPhoneLabel.Name = "clientPhoneLabel";
            clientPhoneLabel.Size = new System.Drawing.Size(98, 13);
            clientPhoneLabel.TabIndex = 17;
            clientPhoneLabel.Text = "Telephone Number";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(105, 184);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(91, 20);
            this.textBoxPass.TabIndex = 16;
            this.textBoxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Update);
            this.textBoxPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Back);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(121, 272);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(105, 146);
            this.textBoxPhone.MaxLength = 12;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(91, 20);
            this.textBoxPhone.TabIndex = 18;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            this.textBoxPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Update);
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelNo_KeyPress);
            this.textBoxPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Back);
            // 
            // labelClientID
            // 
            this.labelClientID.AutoSize = true;
            this.labelClientID.Location = new System.Drawing.Point(102, 77);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(0, 13);
            this.labelClientID.TabIndex = 21;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(103, 110);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.textBoxPhone);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(clientPhoneLabel);
            this.groupBox1.Controls.Add(this.labelClientID);
            this.groupBox1.Controls.Add(clientPasswordLabel);
            this.groupBox1.Controls.Add(clientNameLabel);
            this.groupBox1.Controls.Add(clientIDLabel);
            this.groupBox1.Controls.Add(this.buttonBack);
            this.groupBox1.Controls.Add(this.textBoxPass);
            this.groupBox1.Location = new System.Drawing.Point(7, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 310);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Information";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(10, 272);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 23);
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // pictureBoxDeco
            // 
            this.pictureBoxDeco.Location = new System.Drawing.Point(222, 47);
            this.pictureBoxDeco.Name = "pictureBoxDeco";
            this.pictureBoxDeco.Size = new System.Drawing.Size(453, 310);
            this.pictureBoxDeco.TabIndex = 24;
            this.pictureBoxDeco.TabStop = false;
            // 
            // FormClientUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxDeco);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClientUpdate";
            this.Text = "Client Update Page";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxDeco;
        private System.Windows.Forms.Button buttonUpdate;
    }
}