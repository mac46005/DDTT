
using DataAccess.ClassLib.GenericDataAccess;
using DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces;
using DDTT.ClassLib.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.DataAccessLibrary.DataAccess
{
    public class AccessExpenseTypeData
    {
        public void Insert(ExpenseType expenseType)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<ExpenseType>("dbo.ExpenseType_Insert", "", expenseType);
            }
        }
        public ExpenseType GetById(int id)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<ExpenseType,dynamic>("dbo.spExpenseType_GetById", "", new { Id = id });
            }
        }
        public List<ExpenseType> GetAll()
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                return cnn.LoadSetData<ExpenseType, dynamic>("dbo.ExpenseType_GetAll", "", new { });
            }
        }
        public void DeleteById(int id)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("dbo.spExpenseType_DeleteById", "", new { Id = id });
            }
        }
    }
}
