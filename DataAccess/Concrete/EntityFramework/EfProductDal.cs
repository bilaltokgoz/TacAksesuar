using Core.Entities;
using Core.Concrete.EfRepository;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
//using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfRepository<Product, EfContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (EfContext context = new EfContext())
            {
                var result =
                              from c in context.Categories
                              join p in context.Products on c.CategoryId equals p.CategoryId
                              select new ProductDetailDto
                              {
                                  CategoryName = c.CategoryName,
                                  ProductName = p.ProductName,
                                  ProductId = p.ProductId,
                                  UnitsInStock = p.UnitsInStock,
                              };

                return result.ToList();
            }
        }
    }
}

