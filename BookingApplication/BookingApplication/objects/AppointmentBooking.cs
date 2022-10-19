using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.objects
{
    public class AppointmentBooking
    {
        int bookingId;
        DateTime bookingDate;
        int timeSlot;
        string custName;
        string staffName;
        string serviceName;
        int officeRoomNo;
        string status;
        bool deleted;
        string priority;

        public AppointmentBooking()
        {

        }

        public AppointmentBooking(int bookingId, DateTime bookingDate, int timeSlot, string custName, string staffName, string serviceName, int officeRoomNo, string status, bool deleted, string priority)
        {
            this.bookingId = bookingId;
            this.bookingDate = bookingDate;
            this.timeSlot = timeSlot;
            this.custName = custName;
            this.staffName = staffName;
            this.serviceName = serviceName;
            this.officeRoomNo = officeRoomNo;
            this.status = status;
            this.deleted = deleted;
            this.priority = priority;
        }

        public int BookingId
        {
            get { return bookingId; }
            set { bookingId = value; }
        }

        public DateTime BookingDate
        {
            get { return bookingDate; }
            set { bookingDate = value; }
        }

        public int TimeSlot
        {
            get { return timeSlot; }
            set { timeSlot = value; }
        }

        public string CustomerName
        {
            get { return custName; }
            set { custName = value; }
        }

        public string StaffName
        {
            get { return staffName; }
            set { staffName = value; }
        }

        public string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }

        public int RoomNo
        {
            get { return officeRoomNo; }
            set { officeRoomNo = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        public string Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public override string ToString()
        {
            return "Appointment \n " + custName + " \n " + status;

        }

    }
}
