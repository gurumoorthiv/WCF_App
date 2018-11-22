using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobOpeningClient.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            
            Models.JobOpeningModel model = new Models.JobOpeningModel();
            model.JobOpenings = new List<ServiceReference1.JobOpening>();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(string submit, JobOpeningClient.ServiceReference1.JobOpening model)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            Models.JobOpeningModel jobModel = new Models.JobOpeningModel();
            var role = string.IsNullOrEmpty(model.Role) ? string.Empty : model.Role;

            if (submit == "Get Job Opening By Role")
            {
                jobModel.JobOpenings = client.OpeningJobsByRole(role).ToList();
            }
            else
            {
                jobModel.JobOpenings = client.OpeningJobs().ToList();
            }
            return View(jobModel);
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