using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BR.Soccer.Models;

namespace BR.Soccer.Controllers
{
    public class TournamentController : Controller
    {
        //
        // GET: /Tournament/

        public ActionResult Index()
        {
            var tournamentList = new List<Tournament>()
            {
                new Tournament { Id = 1, Name = "FIFA 4 Star Challenge" }
            };

            return View(tournamentList);
        }

        //
        // GET: /Tournament/Details/5

        public ActionResult Details(int id)
        {
            var tournament = new Tournament { Id = 1, Name = "FIFA 4 Star Challenge" };

            return View(tournament);
        }

        //
        // GET: /Tournament/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tournament/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        //
        // GET: /Tournament/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Tournament/Edit/5

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

        //
        // GET: /Tournament/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Tournament/Delete/5

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
    }
}
