﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryStore.AddressModel;
using OnlineGroceryStore.AdminDetailsModel;
using OnlineGroceryStore.CategoryProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore.Models
{
    public class CategorysController : Controller
    {
        // GET: CategorysController
        public ActionResult Index()
        {
            OnlineGroceryStoreDBContext ogsd = new OnlineGroceryStoreDBContext();

            return View(ogsd.Categories.ToList());
        }

        // GET: CategorysController/Details/5
        public ActionResult Details(int id)
        {
            OnlineGroceryStoreDBContext ogsd = new OnlineGroceryStoreDBContext();

            return View(ogsd.Categories.ToList());
        }

        // GET: CategorysController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategorysController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(AddressModel.Category obj)
        {
            try
            {
                OnlineGroceryStoreDBContext ogsd = new OnlineGroceryStoreDBContext();
                ogsd.Categories.Add(obj);
                ogsd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CategorysController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategorysController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategorysController/Delete/5
        public ActionResult Delete(int id)
        {
            OnlineGroceryStoreDBContext ogsd = new OnlineGroceryStoreDBContext();
            AddressModel.Category cat = ogsd.Categories.FirstOrDefault(i=> i.CategoryId ==id);
            return View(cat);
        }

        // POST: CategorysController/Delete/5
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult Delete()
        {
            try
            {
                OnlineGroceryStoreDBContext ogsd = new OnlineGroceryStoreDBContext();
                int id = int.Parse(Request.Form["DeleteCategoryId"].ToString());
                AddressModel.Category cat = ogsd.Categories.FirstOrDefault(i=> i.CategoryId == id);
                ogsd.Categories.Remove(cat);
                ogsd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
