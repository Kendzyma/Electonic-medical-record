using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medical.Data;
using Medical.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Medical.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LoginController(ApplicationDbContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Users log)
        {
            var obj = _db.users.Where(a => a.UserName.Equals(log.UserName) && a.Password.Equals(log.Password)).FirstOrDefault();
            if (obj != null)
            {
                //Session["UserID"] = obj.Id.ToString();
                //Session["UserName"] = obj.UserName.ToString();
            }
            return View();
        }
    }
}
