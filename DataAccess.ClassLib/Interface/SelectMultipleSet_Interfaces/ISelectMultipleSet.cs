using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassLib.Interface.SelectMultipleSet_Interfaces
{
    public interface ISelectMultipleSet
    {
        List<T> MultipleSet<T, U>(string storedProcedure, string connectionStringName, U parameters);
    }
}
