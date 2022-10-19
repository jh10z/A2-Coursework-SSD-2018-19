using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingApplication.objects;

namespace BookingApplication.dbAccess
{
    class DataViewDBAccess
    {
        Database db;

        public DataViewDBAccess(Database db)
        {
            this.db = db;
        }   

        public objects.DataView dataViewGeneration(string sqlString, List<string> selected)
        {
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = sqlString;
            db.Reader = db.Cmd.ExecuteReader();
            objects.DataView dataViewObj = new objects.DataView(selected, new List<List<String>>());

            while (db.Reader.Read())
            {
                List<string> results = new List<string>();
                for (int i = 0; i < db.Reader.FieldCount; i++)
                {
                    results.Add(db.Reader.GetValue(i).ToString());
                }
                dataViewObj.Rows.Add(results);

            }
            db.Reader.Close();

            return dataViewObj;
        }
    }
}
