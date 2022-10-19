using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingApplication.objects;
using BookingApplication.dbAccess;

namespace BookingApplication
{
    public class AdviceDBAccess
    {
        private Database db;
        private CustomerDBAccess custDBAccess;
        private AppointmentBookingDBAccess bookingDBAccess;
        private OfficeDBAccess officeDBAccess;
        private StaffServiceDBAccess staffServiceDBAccess;
        private ServiceDBAccess serviceDBAccess;
        private StaffDBAccess staffDBAccess;

        public AdviceDBAccess(Database db)
        {
            this.db = db;
            custDBAccess = new CustomerDBAccess(db);
            bookingDBAccess = new AppointmentBookingDBAccess(db);
            officeDBAccess = new OfficeDBAccess(db);
            staffServiceDBAccess = new StaffServiceDBAccess(db);
            serviceDBAccess = new ServiceDBAccess(db);
            staffDBAccess = new StaffDBAccess(db);
        }

        public CustomerDBAccess CustDBAccess
        {
            get { return custDBAccess; }
            set { custDBAccess = value; }
        }

        public AppointmentBookingDBAccess BookingDBAccess
        {
            get { return bookingDBAccess; }
            set { bookingDBAccess = value; }
        }

        public OfficeDBAccess OfficeDBAccess
        {
            get { return officeDBAccess; }
            set { officeDBAccess = value; }
        }

        public StaffServiceDBAccess StaffServiceDBAccess
        {
            get { return staffServiceDBAccess; }
            set { staffServiceDBAccess = value; }
        }

        public ServiceDBAccess ServiceDBAccess
        {
            get { return serviceDBAccess; }
            set { serviceDBAccess = value; }
        }

        public StaffDBAccess StaffDBAccess
        {
            get { return staffDBAccess; }
            set { staffDBAccess = value; }
        }
    }
}
