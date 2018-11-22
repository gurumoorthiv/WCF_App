using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1MVCClient.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        public ActionResult Index(string submit)
        {
            if(string.Equals(submit,"http"))
            { 
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            ViewBag.HelloHttp = client.SayHello("Kumar");
            ViewBag.ProgramHttp = client.TodayProgram("Kumar");
            ViewBag.HelloTcp = string.Empty;
            ViewBag.ProgramTcp = string.Empty;

            }
            else
            {
                ServiceReference1.Service1Client client1 = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
                ViewBag.HelloTcp = client1.SayHello("Kumar");
                ViewBag.ProgramTcp = client1.TodayProgram("Kumar");
                ViewBag.HelloHttp = string.Empty;
                ViewBag.ProgramHttp = string.Empty;
            }
            return View();
        }

        public ActionResult About()
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
}