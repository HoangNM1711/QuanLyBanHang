﻿using Database.EF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Database.EF.DAO
{
    public class CategoryDAO
    {
        ShopDbContext db = null;

        public CategoryDAO()
        {
            db = new ShopDbContext();
        }

        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null) instance = new CategoryDAO();
                return CategoryDAO.instance;
            }

            private set { CategoryDAO.instance = null; }
        }
        public int CheckCategory(string category)
        {
            var result = db.Categories.SingleOrDefault(x => x.Name == category);
            if (result == null)
            {
                return 1;
            }
            else
                return 0;
        }

        public long AddCategory (Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return category.ID;
        }
        
        public bool UpdateCategory( Category category)
        {
            try
            {
                var cate = db.Categories.Find(category.ID);
                cate.Name = category.Name;
                cate.Stock = category.Stock;
                cate.Sold = category.Sold;
                cate.ModifiedDate = category.ModifiedDate;

                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool DeleteCategory(long id)
        {
            try
            {
                var category = db.Categories.Find(id);
                db.Categories.Remove(category);
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public List<Category> ListAllCategory()
        {
            return db.Categories.OrderBy(x => x.ID).ToList();
        }

        public Category GetCategoryById(long id)
        {
            return db.Categories.SingleOrDefault(x => x.ID == id);
        }

        public IEnumerable<Category>SearchCategory(string searchString)
        {
            IQueryable<Category> cate = db.Categories;
            if (!string.IsNullOrEmpty(searchString))
            {
                cate = cate.Where(x => x.Name.Contains(searchString));
            }
            return cate.OrderByDescending(x => x.CreatedDate).ToList();
        }
    }
}