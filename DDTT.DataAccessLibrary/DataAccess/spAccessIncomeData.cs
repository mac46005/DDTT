using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.DataAccessLibrary.DataAccess
{
    class spAccessIncomeData
    {
        public void Insert(Expenditure expenditure)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<Expenditure>("dbo.spExpenditure_Insert", "", expenditure);
            }
        }
        public Expenditure GetById(int id)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<Expenditure, dynamic>("spExpenditure_GetById", "", new { Id = id });
            }
        }
        public List<Expenditure> GetAll()
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                return cnn.LoadSetData<Expenditure, dynamic>("dbo.Expenditure_GetAll", "", new { });
            }
        }
        public void DeleteById(int id)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("spExpenditure_GetById", "", new { Id = id });
            }
        }
    }
}
