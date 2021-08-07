using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassLib.Interface
{
    interface ILoadSingleData
    {
        T LoadData<T, U>(string storedProcedure,string connectionStringName,U parameters);
    }
}
