using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingApplication.objects;
using System.Data.SqlClient;

namespace BookingApplication.dbAccess
{
    public class ServiceDBAccess
    {
        Database db;

        public ServiceDBAccess(Database db)
        {
            this.db = db;
        }

        public Service getServiceFromReader(SqlDataReader rdr)
        {
            Service servObj = new Service();
            servObj.ServiceId = rdr.GetInt32(0);
            servObj.ServiceName = rdr.GetString(1);
            servObj.ServiceDesc = rdr.GetString(2);
            return servObj;
        }

        public List<Service> getAllServices()
        {
            List<Service> results = new List<Service>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Service";
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                results.Add(getServiceFromReader(db.Reader));
            }
            db.Reader.Close();

            return results;
        }

        public Service getServiceById(int servId)
        {
            Service results = new Service();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Service WHERE ServiceId = " + servId;
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                results = getServiceFromReader(db.Reader);
            }
            db.Reader.Close();

            return results;
        }

        public List<Service> getServicesByDay(DateTime date)
        {
            List<Service> results = new List<Service>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Service";
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                if(availableDayForService(date, db.Reader.GetInt32(0)))
                {
                    results.Add(getServiceFromReader(db.Reader));
                }
            }
            db.Reader.Close();

            return results;
        }

        public bool availableDayForService(DateTime date, int serviceId)
        {
            if (date.DayOfWeek == DayOfWeek.Monday && serviceId == 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
