using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15
{
    class Register : AbstractClass
    {
        cookiesDataContext db = new cookiesDataContext();
        /*       public string CID { set; get; }
               public string CName { set; get; }
               public string CPhone { set; get; }
               public string CPass { set; get; }*/

        public override void InsertClient()
        {
            Client client = new Client();
            client.ClientID = CID;
            client.ClientName = CName;
            client.ClientPhone = CPhone;
            client.ClientPassword = CPass;
            db.Clients.InsertOnSubmit(client);
            db.SubmitChanges();
        }

        public override void GenerateCustomeriD()
        {
            Random random = new Random();
            int newID = random.Next(1000, 9999);
            CID = newID.ToString();
        }

        public override bool CheckName(string name)
        {
            IEnumerable<Client> querySearch =
                from client in db.Clients
                where client.ClientName == name
                select client;

            if (querySearch.Count() == 0)
                Flag = true; //not exist

            else
                Flag = false;//exist

            return Flag;
        }
    }
}
