using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using BookingApplication.objects;
using BookingApplication.dbAccess;

namespace BookingApplication.gui
{
    public class AdviceBookingUtil
    {
        private Database db;
        private bool firstStartup;
        private Point lastFormLocation;
        private Form previousForm;

        private AdviceDBAccess advDBAccessObjects;
        private AdviceMethods advMethods;
        private AdviceNav advNav;

        //Volitile-like variables - REMOVE
        private DateTime selectedDate;
        private int selectedID;
        private int selectedTimeSlot;

        public AdviceBookingUtil(Database db)
        {
            this.db = db;
            advDBAccessObjects = new AdviceDBAccess(db);
            advMethods = new AdviceMethods(db);
            advNav = new AdviceNav(db);
        }

        //Get-Setters
        public bool FirstStartup
        {
            get { return firstStartup; }
            set { firstStartup = value; }
        }

        public AdviceDBAccess AdviceDBA
        {
            get { return advDBAccessObjects; }
            set { advDBAccessObjects = value; }
        }

        public AdviceMethods AdvMethods
        {
            get { return advMethods; }
            set { advMethods = value; }
        }

        public AdviceNav AdvNav
        {
            get { return advNav; }
            set { advNav = value; }
        }

        public Point LastFormLocation
        {
            get { return lastFormLocation; }
            set { lastFormLocation = value; }
        }

        public Form LastForm
        {
            get { return previousForm; }
            set { previousForm = value; }
        }

        //Selection
        public DateTime SelectedDate
        {
            get { return selectedDate; }
            set { selectedDate = value; }
        }

        public int SelectedID
        {
            get { return selectedID; }
            set { selectedID = value; }
        }

        public int SelectedTimeSlot
        {
            get { return selectedTimeSlot; }
            set { selectedTimeSlot = value; }
        }
    }
}
