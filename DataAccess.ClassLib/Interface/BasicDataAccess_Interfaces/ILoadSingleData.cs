using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces
{
    public interface ILoadSingleData : IDisposable
    {
        T LoadSingleData<T, U>(string storedProcedure, string connectionStringName, U parameters);
    }
}
