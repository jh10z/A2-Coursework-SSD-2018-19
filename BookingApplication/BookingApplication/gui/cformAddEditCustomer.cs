using System;
using BookingApplication.exceptions;
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
    public partial class cformAddEditCustomer : cform
    {
        AdviceBookingUtil advBookingUtilities;
        Customer custObj;
        string firstName = "New", lastName = "Customer";
        bool newCustomer;

        //Validity Flags
        bool nameIsValid = false;
        bool dobIsValid = false;
        bool atIsValid = false;
        bool postcodeIsValid = false;
        bool emailIsValid = false;
        bool teleIsValid = false;

        public cformAddEditCustomer(AdviceBookingUtil advBookingUtilities, bool newCustomer, Customer custObj): base()
        {
            InitializeComponent();
            BtnBack.Text = "Cancel";
            cFormTitle.Text = "Advice | Add / Edit Customer";
            this.advBookingUtilities = advBookingUtilities;
            this.custObj = custObj;
            this.DesktopLocation = advBookingUtilities.LastFormLocation;
            dtpDOB.MaxDate = DateTime.Now.AddYears(-18);
            custFormSetup(newCustomer);
        }

        //Sets up form depending on need
        public void custFormSetup(bool newCustomer)
        {
            dtpDOB.MaxDate = DateTime.Today;
            if (newCustomer)
            {

                lblCustId.Text = "ID: " + custObj.CustomerId;
                btnDel.Hide();
                btnSave.Text = "Add New Customer";

                //Error Labels
                List<Label> lbl = new List<Label> { lblV1, lblV3, lblV4, lblV5, lblV6 };
                foreach (Label l in lbl)
                {
                    l.Text = "Fill";
                    l.ForeColor = Color.Orange;
                }
            }
            else
            {
                btnDel.Show();
                cFormTitle.Text = "Advice | Edit/Delete Customer";
                lblTitle.Text = "Edit/Delete Existing Customer";           

                lblCustomerName.Text = custObj.Forename + " " + custObj.Surname;
                lblCustId.Text = "ID: " + custObj.CustomerId;
                txtbForename.Text = custObj.Forename;
                txtbSurname.Text = custObj.Surname;
                dtpDOB.Value = custObj.DOB;
                txtbAddress.Text = custObj.Address;
                txtbTown.Text = custObj.Town;
                txtbPostcode.Text = custObj.Postcode;
                txtbEmailAddress.Text = custObj.EmailAddress;
                txtbTeleNo.Text = custObj.TelNo;
            }
            this.newCustomer = newCustomer;
        }
       

        //Save customer details
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(nameIsValid && dobIsValid && atIsValid && postcodeIsValid && emailIsValid && teleIsValid)
                {
                    //Editing a customer
                    if (!newCustomer)
                    {
                        advBookingUtilities.AdviceDBA.CustDBAccess.updateCustomer(txtbForename.Text.Trim(), txtbSurname.Text.Trim(), dtpDOB.Value.Date, txtbAddress.Text.Trim(), txtbTown.Text.Trim(), txtbPostcode.Text.Trim().ToUpper(), txtbEmailAddress.Text.Trim(), txtbTeleNo.Text.Trim(), custObj.CustomerId);
                        MessageBox.Show("The customer, " + txtbForename.Text + " " + txtbSurname.Text + ", has been updated!", "Saved");
                        BtnBack.PerformClick();
                        this.Hide();
                    }
                    else
                    {
                        //Saving a new customer
                        advBookingUtilities.AdviceDBA.CustDBAccess.insertCustomer(custObj.CustomerId, txtbForename.Text.Trim(), txtbSurname.Text.Trim(), dtpDOB.Value.Date, txtbAddress.Text.Trim(), txtbTown.Text.Trim(), txtbPostcode.Text.Trim().ToUpper(), txtbEmailAddress.Text.Trim(), txtbTeleNo.Text.Trim());
                        MessageBox.Show(txtbForename.Text + " " + txtbSurname.Text + " has been saved to the database.", "Success");
                        advBookingUtilities.SelectedID = 1;
                        BtnBack.PerformClick();
                        this.Hide();

                    }
                    advBookingUtilities.LastFormLocation = this.DesktopLocation;
                }
                else
                {
                    MessageBox.Show("All fields must be valid and filled in.", "Warning");
                }
            }
            catch (AddEditCustomer aec)
            {
                MessageBox.Show(aec.Message);
            }
        }

        private void txtbForename_TextChanged(object sender, EventArgs e)
        {
            displayName();

            if (!txtbForename.Text.All(Char.IsLetter))
            {
                txtbForename.Text = txtbForename.Text.Remove(txtbForename.Text.Length - 1);
                txtbForename.SelectionStart = txtbForename.Text.Length;
                lblVOne.Show();
                nameIsValid = true;
            }
            else if (txtbForename.Text == string.Empty || txtbSurname.Text == string.Empty)
            {
                lblVOne.Hide();
                lblV1.Text = "Fill";
                lblV1.ForeColor = Color.Orange;
            }
            else
            {
                lblVOne.Hide();
                lblV1.Text = "Valid";
                lblV1.ForeColor = Color.Lime;
                nameIsValid = true;
                return;
            }
            nameIsValid = false;
        }

        private void txtbSurname_TextChanged(object sender, EventArgs e)
        {
            displayName();

            if (!txtbSurname.Text.All(Char.IsLetter))
            {
                txtbSurname.Text = txtbSurname.Text.Remove(txtbSurname.Text.Length - 1);
                txtbSurname.SelectionStart = txtbSurname.Text.Length;
                lblVOne.Show();
                nameIsValid = true;
            }
            else if (txtbSurname.Text == string.Empty || txtbForename.Text == string.Empty)
            {
                lblVOne.Hide();
                lblV1.Text = "Fill";
                lblV1.ForeColor = Color.Orange;
            }
            else
            {
                lblVOne.Hide();
                lblV1.Text = "Valid";
                lblV1.ForeColor = Color.Lime;
                nameIsValid = true;
                return;
            }
            nameIsValid = false;
        }

        private void txtbTeleNo_TextChanged(object sender, EventArgs e)
        {
            if (!txtbTeleNo.Text.All(Char.IsDigit))
            {
                txtbTeleNo.Text = txtbTeleNo.Text.Remove(txtbTeleNo.Text.Length - 1);
                txtbTeleNo.SelectionStart = txtbTeleNo.Text.Length;
                lblTeleError.Show();
                teleIsValid = true;
            }
            else if (txtbTeleNo.Text == string.Empty || txtbTeleNo.TextLength < 11)
            {
                lblTeleError.Hide();
                lblV6.Text = "Fill";
                lblV6.ForeColor = Color.Orange;
            }
            else
            {
                lblTeleError.Hide();
                lblV6.Text = "Valid";
                lblV6.ForeColor = Color.Lime;
                teleIsValid = true;
                return;
            }
            teleIsValid = false;
        }

        private void cformAddEditCustomer_MdiChildActivate(object sender, EventArgs e)
        {
            advBookingUtilities.LastFormLocation = this.DesktopLocation;
            AdvUtil = advBookingUtilities;
        }

        //Deactivates users
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to deactivate this customer? Any upcoming appointments for this customer will be deleted.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    advBookingUtilities.AdviceDBA.CustDBAccess.deleteCustomer(custObj.CustomerId);
                    advBookingUtilities.LastFormLocation = this.DesktopLocation;
                    advBookingUtilities.AdvNav.gotoForm("cformCustomers", advBookingUtilities);
                    this.Hide();
                }
            }
            catch (AddEditCustomer aec)
            {
                MessageBox.Show(aec.Message);
            }
        }

        //User-friendly validity checker and reductor
        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            if(advBookingUtilities.AdvMethods.calcAge(dtpDOB.Value.Date) < 18)
            {
                lblVTwo.Show();
                lblV2.Text = "Invalid";
                lblV2.ForeColor = Color.Red;
                dobIsValid = false;
            }
            else
            {
                lblVTwo.Hide();
                lblV2.Text = "Valid";
                lblV2.ForeColor = Color.Lime;
                dobIsValid = true;
            }
        }

        private void txtbEmailAddress_TextChanged(object sender, EventArgs e)
        {
            if (advBookingUtilities.AdvMethods.checkEmail(txtbEmailAddress.Text.Trim()))
            {
                lblEmailError.Hide();
                lblV5.Text = "Valid";
                lblV5.ForeColor = Color.Lime;
                emailIsValid = true;
                return;
            }
            else if (txtbEmailAddress.Text == string.Empty)
            {
                lblEmailError.Hide();
                lblV5.Text = "Fill";
                lblV5.ForeColor = Color.Orange;
            }
            else
            {
                lblEmailError.Show();
                lblV5.Text = "Invalid";
                lblV5.ForeColor = Color.Red;
            }
            emailIsValid = false;
        }

        private void txtbPostcode_TextChanged(object sender, EventArgs e)
        {
            if (advBookingUtilities.AdvMethods.checkPostcode(txtbPostcode.Text.Trim().ToUpper()))
            {
                lblPostcodeError.Hide();
                lblV4.Text = "Valid";
                lblV4.ForeColor = Color.Lime;
                emailIsValid = false;
                postcodeIsValid = true;
                return;
            }
            else if(txtbPostcode.Text == string.Empty)
            {
                lblV4.Text = "Fill";
                lblV4.ForeColor = Color.Orange;
                emailIsValid = false;
                lblPostcodeError.Hide();
            }
            else
            {
                lblV4.Text = "Invalid";
                lblV4.ForeColor = Color.Red;
                emailIsValid = false;
                lblPostcodeError.Show();
            }
            postcodeIsValid = false;
        }

        private void txtbAddress_TextChanged(object sender, EventArgs e)
        {
            if(txtbAddress.Text == string.Empty || txtbTown.Text == string.Empty)
            {
                lblV3.Text = "Fill";
                lblV3.ForeColor = Color.Orange;
                atIsValid = false;
            }
            else
            {
                lblV3.Text = "Valid";
                lblV3.ForeColor = Color.Lime;
                atIsValid = true;
            }
        }

        private void txtbTown_TextChanged(object sender, EventArgs e)
        {
            if (txtbTown.Text == string.Empty || txtbAddress.Text == string.Empty)
            {
                lblV3.Text = "Fill";
                lblV3.ForeColor = Color.Orange;
                atIsValid = false;
            }
            else
            {
                lblV3.Text = "Valid";
                lblV3.ForeColor = Color.Lime;
                atIsValid = true;
            }
        }

        //Aesthetical 
        public void displayName()
        {
            if (txtbForename.Text != string.Empty || txtbSurname.Text != string.Empty)
            {
                firstName = txtbForename.Text;
                lastName = txtbSurname.Text;
            }
            else { firstName = string.Empty; lastName = string.Empty; }

            lblCustomerName.Text = firstName + " " + lastName;
        }
    }
}