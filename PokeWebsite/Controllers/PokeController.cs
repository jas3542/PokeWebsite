﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PokeWebsite.Controllers
{
    public class PokeController : Controller
    {
        // GET: Poke
        public ActionResult Index()
        {
            return View();
        }

        // GET: Poke/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Poke/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Poke/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Poke/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Poke/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Poke/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Poke/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}