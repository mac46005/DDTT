using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassLib.Interface
{
    public interface ISelectMultipleSet
    {
        List<T> MultipleSet<T,U>(string storedProcedure,U parameters,string connectionStringName);
    }
}
