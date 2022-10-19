using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.exceptions
{
    class AddEditBooking : Exception
    {
        public AddEditBooking()
        {

        }

        public AddEditBooking(string message): base(message)
        {

        }
    }
}
