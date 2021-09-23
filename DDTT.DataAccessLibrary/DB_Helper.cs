using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.DataAccessLibrary
{
    internal static class DB_Helper
    {
        public static string dbName = "DDTTDb";
        public static DateTime BeginningOfWeek()
        {
            var trgtMonday = DateTime.Now;
            do
            {
                trgtMonday = trgtMonday.AddDays(-1);
            } while (trgtMonday.DayOfWeek != DayOfWeek.Monday);

            return trgtMonday;
        }
    }
    
}
