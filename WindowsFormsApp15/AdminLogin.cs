using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15
{
    class AdminLogin
    {
        cookiesDataContext db = new cookiesDataContext();
        public int AID { set; get; }
        public string APass { set; get; }
        public bool Flag { set; get; }

        public void SearchAdmin()
        {
            IEnumerable<Admin> querySearch =
                from Admin in db.Admins
                where Admin.AdminId == AID &&
                 Admin.AdminPass == APass
                select Admin;

            if (querySearch.Count() != 0)
            {
                Flag = true;
                foreach (Admin a in querySearch)
                {
                    AID = a.AdminId;
                    APass = a.AdminPass.ToString();
                }
            }
        }
    }
}
