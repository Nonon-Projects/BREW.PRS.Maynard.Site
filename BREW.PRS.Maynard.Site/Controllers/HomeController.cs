using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BREW.PRS.Maynard.Site.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var data = Request.Headers;
            var bo = Request.Form;
            return View();
        }

        [HttpPost]
        public ActionResult Index(LocatorDto locatorDto)
        {
 
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> MyPost(LocatorDto locatorDto)
        {
            var client = new HttpClient();
            await client.PostAsync("https://dominoapi.azurewebsites.net/api/Locators/Ensure/", locatorDto, new JsonMediaTypeFormatter());
            // var response = await client.PostAsync("https://localhost:44300/api/Locators/Ensure/", locatorDto, new JsonMediaTypeFormatter());

            // var json = JsonConvert.SerializeObject(locatorDto);
            // var data = new StringContent(json, Encoding.UTF8, "application/json");
            //using (var client = new HttpClient())  
            //{   
            //    client.BaseAddress = new Uri("http://localhost:44300/api/Locators/Ensure");
            //    try
            //    {
            //        var response = await client.PostAsync("", data);
            //        var aa = "";
            //    }
            //    catch (Exception e)
            //    {
            //        var a = "";
            //    }
            //}
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://localhost:44300/api/Locators/Ensure");

            //    //HTTP POST
            //    var response = await client.PostAsync(uri, stringContent);
            //   // var postTask = client.PostAsync
            //   // postTask.Wait();

            //    var result = postTask.Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        return RedirectToAction("Index");
            //    }
            //}

            return View("Collection");
        }
        public ActionResult Collection()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
    public class LocatorDto 
    {
        public string Ip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string HostName { get; set; }
        public string Location { get; set; }
        public string Org { get; set; }
        public string Postal { get; set; }
        public string Region { get; set; }
    }
}