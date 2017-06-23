using Database.EF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.EF.DAO
{
    public class OrderDetailDAO
    {
        ShopDbContext db = null;

        public OrderDetailDAO()
        {
            db = new ShopDbContext();
        }

        private static OrderDetailDAO instance;

        public static OrderDetailDAO Instance
        {
            get
            {
                if (instance == null) instance = new OrderDetailDAO();
                return OrderDetailDAO.instance;
            }

            private set
            {
                OrderDetailDAO.instance = null;
            }
        }

        public long AddOrderDetail(OrderDetail od)
        {
            db.OrderDetails.Add(od);
            db.SaveChanges();
            return od.OrderID;
        }

        public bool UpdateOrderDetail(OrderDetail OD)
        {
            try
            {
                var ODetail = new OrderDetail();

                ODetail.Price = OD.Price;
                ODetail.Quantity = OD.Quantity;
                ODetail.ModifiedDate = OD.ModifiedDate;

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteOrderDetail(long id)
        {
            try
            {
                var item = db.OrderDetails.Find(id);
                db.OrderDetails.Remove(item);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<OrderDetail> ListProductByOrderId(long orderid)
        {
            return db.OrderDetails.Where(x => x.OrderID == orderid).ToList();
        }
        public OrderDetail GetOrderDetailById(long id)
        {
            return db.OrderDetails.SingleOrDefault(x => x.ID == id);
        }
    }
}
