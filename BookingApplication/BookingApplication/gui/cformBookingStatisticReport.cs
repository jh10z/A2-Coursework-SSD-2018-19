using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingApplication.gui
{
    public partial class cformBookingStatisticReport : cform
    {
        int month = -1;
        AdviceBookingUtil advBookingUtilities;
        public cformBookingStatisticReport(AdviceBookingUtil advUtil): base()
        {
            InitializeComponent();
            lblMonth.Text = DateTime.Now.AddMonths(month).ToString("MMMM yyyy");
            advBookingUtilities = advUtil;
            this.DesktopLocation = advBookingUtilities.LastFormLocation;

        }

        private void btnBackMonth_Click(object sender, EventArgs e)
        {
            month -= 1;
            lblMonth.Text = DateTime.Now.AddMonths(month).ToString("MMMM yyyy");
            updateReport(DateTime.Now.AddMonths(month));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            month += 1;
            if (month < 0)
            {
                lblMonth.Text = DateTime.Now.AddMonths(month).ToString("MMMM yyyy");
                updateReport(DateTime.Now.AddMonths(month));
            }
            else
            {
                month = -1;
                MessageBox.Show("You cannot compile stats for a month that hasn't fully passed.", "Warning");
            }
        }

        public void updateReport(DateTime date)
        {
            this.bookingDetailsTableTableAdapter.MonthStats(bookingDetailsDataSet.BookingDetailsTable, date.Month.ToString(), date.Year.ToString());
            this.rVBooking.RefreshReport();
        }

        private void cformBookingStatisticReport_MdiChildActivate(object sender, EventArgs e)
        {
            advBookingUtilities.LastForm = new formHome(advBookingUtilities);
            advBookingUtilities.LastFormLocation = this.DesktopLocation;
            AdvUtil = advBookingUtilities;
        }

        private void cformBookingStatisticReport_Shown(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.AddMonths(month);
            this.bookingDetailsTableTableAdapter.MonthStats(bookingDetailsDataSet.BookingDetailsTable, today.Month.ToString(), today.Year.ToString());
            this.rVBooking.RefreshReport();
        }
    }
}
