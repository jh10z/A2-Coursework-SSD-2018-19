using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BookingApplication.objects;
using BookingApplication.gui;

namespace BookingApplication
{
    public partial class formAppointments : cform
    {
        AdviceBookingUtil advBookingUtil;
        public formAppointments(AdviceBookingUtil advBookingUtil): base()
        {
            InitializeComponent();
            this.advBookingUtil = advBookingUtil;
            lblMonthSelected.Text = "Bookings of Month: " + dTPAppointments.Value.ToString("MMMM yyyy");
            dtpickAppointments_ValueChanged(new object(), new EventArgs());
            dTPMonth.Value = DateTime.Today;
            cFormTitle.Text = "Advice | View Appointments";
            this.DesktopLocation = advBookingUtil.LastFormLocation;
            panelManage.Hide();
            dGridViewMonthlyBookings.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dTPMonth.Format = DateTimePickerFormat.Custom;
            dTPMonth.CustomFormat = "MMMM yyyy";
            dTPMonth.ShowUpDown = true;
            viewBookingsSetup(DateTime.Today, string.Empty);
            dTPAppointments.MaxDate = DateTime.Today.AddDays(13);

        }

        //Date time picker for adding a booking
        private void dtpickAppointments_ValueChanged(object sender, EventArgs e)
        {
            if (dTPAppointments.Value.Date.DayOfWeek == DayOfWeek.Monday || dTPAppointments.Value.Date.DayOfWeek == DayOfWeek.Wednesday || dTPAppointments.Value.Date.DayOfWeek == DayOfWeek.Friday)
            {
                btnViewDay.Enabled = true;
                if(dTPAppointments.Value.Date != DateTime.Today)
                {
                    btnViewDay.Text = "Book | " + dTPAppointments.Value.Date.ToShortDateString();
                }
                else
                {
                    btnViewDay.Text = "Book | Today";
                }
                lblSlotsAvailable.Text = "Office Spaces Available: " +advBookingUtil.AdviceDBA.BookingDBAccess.getAvailabilityByDate(dTPAppointments.Value.Date);
                btnViewDay.BackColor = Color.Lime;
                btnViewDay.FlatAppearance.MouseDownBackColor = Color.Green;
                btnViewDay.FlatAppearance.MouseOverBackColor = Color.Green;

            }
            else
            {
                btnViewDay.Text = "Closed this day";
                lblSlotsAvailable.Text = "Office Spaces Available: N/A";
                btnViewDay.BackColor = Color.DimGray;
                btnViewDay.Enabled = false;
            }
        }

        //Populates the data grid view
        public void viewBookingsSetup(DateTime date, string filter)
        {
            dGridViewMonthlyBookings.DataSource = advBookingUtil.AdvMethods.viewBookingDataTable(advBookingUtil.AdviceDBA.BookingDBAccess.getAllAppointmentBookings(date, filter));
        }

        public void setColumnWidth()
        {
            //Hiding unneccesary columns
            dGridViewMonthlyBookings.Columns[0].Visible = false;
            dGridViewMonthlyBookings.Columns[4].Visible = false;
            dGridViewMonthlyBookings.Columns[6].Visible = false;
            dGridViewMonthlyBookings.Columns[8].Visible = false;
            //Setting column widths appropriately based on expected width and the overall width to fit in the data grid view width
            dGridViewMonthlyBookings.Columns[1].Width = 90;
            dGridViewMonthlyBookings.Columns[2].Width = 75;
            dGridViewMonthlyBookings.Columns[3].Width = 140;
            dGridViewMonthlyBookings.Columns[5].Width = 135;
            dGridViewMonthlyBookings.Columns[7].Width = 100;
        }

        private void btnViewDay_Click(object sender, EventArgs e)
        {
            if (advBookingUtil.AdvMethods.returnAvailableTimeSlotsList().Count == 0 && DateTime.Today == dTPAppointments.Value.Date)
            {
                MessageBox.Show("There are no longer any times available today.");
            }
            else if(dTPAppointments.Value.Date >= DateTime.Today)
            {
                advBookingUtil.LastFormLocation = this.DesktopLocation;
                advBookingUtil.SelectedDate = dTPAppointments.Value.Date;
                advBookingUtil.AdvNav.goToBookingForm(advBookingUtil, true); //TEST
                Hide();
            }
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            string filter = string.Empty;
            if(cbCustomer.SelectedIndex > 0 || cbPriority.SelectedIndex > 0 || cbStaff.SelectedIndex > 0 || cbStatus.SelectedIndex > 0)
            {
                foreach(ComboBox cb in new List<ComboBox>() { cbCustomer, cbPriority, cbStaff, cbStatus})
                {
                    if(cb.SelectedIndex == 0)
                    {
                        filter += "";
                    }
                    else
                    {
                        if(cb.SelectedItem is Customer)
                        {
                            filter += " AND AppointmentBooking.CustomerId = " + ((Customer)cb.SelectedItem).CustomerId;
                        }
                        else if (cb.SelectedItem is string)
                        {
                            if(cb.SelectedItem.ToString() == "Normal" || cb.SelectedItem.ToString() == "Urgent")
                            {
                                filter += " AND Priority = '" + cb.SelectedItem.ToString() + "'";
                            }
                            else
                            {
                                filter += " AND Status = '" + cb.SelectedItem.ToString() + "'";
                            }
                        }
                        else if (cb.SelectedItem is Staff)
                        {
                            filter += " AND StaffService.StaffId = " + ((Staff)cb.SelectedItem).StaffId;
                        }
                    }
                }
            }
            viewBookingsSetup(dTPMonth.Value.Date, filter);
            lblMonthSelected.Text = "Bookings of Month: " + dTPMonth.Value.ToString("MMMM yyyy");
            dGridViewMonthlyBookings.ClearSelection();

            if (dGridViewMonthlyBookings.Rows.Count < 1)
            {
                MessageBox.Show("No results", "Warning");
            }
            showAddBookingPanel();
        }

