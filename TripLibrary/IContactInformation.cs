using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    interface IContactInformation
    {
        string PhoneNumber { get; set; }
        string Email { get; set; }
    }
}
