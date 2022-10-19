using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingApplication.objects;
using System.Data.SqlClient;

namespace BookingApplication.dbAccess
{
    public class OfficeDBAccess
    {
        Database db;

        public OfficeDBAccess(Database db)
        {
            this.db = db;
        }

        public Office getOfficeFromReader(SqlDataReader rdr)
        {
            Office officeObj = new Office();
            officeObj.OfficeId = rdr.GetInt32(0);
            officeObj.RoomNo = rdr.GetInt32(1);
            officeObj.FloorNo = rdr.GetInt32(2);

            return officeObj;
        }

        public List<Office> getAllOffices()
        {
            List<Office> offices = new List<Office>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Office";
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                offices.Add(getOfficeFromReader(db.Reader));
            }
            db.Reader.Close();

            return offices;
        }

        public Office getOfficeById(int officeId)
        {
            Office office = new Office();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Office " +
             "WHERE OfficeId = " + officeId;
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                office = getOfficeFromReader(db.Reader);
            }
            db.Reader.Close();

            return office;
        }

        public List<Office> getOfficesAvailable(DateTime date, int timeSlot)
        {
            List<Office> offices = getAllOffices();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("SELECT Office.OfficeId, Office.RoomNo, Office.FloorNo FROM " +
                "AppointmentBooking " +
                "INNER JOIN Office ON AppointmentBooking.OfficeId = Office.OfficeId " +
                "WHERE AppointmentBooking.TimeSlot = {0} AND " + "AppointmentBooking.Date = " + "' {1:MM/dd/yy}' AND AppointmentBooking.Deleted = 0", timeSlot, date);

            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                for (int i = offices.Count - 1; i >= 0; i--) // Decrementing loop to avoid index shifting when removing
                {
                    if (offices[i].OfficeId == db.Reader.GetInt32(0))
                    {
                        offices.RemoveAt(i);
                    }
                }
            }
            db.Reader.Close();

            return offices;
        }

        public List<Office> getOfficesAvailable(DateTime date)
        {
            List<Office> offices = getAllOffices();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("SELECT Office.OfficeId, Office.RoomNo, Office.FloorNo FROM " +
                "AppointmentBooking " +
                "INNER JOIN Office ON AppointmentBooking.OfficeId = Office.OfficeId " +
                "WHERE AppointmentBooking.Priority = 'Urgent' AND " + "AppointmentBooking.Date = " + "' {0:MM/dd/yy}' AND AppointmentBooking.Deleted = 0", date);

            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                for (int i = offices.Count - 1; i >= 0; i--) // Decrementing loop to avoid index shifting when removing
                {
                    if (offices[i].OfficeId == db.Reader.GetInt32(0))
                    {
                        offices.RemoveAt(i);
                    }
                }
            }
            db.Reader.Close();

            return offices;
        }
    }
}