        public void showAddBookingPanel()
        {
            if (panelAdd.Visible == false)
            {
                lblTitleControl.Text = "Add Section";
                btnControls.Text = "Show Manage Booking Section";
                panelAdd.Visible = true;
                panelManage.Visible = false;
            }
        }

        public void showManageBookingPanel()
        {
            if (panelManage.Visible == false)
            {
                lblTitleControl.Text = "Manage Section";
                btnControls.Text = "Show Add Booking Section";
                panelAdd.Visible = false;
                panelManage.Visible = true;
            }
        }
        //Back Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            formHome formHome = new formHome(advBookingUtil);
            formHome.Show();
            Hide();
        }

        //On form load, populate the filter combo boxes
        private void formAppointments_Load(object sender, EventArgs e)
        {
            AppointmentsToolStripMenuItem.Enabled = false;
            setColumnWidth();

            cbCustomer.Items.Insert(0, new Customer() {CustomerId = -1});
            cbCustomer.Items.AddRange(advBookingUtil.AdviceDBA.CustDBAccess.getAllCustomers().ToArray());
            cbCustomer.SelectedIndex = 0;

            cbStaff.Items.Insert(0, new Staff() { StaffId = -1 });
            cbStaff.Items.AddRange(advBookingUtil.AdviceDBA.StaffDBAccess.getAllStaff().ToArray());
            cbStaff.SelectedIndex = 0;

            cbPriority.Items.AddRange((new List<string>() { "(N/A)", "Normal", "Urgent" }).ToArray());
            cbPriority.SelectedIndex = 0;
            cbStatus.Items.AddRange((new List<string>() { "(N/A)", "Upcoming", "Waiting", "Missed", "Checked In" }).ToArray());
            cbStatus.SelectedIndex = 0;
            dTPAppointments.MinDate = DateTime.Today;

            dGridViewMonthlyBookings.ClearSelection();
        }

        //Methods for showing the panel and hiding
        private void btnControls_Click(object sender, EventArgs e)
        {
            if (panelManage.Visible == true)
            {
                lblTitleControl.Text = "Add Section";
                btnControls.Text = "Show Manage Booking Section";
                panelAdd.Visible = true;
                panelManage.Visible = false;
                dGridViewMonthlyBookings.ClearSelection();
            }
            else if(dGridViewMonthlyBookings.SelectedRows.Count > 0)
            {
                lblTitleControl.Text = "Manage Section";
                btnControls.Text = "Show Add Booking Section";
                panelAdd.Visible = false;
                panelManage.Visible = true;
                populateSelectedBooking();
                panelUpdate();
            }
            else
            {
                MessageBox.Show("You must select a booking to manage", "Warning");
            }
        }

        //Check in method
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if(DateTime.Today != Convert.ToDateTime(dGridViewMonthlyBookings.SelectedRows[0].Cells[1].Value))
            {
                MessageBox.Show("You can only check-in on the day of the booking.", "Warning");
            }
            else if (MessageBox.Show("Are you sure you want to check in?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                advBookingUtil.AdviceDBA.BookingDBAccess.checkInBooking(Convert.ToInt32(dGridViewMonthlyBookings.SelectedRows[0].Cells[0].Value));
                btnResults.PerformClick();
            }
        }

        //View / Edit booking button
        private void btnVAEBooking_Click(object sender, EventArgs e)
        {
            advBookingUtil.LastFormLocation = this.DesktopLocation;
            advBookingUtil.SelectedID = Convert.ToInt32(dGridViewMonthlyBookings.SelectedRows[0].Cells[0].Value);
            advBookingUtil.SelectedDate = Convert.ToDateTime(dGridViewMonthlyBookings.SelectedRows[0].Cells[1].Value);
            advBookingUtil.AdvNav.gotoForm("cformAddEditBooking", advBookingUtil);
            Hide();
        }

