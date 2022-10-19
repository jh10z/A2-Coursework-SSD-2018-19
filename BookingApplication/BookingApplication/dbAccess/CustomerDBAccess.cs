using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingApplication.objects;
using System.Data.SqlClient;

namespace BookingApplication.dbAccess
{
    public class CustomerDBAccess
    {
        Database db;

        public CustomerDBAccess(Database db)
        {
            this.db = db;
        }

        public Customer getCustomerFromReader(SqlDataReader rdr)
        {
            Customer custObj = new Customer();
            custObj.CustomerId = rdr.GetInt32(0);
            custObj.Forename = rdr.GetString(1);
            custObj.Surname = rdr.GetString(2);
            custObj.DOB = rdr.GetDateTime(3);
            custObj.Address = rdr.GetString(4);
            custObj.Town = rdr.GetString(5);
            custObj.Postcode = rdr.GetString(6);
            custObj.ActiveUser = rdr.GetBoolean(7);
            custObj.EmailAddress = rdr.GetString(8);
            custObj.TelNo = rdr.GetString(9);

            return custObj;
        }

        public List<Customer> getAllCustomers() 
        {
            List<Customer> results = new List<Customer>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Customer WHERE ActiveUser = 1";
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                results.Add(getCustomerFromReader(db.Reader));
            }
            db.Reader.Close();

            return results;
        }

        public List<Customer> getCustomersByDate(DateTime date)
        {
            List<Customer> results = new List<Customer>();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Customer WHERE ActiveUser = 1";
            db.Reader = db.Cmd.ExecuteReader();
            while (db.Reader.Read())
            {
                results.Add(getCustomerFromReader(db.Reader));
            }
            db.Reader.Close();

            return results;
        }

        public Customer getCustomerByID(int custId)
        {
            Customer result = new Customer();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Customer WHERE CustomerId = " + custId;
            db.Reader = db.Cmd.ExecuteReader();

            while (db.Reader.Read())
            {
                result = getCustomerFromReader(db.Reader);
            }
            db.Reader.Close();
            return result;
        }

        public void insertCustomer(int custId, string forename, string surname, DateTime dOB, string address, string town, string postcode, string email, string tel)
        {
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("INSERT INTO Customer (CustomerID, Forename, Surname, DOB, Address, Town, Postcode, ActiveUser, EmailAddress, Telephone) VALUES ({0}, '{1}', '{2}', '{3:MM/dd/yy}', '{4}', '{5}', '{6}', {7}, '{8}', '{9}')",
                custId, forename, surname, dOB, address, town, postcode, 1, email, tel);
            db.Cmd.ExecuteNonQuery();
        }

        //At this point I learnt about SQL injection
        public void updateCustomer(string forename, string surname, DateTime dOB, string address, string town, string postcode, string email, string tel, int custId)
        {
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = String.Format("UPDATE Customer SET Forename = '{0}', Surname = '{1}', DOB = '{2:MM/dd/yy}', Address = '{3}',Town = '{4}', Postcode = '{5}', EmailAddress = '{6}', Telephone = '{7}' WHERE CustomerID = {8}",
                forename, surname, dOB, address, town, postcode, email, tel, custId);
            db.Cmd.ExecuteNonQuery();
        }

        //Realised when trying to use while loop, SELECT MAX(CustomerID) only returns to the reader the ID. Thus, I went from while loop to getting off the ID reader directly as reader doesn't go beyond ID
        //^ Every result afterward returned 'null'
        public int getNextCustomerID()
        {
            int id = new int();
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "SELECT MAX(CustomerID) FROM Customer";
            db.Reader = db.Cmd.ExecuteReader();

            while (db.Reader.Read()) // If correctly, while loop will only go once
            {
                id = db.Reader.GetInt32(0);
            }
            db.Reader.Close();

            return id + 1; // Returns the max ID + 1; an ID that is unique and the next after (sequential consistancy)
        }

        public void deleteCustomer(int custId)
        {
            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "UPDATE Customer SET ActiveUser = 0 WHERE CustomerId = " + custId + "; " + 
                "Delete FROM AppointmentBooking WHERE CustomerId = " + custId + " AND Status = 'Upcoming'";
            db.Cmd.ExecuteNonQuery();
        }

    }
}
