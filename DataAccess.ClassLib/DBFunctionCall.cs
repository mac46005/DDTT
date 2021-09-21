using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassLib
{
    public class DBFunctionCall
    {
        private string _owner;
        public DBFunctionCall(string owner = "dbo")
        {
            _owner = owner;
        }
        public string SP_Function(string table,string functionName) => _owner + ".sp" + table + functionName;
        public string SP_Function(Type table, Type functionName) => _owner + ".sp" + nameof(Type) + nameof(Type);
    }
}
