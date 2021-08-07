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
    public class BasicSqlDataAccess : IInsertData, ILoadSetData
    {

        public List<T> LoadSetData<T, U>(string storedProcedure, string connectionStringName, U parameters)
        {
            using (IDbConnection cnn = new SqlConnection(DataString.GetConnectionString(connectionStringName)))
            {
                return cnn.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void SaveData<T>(string storedProcedure, string connectionStringName, T obj)
        {
            using (IDbConnection cnn = new SqlConnection(DataString.GetConnectionString(connectionStringName)))
            {
                cnn.Query<T>(storedProcedure,obj,commandType: CommandType.StoredProcedure);
            }
        }
    }
}
