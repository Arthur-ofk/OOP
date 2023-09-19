using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class DateModifier
    {
        public int CalculateDifference(string firstDate, string secondDate)
        {
            DateTime date1 = DateTime.ParseExact(firstDate, "yyyy MM dd", null);
            DateTime date2 = DateTime.ParseExact(secondDate, "yyyy MM dd", null);

            TimeSpan difference = date1 - date2;

            
            return Math.Abs(difference.Days);
        }
    }
}
