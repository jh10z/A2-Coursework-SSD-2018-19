using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookingApplication.dbAccess;
using BookingApplication.objects;

namespace BookingApplication.gui
{
    public partial class cformViewCustomers : cform
    {
        AdviceBookingUtil advBookingUtilities;
        List<Customer> customers;
        Customer custObj;

        public cformViewCustomers(AdviceBookingUtil advBookingUtilities) : base()
        {
            InitializeComponent();
            this.advBookingUtilities = advBookingUtilities;
            DesktopLocation = advBookingUtilities.LastFormLocation;
            populateListBox(customers = advBookingUtilities.AdviceDBA.CustDBAccess.getAllCustomers());
            txtbListSearch_Leave(new object { }, new EventArgs { });
            cFormTitle.Text = "Advice | View Customers";
            listBoxCustomers.SelectedIndex = 0;
            dGridViewUpcoming.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelCustName.Enabled = true;
            panelCustView.Enabled = true;
            dGridViewUpcoming.Enabled = true;

            custObj = (Customer) listBoxCustomers.SelectedItem;
            lblName.Text = custObj.Forename + " " + custObj.Surname;
            lblAge.Text = "Age | " + advBookingUtilities.AdvMethods.calcAge(custObj.DOB);
            lblDOB.Text = "Date of Birth | " + custObj.DOB.ToShortDateString();
            lblAddress.Text = custObj.Address;
            lblTown.Text = "Town | " + custObj.Town;
            lblPostcode.Text = "Postcode | " + custObj.Postcode;
            lblEmail.Text = custObj.EmailAddress;
            lblTelNo.Text = "TelNo: " + custObj.TelNo;

            populateGridView(custObj.CustomerId);
        }

        //Search functionality for customers
        private void txtbListSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtbListSearch.Text == "Search...")
            {
                populateListBox(customers);
            }

            else if (txtbListSearch.Text != string.Empty)
            {
                
                List<Customer> searchResults = new List<Customer>();

                foreach (Customer cust in customers)
                {
                    if ((cust.Forename + cust.Surname).ToLower().Replace(" ", string.Empty).Contains(txtbListSearch.Text.ToLower().Replace(" ", string.Empty)))
                    {
                        searchResults.Add(cust);
                    }
                }
                if (searchResults.Count == 0)
                {
                    panelCustView.Enabled = false;
                    panelCustName.Enabled = false;
                    dGridViewUpcoming.Enabled = false;
                }

                populateListBox(searchResults);  
                                        
            }
            else
            {
                populateListBox(customers);
            }
        }

        //Button Events
        //Add new customer button, brings user to addeditcustomer form
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            advBookingUtilities.LastForm = this;
            advBookingUtilities.LastFormLocation = this.DesktopLocation;
            int custId = Convert.ToInt32(listBoxCustomers.SelectedValue);
            advBookingUtilities.AdvNav.goToCustomerForm(advBookingUtilities, true, new Customer() { CustomerId = advBookingUtilities.AdviceDBA.CustDBAccess.getNextCustomerID() });
            this.Hide();
        }

        //Brings user to addeditcustomer form
        private void btnEditDel_Click(object sender, EventArgs e)
        {
            advBookingUtilities.LastForm = this;
            advBookingUtilities.LastFormLocation = this.DesktopLocation;
            advBookingUtilities.AdvNav.goToCustomerForm(advBookingUtilities, false, (Customer)listBoxCustomers.SelectedItem);
            this.Hide();
        }

        //Removes watermark for textbox
        private void txtbListSearch_Enter(object sender, EventArgs e)
        {
            txtbListSearch.Text = string.Empty;
            txtbListSearch.ForeColor = Color.Black;
            listBoxCustomers.SelectedIndex = 0;
           
        }

        //Watermark for textbox
        private void txtbListSearch_Leave(object sender, EventArgs e)
        {
            if (txtbListSearch.Text == string.Empty)
            {
                txtbListSearch.Text = "Search...";
                txtbListSearch.ForeColor = Color.Silver;
            }

        }

        //Populate the customer list box with active customers
        public void populateListBox(List<Customer> customers)
        {
            listBoxCustomers.Items.Clear();
            listBoxCustomers.Items.AddRange(customers.ToArray());
            if (listBoxCustomers.Items.Count > 0)
            {
                listBoxCustomers.SelectedIndex = 0;
            }
        }

        //Populate the upcoming appointments data grid view
        public void populateGridView(int custId)
        {
            dGridViewUpcoming.DataSource = advBookingUtilities.AdvMethods.viewBookingDataTable(advBookingUtilities.AdviceDBA.BookingDBAccess.getUpcomingAppointmentsForCustomer(custId));
            //Hiding unneccesary columns
            dGridViewUpcoming.Columns[0].Visible = false;
            dGridViewUpcoming.Columns[3].Visible = false;
            dGridViewUpcoming.Columns[6].Visible = false;
            dGridViewUpcoming.Columns[8].Visible = false;
            //Setting column widths appropriately based on expected width and the overall width to fit in the data grid view width
            dGridViewUpcoming.Columns[1].Width = 90;
            dGridViewUpcoming.Columns[2].Width = 75;
            dGridViewUpcoming.Columns[4].Width = 140;
            dGridViewUpcoming.Columns[5].Width = 135;
            dGridViewUpcoming.Columns[7].Width = 101;
            dGridViewUpcoming.ClearSelection();

            if(dGridViewUpcoming.Rows.Count < 1)
            {
                lblIndicator.Show();
            }
            else
            {
                lblIndicator.Hide();
            }  
        }

        //Gives colour to specific cells
        private void dGridViewUpcoming_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.dGridViewUpcoming.DefaultCellStyle.Font = new Font("Arial", 8);
            this.dGridViewUpcoming.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8);

            for (int i = 0; i <= dGridViewUpcoming.Rows.Count - 1; i++)
            {
                if (dGridViewUpcoming.Rows[i].Cells[7].Value.ToString() == "Upcoming")
                {
                    dGridViewUpcoming.Rows[i].Cells[7].Style.BackColor = Color.FromArgb(255, 128, 0);
                }
                else if (dGridViewUpcoming.Rows[i].Cells[7].Value.ToString() == "Waiting")
                {
                    dGridViewUpcoming.Rows[i].Cells[7].Style.BackColor = Color.LightBlue;
                }

                if (dGridViewUpcoming.Rows[i].Cells[8].Value.ToString() == "Urgent")
                {
                    dGridViewUpcoming.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                }
            }
        }

        private void dGridViewUpcoming_SelectionChanged(object sender, EventArgs e)
        {
            dGridViewUpcoming.ClearSelection();
        }

        private void cformViewCustomers_VisibleChanged(object sender, EventArgs e)
        {
            populateListBox(customers = advBookingUtilities.AdviceDBA.CustDBAccess.getAllCustomers());

            //Windows form bug fix - ignore
            this.dGridViewUpcoming.DefaultCellStyle.Font = new Font("Arial", 8);
            this.dGridViewUpcoming.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8);
        }

        private void cformViewCustomers_MdiChildActivate(object sender, EventArgs e)
        {
            advBookingUtilities.LastForm = new formHome(advBookingUtilities);
            advBookingUtilities.LastFormLocation = this.DesktopLocation;
            AdvUtil = advBookingUtilities;
        }
    }
}
