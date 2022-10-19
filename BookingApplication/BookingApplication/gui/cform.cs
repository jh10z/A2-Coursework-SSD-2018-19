using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingApplication.gui
{
    public partial class cform : Form
    {
        AdviceBookingUtil advUtil;

        public cform()
        {
            InitializeComponent();
        }

        public Label cFormTitle
        {
            get { return lblFormTitle; }
            set { lblFormTitle = value; }
        }
        
        public AdviceBookingUtil AdvUtil
        {
            get { return advUtil; }
            set { advUtil = value; }
        }

        public ToolStripMenuItem BackToMenuToolStripMenuItem
        {
            get { return backToMenuToolStripMenuItem; }
            set { backToMenuToolStripMenuItem = value; }
        }

        public ToolStripMenuItem AppointmentsToolStripMenuItem
        {
            get { return appointmentsToolStripMenuItem; }
            set { appointmentsToolStripMenuItem = value; }
        }

        public Button BtnBack
        {
            get { return btnBack; }
            set { btnBack = value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the application?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navMethod("cformMenu");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit.PerformClick();
        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navMethod("cformAppointment");

        }

        //Navigation method for back button
        public void navMethod(string selectedForm)
        {
            Form childForm = ActiveForm;
            ActivateMdiChild(childForm);
            advUtil.AdvNav.gotoForm(selectedForm, advUtil);
            childForm.Hide();
        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String path = "file://" + Application.StartupPath + "/User Guide.pdf";
            var uri = new System.Uri(path);
            if (File.Exists(uri.LocalPath))
            {
                try
                {
                    Process.Start(path);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message + " " + path);
                }
            }
            else
            {
                MessageBox.Show("Can't open " + path);
            }
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navMethod("cformHome");
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Due to skill repetition, I have decided to leave this out to minimise length of testing.", "Warning");
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Due to skill repetition, I have decided to leave this out to minimise length of testing.", "Warning");
        }

        private void getReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = ActiveForm;
            ActivateMdiChild(childForm);
            advUtil.AdvNav.goToOfficeDiary(advUtil, DateTime.Today);
            childForm.Hide();
        }

        private void upcomingNotificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navMethod("cformCustomers");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backNavMethod();
        }

        public void backNavMethod() //Turned into a method to 
        {
            Form childForm = ActiveForm;
            ActivateMdiChild(childForm);
            advUtil.LastForm.Show();
            childForm.Hide();
        }

        //Allows window to be moved
        #region Window Drag Bar
        //Window Drag Bar
        private bool mouseDown;
        private Point lastLocation;

        private void panelDragBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelDragBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panelDragBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
    }
}
