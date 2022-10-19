using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookingApplication.objects;
using BookingApplication.exceptions;

namespace BookingApplication.gui
{
    public partial class cformAddEditBooking : cform
    {
        AdviceBookingUtil advBookingUtilities;
        bool newBooking;
        int bookingID;
        List<Control> entryFields;
        DataTable dt;
        Office officeObj;
        Staff staffObj;
        List<Staff> staffList;
        List<Office> officeList;
        List<string> currentBookingDetails;
        List<string> rebook;
        bool urgentMode = false;

        public cformAddEditBooking(): base()
        {
            dt = advBookingUtilities.AdvMethods.customerDataTable(advBookingUtilities.AdviceDBA.CustDBAccess.getAllCustomers());
            cbCustomer.ValueMember = dt.Columns[0].ToString();
            cbCustomer.DisplayMember = dt.Columns[1].ToString();
            cbCustomer.DataSource = dt;
        }

        public cformAddEditBooking(AdviceBookingUtil advBookingUtilities, bool newBooking): base()
        {
            InitializeComponent();
            BtnBack.Text = "Cancel";
            cFormTitle.Text = "Advice | Add / Edit Booking";
            this.advBookingUtilities = advBookingUtilities;
            this.newBooking = newBooking;
            DesktopLocation = advBookingUtilities.LastFormLocation;
        }

        //New booking form setup 
        public void newBookingFormSetup()
        {
            dt = advBookingUtilities.AdvMethods.customerDataTable(advBookingUtilities.AdviceDBA.CustDBAccess.getAllCustomers());
            cbCustomer.ValueMember = dt.Columns[0].ToString();
            cbCustomer.DisplayMember = dt.Columns[1].ToString();
            cbCustomer.DataSource = dt;
            updateTime();

            cbPriority.Text = "Normal";
            cbStatus.SelectedIndex = cbStatus.FindStringExact("Upcoming");
            cbStatus.Enabled = false;

            cbPriority.Enabled = false;
            entryFields = new List<Control>() {cbOffice, cbService, cbStaff};
            foreach (Control ctrl in entryFields)
            {
                ctrl.Enabled = false;
            }
            btnDelete.Hide();
        }

        //Booked form setup
        public void bookedSetup()
        {
            cbPriority.Enabled = false;
            currentBookingDetails = advBookingUtilities.AdviceDBA.BookingDBAccess.getBookingDetailsById(advBookingUtilities.SelectedID);
            lblTitle.Text = "Edit Booking (" + currentBookingDetails[4].Substring(0, currentBookingDetails[4].Length - 9) + ")"; //Substring + (-9) from length to get rid of time
            btnSave.Text = "Save Booking"; 
            int serviceId = advBookingUtilities.AdviceDBA.StaffServiceDBAccess.getServiceIdbyStaffServiceId(Convert.ToInt32(currentBookingDetails[3]));
            int staffId = advBookingUtilities.AdviceDBA.StaffServiceDBAccess.getStaffIdbyStaffServiceId(Convert.ToInt32(currentBookingDetails[3]));

            //Populating ComboBoxes
            cbCustomer.Items.Clear();
            cbCustomer.Items.Add(advBookingUtilities.AdviceDBA.CustDBAccess.getCustomerByID(Convert.ToInt16(currentBookingDetails[1])));
            cbCustomer.SelectedIndex = 0;

            officeObj = advBookingUtilities.AdviceDBA.OfficeDBAccess.getOfficeById(Convert.ToInt32(currentBookingDetails[2]));
            staffObj = advBookingUtilities.AdviceDBA.StaffDBAccess.getStaffById(staffId);

            bookingID = Convert.ToInt32(currentBookingDetails[0]);
        
            cbTime.SelectedValue = currentBookingDetails[5];
            txtbDesc.Text = currentBookingDetails[6];
            cbPriority.SelectedIndex = cbPriority.FindStringExact(currentBookingDetails[8]);
            advBookingUtilities.SelectedDate = Convert.ToDateTime(currentBookingDetails[4]);
            cbService.SelectedIndex = cbService.FindStringExact(advBookingUtilities.AdviceDBA.ServiceDBAccess.getServiceById(serviceId).ToString());
            cbStatus.SelectedIndex = cbStatus.FindStringExact(currentBookingDetails[7]);
            cbOffice.SelectedValue = currentBookingDetails[2];
            populateOffice();
            populateStaff();
            cbStatus.SelectedIndex = cbStatus.FindStringExact(currentBookingDetails[7]);
            cbOffice.SelectedValue = currentBookingDetails[2];
            cbStaff.SelectedIndex = cbStaff.FindStringExact(advBookingUtilities.AdviceDBA.StaffDBAccess.getStaffById(staffId).ToString());
            cbStatus.Enabled = false;

            if (advBookingUtilities.SelectedDate < DateTime.Today)
            {
                lblTitle.Text = "Past Booking (" + currentBookingDetails[4].Substring(0, currentBookingDetails[4].Length - 9) + ")"; //Substring + (-9) from length to get rid of time
                lblStaff.Text = "Staff";
                lblOffice.Text = "Office";
                lblService.Text = "Service";
                btnDelete.Hide();
                btnSave.Hide();
                btnAddNewCust.Hide();
                //cbCustomer.Text = "current"
            }
            else
            {
                panelControls.Enabled = true;
                cbPriority.Enabled = true;
                cbStatus.Enabled = true;
            }


        }

