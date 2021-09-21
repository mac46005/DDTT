using DDTT.DataAccessLibrary.DataAccess.Interfaces;
using DDTT.ClassLib.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces;
using DataAccess.ClassLib.GenericDataAccess;
using static DDTT.DataAccessLibrary.DB_Helper;
using static DataAccess.ClassLib.DBNameHelper;

namespace DDTT.DataAccessLibrary.DataAccess
{
    public class AccessIncomeData : IDataAccess<Income>, IThisYear,IThisMonth,IThisWeek
    {
        public void DeleteById(int id)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                
                cnn.SaveData<dynamic>("dbo.spIncome_DeleteById", dbName, new { Id = id });
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Income> GetAll()
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                return cnn.LoadSetData<Income, dynamic>("dbo.spIncome_GetAll", dbName, new { });
            }
        }

        public Income GetById(int id)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<Income, dynamic>("dbo.spIncome_Get",dbName,new { Id = id });
            }
        }

        public List<Income> GetByYear(int year)
        {
            DateTime chosenDate = DateTime.Now;
            var thisYear = chosenDate.Year;
            throw new NotImplementedException();
        }

        public void Insert(Income obj)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("dbo.spIncome_Insert", dbName, new
                {
                    JobTypeId = obj.JobTypeId,
                    BasePay = obj.BasePay,
                    Tip = obj.Tip,
                    TimeStamp = obj.TimeStamp
                });
            }
        }

        public decimal ThisMonth()
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                decimal total = 0;
                cnn.LoadSetData<decimal, dynamic>(dbo_sp() + nameof(Income) + Pre_("ThisMonth"), dbName, new { Today = DateTime.Now })
                    .ToList().ForEach(x => total += x);
                return total;
            }
        }

        public decimal ThisWeek()
        {

        }

        public decimal ThisYear()
        {
            throw new NotImplementedException();
        }
    }
}