        public void populateSelectedBooking()
        {
            lblSelectedDate.Text = "Date: " + dGridViewMonthlyBookings.SelectedRows[0].Cells[1].Value;
            lblSelectedTime.Text = "Time: " + dGridViewMonthlyBookings.SelectedRows[0].Cells[2].Value;
            lblSelectedCustomer.Text = "Customer: " + dGridViewMonthlyBookings.SelectedRows[0].Cells[3].Value;
            lblSelectedStaff.Text = "Staff: " + dGridViewMonthlyBookings.SelectedRows[0].Cells[4].Value;
            lblSelectedPriority.Text = dGridViewMonthlyBookings.SelectedRows[0].Cells[8].Value.ToString();

            if (dGridViewMonthlyBookings.SelectedRows[0].Cells[7].Value.ToString() == "Upcoming" || dGridViewMonthlyBookings.SelectedRows[0].Cells[7].Value.ToString() == "Waiting")
            {
                btnCheckIn.Enabled = true;
            }
            else
            {
                btnCheckIn.Enabled = false;
            }          
            
            if(dGridViewMonthlyBookings.SelectedRows[0].Cells[8].Value.ToString() == "Urgent")
            {
                lblSelectedPriority.ForeColor = Color.Yellow;
            }
            else
            {
                lblSelectedPriority.ForeColor = Color.White;
            }
        }

        //Despite the name, this is for the appointment card report generation
        private void btnOfficeDiary_Click(object sender, EventArgs e)
        {
            if(DateTime.Today < Convert.ToDateTime(dGridViewMonthlyBookings.SelectedRows[0].Cells[1].Value))
            {
                advBookingUtil.LastFormLocation = DesktopLocation;
                advBookingUtil.LastForm = this;
                advBookingUtil.AdvNav.goToReportForm(advBookingUtil, Convert.ToInt32(dGridViewMonthlyBookings.SelectedRows[0].Cells[0].Value));
                this.Hide();
            }
            else
            {
                MessageBox.Show("You cannot generate a reciept for a past booking or a booking today.", "Warning");
            }
        }

        private void dGridViewMonthlyBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelUpdate();
        }

        //Colour cordination for specific cells
        private void dGridViewMonthlyBookings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i <= dGridViewMonthlyBookings.Rows.Count - 1; i++)
            {
                if (dGridViewMonthlyBookings.Rows[i].Cells[7].Value.ToString() == "Upcoming")
                {
                    dGridViewMonthlyBookings.Rows[i].Cells[7].Style.BackColor = Color.FromArgb(255, 128, 0);
                }
                else if (dGridViewMonthlyBookings.Rows[i].Cells[7].Value.ToString() == "Checked In")
                {
                    dGridViewMonthlyBookings.Rows[i].Cells[7].Style.BackColor = Color.LimeGreen;
                }
                else if (dGridViewMonthlyBookings.Rows[i].Cells[7].Value.ToString() == "Missed")
                {
                    dGridViewMonthlyBookings.Rows[i].Cells[7].Style.BackColor = Color.Red;
                }
                else if (dGridViewMonthlyBookings.Rows[i].Cells[7].Value.ToString() == "Waiting")
                {
                    dGridViewMonthlyBookings.Rows[i].Cells[7].Style.BackColor = Color.LightBlue ;
                }

                if(dGridViewMonthlyBookings.Rows[i].Cells[8].Value.ToString() == "Urgent")
                {
                    dGridViewMonthlyBookings.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                }
            }
        }

        public void panelUpdate()
        {
            try
            {
                if (panelManage.Visible == false)
                {
                    btnControls.PerformClick();
                }
                populateSelectedBooking();

                if (Convert.ToDateTime(dGridViewMonthlyBookings.SelectedRows[0].Cells[1].Value) >= DateTime.Today)
                {
                    btnVAEBooking.Text = "View / Edit Booking";
                    btnVAEBooking.BackColor = Color.FromArgb(192, 0, 192);
                    btnVAEBooking.FlatAppearance.MouseOverBackColor = Color.Purple;
                    btnVAEBooking.FlatAppearance.MouseDownBackColor = Color.Purple;
                }
                else
                {
                    btnVAEBooking.Text = "View Booking";
                    btnVAEBooking.BackColor = Color.Red;
                    btnVAEBooking.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 0, 0);
                    btnVAEBooking.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 0, 0);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //Ensure combo box is not editable 
        private void cbCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbPriority_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void formAppointments_VisibleChanged(object sender, EventArgs e)
        {
            btnResults.PerformClick();
        }

        private void formAppointments_MdiChildActivate(object sender, EventArgs e)
        {
            advBookingUtil.LastForm = new formHome(advBookingUtil);
            advBookingUtil.LastFormLocation = this.DesktopLocation;
            AdvUtil = advBookingUtil;
        }
    }
}
