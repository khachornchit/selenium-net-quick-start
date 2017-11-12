using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUtilities.Definition
{
    public class DevelopmentProcessOption
    {
        public static string Default
        {
            get
            {
                string curDir = Directory.GetCurrentDirectory().ToLower();

                if (curDir.Contains("ProductionTestCases".ToLower()))
                {
                    return Production;
                }
                else
                {
                    return Developement;
                }
            }
        }

        public static string Developement { get { return "Development"; } }
        public static string Production { get { return "Production"; } }
    }
}
