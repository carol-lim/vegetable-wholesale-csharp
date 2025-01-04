using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15
{
    abstract class AbstractClass
    {
        cookiesDataContext db = new cookiesDataContext();
        //Register.cs
        public string CID { set; get; }
        public string CName { set; get; }
        public string CPhone { set; get; }
        public string CPass { set; get; }
        public bool Flag { set; get; }
        public abstract void InsertClient();
        public abstract void GenerateCustomeriD();
        public abstract bool CheckName(string a);
/*        public void UpdateCustomer()
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
        }*/

    }
    /*    interface AbstractClass
        {
            //Register.cs
            string CID { set; get; }
            string CName { set; get; }
            string CPhone { set; get; }
            string CPass { set; get; }

            void InsertClient();
            void GenerateCustomeriD();
            void 

        }*/
}
