using SinglePage1.Models.DomainModels.DTO.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinglePage1.Models.VIewModels
{
    public class ProductViewModel
    {
        #region [- ctor -]
        public ProductViewModel()
        {
            Ref_ProductRepository = new DomainModels.POCO.ProductRepository();
            Ref_Products = new DomainModels.DTO.EF.Product();
        }
        #endregion

        #region [- props -]

        #region [- props for class -]
        public Models.DomainModels.POCO.ProductRepository Ref_ProductRepository { get; set; }
        public Models.DomainModels.DTO.EF.Product Ref_Products { get; set; }
        #endregion

        #region [- props for model -]
        public int? Id
        {
            get { return Ref_Products.Id; }
            set { Ref_Products.Id = value; }
        }
        public int? Code
        {
            get { return Ref_Products.Code; }
            set { Ref_Products.Code = value; }
        }
        public string Title
        {
            get { return Ref_Products.Title; }
            set { Ref_Products.Title = value; }
        }
        public int? UnitPrice
        {
            get { return Ref_Products.UnitPrice; }
            set { Ref_Products.UnitPrice = value; }
        }
        public int? Countity
        {
            get { return Ref_Products.Countity; }
            set { Ref_Products.Countity = value; }
        }

        #endregion

        #endregion

        #region [- Methods -]

        #region [- GetProduct() -]
        public List<DomainModels.DTO.EF.Product> GetProduct()
        {
            var products = Ref_ProductRepository.Select();
            return products;
        }
        #endregion

        #region [- PostProduct(ProductViewModel productViewModel) -]
        public void PostProduct(ProductViewModel productViewModel)
        {
            Product ref_Product = new Product();
            ref_Product.Code = productViewModel.Code;
            ref_Product.Title = productViewModel.Title;
            ref_Product.UnitPrice = productViewModel.UnitPrice;
            ref_Product.Countity = productViewModel.Countity;
            Ref_ProductRepository.Insert(ref_Product);
        }
        #endregion

        #region [- FindProducts(int? id) -]
        public ProductViewModel FindProducts(int? id)
        {
            var ref_product = Ref_ProductRepository.FindProduct(id);
            ProductViewModel ref_ProductViewModel = new ProductViewModel();
            ref_ProductViewModel.Id = ref_product.Id;
            ref_ProductViewModel.Code = ref_product.Code;
            ref_ProductViewModel.Title = ref_product.Title;
            ref_ProductViewModel.UnitPrice = ref_product.UnitPrice;
            ref_ProductViewModel.Countity = ref_product.Countity;
            return ref_ProductViewModel;

        }
        #endregion

        #region [- PutProduct(ProductViewModel ref_productViewModel) -]
        public void PutProduct(ProductViewModel ref_productViewModel)
        {
            var ref_product = new Product();
            //ref_product.Id = (int)ref_productViewModel.Id;
            ref_product.Id = ref_productViewModel.Id;
            ref_product.Code = ref_productViewModel.Code;
            ref_product.Title = ref_productViewModel.Title;
            ref_product.UnitPrice = ref_productViewModel.UnitPrice;
            ref_product.Countity = ref_productViewModel.Countity;
            Ref_ProductRepository.Update(ref_product);

        }
        #endregion

        #region [- DeleteProduct(int? id) -]
        public void DeleteProduct(ProductViewModel ref_productViewModel)
        {
            var id = ref_productViewModel.Id;
            Ref_ProductRepository.Delete(id);
        }
        #endregion

        #endregion
    }
}