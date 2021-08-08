using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassLib.Interface.Transaction_Interfaces
{
    public interface IRunTransaction : IDisposable
    {
        void RunTransaction<T, U, V, X>(T obj1, U obj2, string connectionStringName, string storedProcedure1, string storedProcedure2);
    }
}
