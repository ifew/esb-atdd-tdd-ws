using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web.Models;

namespace web.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Confirmation(RegisterModel registerModel)
        {
            ViewData["registerModel.txt_CardNo"] = registerModel.txt_CardNo;
            ViewData["registerModel.txt_CardID"] = registerModel.txt_CardID;
            ViewData["registerModel.txt_BirthDate"] = registerModel.txt_BirthDate;
            ViewData["registerModel.txt_MobileNo"] = registerModel.txt_MobileNo;
            return View();
        }

        public IActionResult Finish()
        {
            return View();
        }

    }
}
