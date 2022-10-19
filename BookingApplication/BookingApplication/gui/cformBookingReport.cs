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
    public partial class cformBookingReport: cform
    {
        AdviceBookingUtil advBookingUtilities;
        int bookingId;

        public cformBookingReport(AdviceBookingUtil advUtil, int bookingId) : base()
        {
            InitializeComponent();
            this.bookingId = bookingId;
            advBookingUtilities = advUtil;
            this.DesktopLocation = advBookingUtilities.LastFormLocation;

        }

        private void rVBooking_Load(object sender, EventArgs e)
        {
            this.bookingDetailsTableTableAdapter.FillBy(bookingDetailsDataSet.BookingDetailsTable, bookingId);
            this.rVBooking.RefreshReport();
        }

        private void cformBookingReport_MdiChildActivate(object sender, EventArgs e)
        {
            advBookingUtilities.LastForm = new formAppointments(advBookingUtilities);
            advBookingUtilities.LastFormLocation = this.DesktopLocation;
            AdvUtil = advBookingUtilities;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.rVBooking.PrintDialog();
        }
    }
}
