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
            return product.ID;
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                var pro = new Product();
                pro.Name = product.Name;
                pro.Stock = product.Stock;
                pro.Price = product.Price;
                pro.Sold = product.Sold;
                pro.ModifiedDate = product.ModifiedDate;
                pro.Status = product.Status;
                pro.CategoryID = product.CategoryID;
                pro.SupplierID = product.SupplierID;

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteProduct(long id)
        {
            try
            {
                var product = db.Products.Find(id);
                db.Products.Remove(product);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Product> ListProductByStatus()
        {
            return db.Products.Where(x => x.Status == "Đang bán").OrderBy(x => x.ID).ToList();
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
        public IEnumerable<Product> SearchProduct(string searchString) //Tìm kiếm
        {
            IQueryable<Product> product = db.Products;
            if (!string.IsNullOrEmpty(searchString))
            {
                product = product.Where(x => x.Name.Contains(searchString) || x.Status.Contains(searchString));
            }
            return product.OrderByDescending(x => x.CreatedDate).ToList();
        }
    }
}