using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.objects
{
    public class Service
    {
        int serviceId;
        string serviceName;
        string serviceDesc;

        public Service()
        {
        }

        public Service(int serviceId, string serviceName, string serviceDesc)
        {
            this.serviceId = serviceId;
            this.serviceName = serviceName;
            this.serviceDesc = serviceDesc;
        }
        
        public int ServiceId
        {
            get { return serviceId; }
            set { serviceId = value; }
        }

        public string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }

        public string ServiceDesc
        {
            get { return serviceDesc; }
            set { serviceDesc = value; }
        }

        public override string ToString()
        {

            return serviceName + " (ID: " + ServiceId + ")";

        }
    }
}
