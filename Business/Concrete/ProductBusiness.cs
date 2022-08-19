
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductDal productDal;
        public ProductBusiness(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public IDataResult< List<ProductDetailDto>> GetProductDetails()
        {
           
            try
            {
                SuccessDataResult<List<ProductDetailDto>> successDataResult = new SuccessDataResult<List<ProductDetailDto>>(productDal.GetProductDetails());
                return successDataResult;
            }
            catch (Exception)
            {

                return new ErrorDataResult<List<ProductDetailDto>>();
            }
        }
        public IDataResult<Product> GetBusiness(int id)
        {
         
            try
            {
                Product product = productDal.Get(P => P.ProductId == id);
                SuccessDataResult<Product> successDataResult = new SuccessDataResult<Product>(product,"ürün geldi");
                return successDataResult;
            }
            catch (Exception)
            {

                return new ErrorDataResult<Product>();
            }
        }
        public IResult AddProduct()
        {
            try
            {
                Product product = new Product();
                //product.ProductId = 1;
                product.ProductName = "ilk ürün";
                product.CategoryId = 1;
                product.Description = "Eklediğimiz ilk ürün";
                product.UnitsInStock = 1;

                productDal.Add(product);
                SuccessResult successResult =new SuccessResult();
                return successResult;
            }
            catch (Exception )
            {
                return new ErrorResult(false);
            }
            
        }
       public IResult UpdateProduct(Product product)
        {
            try
            {
                productDal.Update(product);
                SuccessResult successResult=new SuccessResult();
                return successResult;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public IResult DeleteProduct(Product product)
        {
           
            try
            {
                productDal.Delete(product);
                SuccessResult successResult = new SuccessResult();
                return successResult;
            }
            catch (Exception )
            {
return new ErrorResult();
            }

        }
    }
}
