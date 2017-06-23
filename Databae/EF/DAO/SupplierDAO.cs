using Database.EF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.EF.DAO
{
    public class SupplierDAO
    {
        ShopDbContext db = null;

        public SupplierDAO()
        {
            db = new ShopDbContext();
        }

        private static SupplierDAO instance;

        public static SupplierDAO Instance
        {
            get
            {
                if (instance == null) instance = new SupplierDAO();
                return SupplierDAO.instance;
            }

            private set
            {
                SupplierDAO.Instance = null;
            }
        }

        public int CheckSupplier (string supplier)
        {
            var result = db.Suppliers.SingleOrDefault(x => x.Name == supplier);
            if (result == null)
                return 1;
            else
                return 0;

        }

        public List<Supplier> ListSupplierByStatus()
        {
            return db.Suppliers.Where(x => x.Status == "Đang bán").OrderBy(x => x.Name).ToList();
        }

        public Supplier GetSupplierById(long id)
        {
            return db.Suppliers.SingleOrDefault(x => x.ID == id);
        }
        public long AddSupplier (Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            db.SaveChanges();
            return supplier.ID;
        }

        public bool UpdateSupplier (Supplier supplier)
        {
            try
            {
                var sup = new Supplier();
                sup.Name = supplier.Name;
                sup.ModifiedDate = supplier.ModifiedDate;

                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool UpdateStockSold(Supplier supplier)
        {
            try
            {
                var sup = new Supplier();

                sup.Stock = supplier.Stock;
                sup.Sold = supplier.Sold;
                sup.ModifiedDate = supplier.ModifiedDate;

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteSupplier (long id)
        {
            try
            {
                var sup = db.Suppliers.Find(id);
                db.Suppliers.Remove(sup);
                db.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public IEnumerable<Supplier> SearchSupplier(string searchString)
        {
            IQueryable<Supplier> supplier = db.Suppliers;
            if (!string.IsNullOrEmpty(searchString))
            {
                supplier = supplier.Where(x => x.Name.Contains(searchString) || x.Status.Contains(searchString));
            }
            return supplier.OrderByDescending(x => x.CreatedDate).ToList();
        }
    }
}
