using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class FormClientView : Form
    {
        ViewClientOrder viewCOrder = new ViewClientOrder();

        public FormClientView()
        {
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            loadLabel();
        }

       private void loadLabelRecord()
        {
            string titleCount = string.Format("{0,-5}", "No");
            string titleVegeID = string.Format(" {0,-10}", "Vege ID");
            string titleVegeName = string.Format("{0,-40}", "Vege Name");
            string titleUnit = string.Format("{0,-13}", "Unit(kg)");
            string titleUnitPrice = string.Format("{0,-20}", "Price/kg (RM)");
            string titlePrice = string.Format("{0,-20}", "Price (RM)");
            labelRecord.Text = titleCount + titleVegeID + titleVegeName + titleUnit + titleUnitPrice + titlePrice;
        }

        private void loadLabel()
        {
            string titleCount = string.Format("{0,-5}", "No");
            string titleOrderID = string.Format("{0,-20}", "Order ID");
            string titleOrderDate = string.Format("{0,-20}", "Order Date");
            string titlePay = string.Format("{0,-15}", "Payment (RM)");

            labelOrder.Text = titleCount + titleOrderID + titleOrderDate + titlePay;

            loadLabelRecord();

            displayReport();

            buttonView.Enabled = false;
        }

        private void displayReport()
        {
            viewCOrder.ClientID = Login.CID;
            
            viewCOrder.ViewRecord();
            
            // $"{No,-7}{OrderID,-24}{OrderDate.ToShortDateString(),-18}{Payment,10}";
            if (viewCOrder.FlagOrder == false)
            {
                //this.Close();
                MessageBox.Show("No order received from client", "Order Info");
            }

            else
            {
                /*foreach (var displayList in viewCOrder.listCustomerOrder)
                {
                    listBoxRecord.Items.Add(displayList);
                }*/
                for (int a = 0; a < viewCOrder.listCustomerOrder.Count(); a++)
                {
                    listBoxRecord.Items.Add($"{viewCOrder.listCustomerOrder[a].No,-7}{viewCOrder.listCustomerOrder[a].OrderID,-24}{viewCOrder.listCustomerOrder[a].OrderDate.ToShortDateString(),-18}{viewCOrder.listCustomerOrder[a].Payment,10}");
                }

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            //cannot run
            //viewCOrder.OrderID = listBoxRecord
            //(int)(listBoxRecord.SelectedItem as DataRowView)["Order ID"];

            //sync the orderID with index
            viewCOrder.OrderID = viewCOrder.listOrderID[listBoxRecord.SelectedIndex];
            viewCOrder.ViewVege(viewCOrder.OrderID);

            /*foreach (var displayName in viewCOrder.listVege)
            {
                labelRecord.Text += $"\n{displayName}";
            }*/
            for (int a = 0; a < viewCOrder.listVege.Count(); a++)
            {
                labelRecord.Text += $"\n{viewCOrder.listVege[a].No,-7}{viewCOrder.listVege[a].VegeID,-10}{viewCOrder.listVege[a].VegeName,-40}{viewCOrder.listVege[a].Unit,13}{viewCOrder.listVege[a].UnitPrice,20}{viewCOrder.listVege[a].Price,20}";
            }
        }

        private void listBoxRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRecord.SelectedItem != null)
            {
                labelRecord.Text = "";
                loadLabelRecord();

                buttonView.Enabled = true;
            }
        }
    }
}
