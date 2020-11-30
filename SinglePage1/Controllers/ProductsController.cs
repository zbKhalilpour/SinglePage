using SinglePage1.Models.VIewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SinglePage1.Controllers
{
    public class ProductsController : Controller
    {
        #region [- ctor -]
        public ProductsController()
        {
            Ref_ProductViewModel = new Models.VIewModels.ProductViewModel();
        }
        #endregion

        #region [- props -]
        public Models.VIewModels.ProductViewModel Ref_ProductViewModel { get; set; }
        #endregion

        #region [- Actions -]

        #region [- Product() -]
        public ActionResult Product()
        {
            return View(Ref_ProductViewModel);
        }
        #endregion

        #region [- Create() -]
        [HttpPost]
        // [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Create(ProductViewModel ref_ProductViewModel)
        {

            if (ModelState.IsValid)
            {
                Ref_ProductViewModel.PostProduct(ref_ProductViewModel);
                return Json(new { Message = "Success" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    ModelState_IsValid = "False",
                    JsonRequestBehavior.AllowGet
                });
            }
        }
        #endregion

        #region [- Edit(ProductViewModel ref_productsViewModel) -]
        //[HttpPost]
        //[AllowAnonymous]
        //public ActionResult Edit(ProductViewModel ref_productsViewModel)
        //{
        //    if (ref_productsViewModel.Id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    if (ref_productsViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        Ref_ProductViewModel.PutProduct(ref_productsViewModel);
        //        return Json(true, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new
        //        {
        //            ModelState_IsValid = "False",
        //            JsonRequestBehavior.AllowGet
        //        });
        //    }

        //}
        [HttpPost]
        // [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Edit(ProductViewModel ref_ProductViewModel)
        {

            if (ModelState.IsValid)
            {
                Ref_ProductViewModel.PutProduct(ref_ProductViewModel);
                return Json(new { Message = "Success" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    ModelState_IsValid = "False",
                    JsonRequestBehavior.AllowGet
                });
            }
        }
        #endregion

        #region [- Delete -]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        //[HttpDelete]
        [AllowAnonymous]
        //[Route("Delete")]
        public ActionResult Delete(ProductViewModel ref_ProductViewModel)
        {  
            if (ModelState.IsValid)
            {
                Ref_ProductViewModel.DeleteProduct( ref_ProductViewModel);
                return Json(new { Message = "Success" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    ModelState_IsValid = "False",
                    JsonRequestBehavior.AllowGet
                });
            }
        }
        
        #endregion

    #endregion

    }

}