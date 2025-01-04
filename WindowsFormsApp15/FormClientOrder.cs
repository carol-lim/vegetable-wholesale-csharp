using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        VegetablesClient VegetablesCustomer = new VegetablesClient();

        //messagaeBox
        public string message, title;
        private MessageBoxButtons buttons = MessageBoxButtons.YesNo;

        //Collections : List
        public List<String> ListSelectedVege = new List<String>();
        public List<int> ListOrderUnit = new List<int>();
        public List<decimal> ListUnitPrice = new List<decimal>();
        public List<decimal> ListPrice = new List<decimal>();

        //built-in delegates
        public Func<decimal, decimal, decimal> Pay = (p, s) => p + s;
        public Predicate<decimal> ShipFeeOrNot = t => t > 70;

        // anonymous delegate
        delegate void DelegateInfo(string info, string alert);

        //delegate
        delegate void DelegateNoParam();

        private DelegateInfo DisplayInfo = delegate (string info, string alert)
        {
            MessageBox.Show(info, alert);
        };

        private void ClearList()
        {
            ListSelectedVege.Clear();
            ListOrderUnit.Clear();
            ListUnitPrice.Clear();
            ListPrice.Clear();
        }

        public Form1()
        {
            InitializeComponent();
            numericUpDownKG.Minimum = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitialState();
        }

        private void InitialState()
        {
            groupBoxCheckOut.Enabled = true;
            groupBoxChoose.Enabled = true;
            VegetablesCustomer.ShowVegeName();
            foreach (string v in VegetablesCustomer.ShowVegeName())
            {
                listBoxVege.Items.Add(v);
            }

            buttonAdd.Enabled = false;
            buttonReset.Enabled = false;
            buttonDel.Enabled = false;
            buttonClearAll.Enabled = false;
            labelPrice.Enabled = false;
            numericUpDownKG.Enabled = false;
            pictureBoxVege.Enabled = false;
            buttonCheckOut.Enabled = false;
            dateTimePickerOrder.MinDate = DateTime.Today;

            string titleVege = String.Format("{0,-20}", "Selected Vegetable");
            string titleUnit = String.Format("{0,-20}", "Unit(kg)");
            string titleUnitPrice = String.Format("{0,-20}", "Unit Price(RM)");
            string titlePrice = String.Format("{0,-15}", "Price(RM)");

            labelOrder.Text = titleVege + titleUnit + titleUnitPrice + titlePrice;
            groupBoxBill.Enabled = false;
        }
        public void ClearPayBill()
        {
            string titleVege = String.Format("{0,-20}", "Selected Vegetable");
            string titleUnit = String.Format("{0,-20}", "Unit(kg)");
            string titleUnitPrice = String.Format("{0,-20}", "Unit Price(RM)");
            string titlePrice = String.Format("{0,-15}", "Price(RM)");

            labelOrder.Text = titleVege + titleUnit + titleUnitPrice + titlePrice;
            labelOrderID.Text = "id";
            labelClientID.Text = "id";
            labelDate.Text = "date";
            labelTotalPay.Text = "total";
            labelTotalPrice.Text = "total";
            labelShipFee.Text = "total";
            groupBoxBill.Enabled = false;
        }
        public void Clear()
        {
            ClearPayBill();
            listBoxSelectedVege.Items.Clear();
            listBoxUnit.Items.Clear();
            listBoxUnitPrice.Items.Clear();
            listBoxPrice.Items.Clear();
            listBoxVege.ClearSelected();
            labelPrice.Text = "0.00";
            numericUpDownKG.Value = 1;
            dateTimePickerOrder.Value = DateTime.Today;
        }

        private void listBoxVege_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = listBoxVege.SelectedIndex + 1; //vege id starts from 1
            foreach (var p in VegetablesCustomer.ShowVegePrice(num))
            {
                labelPrice.Text = p.ToString();
            }

            buttonAdd.Enabled = true;
            labelPrice.Enabled = true;
            numericUpDownKG.Enabled = true;
            ShowVegePic();
        }

        private void ShowVegePic()
        {
            pictureBoxVege.Enabled = true;
            pictureBoxVege.SizeMode = PictureBoxSizeMode.Zoom;
            //string path = "C:\\Users\\admin\\Downloads\\VegePic\\";

            // Get the current directory (the bin/Debug or bin/Release folder)
            string currentDirectory = Directory.GetCurrentDirectory();

            // Get the project directory by going up two levels (from bin to project root)
            string projectDirectory = Directory.GetParent(currentDirectory).Parent.FullName;

            // Combine with Resources folder
            string path = Path.Combine(projectDirectory, "Resources\\");
            string type1 = ".jpg";
            string type2 = ".jpeg";

            if (listBoxVege.SelectedIndex == 0)
                pictureBoxVege.ImageLocation = $"{path}labuMerah{type1}";
            else if (listBoxVege.SelectedIndex == 1)
                pictureBoxVege.ImageLocation = $"{path}kobisBeijing{type1}";
            else if (listBoxVege.SelectedIndex == 2)
                pictureBoxVege.ImageLocation = $"{path}kobisCameron{type1}";
            else if (listBoxVege.SelectedIndex == 3)
                pictureBoxVege.ImageLocation = $"{path}lobakPutih{type1}";
            else if (listBoxVege.SelectedIndex == 4)
                pictureBoxVege.ImageLocation = $"{path}timunJepun{type1}";
            else if (listBoxVege.SelectedIndex == 5)
                pictureBoxVege.ImageLocation = $"{path}saladBulat{type1}";
            else if (listBoxVege.SelectedIndex == 6)
                pictureBoxVege.ImageLocation = $"{path}bawangBesar{type1}";
            else if (listBoxVege.SelectedIndex == 7)
                pictureBoxVege.ImageLocation = $"{path}lobakMerah{type1}";
            else if (listBoxVege.SelectedIndex == 8)
                pictureBoxVege.ImageLocation = $"{path}haliaTua{type1}";
            else if (listBoxVege.SelectedIndex == 9)
                pictureBoxVege.ImageLocation = $"{path}kacangPangjang{type1}";
            else if (listBoxVege.SelectedIndex == 10)
                pictureBoxVege.ImageLocation = $"{path}kasturi{type1}";
            else if (listBoxVege.SelectedIndex == 11)
                pictureBoxVege.ImageLocation = $"{path}kobisBunga{type1}";
            else if (listBoxVege.SelectedIndex == 12)
                pictureBoxVege.ImageLocation = $"{path}kobisPanjang{type1}";
            else if (listBoxVege.SelectedIndex == 13)
                pictureBoxVege.ImageLocation = $"{path}petola{type1}";
            else if (listBoxVege.SelectedIndex == 14)
                pictureBoxVege.ImageLocation = $"{path}kacangBotol{type2}";
            else if (listBoxVege.SelectedIndex == 15)
                pictureBoxVege.ImageLocation = $"{path}sawiCameron{type1}";
            else if (listBoxVege.SelectedIndex == 16)
                pictureBoxVege.ImageLocation = $"{path}leekChina{type1}";
            else if (listBoxVege.SelectedIndex == 17)
                pictureBoxVege.ImageLocation = $"{path}kobisMerah{type1}";
            else if (listBoxVege.SelectedIndex == 18)
                pictureBoxVege.ImageLocation = $"{path}ciliMerah{type1}";
            else if (listBoxVege.SelectedIndex == 19)
                pictureBoxVege.ImageLocation = $"{path}terungSusu{type1}";
            else if (listBoxVege.SelectedIndex == 20)
                pictureBoxVege.ImageLocation = $"{path}buncis{type1}";
            else if (listBoxVege.SelectedIndex == 21)
                pictureBoxVege.ImageLocation = $"{path}bendi{type1}";
            else if (listBoxVege.SelectedIndex == 22)
                pictureBoxVege.ImageLocation = $"{path}sawiJepun{type1}";
            else if (listBoxVege.SelectedIndex == 23)
                pictureBoxVege.ImageLocation = $"{path}tomato{type1}";
            else if (listBoxVege.SelectedIndex == 24)
                pictureBoxVege.ImageLocation = $"{path}timun{type1}";
            else if (listBoxVege.SelectedIndex == 25)
                pictureBoxVege.ImageLocation = $"{path}enokiCendawan{type1}";
            else if (listBoxVege.SelectedIndex == 26)
                pictureBoxVege.ImageLocation = $"{path}labuAir{type1}";
            else if (listBoxVege.SelectedIndex == 27)
                pictureBoxVege.ImageLocation = $"{path}saderiChina{type1}";
            else if (listBoxVege.SelectedIndex == 28)
                pictureBoxVege.ImageLocation = $"{path}bayam{type1}";
            else if (listBoxVege.SelectedIndex == 29)
                pictureBoxVege.ImageLocation = $"{path}keledekPutih{type1}";
            else if (listBoxVege.SelectedIndex == 30)
                pictureBoxVege.ImageLocation = $"{path}kailan{type1}";
            else if (listBoxVege.SelectedIndex == 31)
                pictureBoxVege.ImageLocation = $"{path}sawiKecil{type1}";
            else if (listBoxVege.SelectedIndex == 32)
                pictureBoxVege.ImageLocation = $"{path}ciliBulatKuning{type1}";
            else if (listBoxVege.SelectedIndex == 33)
                pictureBoxVege.ImageLocation = $"{path}terungBulat{type1}";
            else if (listBoxVege.SelectedIndex == 34)
                pictureBoxVege.ImageLocation = $"{path}ubiTeratai{type1}";
            else if (listBoxVege.SelectedIndex == 35)
                pictureBoxVege.ImageLocation = $"{path}kangkungTempatan{type1}";
            else if (listBoxVege.SelectedIndex == 36)
                pictureBoxVege.ImageLocation = $"{path}kacangPea{type1}";
            else if (listBoxVege.SelectedIndex == 37)
                pictureBoxVege.ImageLocation = $"{path}kingOysterMushroom{type1}";
            else if (listBoxVege.SelectedIndex == 38)
                pictureBoxVege.ImageLocation = $"{path}brokoli{type1}";
            else if (listBoxVege.SelectedIndex == 39)
                pictureBoxVege.ImageLocation = $"{path}cendawanSalji{type2}";
            else if (listBoxVege.SelectedIndex == 40)
                pictureBoxVege.ImageLocation = $"{path}choySum{type1}";
            else if (listBoxVege.SelectedIndex == 41)
                pictureBoxVege.ImageLocation = $"{path}ubiBit{type1}";
            else if (listBoxVege.SelectedIndex == 42)
                pictureBoxVege.ImageLocation = $"{path}sawiPutih{type1}";
            else if (listBoxVege.SelectedIndex == 43)
                pictureBoxVege.ImageLocation = $"{path}peria{type2}";
            else if (listBoxVege.SelectedIndex == 44)
                pictureBoxVege.ImageLocation = $"{path}keledekOren{type1}";
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedVege.Items.Contains(listBoxVege.SelectedItem))
            {
                DisplayInfo($"{listBoxVege.SelectedItem}" + " already exists in cart!", "Alert");
            }
            else
            {
                listBoxSelectedVege.Items.Add(listBoxVege.SelectedItem);
                listBoxUnit.Items.Add(numericUpDownKG.Value);
                listBoxUnitPrice.Items.Add(labelPrice.Text);
                decimal price = numericUpDownKG.Value * decimal.Parse(labelPrice.Text);
                listBoxPrice.Items.Add(price);
                DisplayInfo($"{listBoxVege.SelectedItem}" + " has been added to cart!", "Added Successfully");
                buttonReset.Enabled = true;
                buttonClearAll.Enabled = true;
                buttonCheckOut.Enabled = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            message = "Do you want to delete " + $"{listBoxSelectedVege.SelectedItem}" + "?";
            title = "Delete Selected Vegetable";
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                DisplayInfo($"{listBoxSelectedVege.SelectedItem}" + " has been deleted!", "Deleted Successfully");
                listBoxSelectedVege.Items.Remove(listBoxSelectedVege.SelectedItem);
                listBoxUnit.Items.Remove(listBoxUnit.SelectedItem);
                listBoxUnitPrice.Items.Remove(listBoxUnitPrice.SelectedItem);
                listBoxPrice.Items.Remove(listBoxPrice.SelectedItem);

            }
            buttonDel.Enabled = false;

            if (listBoxSelectedVege.Items.Count == 0)
            {
                buttonClearAll.Enabled = false;
                buttonCheckOut.Enabled = false;
            }

        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            message = "Do you want to clear all selected vegetable in your cart?";
            title = "Clear Selected Vegetables";
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                listBoxSelectedVege.Items.Clear();
                listBoxUnit.Items.Clear();
                listBoxUnitPrice.Items.Clear();
                listBoxPrice.Items.Clear();
                dateTimePickerOrder.Value = DateTime.Today;
                DisplayInfo("All selected vegetables in your cart have been cleared!", "Alert");
            }
            buttonDel.Enabled = false;
            buttonClearAll.Enabled = false;
            buttonCheckOut.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            message = "Do you really want to reset form?";
            title = "Reset Form";
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                labelPrice.Text = "0.00";
                numericUpDownKG.Value = 1;
                listBoxVege.SelectedItem = null;
                pictureBoxVege.Image = null;
                buttonAdd.Enabled = false;
                buttonReset.Enabled = false;
            }
        }

        private void listBoxSelectedVege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSelectedVege.SelectedItem != null)
            {
                //sync 4 listbox
                listBoxUnit.SelectedIndex = listBoxSelectedVege.SelectedIndex;
                listBoxUnitPrice.SelectedIndex = listBoxSelectedVege.SelectedIndex;
                listBoxPrice.SelectedIndex = listBoxSelectedVege.SelectedIndex;

                buttonDel.Enabled = true;
            }
        }

        private void listBoxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUnit.SelectedItem != null)
            {
                //sync 4 listbox
                listBoxSelectedVege.SelectedIndex = listBoxUnit.SelectedIndex;
                listBoxUnitPrice.SelectedIndex = listBoxUnit.SelectedIndex;
                listBoxPrice.SelectedIndex = listBoxUnit.SelectedIndex;
                buttonDel.Enabled = true;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            DelegateNoParam EmptyList = ClearList;
            message = "Are you sure to check out order?";
            title = "Check Out Order";
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                groupBoxBill.Enabled = true;
                decimal totalPrice = 0, shipfee;
                for (int i = 0; i < listBoxSelectedVege.Items.Count; i++)
                {
                    ListSelectedVege.Add(listBoxSelectedVege.Items[i].ToString());
                    ListOrderUnit.Add(int.Parse(listBoxUnit.Items[i].ToString()));
                    ListUnitPrice.Add(decimal.Parse(listBoxUnitPrice.Items[i].ToString()));
                    ListPrice.Add(decimal.Parse(listBoxPrice.Items[i].ToString()));
                    labelOrder.Text += $"\n{ListSelectedVege[i],-30}" +
                        $"{ListOrderUnit[i],-20}" +
                        $"{ListUnitPrice[i],-25}" +
                        $"{ListPrice[i],-15}";
                    totalPrice += ListPrice[i];
                }
                VegetablesCustomer.GenerateOrderID();
                labelOrderID.Text = VegetablesCustomer.OrderID.ToString();
                labelClientID.Text = Login.CID;
                labelDate.Text = dateTimePickerOrder.Value.ToShortDateString();
                groupBoxChoose.Enabled = false;
                groupBoxCheckOut.Enabled = false;
                labelTotalPrice.Text = totalPrice.ToString();
                if (ShipFeeOrNot(totalPrice))
                {
                    shipfee = 0;
                }
                else
                {
                    shipfee = 5;
                }
                labelShipFee.Text = shipfee.ToString();
                labelTotalPay.Text = Pay(totalPrice, shipfee).ToString();
            }
        }

        private void listBoxUnitPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUnitPrice.SelectedItem != null)
            {
                //sync 4 listbox
                listBoxUnit.SelectedIndex = listBoxUnitPrice.SelectedIndex;
                listBoxSelectedVege.SelectedIndex = listBoxUnitPrice.SelectedIndex;
                listBoxPrice.SelectedIndex = listBoxUnitPrice.SelectedIndex;
                buttonDel.Enabled = true;
            }
        }

        private void listBoxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPrice.SelectedItem != null)
            {
                //sync 4 listbox
                listBoxUnit.SelectedIndex = listBoxPrice.SelectedIndex;
                listBoxSelectedVege.SelectedIndex = listBoxPrice.SelectedIndex;
                listBoxUnitPrice.SelectedIndex = listBoxPrice.SelectedIndex;
                buttonDel.Enabled = true;
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            message = "Are you sure to cancel order? (You will have to repeat adding vegetable to cart again!)";
            title = "Cancel Order";
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                DelegateNoParam EmptyList = ClearList;
                EmptyList();
                Clear();
                InitialState();
                DisplayInfo("Order has been cancelled! Please make a new order again, thank you!", "Order Cancelled");
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            message = "Are you sure to confirm order?";
            title = "Confirm Order";
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //insert into db after confirm order, before clearing list
                VegetablesCustomer.GenerateBridgeID();
                VegetablesCustomer.ODate = DateTime.Parse(labelDate.Text);
                VegetablesCustomer.TotalPayment = decimal.Parse(labelTotalPay.Text);
                VegetablesCustomer.SaveBridge(ListSelectedVege, ListOrderUnit, ListPrice);

                DelegateNoParam EmptyList = ClearList;
                EmptyList();
                Clear();
                InitialState();
                DisplayInfo("Order has been process! Thank you for purchasing with us!", "Ordered Successfully");
                //var formClientHome = new Form8();
                //formClientHome.MdiParent = this.MdiParent;
                //formClientHome.Dock = DockStyle.Fill;
                //formClientHome.Show();
                this.Close();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBoxCheckOut_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxChoose_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            message = "Are you sure to edit order?";
            title = "Edit Order";
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                ClearPayBill();
                DelegateNoParam EmptyList = ClearList;
                EmptyList();
                groupBoxCheckOut.Enabled = true;
                groupBoxChoose.Enabled = true;
                DisplayInfo("Order has been replaced to cart, you can edit now! ", "Edit Now");
            }
        }
    }
}
