using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.objects
{
    public class Staff
    {
        int staffId;
        string forename;
        string surname;
        string jobTitle;
        string jobDesc;
        bool activeUser;

        public Staff()
        {
        }

        public Staff(int staffId, string forename, string surname, string jobTitle, string jobDesc, bool activeUser)
        {
            this.staffId = staffId;
            this.forename = forename;
            this.surname = surname;
            this.jobTitle = jobTitle;
            this.jobDesc = jobDesc;
            this.activeUser = activeUser;
        }

        public int StaffId
        {
            get { return staffId; }
            set { staffId = value; }
        }

        public string Forename
        {
            get { return forename; }
            set { forename = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public string JobDesc
        {
            get { return jobDesc; }
            set { jobDesc = value; }
        }

        public bool ActiveUser
        {
            get { return activeUser; }
            set { activeUser = value; }
        }

        public override string ToString()
        {
            if (StaffId == -1)
            {
                return "(Not Specified)";
            }
            else
            {
                return forename + " " + surname + " (ID: " + StaffId + ")";
            }
        }
    }
}
