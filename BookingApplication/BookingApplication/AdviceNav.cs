using BookingApplication.gui;
using BookingApplication.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingApplication
{
    public class AdviceNav
    {
        private Database db;
        private Form currentForm;
        private Form previousForm;

        public AdviceNav(Database db)
        {
            this.db = db;
            currentForm = new Form();
        }

        public Form PreviousForm
        {
            get { return previousForm; }
            set { previousForm = value; }
        }


        public void gotoForm(string passedForm, AdviceBookingUtil advBookingUtil)
        {
            switch (passedForm)
            {
                case "cformAppointment":
                    currentForm = new formAppointments(advBookingUtil);
                    break;

                case "cformMenu":
                    currentForm = new cformMenu(advBookingUtil);
                    break;

                case "cformCustomers":
                    currentForm = new cformViewCustomers(advBookingUtil);
                    break;

                case "cformHome":
                    currentForm = new formHome(advBookingUtil);
                    break;

                case "cformAddEditBooking":
                    currentForm = new cformAddEditBooking(advBookingUtil, false);
                    break;
                case "stats":
                    currentForm = new cformBookingStatisticReport(advBookingUtil);
                    break; 

                default:
                    if (MessageBox.Show("This form does not exist. Would you like to relaunch the application?", "Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else { Application.Exit(); }

                    return; //Ends the methods here - just in case - so that currentForm.Show never gets executed
            }
            currentForm.Show();
        }

        public void goToCustomerForm(AdviceBookingUtil advBookingUtil, bool newCustomer, Customer custObj)
        {
            currentForm = new cformAddEditCustomer(advBookingUtil, newCustomer, custObj);
            currentForm.Show();
        }

        public void goToBookingForm(AdviceBookingUtil advBookingUtil, bool newBooking)
        {
            currentForm = new cformAddEditBooking(advBookingUtil, newBooking);
            currentForm.Show();
        }

        public void goToOfficeDiary(AdviceBookingUtil advBookingUtil, DateTime date)
        {
            currentForm = new cformOfficeDiary(advBookingUtil, date);
            currentForm.Show();
        }

        public void goToReportForm(AdviceBookingUtil advBookingUtil, int bookingId)
        {
            currentForm = new cformBookingReport(advBookingUtil, bookingId);
            currentForm.Show();
        }
    }
}
