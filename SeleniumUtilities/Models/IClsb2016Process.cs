using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUtilities.Models
{
    interface IClsb2016Process
    {
        bool BrowsePage();
        bool FillInformation();
        bool SubmitForm();
    }
}
