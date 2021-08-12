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
using DataAccess.ClassLib.Interface.MapMultipleObject_Interfaces;
using DataAccess.ClassLib.Interface.Transaction_Interfaces;

namespace DataAccess.ClassLib.GenericDataAccess
{
    public class SqlDataAccess : 
        ISaveSingleData, ILoadSetData, 
        ILoadSingleData,IMapTwoObjects,
        IMapThreeObjects, IRunTransaction
    {
        public void Dispose()
        {
        }

        public T LoadSingleData<T, U>(string storedProcedure, string connectionStringName, U parameters)
        {
            using (IDbConnection cnn = new SqlConnection(DataString.GetConnectionString(connectionStringName)))
            {
                return cnn.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).ToArray()[0];
            }
        }

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

        public List<T> MapTwoObjects<T, U, V, W>(string storedProcedure, string connectionStringName, Func<U, V, T> map, W parameters)
        {
            using (IDbConnection cnn = new SqlConnection(DataString.GetConnectionString(connectionStringName)))
            {
                return cnn.Query<U, V, T>(storedProcedure, map, parameters).ToList();
            }
        }

        public List<T> MapThreeObjects<T, U, V, W, X>(string storedProcedure, string connectionStringName, Func<U, V, W, T> map, X parameters)
        {
            using (IDbConnection cnn = new SqlConnection(DataString.GetConnectionString(connectionStringName)))
            {
                return cnn.Query<U, V, W, T>(storedProcedure, map, parameters).ToList();
            }
        }

        //Open connect/Start transaction method
        //load using the transaction
        //save using the transaction
        //close connection/stop transaction method
        //dispose

        private IDbConnection _connection;
        private IDbTransaction _transaction; 
        public void StartTransaction(string connectionStringName)
        {
            _connection = new SqlConnection(DataString.GetConnectionString(connectionStringName));

            _transaction = _connection.BeginTransaction();
        }
        public void RunTransaction<T, U, V, X>(T obj1, U obj2, string connectionStringName, string storedProcedure1, string storedProcedure2)
        {
            using(IDbConnection cnn = new SqlConnection(DataString.GetConnectionString(connectionStringName)))
            {
                var trans = cnn.BeginTransaction();

            }
        }
    }
}
