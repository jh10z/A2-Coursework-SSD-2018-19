using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using BookingApplication.gui;
using BookingApplication.objects;
namespace BookingApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Database db = new Database();
            if (!db.connect())
            {
                MessageBox.Show("Database Connection not opened.", "Error");
                Application.Exit();
            }
            AdviceBookingUtil advBookingUtil = new AdviceBookingUtil(db);
            MessageBox.Show("Any upcoming bookings that have passed todays date will be marked as missed.", "Warning");
            advBookingUtil.AdviceDBA.BookingDBAccess.updateBookings();
            advBookingUtil.FirstStartup = true;
            Application.Run(new cformMenu(advBookingUtil));
        }
    }
}
