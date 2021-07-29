using Microsoft.AspNetCore.Mvc;
using ReportedeTiempoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ReportedeTiempoMVC.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult<LoginViewModel> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel login)
        {
            Uri url = new Uri("https://localhost:44310/api/Login");

            HttpClient client = new HttpClient();

            await client.PostAsJsonAsync<LoginViewModel>(url, login);

            if (!ModelState.IsValid)
            {
                return BadRequest("Datos no válidos");
            }

            var message = new HttpResponseMessage();

            message.StatusCode.ToString();

            return RedirectToAction("Index", "Actividades");
        }
    }
}
