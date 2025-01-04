using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15
{
    class ClientUpdate : Login
    {
        cookiesDataContext db = new cookiesDataContext();

        //public string cID { set; get; }
        /*public string CID { set; get; }
        public string CName { set; get; }
        public string CPhone { set; get; }
        public string CPass { set; get; }*/
        //public bool FlagCustomer { set; get; }

        public void UpdateCustomer()
        {

            IEnumerable<Client> queryUpdate =
                 from c in db.Clients
                 where c.ClientID == CID
                 select c;

            foreach (Client cDetails in queryUpdate)
            {
                cDetails.ClientPhone = CPhone;
                cDetails.ClientPassword = CPass;
            }
            db.SubmitChanges();
        }

        public void Load()
        {
            var queryClient = db.Clients.Where(c => c.ClientID == CID);
            int countCustomer = queryClient.Count();

            if (countCustomer == 0)
                Flag = false;
            else
            {
                Flag = true;
                foreach (var c in queryClient)
                {
                    //CID = Login.CID;
                    CName = c.ClientName;
                    CPhone = c.ClientPhone;
                    CPass = c.ClientPassword;
                }
            }

        }
    }

    
}
