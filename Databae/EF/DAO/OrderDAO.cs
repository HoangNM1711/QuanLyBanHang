using Database.EF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.EF.DAO
{
    public class OrderDAO
    {
        ShopDbContext db = null;
        public OrderDAO()
        {
            db = new ShopDbContext();
        }

        private static OrderDAO instance;

        public static OrderDAO Instance
        {
            get
            {
                if (instance == null) instance = new OrderDAO();
                return OrderDAO.instance;
            }
            private set
            {
                OrderDAO.instance = null;
            }
        }

        public long AddOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order.ID;
        }

        public bool UpdateOrder(Order order)
        {
            try
            {
                var orDer = new Order();

                orDer.CustomerName = order.CustomerName;
                orDer.CustomerAddress = order.CustomerAddress;
                orDer.CustomerPhone = order.CustomerPhone;
                orDer.CustomerEmail = order.CustomerEmail;
                orDer.ModifiedDate = order.ModifiedDate;
                orDer.Status = order.Status;

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdatePrice (Order od)
        {
            try
            {
                var orDer = new Order();
                orDer.TotalPrice = od.TotalPrice;
                orDer.ModifiedDate = od.ModifiedDate;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteOrder(long id)
        {
            try
            {
                var order = db.Orders.Find(id);
                db.Orders.Remove(order);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Order> ListOrderByStatus ()
        {
            return db.Orders.Where(x => x.Status == "Đang xử lý").ToList();
        }

        public Order GetOrderById(long id)
        {
            return db.Orders.SingleOrDefault(x => x.ID == id);
        }

        public IEnumerable<Order> SearchOrder(string searchString)
        {
            IQueryable<Order> order = db.Orders;
            if (!string.IsNullOrEmpty(searchString))
            {
                order = order.Where(x => x.CustomerName.Contains(searchString) || x.CustomerAddress.Contains(searchString)
                                        || x.CustomerEmail.Contains(searchString) || x.CustomerPhone.Contains(searchString)
                                        || x.Status.Contains(searchString));
            }
            return order.OrderByDescending(x => x.CreatedDate).ToList();
        }
    }
}
