using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15
{
    class ViewClientOrder
    {
        cookiesDataContext db = new cookiesDataContext();

        //client order record
        public string ClientID { set; get; }
        public int OrderID { set; get; }
        public DateTime OrderDate { set; get; }
        public decimal Payment { set; get; }
        public bool FlagCustomer { set; get; }

        public List<ViewClientOrder> listCustomerOrder { set; get; }
        public List<int> listOrderID { set; get; }
        public int No { set; get; }
        public int Unit { set; get; }
        public decimal Price { set; get; }
        public decimal UnitPrice { set; get; }
        public int VegeID { set; get; }
        public bool FlagOrder { set; get; }
        /*public override string ToString() => 
            $"{No,-7}{OrderID,-24}{OrderDate.ToShortDateString(),-18}{Payment,10}";*/

        //cannot run
        //i am trying
        public List<ViewClientOrder> listVege { set; get; }
        public string VegeName { set; get; }

        public void ViewRecord()
        {
            //check if got client
            var queryClient = db.Clients.Where(c => c.ClientID == ClientID);
            int countCustomer = queryClient.Count();

            if (countCustomer == 0)
                FlagCustomer = false;
            else
            {
                FlagCustomer = true;
                foreach (var c in queryClient)
                {
                    ClientID = Login.CID;
                }

                //check if got order
                var queryClientOrder = db.Orders.Where(qOrder => qOrder.ClientID == ClientID);
                int countOrder = queryClientOrder.Count();
                if (countOrder == 0)
                {
                    FlagOrder = false;
                }
                else
                {
                    FlagOrder = true;
                    listCustomerOrder = new List<ViewClientOrder>();
                    listOrderID = new List<int>();
                    int i = 0;

                    foreach (var co in queryClientOrder)
                    {
                        i++;
                        ViewClientOrder myOrder = new ViewClientOrder();
                        myOrder.No = i;
                        myOrder.OrderID = co.OrderID;
                        myOrder.OrderDate = (DateTime)co.OrderDate;
                        myOrder.Payment = (decimal)co.Payment;
                        listCustomerOrder.Add(myOrder);

                        //store the orderID in list
                        listOrderID.Add(myOrder.OrderID);
                    }
                }
            }
        }

        //cannot run
        //i am trying
        public void ViewVege(int OrderID)
        {
            //var queryJoin = from c in db.Clients
            //                join o in db.Orders
            //                on c.ClientID equals o.ClientID
            //                join vo in db.Vege_Orders
            //                on o.OrderID equals vo.OrderID
            //                join v in db.Vegetables
            //                on vo.VegeID equals v.VegeID
            //                orderby vo.Vege_Order_ID
            //                select new { v.VegeName};

            //var queryClientOrder = queryJoin.Where(qOrder => qOrder.OrderID == OrderID).Select(vName=>VegeName);
            // var queryVegeName = queryJoin.Where(oDate=> oDate=OrderDate.ToLongDateString());

            /*var queryJoin = from c in db.Clients
                            join o in db.Orders
                            on c.ClientID equals o.ClientID
                            join vo in db.Vege_Orders
                            on o.OrderID equals vo.OrderID
                            join v in db.Vegetables
                            on vo.VegeID equals v.VegeID
                            orderby o.OrderID
                            select new { v.VegeName, vo.Vege_Order_ID};*/

            var queryJoin = from o in db.Orders
                            join vo in db.Vege_Orders
                            on o.OrderID equals vo.OrderID
                            join v in db.Vegetables
                            on vo.VegeID equals v.VegeID
                            orderby o.OrderID
                            select new { v.VegeName, v.VegeID, vo.Unit, v.VegePricePerKG, vo.Price, o.OrderID};

            var queryID = queryJoin.Where(myVege => myVege.OrderID == OrderID);

            listVege = new List<ViewClientOrder>();
            int i = 0;
            foreach (var ov in queryID)
            {
                i++;
                ViewClientOrder myOrder = new ViewClientOrder();

                myOrder.No = i;
                myOrder.VegeName = ov.VegeName;
                myOrder.Unit = (int)ov.Unit;
                myOrder.UnitPrice = (int)ov.VegePricePerKG;
                myOrder.Price = (decimal)ov.Price;
                myOrder.VegeID = ov.VegeID;

                listVege.Add(myOrder);
            }
        }
    }
}
