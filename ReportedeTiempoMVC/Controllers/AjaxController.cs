﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportedeTiempoMVC.Controllers
{
    public class AjaxController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
