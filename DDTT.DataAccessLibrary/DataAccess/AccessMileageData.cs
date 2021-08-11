using DataAccess.ClassLib.GenericDataAccess;
using DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces;
using DDTT.ClassLib.Models.BusinessModels;
using DDTT.DataAccessLibrary.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.DataAccessLibrary.DataAccess
{
    public class AccessMileageData : IDataAccess<Mileage>
    {
        public void Insert(Mileage mileage)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<Mileage>("dbo.spMileage_Insert", "", mileage);
            }
        }
        public Mileage GetById(int id)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<Mileage, dynamic>("dbo.spMileage_GetById", "", new { Id = id });
            }
        }
        public List<Mileage> GetAll()
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                return cnn.LoadSetData<Mileage, dynamic>("dbo.spMileage_GetAll", "", new { });
            }
        }
        public void DeleteById(int id)
        {
            using(ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("dbo.spMileage_DeleteById", "",new { Id = id });
            }
        }
    }
}
