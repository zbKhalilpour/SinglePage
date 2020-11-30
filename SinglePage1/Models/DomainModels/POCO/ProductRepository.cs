using SinglePage1.Models.DomainModels.DTO.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SinglePage1.Models.DomainModels.POCO
{
    public class ProductRepository
    {
        #region [- ctor -]
        public ProductRepository()
        {

        }
        #endregion

        #region [- Tasks -]

        #region [- Select() -]
        public List<DTO.EF.Product> Select()
        {
            using (var context = new Models.DomainModels.DTO.EF.OnlineStoreEntities())
            {
                try
                {
                    var q = context.Products.ToList();
                    return q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                        context.Dispose();
                }
            }
        }
        #endregion

        #region [- Insert(Products products) -]
        public void Insert(Product products)
        {
            using (var context = new Models.DomainModels.DTO.EF.OnlineStoreEntities())
            {
                try
                {
                    context.Products.Add(products);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                        context.Dispose();
                }
            }
        }
        #endregion

        #region [- FindId() -]
        public Product FindProduct(int? id)
        {
            using (var context = new Models.DomainModels.DTO.EF.OnlineStoreEntities())
            {
                try
                {
                    var q = context.Products.Find(id);
                    return q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                        context.Dispose();
                }
            }
        }
        #endregion

        #region [- Update(Product ref_products) -]
        public void Update(Product ref_products)
        {
            using (var context = new Models.DomainModels.DTO.EF.OnlineStoreEntities())
            {
                try
                {
                    context.Entry(ref_products).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                        context.Dispose();
                }
            }
        }
        #endregion

        #region [- Delete(int? id) -]
        public void Delete(int? id)
        {

            {
                using (var context = new Models.DomainModels.DTO.EF.OnlineStoreEntities())
                {
                    try
                    {
                        var q = context.Products.Find(id);
                        context.Products.Remove(q);
                        context.SaveChanges();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {
                        if (context != null)
                            context.Dispose();
                    }
                }
            }
        }
        #endregion

        #endregion
    }
}