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
    public partial class FormAdminViewClientData : Form
    {
        cookiesDataContext db = new cookiesDataContext();

        private void displayAllData()
        {
            IEnumerable<Client> querySearch =
                from client in db.Clients
                select client;
            ViewTableClient(querySearch);
        }

        private void ViewTableClient(IEnumerable<Client> querySearch)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Client ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Telephone Number", typeof(string));

            foreach (Client client in querySearch)
            {
                DataRow dr = dt.NewRow();
                dr["Client ID"] = client.ClientID.ToString();
                dr["Name"] = client.ClientName.ToString();
                dr["Password"] = client.ClientPassword.ToString();
                dr["Telephone Number"] = client.ClientPhone.ToString();

                dt.Rows.Add(dr);
            }

            dataGridViewClient.DataSource = dt;

            comboBoxSort.Items.Clear();
            foreach (DataColumn combodata in dt.Columns)
            {
                string datacol = combodata.ToString();
                if (Equals(datacol, "Client ID") | Equals(datacol, "Name"))
                    comboBox1.Items.Add(combodata.ToString());
            }
        }

        public FormAdminViewClientData()
        {
            InitializeComponent();
        }

        private void FormViewClientData_Load(object sender, EventArgs e)
        {
            displayAllData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAdminViewClientData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cookiesDataSet1.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter1.Fill(this.cookiesDataSet1.Client);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            IEnumerable<Client> querySearch;
            if (comboBox1.SelectedIndex == 0)
            {
                querySearch = from client in db.Clients
                              orderby client.ClientID
                              select client;
            }
            else
            {
                querySearch = from client in db.Clients
                              orderby client.ClientName
                              select client;
            }
            ViewTableClient(querySearch);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var formAdminHome = new FormAdminHome();
            formAdminHome.MdiParent = this.MdiParent;
            formAdminHome.Dock = DockStyle.Fill;
            formAdminHome.Show();
            this.Close();
        }
    }
}
