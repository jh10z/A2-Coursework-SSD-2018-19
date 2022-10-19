using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BookingApplication.objects
{
    public class Database
    {
        private SqlCommand cmd;
        private SqlConnection con;
        private SqlDataReader reader;

        //Constructors
        public Database()
        {
        }

        //Getters and Setters
        public SqlCommand Cmd
        {
            get { return cmd; }
            set { cmd = value; }
        }

        public SqlConnection Con
        {
            get { return con; }
            set { con = value; }
        }

        public SqlDataReader Reader
        {
            get { return reader; }
            set { reader = value; }
        }

        //Methods
        public bool connect()
        {
            string startUpPath = Application.StartupPath;
            startUpPath = startUpPath.Substring(0, startUpPath.Length - 9);
            SqlConnectionStringBuilder scStrBuild = new SqlConnectionStringBuilder();
            scStrBuild.DataSource = "(LocalDB)\\MSSQLLocalDB";
            scStrBuild.AttachDBFilename = startUpPath + "AdviceBooking.mdf";
            scStrBuild.IntegratedSecurity = true;
            scStrBuild.Pooling = true;
            con = new SqlConnection(scStrBuild.ToString());
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            if (con.State == ConnectionState.Open)
            {
                return true;
            }
            else { return false; }
        }

    }
}
