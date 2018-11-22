using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobOpeningClient.Models
{
    public class JobOpeningModel
    {
        public string Role { get; set; }
        public List<ServiceReference1.JobOpening> JobOpenings { get; set; }
    }
}