using Dapper;
using DataAccess.ClassLib.Interface;
using DataAccess.ClassLib.Interface.MapMultipleObject_Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassLib.GenericDataAccess
{
    public class MapMultiObjects : IMapTwoObjects
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<T> MapTwoObjects<T, U, V, W>(string storedProcedure, string connectionStringName, Func<U, V, T> map, W parameters)
        {
            using (IDbConnection cnn = new SqlConnection(DataString.GetConnectionString(connectionStringName)))
            {
                return cnn.Query<U,V,T>(storedProcedure, map,parameters).ToList();
            }
        }
    }
}
