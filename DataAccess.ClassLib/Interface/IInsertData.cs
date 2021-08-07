using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassLib.Interface
{
    public interface IInsertData
    { 
        void SaveData<T>(string storedProcedure, string connectionStringName,T obj);
    }
}
