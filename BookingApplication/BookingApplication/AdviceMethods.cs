using BookingApplication.exceptions;
using BookingApplication.objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingApplication
{
    public class AdviceMethods
    {
        private Database db;

        public AdviceMethods(Database db)
        {
            this.db = db;
        }

        //Age Calculation Method that return age as an interger
        public int calcAge(DateTime DOB)
        {
            int age = Convert.ToInt32(DateTime.Now.Year - DOB.Year);
            if (DateTime.Now.DayOfYear < DOB.DayOfYear)
            {
                age -= 1;
            }
            return age;
        }

        public Customer existingCustomerData(int custId)
        {
            Customer custObj = new Customer();
            return custObj;
        }

        public DataTable customerDataTable(List<Customer> customers)
        {
            DataTable dt = new DataTable(); //Datatable is created to organise columns and rows
            dt.Columns.Add("custId"); // Adding columns for storing each row
            dt.Columns.Add("custName");

            foreach (Customer cust in customers) // Each row is a different customer
            {
                dt.Rows.Add(cust.CustomerId, cust.Forename + " " + cust.Surname + " (ID: " + cust.CustomerId + ")"); //Data I want displayed
            }

            return dt;
        }

        public DataTable officeDataTable(List<Office> offices)
        {
            DataTable dt = new DataTable(); //Datatable is created to organise columns and rows
            dt.Columns.Add("officeId"); // Adding columns for storing each row
            dt.Columns.Add("officeDisplay");

            foreach (Office office in offices) // Each row is a different customer
            {
                dt.Rows.Add(office.OfficeId, "Office Room: " + office.RoomNo + " Floor: " + office.FloorNo); //Data I want displayed
            }

            return dt;
        }

        public DataTable serviceDataTable(List<Service> services)
        {
            DataTable dt = new DataTable(); //Datatable is created to organise columns and rows
            dt.Columns.Add("servID");
            dt.Columns.Add("servName");

            foreach (Service serv in services) // Each row is a different customer
            {
                dt.Rows.Add(serv.ServiceId, serv.ServiceName); //Data I want displayed
            }

            return dt;
        }

        public DataTable staffDataTable(List<Staff> staff)
        {
            DataTable dt = new DataTable(); //Datatable is created to organise columns and rows
            dt.Columns.Add("staffId");
            dt.Columns.Add("staffString");

            foreach (Staff s in staff) // Each row is a different customer
            {
                dt.Rows.Add(s.StaffId, s.Forename + " " + s.Surname + " ( ID: " + s.StaffId + " ) "); //Data I want displayed
            }

            return dt;
        }

        public DataTable timeDataTable(List<int> timeSlots)
        {
            DataTable dt = new DataTable(); //Datatable is created to organise columns and rows
            dt.Columns.Add("timeValue");
            dt.Columns.Add("timeDisplay");

            foreach (int timeslotId in timeSlots) // Each row is a different customer
            {
                dt.Rows.Add(timeslotId, timeSlotToString(timeslotId)); //Data I want displayed
            }

            return dt;
        }

        public DataTable bookingsDataTable(List<AppointmentBooking> bookings)
        {
            return new DataTable();
        }

        //Con
        public string timeSlotToString(int timeSlot)
        {
            switch (timeSlot)
            {
                case 1:
                    return "10:00 - 11:00";
                case 2:
                    return "11:00 - 12:00";
                case 3:
                    return "13:00 - 14:00";
                case 4:
                    return "14:00 - 15:00";
                default:
                    return "Invalid Time Slot";
            }
        }

        public bool checkIfOfficeIsInList(int officeId, List<Office> officeList)
        {
            foreach (Office office in officeList)
            {
                if (officeId == office.OfficeId)
                {
                    return true;
                }
            }
            return false;
        }

        public bool checkIfStaffIsInList(int staffId, List<Staff> staffList)
        {
            foreach (Staff staff in staffList)
            {
                if (staffId == staff.StaffId)
                {
                    return true;
                }
            }
            return false;
        }

        //If today, check if time is passed (Only applicable to today)
        public List<int> returnAvailableTimeSlotsList()
        {
            List<int> timeSlots = new List<int>() { 1, 2, 3, 4 };

            for (int i = timeSlots.Count - 1; i >= 0; i--)
            {
            switch(timeSlots[i])
                {
                    case 1:
                        if (DateTime.Now.TimeOfDay > DateTime.Parse("2000/12/12 11:00:00.000").TimeOfDay)
                        {
                            timeSlots.RemoveAt(i);
                        }
                        break;
                    case 2:
                        if (DateTime.Now.TimeOfDay > DateTime.Parse("2000/12/12 12:00:00.000").TimeOfDay)
                        {
                            timeSlots.RemoveAt(i);
                        }
                        break;
                    case 3:
                        if (DateTime.Now.TimeOfDay > DateTime.Parse("2000/12/12 14:00:00.000").TimeOfDay)
                        {
                            timeSlots.RemoveAt(i);
                        }
                        break;
                    case 4:
                        if(DateTime.Now.TimeOfDay > DateTime.Parse("2000/12/12 15:00:00.000").TimeOfDay)
                        {
                            timeSlots.RemoveAt(i);
                        }
                        break;
                }
            }
            return timeSlots;
        }
        public DataTable viewBookingDataTable(List<AppointmentBooking> bookingList)
        {
            DataTable dT = new DataTable();
            dT.Columns.Add("Booking ID");
            dT.Columns.Add("Date Booked");
            dT.Columns.Add("Time");
            dT.Columns.Add("Customer");
            dT.Columns.Add("Staff Assigned");
            dT.Columns.Add("Service");
            dT.Columns.Add("Room No.");
            dT.Columns.Add("Status");
            dT.Columns.Add("Priority");

            foreach (AppointmentBooking booking in bookingList)
            {
                {
                    dT.Rows.Add(booking.BookingId, booking.BookingDate.ToShortDateString(), timeSlotToString(booking.TimeSlot), booking.CustomerName, booking.StaffName, booking.ServiceName, booking.RoomNo, booking.Status, booking.Priority);
                }
            }

            return dT;
        }

        public DataTable viewUpcomingBookingsDataTable(List<AppointmentBooking> bookingList)
        {
            DataTable dT = new DataTable();
            dT.Columns.Add("Booking ID");
            dT.Columns.Add("Date Booked");
            dT.Columns.Add("Time");
            dT.Columns.Add("Staff Assigned");
            dT.Columns.Add("Service");
            dT.Columns.Add("Room No.");

            foreach (AppointmentBooking booking in bookingList)
            {
                dT.Rows.Add(booking.BookingId, booking.BookingDate.ToShortDateString(), timeSlotToString(booking.TimeSlot), booking.StaffName, booking.ServiceName, booking.RoomNo);
            }

            return dT;
        }

        public DataTable viewOfficeDiaryDataTable(List<List<string>> bookings)
        {
            DataTable dT = new DataTable();
            DataRow dTRow;
            dT.Columns.Add("10:00 - 11:00");
            dT.Columns.Add("11:00 - 12:00");
            dT.Columns.Add("Lunch");
            dT.Columns.Add("13:00 - 14:00");
            dT.Columns.Add("14:00 - 15:00");

            
            for (int row = 1; row < 5; row++)
            {
                dTRow = dT.NewRow();
                for (int col = 0; col < 5; col++)
                {
                    if(col != 2)
                    {
                        int column = col;
                        if (col > 2)
                        {
                            column -= 1;
                        }
                        foreach (List<string> booking in bookings)
                        {
                            if (Convert.ToInt32(booking[0]) == row && Convert.ToInt32(booking[1]) == column + 1)
                            {                                
                                dTRow[col] = booking[2];
                                break;
                            }
                        }
                        //if (dTRow[col].ToString() == string.Empty)
                        //{
                        //    dTRow[col] = "Open Slot";
                        //}
                    }
                    else //Sets lunch column to empty
                    {
                        dTRow[col] = "";
                    }
                    
                }
                dT.Rows.Add(dTRow);
            }
            return dT;
        }

        public bool checkPostcode(string postcode)
        {
            return (new Regex(@"(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|(([A-Z-[QVX]][0-9][A-HJKSTUW])|([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY])))) [0-9][A-Z-[CIKMOV]]{2})")).IsMatch(postcode);
        }

        public bool checkEmail(string email)
        {
            try
            {
                var validate = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;         
            }
        }
    }
}
