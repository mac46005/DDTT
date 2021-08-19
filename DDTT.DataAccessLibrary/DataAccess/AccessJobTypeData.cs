using DataAccess.ClassLib.GenericDataAccess;
using DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces;
using DDTT.ClassLib.Models.BusinessModels;
using DDTT.DataAccessLibrary.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DDTT.DataAccessLibrary.DB_Helper;
namespace DDTT.DataAccessLibrary.DataAccess
{
    public class AccessJobTypeData : IDataAccess<JobType>
    {
        public void DeleteById(int id)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("dbo.spJobType_DeleteById", dbName, new { Id = id });
            }
        }

        public List<JobType> GetAll()
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                return cnn.LoadSetData<JobType, dynamic>("dbo.spJobType_GetAll", dbName, new { });
            }
        }

        public JobType GetById(int id)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<JobType, dynamic>("dbo.spJobType_GetById", dbName, new { Id = id });
            }
        }

        public void Insert(JobType obj)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("dbo.spJobType_Insert", dbName, new { Job = obj.Job });
            }
        }
    }
}
