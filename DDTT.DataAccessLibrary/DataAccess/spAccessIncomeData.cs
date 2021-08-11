using DDTT.DataAccessLibrary.DataAccess.Interfaces;
using DDTT.ClassLib.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces;
using DataAccess.ClassLib.GenericDataAccess;

namespace DDTT.DataAccessLibrary.DataAccess
{
    public class spAccessIncomeData : IDataAccess<Income>
    {
        public void DeleteById(int id)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                
                cnn.SaveData<dynamic>("dbo.spIncome_DeleteById", "", new { Id = id });
            }
        }

        public List<Income> GetAll()
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                return cnn.LoadSetData<Income, dynamic>("dbo.spIncome_GetAll", "", new { });
            }
        }

        public Income GetById(int id)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<Income, dynamic>("dbo.spIncome_Get","",new { Id = id });
            }
        }

        public void Insert(Income obj)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<Income>("dbo.spIncome_Insert", "", obj);
            }
        }
    }
}