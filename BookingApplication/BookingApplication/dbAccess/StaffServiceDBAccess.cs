using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingApplication.objects;
using System.Data.SqlClient;

namespace BookingApplication.dbAccess
{
    public class StaffServiceDBAccess
    {
        Database db;

        public StaffServiceDBAccess(Database db)
        {
            this.db = db;
        }

        public StaffService getStaffServiceFromReader(SqlDataReader rdr)
        {
            StaffService staffServiceObj = new StaffService();
            staffServiceObj.StaffServiceId = rdr.GetInt32(0);
            staffServiceObj.StaffId = rdr.GetInt32(1);
            staffServiceObj.ServiceId = rdr.GetInt32(2);

            return staffServiceObj;
        }

        //public List<StaffService> getStaffByServiceFromStaffService(int serviceId)
        //{
        //    List<StaffService> staffServiceList = new List<StaffService>();
        //    db.Cmd = db.Con.CreateCommand();
        //    db.Cmd.CommandText = "SELECT * FROM StaffService WHERE = " + serviceId;
        //    db.Reader = db.Cmd.ExecuteReader();
        //    while (db.Reader.Read())
        //    {
        //        staffServiceList.Add(getStaffServiceFromReader(db.Reader));
        //    }
        //    db.Reader.Close();

        //    return staffServiceList;
        //}

        public Dictionary<int, List<string>> getStaffByServiceFromStaffService(int serviceId)
        {
            Dictionary<int, List<string>> staffServiceList = new Dictionary<int, List<string>>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT StaffService.StaffServiceId, Staff.Forename" +
                "FROM StaffService WHERE = " + serviceId;
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                staffServiceList.Add(db.Reader.GetInt32(0), new List<string>() { db.Reader.GetString(1) });
            }
            db.Reader.Close();

            return staffServiceList;
        }

        public int getStaffIdbyStaffServiceId(int StaffServiceId)
        {
            int id = new int();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT StaffId " +
                "FROM StaffService WHERE StaffServiceId = " + StaffServiceId;
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                id = db.Reader.GetInt32(0);
            }
            db.Reader.Close();

            return id;
        }

        public int getServiceIdbyStaffServiceId(int StaffServiceId)
        {
            int id = new int();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT ServiceId " +
                "FROM StaffService WHERE StaffServiceId = " + StaffServiceId;
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                id = db.Reader.GetInt32(0);
            }
            db.Reader.Close();

            return id;
        }

        public int getStaffServiceIdByStaffAndService(int staffId, int serviceId)
        {
            int id = new int();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT StaffServiceId " +
                "FROM StaffService WHERE StaffId = " + staffId + " AND ServiceId = " + serviceId;
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                id = db.Reader.GetInt32(0);
            }
            db.Reader.Close();

            return id;
        }

        public bool checkIfStaffIsInService(int staffId, int serviceId)
        {
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT StaffId " +
                "FROM StaffService " +
                "WHERE ServiceId = " + serviceId;

            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                if (db.Reader.GetInt32(0) == staffId)
                {
                    db.Reader.Close();
                    return true;
                }
            }
            db.Reader.Close();

            return false;
        }
    }
}
