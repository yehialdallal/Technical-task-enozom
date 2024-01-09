using Repository.Context;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.rep
{
    public class ProductRepository : IRepository
    {
        private readonly MyContext _context;

        public ProductRepository(MyContext context)
        {
            _context = context;
        }  
        public List<Product> Search(string name)
        {
            List<Product> categoriesMatching = (from p in _context.Products
                                                join cp in _context.CategoriesProducts on p.Id equals cp.ProductId
                                                join c in _context.Categories on cp.CategoryId equals c.Id
                                                where c.Name.ToLower().Contains(name.ToLower())
                                                || p.Name.ToLower().Contains(name.ToLower())
                                                select new Product
                                                {
                                                    Id = p.Id,
                                                    Name = p.Name
                                                }).Distinct().ToList();
            return categoriesMatching;
        }
    }
}
