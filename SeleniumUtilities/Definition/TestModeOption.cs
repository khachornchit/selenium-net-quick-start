using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUtilities.Definition
{
    public class TestModeOption
    {
        public static string Default { get { return Auto; } }
        public static string Auto { get { return "Auto"; } }
        public static string Manual { get { return "Manual"; } }
    }
}