        //Saves booking on click event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks if everything is filled
                if (cbCustomer.SelectedItem == null || cbTime.SelectedItem == null || cbOffice.SelectedItem == null || cbService.SelectedItem == null || cbStaff.SelectedItem == null || cbPriority.SelectedItem == null || txtbDesc.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                //Statement for ugent booking
                else if (urgentMode && advBookingUtilities.AdviceDBA.BookingDBAccess.getBookingIdByStaffServiceTimeDate(advBookingUtilities.AdviceDBA.StaffServiceDBAccess.getStaffServiceIdByStaffAndService(((Staff)cbStaff.SelectedItem).StaffId, ((Service)cbService.SelectedItem).ServiceId), Convert.ToInt32(cbTime.SelectedValue), advBookingUtilities.SelectedDate) != -1)
                {
                    if (MessageBox.Show("Are you sure? This urgent booking will replace another booking. The previous slot holder will have their booking moved to the waiting list, deferred to two weeks later and set to urgent.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int rebookingId = advBookingUtilities.AdviceDBA.BookingDBAccess.getBookingIdByStaffServiceTimeDate(advBookingUtilities.AdviceDBA.StaffServiceDBAccess.getStaffServiceIdByStaffAndService(((Staff)cbStaff.SelectedItem).StaffId, ((Service)cbService.SelectedItem).ServiceId), Convert.ToInt32(cbTime.SelectedValue), advBookingUtilities.SelectedDate);
                        MessageBox.Show("The urgent booking room may have to be moved to accomadate a replacement. Please check the booking after the confirmation.");
                        advBookingUtilities.AdviceDBA.BookingDBAccess.replacedBooking(rebookingId);
                        advBookingUtilities.LastFormLocation = this.DesktopLocation;
                        advBookingUtilities.AdviceDBA.BookingDBAccess.insertBooking(Convert.ToInt32(cbCustomer.SelectedValue), advBookingUtilities.AdviceDBA.BookingDBAccess.getOfficeIdByBookingId(rebookingId), advBookingUtilities.AdviceDBA.StaffServiceDBAccess.getStaffServiceIdByStaffAndService(((Staff)cbStaff.SelectedItem).StaffId, ((Service)cbService.SelectedItem).ServiceId), advBookingUtilities.SelectedDate, Convert.ToInt32(cbTime.SelectedValue), txtbDesc.Text, cbPriority.SelectedItem.ToString(), 0);
                        advBookingUtilities.LastFormLocation = this.DesktopLocation;
                        advBookingUtilities.AdvNav.gotoForm("cformAppointment", advBookingUtilities);
                        this.Hide();

                    }
                }
                else
                {
                    //Custom Exception Throw
                    if (urgentMode && advBookingUtilities.AdviceDBA.BookingDBAccess.getBookingIdByOfficeTimeDate(Convert.ToInt32(cbOffice.SelectedValue), Convert.ToInt32(cbTime.SelectedValue), advBookingUtilities.SelectedDate) != -1) // Added to show custom exception use
                    {
                        throw new AddEditBooking("The office you have selected is currently in use.");
                    }
                    else if (MessageBox.Show("Are you sure you want to save?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        advBookingUtilities.LastFormLocation = this.DesktopLocation;

                        if (!newBooking)
                        {
                            //Updating an existing and future booking
                            advBookingUtilities.AdviceDBA.BookingDBAccess.updateBooking(advBookingUtilities.SelectedID, Convert.ToInt32(cbOffice.SelectedValue), advBookingUtilities.AdviceDBA.StaffServiceDBAccess.getStaffServiceIdByStaffAndService(((Staff)cbStaff.SelectedItem).StaffId, ((Service)cbService.SelectedItem).ServiceId), advBookingUtilities.SelectedDate, Convert.ToInt32(cbTime.SelectedValue), txtbDesc.Text, cbPriority.SelectedItem.ToString(), cbStatus.SelectedItem.ToString());
                            MessageBox.Show("The booking data has been updated!", "Saved");
                            advBookingUtilities.AdvNav.gotoForm("cformAppointment", advBookingUtilities);
                            this.Hide();
                        }
                        else                    
                        {
                            //Inserting a new booking
                            advBookingUtilities.AdviceDBA.BookingDBAccess.insertBooking(Convert.ToInt32(cbCustomer.SelectedValue), Convert.ToInt32(cbOffice.SelectedValue), advBookingUtilities.AdviceDBA.StaffServiceDBAccess.getStaffServiceIdByStaffAndService(((Staff)cbStaff.SelectedItem).StaffId, ((Service)cbService.SelectedItem).ServiceId), advBookingUtilities.SelectedDate, Convert.ToInt32(cbTime.SelectedValue), txtbDesc.Text, cbPriority.SelectedItem.ToString(), 0);
                            advBookingUtilities.LastFormLocation = this.DesktopLocation;
                            advBookingUtilities.AdvNav.gotoForm("cformAppointment", advBookingUtilities);
                            this.Hide();
                        }
                    }
                }
            }
            catch (AddEditBooking aeb)
            {
                MessageBox.Show(aeb.Message);
            }

        }

        //Delete booking click event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Prompt
                if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    advBookingUtilities.AdviceDBA.BookingDBAccess.deleteBooking(advBookingUtilities.SelectedID);
                    if (Convert.ToDateTime(currentBookingDetails[4]) == DateTime.Today)
                    {
                        MessageBox.Show("As the booking was today, no booking will replace this due to the shortness of notice. Thus, will be left for drop-in customers.", "Warning");
                    }
                    else if (advBookingUtilities.AdviceDBA.BookingDBAccess.getBookingIdByStaffServiceTimeDate(Convert.ToInt32(currentBookingDetails[3]), Convert.ToInt32(currentBookingDetails[5]), Convert.ToDateTime(currentBookingDetails[4]).AddDays(14)) != -1)
                    {
                        int waitbook = advBookingUtilities.AdviceDBA.BookingDBAccess.getBookingIdByStaffServiceTimeDate(Convert.ToInt32(currentBookingDetails[3]), Convert.ToInt32(currentBookingDetails[5]), Convert.ToDateTime(currentBookingDetails[4]).AddDays(14));
                        advBookingUtilities.AdviceDBA.BookingDBAccess.replacedBooking(waitbook, Convert.ToDateTime(currentBookingDetails[4]));
                        MessageBox.Show("The previous booking holder that was previously put on the waiting list will be moved in place of this deleted booking.", "Warning");
                    }
                    else
                    {
                        MessageBox.Show("Note: there are no direct wait listed booking to replace this cancelled booking", "Warning");
                    }
                    advBookingUtilities.LastFormLocation = this.DesktopLocation;
                    advBookingUtilities.AdvNav.gotoForm("cformAppointment", advBookingUtilities);
                    this.Hide();
                }
            }
            catch(Exception aeb)
            {
                MessageBox.Show(aeb.Message);
            }

        }

        //Customer Combobox, resets other fields
        private void cbCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateTime();
            int index = -1;
            if (cbTime.Items.Count == 0)
            {
                lblTime.Text = "No Times Available";
                lblTime.ForeColor = Color.Red;
                cbTime.Enabled = false;
            }
            else
            {
                if (cbTime.Items.Count == 1)
                {
                    index = 0;
                }
                else
                {
                }
                cbTime.SelectedIndex = index;
                cbOffice.SelectedIndex = -1;
                cbService.SelectedIndex = -1;
                cbStaff.SelectedIndex = -1;
                lblTime.ForeColor = Color.White;
                lblTime.Text = "Time";
                cbTime.Enabled = true;
            }
            cbOffice.Enabled = false;
            cbService.Enabled = false;
            cbStaff.Enabled = false;
            lblOffice.Text = "Office(s) Available";
            lblService.Text = "Service(s) Available";
            lblStaff.Text = "Staff Available";
        }

        //Time combo box, dependant on customer
        private void cbTime_SelectionChangeCommitted(object sender, EventArgs e)
        {
            populateOffice();
            int index = -1;
            if (officeList.Count == 0)
            {
                lblOffice.Text = "No Available Offices";
                lblOffice.ForeColor = Color.Red;
                cbOffice.Enabled = false;
            }
            else
            {
                if (officeList.Count == 1)
                {
                    index = 0;
                    cbService.Enabled = true;
                }
                else
                {
                    cbService.Enabled = false;
                }
                cbOffice.SelectedIndex = index;
                cbService.SelectedIndex = -1;
                cbStaff.SelectedIndex = -1;
                cbOffice.Enabled = true;
                lblOffice.ForeColor = Color.White;
            }
            cbService.Enabled = false;
            cbStaff.Enabled = false;
            lblService.Text = "Service(s) Available";
            lblStaff.Text = "Staff Available";
        }

        private void cbOffice_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbService.Enabled = true;
        }

        //Populate service combobox - no real dependecies
        private void cbService_SelectionChangeCommitted(object sender, EventArgs e)
        {
            populateStaff();
            int index = -1;
            if (staffList.Count == 0)
            { 
                lblStaff.Text = "No Available Staff";
                lblStaff.ForeColor = Color.Red;
                cbStaff.SelectedIndex = -1;
                cbStaff.ResetText();
                cbStaff.Enabled = false;
            }
            else
            {
                if (staffList.Count == 1)
                    index = 0;
                cbStaff.SelectedIndex = index;
                cbStaff.Enabled = true;
                lblStaff.ForeColor = Color.White;
            }
        }

        //ComboBox Population Methods
        public void populateOffice()
        {
            if(!urgentMode)
            {
                officeList = advBookingUtilities.AdviceDBA.OfficeDBAccess.getOfficesAvailable(advBookingUtilities.SelectedDate, Convert.ToInt32(cbTime.SelectedValue));
                if (!newBooking && !advBookingUtilities.AdvMethods.checkIfOfficeIsInList(Convert.ToInt32(officeObj.OfficeId), officeList))
                {
                    officeList.Add(officeObj);
                    officeList = officeList.OrderBy(o => o.OfficeId).ToList();
                }
                lblOffice.Text = "Office(s) Available (" + officeList.Count + ")";
                //Return List
                dt = advBookingUtilities.AdvMethods.officeDataTable(officeList);
                cbOffice.ValueMember = dt.Columns[0].ToString();
                cbOffice.DisplayMember = dt.Columns[1].ToString();
                cbOffice.DataSource = dt;
            }
            else
            {
                officeList = advBookingUtilities.AdviceDBA.OfficeDBAccess.getOfficesAvailable(advBookingUtilities.SelectedDate);
                lblOffice.Text = "Office(s) Available (" + officeList.Count + ")";
                //Return List
                dt = advBookingUtilities.AdvMethods.officeDataTable(officeList);
                cbOffice.ValueMember = dt.Columns[0].ToString();
                cbOffice.DisplayMember = dt.Columns[1].ToString();
                cbOffice.DataSource = dt;
            }
        }

        //Populate staff combo box method
        public void populateStaff()
        {
            cbStaff.Text = string.Empty;
            if (!urgentMode)
            {
                staffList = advBookingUtilities.AdviceDBA.StaffDBAccess.getStaffAvailable(advBookingUtilities.SelectedDate, Convert.ToInt32(cbTime.SelectedValue), ((Service)cbService.SelectedItem).ServiceId);
                if (!newBooking && advBookingUtilities.AdviceDBA.StaffServiceDBAccess.checkIfStaffIsInService(Convert.ToInt32(staffObj.StaffId), ((Service)cbService.SelectedItem).ServiceId) && !staffList.Any(item => item.StaffId == staffObj.StaffId))
                {
                    staffList.Add(staffObj);
                    staffList = staffList.OrderBy(o => o.StaffId).ToList();
                }
                lblStaff.Text = "Staff Available (" + staffList.Count + ")";
                cbStaff.Items.Clear();
                cbStaff.Items.AddRange(staffList.ToArray());
            }
            else
            {               
                staffList = advBookingUtilities.AdviceDBA.StaffDBAccess.getStaffAvailableUrgent(advBookingUtilities.SelectedDate, ((Service)cbService.SelectedItem).ServiceId, Convert.ToInt32(cbTime.SelectedValue));
                lblStaff.Text = "Staff Available (" + staffList.Count + ")";
                cbStaff.Items.Clear();
                cbStaff.Items.AddRange(staffList.ToArray());
            }
        }

        //On form load, load required stuff
        private void cformAddEditBooking_Load(object sender, EventArgs e)
        {
            cbService.Items.Clear();
            cbPriority.Items.Clear();
            cbStaff.Items.Clear();
            cbStatus.Items.Clear();
            
            cbService.Items.AddRange(advBookingUtilities.AdviceDBA.ServiceDBAccess.getServicesByDay(advBookingUtilities.SelectedDate).ToArray());
            cbPriority.Items.AddRange((new List<string>() { "Normal", "Urgent" }).ToArray()); //Could probably just make a list
            cbStatus.Items.AddRange((new List<string>() { "Upcoming", "Waiting", "Missed", "Checked In" }).ToArray());
            updateTime();

            cbTime.SelectedItem = null;
            cbCustomer.SelectedIndex = -1;
            cbOffice.SelectedIndex = -1;
            cbService.SelectedItem = -1;
            cbStaff.SelectedIndex = -1;
            cbPriority.SelectedIndex = -1;

            if (!newBooking)
            {
                cbCustomer.Items.Clear();
                bookedSetup();
                cbCustomer.Enabled = false;
                btnAddNewCust.Hide();
                //btnCheckDetails.Hide();
                panelPriority.SendToBack();
                label1.Show();
                cbPriority.Show();
                label7.Show();
                cbStatus.Show();

            }
            else
            {
                newBookingFormSetup();
                cbTime.SelectedItem = null;
                lblTitle.Text = "Add Booking (" + advBookingUtilities.SelectedDate.ToShortDateString() + ")";
                if(advBookingUtilities.SelectedID == 0)
                {
                    cbCustomer.SelectedIndex = 0;
                }
                else
                {
                    cbCustomer.SelectedIndex = cbCustomer.Items.Count - 1;
                }
            }

        }

        //Time combo box population method
        public void updateTime()
        {
            List<int> timeSlots;
            if (advBookingUtilities.SelectedDate == DateTime.Today)
            {
                timeSlots = advBookingUtilities.AdvMethods.returnAvailableTimeSlotsList();
            }
            else
            {
                timeSlots = new List<int>() { 1, 2, 3, 4 };
            }

            if(!urgentMode)
            {
                for (int i = 4; i > 0; i--)
                {
                    if (advBookingUtilities.AdviceDBA.BookingDBAccess.checkIfCustomerBookedDateTime(Convert.ToInt32(cbCustomer.SelectedValue), advBookingUtilities.SelectedDate, i))
                    {
                        timeSlots.RemoveAt(i - 1);
                    }

                }
            }

            dt = advBookingUtilities.AdvMethods.timeDataTable(timeSlots);
            cbTime.ValueMember = dt.Columns[0].ToString();
            cbTime.DisplayMember = dt.Columns[1].ToString();
            cbTime.DataSource = dt;
        }

        //Sets up form for normal booking
        private void btnNormal_Click(object sender, EventArgs e)
        {
            cbService.SelectedItem = null;
            cbStaff.SelectedItem = null;
            urgentMode = false;
            cbPriority.SelectedIndex = cbPriority.FindStringExact("Normal");
            panelPriority.SendToBack();
            panelControls.Enabled = true;
            label1.Show();
            cbPriority.Show();
            btnPriorityBack.Show();
            newBookingFormSetup();
            resetForms();
        }

        //Sets up form for urgent booking
        private void btnUrgent_Click(object sender, EventArgs e)
        {
            urgentMode = true;
            cbPriority.SelectedIndex = cbPriority.FindStringExact("Urgent");
            cbTime.SelectedItem = null;
            cbOffice.SelectedIndex = -1;
            cbService.SelectedItem = null;
            cbStaff.SelectedIndex = -1;
            panelPriority.SendToBack();
            panelControls.Enabled = true;
            label1.Show();
            cbPriority.Show();
            btnPriorityBack.Show();
            newBookingFormSetup();
            resetForms();
            cbPriority.SelectedIndex = cbPriority.FindStringExact("Urgent");
        }

        //A counter for characters used
        private void txtbDesc_TextChanged(object sender, EventArgs e)
        {
            lblCharLength.Text = txtbDesc.Text.Count() + "/500 Characters Used";
        }

        public void resetForms()
        {
            lblOffice.Text = "Office(s) Available";
            lblService.Text = "Service(s) Available";
            lblStaff.Text = "Staff Available";
            lblOffice.ForeColor = Color.White;
            lblStaff.ForeColor = Color.White;
            cbOffice.Enabled = false;
            cbService.Enabled = false;
            cbStaff.Enabled = false;
            updateTime();
            cbTime.SelectedItem = null;
            if (cbTime.Items.Count == 0)
            {
                cbTime.Enabled = false;
                lblTime.ForeColor = Color.Red;
                lblTime.Text = "No Times Available";
            }
        }

        private void btnPriorityBack_Click(object sender, EventArgs e)
        {
            panelControls.Enabled = false;
            panelPriority.BringToFront();
            cbPriority.Hide();
            label1.Hide();
            btnPriorityBack.Hide();
        }

        private void btnAddNewCust_Click(object sender, EventArgs e)
        {
            advBookingUtilities.LastForm = this;
            advBookingUtilities.LastFormLocation = this.DesktopLocation;
            advBookingUtilities.AdvNav.goToCustomerForm(advBookingUtilities, true, new Customer() { CustomerId = advBookingUtilities.AdviceDBA.CustDBAccess.getNextCustomerID() });
            this.Hide();
        }

        private void cbCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbOffice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbService_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //If an urgent booking is found, the booking is brought up for the user to see
        private void cbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbStaff.SelectedIndex > -1 && urgentMode && advBookingUtilities.AdviceDBA.BookingDBAccess.getBookingIdByStaffServiceTimeDate(advBookingUtilities.AdviceDBA.StaffServiceDBAccess.getStaffServiceIdByStaffAndService(((Staff)cbStaff.SelectedItem).StaffId, ((Service)cbService.SelectedItem).ServiceId), Convert.ToInt32(cbTime.SelectedValue), advBookingUtilities.SelectedDate) != -1)
            {
                int rebookingId = advBookingUtilities.AdviceDBA.BookingDBAccess.getBookingIdByStaffServiceTimeDate(advBookingUtilities.AdviceDBA.StaffServiceDBAccess.getStaffServiceIdByStaffAndService(((Staff)cbStaff.SelectedItem).StaffId, ((Service)cbService.SelectedItem).ServiceId), Convert.ToInt32(cbTime.SelectedValue), advBookingUtilities.SelectedDate);
                rebook = advBookingUtilities.AdviceDBA.BookingDBAccess.getBookingDetailsById(rebookingId);
                lblRBID.Text = "Booking ID: " + rebook[0];
                lblRBDate.Text = "Booking Date: " + rebook[4].Substring(0, rebook[4].Length - 9);
                lblRBStatus.Text = "Booking Status: " + rebook[7];
                lblRBPriority.Text = "Booking Priority: " + rebook[8];
                panelOverride.Show();
            }
            else
            {
                panelOverride.Hide();
            }
        }


        //Ensures that combo box cannot be edited
        private void cbStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbPriority_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnViewDesc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rebook[6], "Booking Description");
        }

        //When form comes back from customer creation form
        private void cformAddEditBooking_VisibleChanged(object sender, EventArgs e)
        {
            if(newBooking)
            {
                dt = advBookingUtilities.AdvMethods.customerDataTable(advBookingUtilities.AdviceDBA.CustDBAccess.getAllCustomers());
                cbCustomer.ValueMember = dt.Columns[0].ToString();
                cbCustomer.DisplayMember = dt.Columns[1].ToString();
                cbCustomer.DataSource = dt;
                if (advBookingUtilities.SelectedID == 0)
                {
                    cbCustomer.SelectedIndex = 0;
                }
                else
                {
                    cbCustomer.SelectedIndex = cbCustomer.Items.Count - 1;
                }
            }
        }

        private void cformAddEditBooking_MdiChildActivate(object sender, EventArgs e)
        {
            advBookingUtilities.LastForm = new formAppointments(advBookingUtilities);
            advBookingUtilities.LastFormLocation = this.DesktopLocation;
            AdvUtil = advBookingUtilities;
        }

    }
}
