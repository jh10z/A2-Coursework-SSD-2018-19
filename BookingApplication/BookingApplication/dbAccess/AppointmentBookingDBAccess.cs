 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BookingApplication.objects;

namespace BookingApplication.dbAccess
{
    public class AppointmentBookingDBAccess
    {
        Database db;
        OfficeDBAccess officeDBAccess;

        public AppointmentBookingDBAccess(Database db)
        {
            this.db = db;
            officeDBAccess = new OfficeDBAccess(db);
        }

        public AppointmentBooking getAppointmentBookingFromReader(SqlDataReader rdr)
        {
            AppointmentBooking bookingObj = new AppointmentBooking();
            bookingObj.BookingId = rdr.GetInt32(0);
            bookingObj.BookingDate = rdr.GetDateTime(1);
            bookingObj.TimeSlot = rdr.GetInt32(2);
            bookingObj.CustomerName = rdr.GetString(3) + " " + rdr.GetString(4);
            bookingObj.RoomNo = rdr.GetInt32(5);
            bookingObj.StaffName = rdr.GetString(6) + " " + rdr.GetString(7);
            bookingObj.ServiceName = rdr.GetString(8);
            bookingObj.Status = rdr.GetString(9);
            bookingObj.Deleted = rdr.GetBoolean(10);
            bookingObj.Priority = rdr.GetString(11);

            return bookingObj;
        }

        public List<AppointmentBooking> getAllAppointmentBookings(DateTime date, string filter)
        {
            List<AppointmentBooking> Bookings = new List<AppointmentBooking>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT AppointmentBooking.BookingId, AppointmentBooking.Date, AppointmentBooking.TimeSlot, Customer.Forename, Customer.Surname, Office.RoomNo, Staff.Forename, Staff.Surname, Service.Name, AppointmentBooking.Status, AppointmentBooking.Deleted, AppointmentBooking.Priority FROM " +
                "(AppointmentBooking " +
                "INNER JOIN Customer ON AppointmentBooking.CustomerId = Customer.CustomerId " +
                "INNER JOIN Office ON AppointmentBooking.OfficeId = Office.OfficeId " +
                "INNER JOIN StaffService ON AppointmentBooking.StaffServiceId = StaffService.StaffServiceId) " +
                "INNER JOIN (StaffService AS StaffAlias INNER JOIN Staff ON StaffAlias.StaffId = Staff.StaffId) ON StaffAlias.StaffServiceId = StaffService.StaffServiceId " +
                "INNER JOIN (StaffService AS ServiceAlias INNER JOIN Service ON ServiceAlias.ServiceId = Service.ServiceId) ON ServiceAlias.StaffServiceId = StaffService.StaffServiceId " +
                "WHERE MONTH(AppointmentBooking.Date) = " + date.Month + " AND  YEAR(AppointmentBooking.Date) = " + date.Year + " AND AppointmentBooking.Deleted = 0" + filter +
                " ORDER BY AppointmentBooking.Date, AppointmentBooking.TimeSlot";
            //ADD ORDER BY TIME SLOT
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                Bookings.Add(getAppointmentBookingFromReader(db.Reader));
            }
            db.Reader.Close();
            return Bookings;
        }

