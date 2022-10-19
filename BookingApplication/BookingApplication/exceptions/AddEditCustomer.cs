using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.exceptions
{
    class AddEditCustomer : Exception
    {
        public AddEditCustomer()
        {

        }

        public AddEditCustomer(string message): base(message)
        {

        }
    }
}
