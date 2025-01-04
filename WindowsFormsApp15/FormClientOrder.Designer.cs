namespace WindowsFormsApp15
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxVege = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxVege = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.numericUpDownKG = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxSelectedVege = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listBoxUnit = new System.Windows.Forms.ListBox();
            this.groupBoxChoose = new System.Windows.Forms.GroupBox();
            this.groupBoxCheckOut = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxPrice = new System.Windows.Forms.ListBox();
            this.listBoxUnitPrice = new System.Windows.Forms.ListBox();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.groupBoxBill = new System.Windows.Forms.GroupBox();
            this.labelClientID = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelVegeCheckOut = new System.Windows.Forms.Label();
            this.labelTotalPay = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelShipFee = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKG)).BeginInit();
            this.groupBoxChoose.SuspendLayout();
            this.groupBoxCheckOut.SuspendLayout();
            this.groupBoxBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxVege
            // 
            this.listBoxVege.FormattingEnabled = true;
            this.listBoxVege.Location = new System.Drawing.Point(12, 46);
            this.listBoxVege.Name = "listBoxVege";
            this.listBoxVege.Size = new System.Drawing.Size(153, 290);
            this.listBoxVege.TabIndex = 0;
            this.listBoxVege.SelectedIndexChanged += new System.EventHandler(this.listBoxVege_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Vegetables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vegetables Image";
            // 
            // pictureBoxVege
            // 
            this.pictureBoxVege.Location = new System.Drawing.Point(174, 46);
            this.pictureBoxVege.Name = "pictureBoxVege";
            this.pictureBoxVege.Size = new System.Drawing.Size(174, 156);
            this.pictureBoxVege.TabIndex = 3;
            this.pictureBoxVege.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price per kg";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(320, 239);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(28, 13);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "0.00";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(173, 313);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(87, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset Form";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(263, 313);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add to Cart";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Choose Order Date";
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(15, 253);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(184, 20);
            this.dateTimePickerOrder.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Shipping fee";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(286, 258);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(27, 13);
            this.labelTotalPrice.TabIndex = 17;
            this.labelTotalPrice.Text = "total";
            // 
            // numericUpDownKG
            // 
            this.numericUpDownKG.Location = new System.Drawing.Point(298, 267);
            this.numericUpDownKG.Name = "numericUpDownKG";
            this.numericUpDownKG.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownKG.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "RM";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(15, 313);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(76, 23);
            this.buttonDel.TabIndex = 27;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(97, 313);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(78, 23);
            this.buttonClearAll.TabIndex = 29;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Choose kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Your Cart";
            // 
            // listBoxSelectedVege
            // 
            this.listBoxSelectedVege.FormattingEnabled = true;
            this.listBoxSelectedVege.Location = new System.Drawing.Point(15, 46);
            this.listBoxSelectedVege.Name = "listBoxSelectedVege";
            this.listBoxSelectedVege.Size = new System.Drawing.Size(184, 160);
            this.listBoxSelectedVege.TabIndex = 35;
            this.listBoxSelectedVege.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedVege_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Unit(kg)";
            // 
            // listBoxUnit
            // 
            this.listBoxUnit.FormatString = "N0";
            this.listBoxUnit.FormattingEnabled = true;
            this.listBoxUnit.Location = new System.Drawing.Point(205, 46);
            this.listBoxUnit.Name = "listBoxUnit";
            this.listBoxUnit.Size = new System.Drawing.Size(52, 160);
            this.listBoxUnit.TabIndex = 37;
            this.listBoxUnit.SelectedIndexChanged += new System.EventHandler(this.listBoxUnit_SelectedIndexChanged);
            // 
            // groupBoxChoose
            // 
            this.groupBoxChoose.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBoxChoose.Controls.Add(this.label2);
            this.groupBoxChoose.Controls.Add(this.listBoxVege);
            this.groupBoxChoose.Controls.Add(this.label1);
            this.groupBoxChoose.Controls.Add(this.pictureBoxVege);
            this.groupBoxChoose.Controls.Add(this.label3);
            this.groupBoxChoose.Controls.Add(this.labelPrice);
            this.groupBoxChoose.Controls.Add(this.buttonReset);
            this.groupBoxChoose.Controls.Add(this.label6);
            this.groupBoxChoose.Controls.Add(this.buttonAdd);
            this.groupBoxChoose.Controls.Add(this.numericUpDownKG);
            this.groupBoxChoose.Controls.Add(this.label9);
            this.groupBoxChoose.Location = new System.Drawing.Point(9, 12);
            this.groupBoxChoose.Name = "groupBoxChoose";
            this.groupBoxChoose.Size = new System.Drawing.Size(363, 352);
            this.groupBoxChoose.TabIndex = 39;
            this.groupBoxChoose.TabStop = false;
            this.groupBoxChoose.Text = "Choose Vegetable and unit";
            this.groupBoxChoose.Enter += new System.EventHandler(this.groupBoxChoose_Enter);
            // 
            // groupBoxCheckOut
            // 
            this.groupBoxCheckOut.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBoxCheckOut.Controls.Add(this.label10);
            this.groupBoxCheckOut.Controls.Add(this.label8);
            this.groupBoxCheckOut.Controls.Add(this.listBoxPrice);
            this.groupBoxCheckOut.Controls.Add(this.listBoxUnitPrice);
            this.groupBoxCheckOut.Controls.Add(this.listBoxSelectedVege);
            this.groupBoxCheckOut.Controls.Add(this.label5);
            this.groupBoxCheckOut.Controls.Add(this.buttonCheckOut);
            this.groupBoxCheckOut.Controls.Add(this.dateTimePickerOrder);
            this.groupBoxCheckOut.Controls.Add(this.listBoxUnit);
            this.groupBoxCheckOut.Controls.Add(this.label12);
            this.groupBoxCheckOut.Controls.Add(this.buttonDel);
            this.groupBoxCheckOut.Controls.Add(this.buttonClearAll);
            this.groupBoxCheckOut.Controls.Add(this.label4);
            this.groupBoxCheckOut.Location = new System.Drawing.Point(378, 12);
            this.groupBoxCheckOut.Name = "groupBoxCheckOut";
            this.groupBoxCheckOut.Size = new System.Drawing.Size(386, 352);
            this.groupBoxCheckOut.TabIndex = 40;
            this.groupBoxCheckOut.TabStop = false;
            this.groupBoxCheckOut.Text = "Check Out";
            this.groupBoxCheckOut.Enter += new System.EventHandler(this.groupBoxCheckOut_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Price(RM)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 26);
            this.label8.TabIndex = 41;
            this.label8.Text = "Unit Price\r\n(RM)";
            // 
            // listBoxPrice
            // 
            this.listBoxPrice.FormatString = "N2";
            this.listBoxPrice.FormattingEnabled = true;
            this.listBoxPrice.Location = new System.Drawing.Point(321, 46);
            this.listBoxPrice.Name = "listBoxPrice";
            this.listBoxPrice.Size = new System.Drawing.Size(52, 160);
            this.listBoxPrice.TabIndex = 40;
            this.listBoxPrice.SelectedIndexChanged += new System.EventHandler(this.listBoxPrice_SelectedIndexChanged);
            // 
            // listBoxUnitPrice
            // 
            this.listBoxUnitPrice.FormatString = "N2";
            this.listBoxUnitPrice.FormattingEnabled = true;
            this.listBoxUnitPrice.Location = new System.Drawing.Point(263, 46);
            this.listBoxUnitPrice.Name = "listBoxUnitPrice";
            this.listBoxUnitPrice.Size = new System.Drawing.Size(52, 160);
            this.listBoxUnitPrice.TabIndex = 39;
            this.listBoxUnitPrice.SelectedIndexChanged += new System.EventHandler(this.listBoxUnitPrice_SelectedIndexChanged);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(181, 313);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(76, 23);
            this.buttonCheckOut.TabIndex = 38;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // groupBoxBill
            // 
            this.groupBoxBill.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBoxBill.Controls.Add(this.labelClientID);
            this.groupBoxBill.Controls.Add(this.label16);
            this.groupBoxBill.Controls.Add(this.labelOrderID);
            this.groupBoxBill.Controls.Add(this.label15);
            this.groupBoxBill.Controls.Add(this.buttonEdit);
            this.groupBoxBill.Controls.Add(this.labelDate);
            this.groupBoxBill.Controls.Add(this.label11);
            this.groupBoxBill.Controls.Add(this.labelOrder);
            this.groupBoxBill.Controls.Add(this.buttonCancel);
            this.groupBoxBill.Controls.Add(this.labelVegeCheckOut);
            this.groupBoxBill.Controls.Add(this.labelTotalPay);
            this.groupBoxBill.Controls.Add(this.label17);
            this.groupBoxBill.Controls.Add(this.labelShipFee);
            this.groupBoxBill.Controls.Add(this.label14);
            this.groupBoxBill.Controls.Add(this.buttonConfirm);
            this.groupBoxBill.Controls.Add(this.label7);
            this.groupBoxBill.Controls.Add(this.labelTotalPrice);
            this.groupBoxBill.Location = new System.Drawing.Point(771, 12);
            this.groupBoxBill.Name = "groupBoxBill";
            this.groupBoxBill.Size = new System.Drawing.Size(356, 352);
            this.groupBoxBill.TabIndex = 41;
            this.groupBoxBill.TabStop = false;
            this.groupBoxBill.Text = "Pay Bill";
            this.groupBoxBill.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // labelClientID
            // 
            this.labelClientID.AutoSize = true;
            this.labelClientID.Location = new System.Drawing.Point(79, 259);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(15, 13);
            this.labelClientID.TabIndex = 53;
            this.labelClientID.Text = "id";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 259);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Client ID";
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(79, 274);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(15, 13);
            this.labelOrderID.TabIndex = 51;
            this.labelOrderID.Text = "id";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 274);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Order ID";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(11, 313);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(105, 23);
            this.buttonEdit.TabIndex = 49;
            this.buttonEdit.Text = "Edit Order";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(79, 289);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(28, 13);
            this.labelDate.TabIndex = 48;
            this.labelDate.Text = "date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Order Date";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(13, 30);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(10, 13);
            this.labelOrder.TabIndex = 46;
            this.labelOrder.Text = "-";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(136, 313);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 23);
            this.buttonCancel.TabIndex = 45;
            this.buttonCancel.Text = "Cancel Order";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelVegeCheckOut
            // 
            this.labelVegeCheckOut.AutoSize = true;
            this.labelVegeCheckOut.Location = new System.Drawing.Point(13, 64);
            this.labelVegeCheckOut.Name = "labelVegeCheckOut";
            this.labelVegeCheckOut.Size = new System.Drawing.Size(0, 13);
            this.labelVegeCheckOut.TabIndex = 44;
            // 
            // labelTotalPay
            // 
            this.labelTotalPay.AutoSize = true;
            this.labelTotalPay.Location = new System.Drawing.Point(286, 289);
            this.labelTotalPay.Name = "labelTotalPay";
            this.labelTotalPay.Size = new System.Drawing.Size(27, 13);
            this.labelTotalPay.TabIndex = 43;
            this.labelTotalPay.Text = "total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(166, 289);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Total Payment";
            // 
            // labelShipFee
            // 
            this.labelShipFee.AutoSize = true;
            this.labelShipFee.Location = new System.Drawing.Point(286, 274);
            this.labelShipFee.Name = "labelShipFee";
            this.labelShipFee.Size = new System.Drawing.Size(27, 13);
            this.labelShipFee.TabIndex = 41;
            this.labelShipFee.Text = "total";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(166, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Total Price";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(257, 313);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(88, 23);
            this.buttonConfirm.TabIndex = 39;
            this.buttonConfirm.Text = "Confirm Order";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(9, 370);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(76, 23);
            this.buttonBack.TabIndex = 43;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1136, 449);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxBill);
            this.Controls.Add(this.groupBoxCheckOut);
            this.Controls.Add(this.groupBoxChoose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Client Order Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKG)).EndInit();
            this.groupBoxChoose.ResumeLayout(false);
            this.groupBoxChoose.PerformLayout();
            this.groupBoxCheckOut.ResumeLayout(false);
            this.groupBoxCheckOut.PerformLayout();
            this.groupBoxBill.ResumeLayout(false);
            this.groupBoxBill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxVege;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownKG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxSelectedVege;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBoxUnit;
        private System.Windows.Forms.GroupBox groupBoxChoose;
        private System.Windows.Forms.GroupBox groupBoxCheckOut;
        private System.Windows.Forms.GroupBox groupBoxBill;
        private System.Windows.Forms.Label labelTotalPay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelShipFee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelVegeCheckOut;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxPrice;
        private System.Windows.Forms.ListBox listBoxUnitPrice;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Button buttonBack;
    }
}