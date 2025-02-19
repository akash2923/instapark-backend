using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instapark.IPmodels
{
    public class ServiceResponse
    {
        public List<Message> Messages { get; set; }
        public ServiceStatusType Status { get; set; }

        public ServiceResponse()
        {
            Status = ServiceStatusType.Failure;
            Messages = new List<Message>();
        }
    }
}