using Core.Services;
using Domain.Repositories;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Inventory.Controllers
{
    public class RoleController : Controller
    {
        private UnitOfWork unitOfWork;
        private RoleServices roleService;

        public RoleController()
        {
            unitOfWork = new UnitOfWork();
            roleService = new RoleServices(unitOfWork);
        }
        // GET: Role
        public ActionResult Index()
        {
            var data = roleService.GetAll();
            return View(data);
        }


        // GET: Role/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Role/Create
        [HttpPost]
        public ActionResult Create(RoleViewModel roleVM)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    roleService.Create(roleVM);

                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Role/Details/5
        public ActionResult Details(int id = 0)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            RoleViewModel details = roleService.GetById(id);
            if (details == null)
            {
                return HttpNotFound();
            }
            return View(details);

        }

        // GET: Role/Edit/5
        public ActionResult Edit(int id)
        {
            var edit = roleService.GetById(id);
            return View(edit);
        }

        // POST:  Role/Edit/5
        [HttpPost]
        public ActionResult Edit(RoleViewModel roleVM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add update logic here

                    roleService.Update(roleVM);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        public ActionResult Delete(int id = 0)
        {
            if (id != 0)
            {
                var delete = roleService.GetById(id);
                return View(delete);
            }
            return View();
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    roleService.Delete(id);

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
    }
}
