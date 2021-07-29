using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Polly;
using ReportedeTiempoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ReportedeTiempoMVC.Controllers
{
    public class ActividadesController : Controller
    {
        public ActionResult ObtenerActividades()
        {
            //IEnumerable<ActividadesViewModel> actividades = null;

            //using (var cliente = new HttpClient())
            //{
            //    cliente.BaseAddress = new Uri("https://localhost:44310/api/");

            //    //HTTP GET
            //    var responseTask = cliente.GetAsync("actividades");

            //    responseTask.Wait();

            //    var result = responseTask.Result;

            //    if (result.IsSuccessStatusCode)
            //    {
            //        var readTask = result.Content.ReadAsAsync<List<ActividadesViewModel>>();

            //        readTask.Wait();

            //        actividades = readTask.Result;
            //    }
            //    else
            //    {
            //        actividades = Enumerable.Empty<ActividadesViewModel>();

            //        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            //    }
            //}

            return View();
        }

        //public async Task<ActionResult> Index()
        //{
        //    var answer = new List<ActividadesViewModel>();

        //    Uri url = new Uri("https://localhost:44310/api/actividades");

        //    var response = await ConsumeService(url).ConfigureAwait(false);

        //    if (!string.IsNullOrEmpty(response))
        //    {
        //        answer = JsonConvert.DeserializeObject<List<ActividadesViewModel>>(response);
        //    }

        //    return View(answer);
        //}

        //public async Task<string> ConsumeService(Uri url)
        //{
        //    using var httpClient = new HttpClient();

        //    using var response = await Policy.HandleResult<HttpResponseMessage>(message => !message.IsSuccessStatusCode)
        //            .WaitAndRetryAsync(3, i => TimeSpan.FromSeconds(2), (result, TimeSpan, retryCount, context) => { })
        //            .ExecuteAsync(() => httpClient.GetAsync(url)).ConfigureAwait(false);

        //    return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        //}

        //[HttpGet]
        //public ActionResult<ActividadesViewModel> CreateActividad()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult CreateActividad(ActividadesViewModel actividades)
        //{
        //    Uri url = new Uri("https://localhost:44310/api/actividades");

        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = url;

        //        var insertAct = client.PostAsJsonAsync<ActividadesViewModel>("actividades", actividades);

        //        insertAct.Wait();

        //        var result = insertAct.Result;

        //        if (result.IsSuccessStatusCode)
        //        {
        //            return RedirectToAction("Index");
        //        }
        //    }

        //    return View();
        //}

        //public ActionResult<ActividadesViewModel> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    return View();
        //}
    }
}
