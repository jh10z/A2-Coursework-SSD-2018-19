using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingApplication.objects;
using System.Data.SqlClient;

namespace BookingApplication.dbAccess
{
    public class StaffDBAccess
    {
        private Database db;

        public StaffDBAccess(Database db)
        {
            this.db = db;
        }


        //Methods
        public Staff getStaffFromReader(SqlDataReader rdr)
        {
            Staff staffObj = new Staff();
            staffObj.StaffId = rdr.GetInt32(0);
            staffObj.Forename = rdr.GetString(1);
            staffObj.Surname = rdr.GetString(2);
            staffObj.JobTitle = rdr.GetString(3);
            staffObj.JobDesc = rdr.GetString(4);
            staffObj.ActiveUser = rdr.GetBoolean(5);
            return staffObj;
        }

        public List<Staff> getAllStaff()
        {
            List<Staff> results = new List<Staff>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Staff WHERE ActiveUser = 1";
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                results.Add(getStaffFromReader(db.Reader));
            }
            db.Reader.Close();

            return results;
        }

        public Staff getStaffById(int staffId)
        {
            Staff results = new Staff();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Staff " +
            "WHERE StaffId = " + staffId;
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                results = getStaffFromReader(db.Reader);
            }
            db.Reader.Close();
            return results;
        }

        public List<Staff> getStaffbyService(int serviceId)
        {
            List<Staff> results = new List<Staff>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT Staff.StaffId, Staff.Forename, Staff.Surname, Staff.JobTitle, Staff.JobDesc, Staff.ActiveUser FROM StaffService " +
            "INNER JOIN Staff ON StaffService.StaffId = Staff.StaffId " +
            "WHERE ServiceId = " + serviceId;
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                results.Add(getStaffFromReader(db.Reader));
            }
            db.Reader.Close();
            return results;
        }


        public List<Staff> getStaffAvailable(DateTime date, int timeSlot, int serviceId)
        {
            List<Staff> staff = getStaffbyService(serviceId);
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("SELECT Staff.StaffId, Staff.Forename, Staff.Surname, Staff.JobTitle, Staff.JobDesc, Staff.ActiveUser " +
                "FROM (AppointmentBooking " +
                "INNER JOIN StaffService ON AppointmentBooking.StaffServiceId = StaffService.StaffServiceId) " +
                "INNER JOIN (StaffService AS StaffAlias INNER JOIN Staff ON StaffAlias.StaffId = Staff.StaffId) ON StaffAlias.StaffServiceId = StaffService.StaffServiceId " +
                "INNER JOIN (StaffService AS ServiceAlias INNER JOIN Service ON ServiceAlias.ServiceId = Service.ServiceId) ON ServiceAlias.StaffServiceId = StaffService.StaffServiceId " +
                "WHERE AppointmentBooking.TimeSlot = {0} AND " + "AppointmentBooking.Date = " + "' {1:MM/dd/yy}' AND Service.ServiceId = {2} AND AppointmentBooking.Deleted = 0", timeSlot, date, serviceId);

            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                for (int i = staff.Count - 1; i >= 0; i--) // Decrementing loop to avoid index shifting when removing
                {
                    if (staff[i].StaffId == db.Reader.GetInt32(0))
                    {
                        staff.RemoveAt(i);
                    }
                }
            }
            db.Reader.Close();

            return staff;
        }

        public List<Staff> getStaffAvailableUrgent(DateTime date, int serviceId, int timeSlot)
        {
            List<Staff> staff = getStaffbyService(serviceId);
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("SELECT Staff.StaffId, Staff.Forename, Staff.Surname, Staff.JobTitle, Staff.JobDesc, Staff.ActiveUser " +
                "FROM (AppointmentBooking " +
                "INNER JOIN StaffService ON AppointmentBooking.StaffServiceId = StaffService.StaffServiceId) " +
                "INNER JOIN (StaffService AS StaffAlias INNER JOIN Staff ON StaffAlias.StaffId = Staff.StaffId) ON StaffAlias.StaffServiceId = StaffService.StaffServiceId " +
                "INNER JOIN (StaffService AS ServiceAlias INNER JOIN Service ON ServiceAlias.ServiceId = Service.ServiceId) ON ServiceAlias.StaffServiceId = StaffService.StaffServiceId " +
                "WHERE AppointmentBooking.Priority = 'Urgent' AND " + "AppointmentBooking.Date = " + "' {0:MM/dd/yy}' AND Service.ServiceId = {1} AND AppointmentBooking.Deleted = 0 AND AppointmentBooking.TimeSlot = {2}", date, serviceId, timeSlot);

            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                for (int i = staff.Count - 1; i >= 0; i--) // Decrementing loop to avoid index shifting when removing
                {
                    if (staff[i].StaffId == db.Reader.GetInt32(0))
                    {
                        staff.RemoveAt(i);
                    }
                }
            }
            db.Reader.Close();

            return staff;
        }

        public string getStaffName(int staffId)
        {
            string result = "";
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT CONCAT(Forename, ' ' , Surname) FROM Staff WHERE Staff.StaffId = " + staffId;
            db.Reader = db.Cmd.ExecuteReader();
            db.Reader.Read();
            result = db.Reader.GetString(0);
            db.Reader.Close();

            return result;
        }
    }
}
