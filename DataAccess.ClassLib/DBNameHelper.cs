using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassLib
{
    public static class DBNameHelper
    {
        public static string dbo_sp() => "dbo.sp";
        public static string Pre_(string value) => "_" + value;
    }
}
