using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassLib.Interface.MapMultipleObject_Interfaces
{
    public interface IMapTwoObjects : IDisposable
    {
        List<T> MapTwoObjects<T, U, V, W>(string storedProcedure, string connectionStringName, Func<U, V, T> map,W parameters);
    }
}
