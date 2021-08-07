using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccess.ClassLib.Interface;
using DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces;

namespace DataAccess.ClassLib.GenericDataAccess
{
    public class BasicSqlDataAccess : IInsertData, ILoadSetData, IGetConnectionString
    {
        public string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public List<T> LoadSetData<T, U>(string storedProcedure, string connectionStringName, U parameters)
        {
        }

        public void SaveData<T>(string storedProcedure, string connectionStringName, T obj)
        {
            throw new NotImplementedException();
        }
    }
}
