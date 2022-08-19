using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductBusiness
    {

        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetBusiness(int id);
        IResult AddProduct();
        IResult UpdateProduct(Product product);
        IResult DeleteProduct(Product product);
    }
}
