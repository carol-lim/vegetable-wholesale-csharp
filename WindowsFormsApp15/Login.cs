using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15
{
    class Login
    {
        cookiesDataContext db = new cookiesDataContext();
        /*Client Table*/
        public static string CID { set; get; }
        public string CName { set; get; }
        public string CPass { set; get; }
        public string CPhone { set; get; }
        public bool Flag { set; get; }
        //Order Table
        public int OrderID { set; get; }
        public decimal TotalPayment { set; get; }

        //Vege Table
        public int VegeID { set; get; }
        public string VName { set; get; }

        //Vege_Order Table(Bridge)
        public int VO_ID { set; get; }
        public DateTime ODate { set; get; }
        public int Unit { set; get; }
        public decimal Price { set; get; }

        public void SearchCustomer()
        {
            IEnumerable<Client> querySearch =
                from client in db.Clients
                where client.ClientName == CName &&
                 client.ClientPassword == CPass
                select client;

            if (querySearch.Count() != 0)
            {
                Flag = true;
                foreach (Client c in querySearch)
                {
                    CName = c.ClientName.ToString();
                    CPass = c.ClientPassword.ToString();
                    CID = c.ClientID.ToString();
                }
            }
            else
            {
                Flag = false;
            }
        }
    }
}
