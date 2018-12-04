using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AjaxExample.Models;

namespace AjaxExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("process")]
        public JsonResult Process(Person newPerson)
        {
            if(ModelState.IsValid)
            {
                return Json(newPerson);
            }
            return Json(ModelState.Values);
        }

    }
}
