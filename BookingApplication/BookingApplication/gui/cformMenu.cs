using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using BookingApplication.objects;
using System.IO;

namespace BookingApplication.gui
{
    public partial class cformMenu : cform
    {
        AdviceBookingUtil advBookingUtil;

        public cformMenu(AdviceBookingUtil advBookingUtil): base()
        {
            InitializeComponent();
            cFormTitle.Text = "Woodside Community Hub | Menu";
            
            this.advBookingUtil = advBookingUtil;
            if (advBookingUtil.FirstStartup == true)
            {
                CenterToScreen();
                advBookingUtil.FirstStartup = false;
            }
            else { this.DesktopLocation = advBookingUtil.LastFormLocation; }
            BackToMenuToolStripMenuItem.Enabled = false;
            BtnBack.Hide();
        }

        //Navigation
        private void btnAdvice_Click(object sender, EventArgs e)
        {
            advBookingUtil.LastForm = this;
            advBookingUtil.LastFormLocation = this.DesktopLocation;
            advBookingUtil.AdvNav.gotoForm("cformHome", advBookingUtil);
            this.Hide();
        }

        private void btnComplexCode_Click(object sender, EventArgs e)
        {
            String path = "file://" + Application.StartupPath + "/Complex Code.docx";
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

        //Compliments the inherited form imperatively
        private void cformMenu_MdiChildActivate(object sender, EventArgs e)
        {
            advBookingUtil.LastFormLocation = this.DesktopLocation;
            AdvUtil = advBookingUtil;
        }
    }
}
