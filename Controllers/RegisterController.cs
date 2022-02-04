using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medical.Data;
using Medical.Models;
using Microsoft.AspNetCore.Mvc;

namespace Medical.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDbContext _db;
        public RegisterController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            return View();
        }

        //Post - register

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Users use)
        {
            if (ModelState.IsValid)
            {

                _db.users.Add(use);
                _db.SaveChanges();
                TempData["Message"] = "Success";
                return RedirectToAction("index");
            }
            return View();



        }

    }
}