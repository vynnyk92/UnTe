using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn
{
    public class LogAnalyzer
    {
        public const string WRONG = "Wrong extension";

        public bool IsValidLogFileName(string filName)
        {
            if (!filName.EndsWith(".SLF", StringComparison.InvariantCultureIgnoreCase))
            {
                throw new ArgumentException(WRONG);
            }
            return true;
        }
    }
}
