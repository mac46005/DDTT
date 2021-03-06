using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces
{
    public interface ILoadSetData : IDisposable
    {
        List<T> LoadSetData<T, U>(string storedProcedure, string connectionStringName, U parameters);
    }
}
