using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium2016.Models
{
    public class AutoId
    {
        public static string Id { get { return GenerateId(); } }

        public static string CurrentDateTime { get { return GenerateCurrentDateTime(); } }

        private static string GenerateId()
        {
            DateTime dt = DateTime.Now;
            return string.Format("{0}{1:00}{2:00}{3:00}{4:00}{5:00}{6:0000}", dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
        }

        private static string GenerateCurrentDateTime()
        {
            DateTime dt = DateTime.Now;
            return string.Format("{0}.{1:00}.{2:00} {3:00}:{4:00}", dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute);
        }
    }
}
