using Core.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;


namespace DataAccess.Abstract
{
  public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
