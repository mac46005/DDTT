using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassLib.Interface
{
    public interface IMapMultipleObjects
    {
        List<T> MapMultipleObjects<T, U, V>(string storedProcedure,string connectionStringName,Func<U,V,T> map);
    }
}
