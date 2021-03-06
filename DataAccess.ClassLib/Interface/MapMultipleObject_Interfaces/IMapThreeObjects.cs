using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassLib.Interface.MapMultipleObject_Interfaces
{
    public interface IMapThreeObjects : IDisposable
    {
        List<T> MapThreeObjects<T, U, V, W, X>(string storedProcedure, string connectionStringName, Func<U, V, W, T> map, X parameters);
    }
}
