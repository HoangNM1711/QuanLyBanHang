using Database.EF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.EF.DAO
{
    public class ProductDAO
    {
        ShopDbContext db = null;

        public ProductDAO()
        {
            db = new ShopDbContext();
        }

        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get
            {
                if (instance == null) instance = new ProductDAO();
                return ProductDAO.instance;
            }

           private set
            {
                ProductDAO.instance = null;
            }
        }

        public long AddProduct (Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return product.CategoryID;
        }

        public List<Product> ListAllProduct ()
        {
            return db.Products.OrderBy(x => x.ID).ToList();
        }

        public Product GetProductById (long id)
        {
            return db.Products.SingleOrDefault(x => x.ID == id);
        }

        public int CheckProduct(string product)
        {
            var result = db.Products.SingleOrDefault(x => x.Name == product);
            if (result == null)
            {
                return 1;
            }
            else
                return 0;
        }
    }
}