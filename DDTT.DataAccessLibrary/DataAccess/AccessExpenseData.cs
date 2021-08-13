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
    public class AccessExpenseData : IDataAccess<Expenditure>
    {
        public void Insert(Expenditure expenditure)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("dbo.spExpenditure_Insert", dbName, new
                {
                    JobTypeId = expenditure.JobTypeId,
                    Amount = expenditure.Amount,
                    TimeStamp = expenditure.TimeStamp,
                    ExpenseTypeId = expenditure.ExpenseTypeId,
                    Note = expenditure.Note

                });
            }
        }
        public Expenditure GetById(int id)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<Expenditure, dynamic>("spExpenditure_GetById", dbName, new { Id = id });
            }
        }
        public List<Expenditure> GetAll()
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                return cnn.LoadSetData<Expenditure, dynamic>("dbo.Expenditure_GetAll", dbName, new { });
            }
        }
        public void DeleteById(int id)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("spExpenditure_GetById", dbName,new { Id = id });
            }
        }
    }
}
