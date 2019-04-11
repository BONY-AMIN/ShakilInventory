using Core.Services;
using Domain.Repositories;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.Controllers
{
    public class ProcurementController : Controller
    {

        private UnitOfWork UnitOfWork;
        private ProcurementServices ProcurementServices;
        private ProcrurementTypeServices ProcrurementTypeServices;
        private SupplierCompanyServices SupplierCompanyServices;
        private SubSubSubSubCategoryServices SubSubSubSubCategoryServices;
        private SubSubSubCategoryServices SubSubSubCategoryServices;
        private SubSubCategoryServices SubSubCategoryServices;
        private CategoryServices CategoryServices;
        private SubCategoryServices SubCategoryServices;
        private ItemServices ItemServices;
        private ModelServices ModelServices;
        private BrandServices BrandServices;

        private UnitServices UnitServices;




        public ProcurementController()
        {

            UnitOfWork = new UnitOfWork();
            ProcurementServices = new ProcurementServices(UnitOfWork);
            ProcrurementTypeServices = new ProcrurementTypeServices(UnitOfWork);
            SupplierCompanyServices = new SupplierCompanyServices(UnitOfWork);
            SubSubSubSubCategoryServices = new SubSubSubSubCategoryServices(UnitOfWork);
            SubSubSubCategoryServices = new SubSubSubCategoryServices(UnitOfWork);
            SubSubCategoryServices = new SubSubCategoryServices(UnitOfWork);
            SubCategoryServices = new SubCategoryServices(UnitOfWork);
            CategoryServices = new CategoryServices(UnitOfWork);
            ItemServices = new ItemServices(UnitOfWork);
            ModelServices = new ModelServices(UnitOfWork);
            BrandServices = new BrandServices(UnitOfWork);
            UnitServices = new UnitServices(UnitOfWork);
        }



        // GET: Procurement
        public ActionResult Index()
        {
            ModelState.Clear();
            return View();
        }

        // GET: Procurement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Procurement/Create
        public ActionResult Create()
        {
            loadAll();
            return View();
        }

        // POST: Procurement/Create
        [HttpPost]
        public ActionResult Create(ProcurementViewModel ProcurementViewModel)




        {
            try
            {
                // TODO: Add insert logic here
                 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Procurement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Procurement/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Procurement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Procurement/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public void loadAll()
        {

            SubCategoryViewModel objSubCategory = new SubCategoryViewModel();
            CategoryViewModel objCategory = new CategoryViewModel();
            int i = 0;

            var ProcurementTypeList = ProcrurementTypeServices.GetAll();
            ViewBag.ProcurementTypeList = new SelectList(ProcurementTypeList, "ProcurementTypeId", "ProcurementTypeName");

            var SuplierCompanyList = SupplierCompanyServices.GetAll();
            ViewBag.SuplierCompanyList = new SelectList(SuplierCompanyList, "SupplierCompanyId", "SupplierCompanyName");

            var Itemlist = ItemServices.GetAll();
            ViewBag.Itemlist = new SelectList(Itemlist, "ItemId", "ItemName");

            var CatgoryList = CategoryServices.GetAll(objCategory.CategoryId);
            ViewBag.categorylist = new SelectList(CatgoryList, "CategoryId", "CategoryName");

            var SubCategoryList = SubCategoryServices.GetDropDown(objSubCategory.SubCategoryId);
            ViewBag.subCategorylist = new SelectList(SubCategoryList, "SubCategoryId", "SubCategoryName");

            var SubSubCategoryList = SubSubCategoryServices.GetDropDown(objSubCategory.SubCategoryId);
            ViewBag.subSubCategoryList = new SelectList(SubSubCategoryList, "SubSubCategoryId", "SubSubCategoryName");

            var SubSubSubCategoryList = SubSubSubCategoryServices.GetDropDown(objSubCategory.SubCategoryId);
            ViewBag.subSubSubCategoryList = new SelectList(SubSubSubCategoryList, "SubSubSubCategoryId", "SubSubSubCategoryName");

            var SubSubSubSubCategoryList = SubSubSubSubCategoryServices.GetDropDown(objSubCategory.SubCategoryId);
            ViewBag.SubSubSubSubCategoryList = new SelectList(SubSubSubSubCategoryList, "SubSubSubSubCategoryId", "SubSubSubSubCategoryName");

            var BrandList = BrandServices.GetAll(i);
            ViewBag.BrandList = new SelectList(BrandList, "BrandId", "BrandName");


            var ModelList = ModelServices.GetAll(i);
            ViewBag.ModelList = new SelectList(ModelList, "ModelId", "ModelName");

            var UnitList = UnitServices.GetAll(i);
            ViewBag.UnitList = new SelectList(UnitList, "UnitId", "UnitName");




        }

        public JsonResult GETAll(int Itemid)
        {
            var data = ItemServices.GetDropDown(Itemid);
            return Json(data, JsonRequestBehavior.AllowGet);
        }




        public JsonResult GETCategory(int Itemid)
        {
            var data = CategoryServices.GetDropDown(Itemid);
            return Json(data, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GETSubCategory(int CategoryId)
        {
            var data = SubCategoryServices.GetDropDown(CategoryId);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GETSubSubCategory(int SubCategoryId)
        {
            var data = SubSubCategoryServices.GetDropDown(SubCategoryId);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GETSubSubSubCategory(int SubSubCategoryId)
        {
            var data = SubSubSubCategoryServices.GetDropDown(SubSubCategoryId);
            return Json(data, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GETSubSubSubSubCategory(int SubSubSubCategoryId)
        {
            var data = SubSubSubSubCategoryServices.GetDropDown(SubSubSubCategoryId);
            return Json(data, JsonRequestBehavior.AllowGet);
        }


       









    }
}
