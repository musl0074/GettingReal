using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    interface IPassportInformation
    {
        string PassportNumber { get; set; }
        string DateOfIssue { get; set; }
        string DateOfBirth { get; set; }
    }
}
