using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.objects
{
    public class Office
    {
        int officeId;
        int roomNo;
        int floorNo;

        public Office()
        {
        }

        public Office(int officeId, int roomNo, int floorNo)
        {
            this.officeId = officeId;
            this.roomNo = roomNo;
            this.floorNo = floorNo;
        }

        public int OfficeId
        {
            get { return officeId; }
            set { officeId = value; }
        }

        public int RoomNo
        {
            get { return roomNo; }
            set { roomNo = value; }
        }

        public int FloorNo
        {
            get { return floorNo; }
            set { floorNo = value; }
        }

    }
}
