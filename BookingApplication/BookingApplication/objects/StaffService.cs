using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.objects
{
    public class StaffService
    {
        int staffServiceId;
        int staffId;
        int serviceId;

        //Constructors
        public StaffService()
        {
        }

        public StaffService(int staffServiceId, int staffId, int serviceId)
        {
            this.staffServiceId = staffServiceId;
            this.staffId = staffId;
            this.serviceId = serviceId;
        }

        //Methods
        public int StaffServiceId
        {
            get { return staffServiceId; }
            set { staffServiceId = value; }
        }

        public int StaffId
        {
            get { return staffId; }
            set { staffId = value; }
        }

        public int ServiceId
        {
            get { return serviceId; }
            set { serviceId = value; }
        }

    }
}