        public List<AppointmentBooking> getUpcomingAppointmentsForCustomer(int custId)
        {
            List<AppointmentBooking> Bookings = new List<AppointmentBooking>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT AppointmentBooking.BookingId, AppointmentBooking.Date, AppointmentBooking.TimeSlot, Customer.Forename, Customer.Surname, Office.RoomNo, Staff.Forename, Staff.Surname, Service.Name, AppointmentBooking.Status, AppointmentBooking.Deleted, AppointmentBooking.Priority FROM " +
                "(AppointmentBooking " +
                "INNER JOIN Customer ON AppointmentBooking.CustomerId = Customer.CustomerId " +
                "INNER JOIN Office ON AppointmentBooking.OfficeId = Office.OfficeId " +
                "INNER JOIN StaffService ON AppointmentBooking.StaffServiceId = StaffService.StaffServiceId) " +
                "INNER JOIN (StaffService AS StaffAlias INNER JOIN Staff ON StaffAlias.StaffId = Staff.StaffId) ON StaffAlias.StaffServiceId = StaffService.StaffServiceId " +
                "INNER JOIN (StaffService AS ServiceAlias INNER JOIN Service ON ServiceAlias.ServiceId = Service.ServiceId) ON ServiceAlias.StaffServiceId = StaffService.StaffServiceId " +
                "WHERE AppointmentBooking.CustomerId = " + custId + " AND AppointmentBooking.Deleted = 0 AND AppointmentBooking.Status != 'Missed' AND AppointmentBooking.Status != 'Checked In'" +
                "ORDER BY AppointmentBooking.Date, AppointmentBooking.TimeSlot";
            //ADD ORDER BY TIME SLOT
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                Bookings.Add(getAppointmentBookingFromReader(db.Reader));
            }
            db.Reader.Close();
            return Bookings;
        }

        //Add MessageBoxes and fix date < less than
        public void updateBookings()
        {
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "UPDATE AppointmentBooking SET Status = 'Missed' WHERE CONVERT(date, GETDATE()) > DATE AND Status != 'Checked In'";
            db.Cmd.ExecuteNonQuery();
        }


        public List<string> getBookingDetailsById(int bookingId)
        {
            List<string> booking = new List<string>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM " +
                "AppointmentBooking " +
                "WHERE BookingId = " + bookingId;
            db.Reader = db.Cmd.ExecuteReader();
            db.Reader.Read();
            for (int i = 0; i < db.Reader.FieldCount; i++)
            {
                booking.Add(db.Reader.GetValue(i).ToString());
            }
            db.Reader.Close();
            return booking;
        }

        public List<List<string>> getBookingsDetailsByDateForOfficeDiary(DateTime date)
        {
            List<List<string>> bookings = new List<List<string>>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = string.Format("SELECT AppointmentBooking.OfficeId, AppointmentBooking.TimeSlot, CONCAT(Customer.Forename, ' ', Customer.Surname) FROM AppointmentBooking " +
                "INNER JOIN Customer ON AppointmentBooking.CustomerId = Customer.CustomerId WHERE Date = '{0:MM/dd/yy}'", date);
            db.Reader = db.Cmd.ExecuteReader();

            while (db.Reader.Read())
            {
                List<string> booking = new List<string>();
                for (int i = 0; i < db.Reader.FieldCount; i++)
                {
                    booking.Add(db.Reader.GetValue(i).ToString());
                }
                bookings.Add(booking);
            }
            db.Reader.Close();
            return bookings;
        }

        public List<int> getStaffAvailableForDate()
        {
            return new List<int>();
        }
        //use not equal to
        public List<int> getBookedTimesByOffices(DateTime date, int officeId)
        {
            List<int> bookedTimesByOfficesList = new List<int>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("SELECT AppointmentBooking.TimeSlot FROM " +
                "AppointmentBooking " +
                "WHERE AppointmentBooking.OfficeId = {0} AND AppointmentBooking.Date = '{1:MM/dd/yy}' AND AppointmentBooking.Deleted = 0", officeId, date);
            db.Reader = db.Cmd.ExecuteReader();

            while (db.Reader.Read())
            {
                bookedTimesByOfficesList.Add(db.Reader.GetInt32(0));
            }

            db.Reader.Close();
            return bookedTimesByOfficesList;
        }

        public List<int> getBookedStaffByServices(DateTime date, int serviceId)
        {
            List<int> staffAvailableByServiceList = new List<int>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("SELECT AppointmentBooking.StaffServiceId FROM " +
                "(AppointmentBooking " +
                "INNER JOIN StaffService ON AppointmentBooking.StaffServiceId = StaffService.StaffServiceId) " +
                "INNER JOIN(StaffService AS ServiceAlias INNER JOIN Service ON ServiceAlias.ServiceId = Service.ServiceId) ON ServiceAlias.StaffServiceId = StaffService.StaffServiceId " +
                "INNER JOIN (StaffService AS StaffAlias INNER JOIN Staff ON StaffAlias.StaffId = Staff.StaffId) ON StaffAlias.StaffServiceId = StaffService.StaffServiceId " +
                "WHERE AppointmentBooking.Date = '{0:MM/dd/yy}' AND ServiceAlias.ServiceId = {1} AND AppointmentBooking.Deleted = 0", date, serviceId);
            db.Reader = db.Cmd.ExecuteReader();

            while (db.Reader.Read())
            {
                staffAvailableByServiceList.Add(db.Reader.GetInt32(0));
            }

            db.Reader.Close();

            return staffAvailableByServiceList;
        }

        public int getAvailabilityByDate(DateTime date)
        {
            int count = 0;
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("SELECT COUNT(BookingId) FROM " +
                "AppointmentBooking " +
                "WHERE AppointmentBooking.Date = '{0:MM/dd/yy}' AND Deleted = 0", date);
            db.Reader = db.Cmd.ExecuteReader();

            while (db.Reader.Read())
            {
                count = db.Reader.GetInt32(0);
            }

            db.Reader.Close();
            return 20 - count; //Max spaces available per day - unavailable spaces for day, returns spaces available for day
        }

        public void updateBooking(int bookingId, int officeId, int staffServiceId, DateTime date, int timeslot, string desc, string priority, string status)
        {
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("UPDATE AppointmentBooking SET OfficeId = {0}, StaffServiceId = {1}, Date = '{2:MM/dd/yy}', TimeSlot = {3}, Description = '{4}', Priority = '{5}', Status = '{6}' WHERE BookingId = {7}", 
                officeId, staffServiceId, date, timeslot, desc, priority, status, bookingId);
            db.Cmd.ExecuteNonQuery();
        }

        public List<string> getBookingDetailsByOfficeAndDateAndTimeslot(int officeId, DateTime date, int timeslot)
        {
            List<string> booking = new List<string>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("SELECT AppointmentBooking.BookingId, CONCAT(Customer.Forename, ' ', Customer.Surname), AppointmentBooking.Description, AppointmentBooking.Priority, AppointmentBooking.StaffServiceId, AppointmentBooking.Status FROM " +
                "AppointmentBooking " +
                "INNER JOIN Customer ON AppointmentBooking.CustomerId = Customer.CustomerId " +
                "WHERE OfficeId = {0} AND Date = '{1:MM/dd/yy}' AND TimeSlot = {2} AND Deleted = 0", officeId, date, timeslot);
            db.Reader = db.Cmd.ExecuteReader();
            db.Reader.Read();
            if (!db.Reader.HasRows)
            {
                db.Reader.Close();
                return null;
            }
            for (int i = 0; i < db.Reader.FieldCount; i++)
            {
                booking.Add(db.Reader.GetValue(i).ToString());
            }
            db.Reader.Close();
            return booking;
        }

        public void insertBooking(int custId, int officeId, int staffServiceId, DateTime date, int timeslot, string desc, string priority, int deleted)
        {
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("INSERT INTO AppointmentBooking (CustomerId, OfficeId, StaffServiceId, Date, TimeSlot, Description, Status, Priority, Deleted) VALUES ({0}, {1}, {2}, '{3:MM/dd/yy}', {4}, '{5}', '{6}', '{7}', {8})",
                custId, officeId, staffServiceId, date, timeslot, desc, "Upcoming", priority, deleted);
            db.Cmd.ExecuteNonQuery();
        }

        public void deleteBooking(int bookingId)
        {
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("DELETE FROM AppointmentBooking WHERE BookingId = {0}",
                bookingId);
            db.Cmd.ExecuteNonQuery();
        }

        public void checkInBooking(int bookingId)
        {
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("UPDATE AppointmentBooking SET Status = 'Checked In' WHERE BookingId = {0}",
                bookingId);
            db.Cmd.ExecuteNonQuery();
        }

        public int getBookingIdByOfficeTimeDate(int officeId, int timeSlot, DateTime date)
        {
            int booking = new int();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("SELECT BookingId FROM " +
                "AppointmentBooking " +
                "WHERE OfficeId = {0} AND TimeSlot = {1} AND Date = '{2:MM/dd/yy}'", officeId, timeSlot, date);
            db.Reader = db.Cmd.ExecuteReader();
            db.Reader.Read();
            if (!db.Reader.HasRows)
            {
                db.Reader.Close();
                return -1;
            }
            booking = db.Reader.GetInt32(0);
            db.Reader.Close();
            return booking;
        }

        public int getBookingIdByStaffServiceTimeDate(int StaffServiceId, int timeSlot, DateTime date)
        {
            int booking = new int();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("SELECT BookingId FROM " +
                "AppointmentBooking " +
                "WHERE StaffServiceId = {0} AND TimeSlot = {1} AND Date = '{2:MM/dd/yy}'", StaffServiceId, timeSlot, date);
            db.Reader = db.Cmd.ExecuteReader();
            db.Reader.Read();
            if (!db.Reader.HasRows)
            {
                db.Reader.Close();
                return -1;
            }
            booking = db.Reader.GetInt32(0);
            db.Reader.Close();
            return booking;
        }

        public int getOfficeIdByBookingId(int bookingId)
        {
            int officeId = new int();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT OfficeId FROM " +
                "AppointmentBooking " +
                "WHERE BookingId = " + bookingId;
            db.Reader = db.Cmd.ExecuteReader();
            db.Reader.Read();
            officeId = db.Reader.GetInt32(0);
            db.Reader.Close();
            return officeId;
        }


        public void replacedBooking(int bookingId)
        {
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("UPDATE AppointmentBooking SET Date = DATEADD(week, 2, AppointmentBooking.Date), Status = 'Waiting', Priority = 'Urgent' WHERE BookingId = {0}",
                bookingId);
            db.Cmd.ExecuteNonQuery();
        }

        public void replacedBooking(int bookingId, DateTime date)
        {
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("UPDATE AppointmentBooking SET Date = '{0:MM/dd/yy}', Status = 'Waiting', Priority = 'Urgent' WHERE BookingId = {1}",
                date, bookingId);
            db.Cmd.ExecuteNonQuery();
        }

        public int maxId()
        {
            int booking = new int();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT MAX(BookingId) FROM AppointmentBooking";
            db.Reader = db.Cmd.ExecuteReader();
            db.Reader.Read();
            booking = db.Reader.GetInt32(0);
            db.Reader.Close();
            return booking;
        }

        public bool checkIfCustomerBookedDateTime(int custId, DateTime date, int ts)
        {
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("SELECT * FROM " +
                "AppointmentBooking " +
                "WHERE CustomerId = {0} AND Date = '{1:MM/dd/yy}' AND TimeSlot = {2}", custId, date, ts);
            db.Reader = db.Cmd.ExecuteReader();
            db.Reader.Read();
            if (!db.Reader.HasRows)
            {
                db.Reader.Close();
                return false;
            }
            db.Reader.Close();
            return true;
        }
    }
}
