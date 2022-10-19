using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookingApplication.gui;
using BookingApplication.objects;

namespace BookingApplication
{
    public partial class formHome : cform
    {
        AdviceBookingUtil advBookingUtil;

        public formHome(AdviceBookingUtil advBookingUtilities): base()
        {
            InitializeComponent();
            DesktopLocation = advBookingUtilities.LastFormLocation;
            this.advBookingUtil = advBookingUtilities;
            cFormTitle.Text = "Advice | Menu";
            BtnBack.Hide();

        }

        //Form Navigation
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            advBookingUtil.LastForm = this;
            advBookingUtil.LastFormLocation = this.DesktopLocation;
            advBookingUtil.AdvNav.gotoForm("cformAppointment", advBookingUtil);
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            advBookingUtil.LastForm = this;
            advBookingUtil.LastFormLocation = this.DesktopLocation;
            advBookingUtil.AdvNav.gotoForm("cformCustomers", advBookingUtil);
            this.Hide();
        }

        private void btnDiary_Click(object sender, EventArgs e)
        {
            advBookingUtil.LastForm = this;
            advBookingUtil.LastFormLocation = this.DesktopLocation;
            advBookingUtil.AdvNav.goToOfficeDiary(advBookingUtil, DateTime.Today);
            this.Hide();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            advBookingUtil.LastForm = this;
            advBookingUtil.LastFormLocation = this.DesktopLocation;
            advBookingUtil.AdvNav.gotoForm("stats", advBookingUtil);
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Due to skill repetition, I have decided to leave this out to minimise the length of testing");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            base.backNavMethod();
        }

        private void formHome_MdiChildActivate(object sender, EventArgs e)
        {
            advBookingUtil.LastForm = new cformMenu(advBookingUtil);
            advBookingUtil.LastFormLocation = this.DesktopLocation;
            AdvUtil = advBookingUtil;
        }

        //Extra Aesthetical Code
        //Timer
        private void systemTimer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongDateString() + " | " + DateTime.Now.ToLongTimeString();
        }

        //Allows transparency of a label on picture box
        private void formHome_Load(object sender, EventArgs e)
        {
            var pos = this.PointToScreen(lblDateTime.Location);
            pos = picBanner.PointToClient(pos);
            lblDateTime.Parent = picBanner;
            lblDateTime.Location = pos;
            lblDateTime.BackColor = Color.Transparent;
        }
    }
}
