using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15
{
    class VegetablesClient : Login 
    {
        cookiesDataContext db = new cookiesDataContext();

        public void SaveBridge(List<string> ListVege, List<int> ListUnit, List<decimal> ListPrice)
        {
            Order order = new Order();
            order.OrderID = OrderID;
            order.ClientID = CID;
            order.OrderDate = ODate;
            order.Payment = (decimal)TotalPayment;

            db.Orders.InsertOnSubmit(order);
            for (int i = 0; i < ListVege.Count(); i++)
            {
                VName = ListVege[i];
                Unit = ListUnit[i];
                Price = ListPrice[i];

                var queryVege = db.Vegetables.Where(vege => vege.VegeName == VName).Select(vege => vege.VegeID);

                foreach (var qv in queryVege)
                    VegeID = qv;

                Vege_Order vo = new Vege_Order();
                vo.OrderID = OrderID;
                vo.VegeID = VegeID;
                GenerateBridgeID();
                vo.Vege_Order_ID = VO_ID;
                vo.Unit = Unit;
                vo.Price = (decimal)Price;

                db.Vege_Orders.InsertOnSubmit(vo);
                db.SubmitChanges();
            }
        }

        public void GenerateOrderID()
        {
            int rowOrderCount =
                (from order in db.Orders
                 select order.OrderID).Max();
            OrderID = ++rowOrderCount;
        }

        public void GenerateBridgeID()
        {
            int rowBridgeCount =
                (from vo in db.Vege_Orders
                 select vo.Vege_Order_ID).Max();
            VO_ID = ++rowBridgeCount;
        }

        public IEnumerable<string> ShowVegeName()
        {
            IEnumerable<string> queryDisplayVege =
                from VName in db.Vegetables
                select VName.VegeName;

            return queryDisplayVege;
        }

        public IQueryable<double?> ShowVegePrice(int num)
        {
            IQueryable<double?> queryVegePrice =
                from VPrice in db.Vegetables
                where VPrice.VegeID == num
                select VPrice.VegePricePerKG;

            return queryVegePrice;
        }
    }
}
