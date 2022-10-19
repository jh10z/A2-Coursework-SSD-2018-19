using BookingApplication.objects;
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
    public partial class cformOfficeDiary : cform
    {
        AdviceBookingUtil advBookingUtil;
        private int columnSelected;
        private DateTime date;
        private int selectedId;
        private List<string> selectedBooking = new List<string>();

        public cformOfficeDiary(AdviceBookingUtil advBookingUtil, DateTime date) : base()
        {
            InitializeComponent();
            DesktopLocation = advBookingUtil.LastFormLocation;
            this.advBookingUtil = advBookingUtil;
            cFormTitle.Text = "Advice | Office Diary";
            this.date = date;
            populateOfficeDiary(date);
            picLunchR.BringToFront();
        }

        public void populateOfficeDiary(DateTime date)
        {
            dGridViewOfficeDiary.DataSource = advBookingUtil.AdvMethods.viewOfficeDiaryDataTable(advBookingUtil.AdviceDBA.BookingDBAccess.getBookingsDetailsByDateForOfficeDiary(date));
            for(int i = 0; i < dGridViewOfficeDiary.ColumnCount; i++)
            {
                if(i != 2)
                {
                    dGridViewOfficeDiary.Columns[i].Width = 114; //122 no row /45
                }
                else
                {
                    dGridViewOfficeDiary.Columns[i].Width = 40;
                }
            }

            dGridViewOfficeDiary.ColumnHeadersHeight = 20;
        }

        //Window Forms stuff
        private void dGridViewOfficeDiary_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dGridViewOfficeDiary.Rows.Count; i++)
            {                
                dGridViewOfficeDiary.Rows[i].HeaderCell.Value = "Room: " + (i + 1) * 10;
            }

            foreach (DataGridViewColumn column in dGridViewOfficeDiary.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dGridViewOfficeDiary.TopLeftHeaderCell.Value = "Office";
            dGridViewOfficeDiary.RowHeadersWidth = 98;
        }
        
        //If cell is populated, this event help extract and display relevant data
        private void dGridViewOfficeDiary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Control> labels = new List<Control>() { lblCustomer, lblPriority, lblDescri, lblStaff };
            columnSelected = dGridViewOfficeDiary.CurrentCell.ColumnIndex + 1;

            if (dGridViewOfficeDiary.CurrentCell.Value.ToString() == "" || dGridViewOfficeDiary.CurrentCell.Value.ToString() == "Open Slot")
            {
                btnReceipt.Enabled = false;
                btnCheck.Enabled = false;
                goto Error;
            }
            else if (columnSelected <= 2)
            {
                goto Selected;
            }
            else if(columnSelected > 2 && columnSelected != 3)
            {
                columnSelected -= 1;
                goto Selected;
            }

            Selected:

            btnReceipt.Enabled = true;
            panelControls.Enabled = true;
            //Tailor an SQL method later
            selectedBooking = advBookingUtil.AdviceDBA.BookingDBAccess.getBookingDetailsByOfficeAndDateAndTimeslot(dGridViewOfficeDiary.CurrentCell.RowIndex + 1, dTPMonth.Value.Date, columnSelected);
            selectedId = Convert.ToInt32(selectedBooking[0]);
            lblCustomer.Text = "Customer: " + selectedBooking[1];
            lblDescri.Text = selectedBooking[2];
            lblPriority.Text = "Priorty: " + selectedBooking[3];
            lblStaff.Text = "Staff: " + advBookingUtil.AdviceDBA.StaffDBAccess.getStaffName(advBookingUtil.AdviceDBA.StaffServiceDBAccess.getStaffIdbyStaffServiceId(Convert.ToInt16(selectedBooking[4])));

            if(selectedBooking[5] == "Upcoming" || selectedBooking[5] == "Waiting")
            {
                btnCheck.Enabled = true;
            }
            else
            {
                btnCheck.Enabled = false;
            }
            foreach (Control lbl in labels)
            {
                lbl.Show();
            }
            lblNotify.Hide();
            return;

            Error:
            foreach (Control ctrl in labels)
            {
                ctrl.Hide();
            }
            lblNotify.Show();
        }

        //Check in event
        private void btnCheckReplace_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Today != date)
                {
                    MessageBox.Show("You can only check-in on the day of the booking.", "Warning");
                }
                else if (MessageBox.Show("Are you sure you want to check in?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    advBookingUtil.AdviceDBA.BookingDBAccess.checkInBooking(selectedId);
                }
            }
            catch(Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void cformOfficeDiary_Load(object sender, EventArgs e)
        {
            dGridViewOfficeDiary_CellClick(this.dGridViewOfficeDiary, new DataGridViewCellEventArgs(0, 0));
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            advBookingUtil.LastFormLocation = this.DesktopLocation;
            advBookingUtil.SelectedID = selectedId;
            advBookingUtil.SelectedDate = date;
            advBookingUtil.AdvNav.gotoForm("cformAddEditBooking", advBookingUtil);
            Hide();
        }

        private void dTPMonth_CloseUp(object sender, EventArgs e)
        {
            populateOfficeDiary(dTPMonth.Value);
            lblTitle.Text = "Schedule: ";
            if (dTPMonth.Value.Date == DateTime.Today)
            {
                lblTitle.Text += "Today";
            }
            else
            {
                lblTitle.Text += dTPMonth.Value.Date.ToShortDateString();
            }
            dGridViewOfficeDiary_CellClick(this.dGridViewOfficeDiary, new DataGridViewCellEventArgs(0, 0));
        }

        //Adds colour to specific cells
        private void dGridViewOfficeDiary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int col = 0;
            for (int i = 1; i < 5; i++)
            {
                for (int r = 1; r < 5; r++)
                {
                    col = i;
                    if (i > 2)
                    {
                        col += 1;
                    }
                    List<string> booking = advBookingUtil.AdviceDBA.BookingDBAccess.getBookingDetailsByOfficeAndDateAndTimeslot(r, dTPMonth.Value.Date, i);
                    if(booking != null)
                    {
                        if (booking[5] == "Upcoming")
                        {
                            dGridViewOfficeDiary.Rows[r - 1].Cells[col - 1].Style.BackColor = Color.FromArgb(255, 128, 0);
                        }
                        else if (booking[5] == "Checked In")
                        {
                            dGridViewOfficeDiary.Rows[r - 1].Cells[col - 1].Style.BackColor = Color.LimeGreen;
                        }
                        else if (booking[5] == "Missed")
                        {
                            dGridViewOfficeDiary.Rows[r - 1].Cells[col - 1].Style.BackColor = Color.Red;
                        }
                        else if (booking[5] == "Waiting")
                        {
                            dGridViewOfficeDiary.Rows[r - 1].Cells[col - 1].Style.BackColor = Color.LightBlue;
                        }

                    }

                }
            }
        }


        //Goes to appointment card report
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (DateTime.Today < dTPMonth.Value.Date)
            {
                advBookingUtil.LastFormLocation = DesktopLocation;
                advBookingUtil.LastForm = this;
                advBookingUtil.AdvNav.goToReportForm(advBookingUtil, Convert.ToInt32(selectedBooking[0]));
                this.Hide();
            }
            else
            {
                MessageBox.Show("You cannot generate a reciept for a past booking or a booking today.", "Warning");
            }
        }

        private void cformOfficeDiary_MdiChildActivate(object sender, EventArgs e)
        {
            advBookingUtil.LastFormLocation = this.DesktopLocation;
            AdvUtil = advBookingUtil;
        }
    }
}
