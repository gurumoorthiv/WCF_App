using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JobOpenings
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private List<JobOpening> _jobOpenings;
        public Service1()
        {
            _jobOpenings = new List<JobOpening>();
            _jobOpenings.Add(new JobOpening() { JobDescription = "Development", Role = "Developer" });
            _jobOpenings.Add(new JobOpening() { JobDescription = "Design and Development", Role = "Senior Developer" });
            _jobOpenings.Add(new JobOpening() { JobDescription = "Testing the software", Role = "Tester" });
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<JobOpening> OpeningJobs()
        {
            return _jobOpenings;
        }

        public List<JobOpening> OpeningJobsByRole(string role)
        {
            return _jobOpenings.Where(x => x.Role.ToLower() == role.ToLower()).ToList();
        }
    }
}
