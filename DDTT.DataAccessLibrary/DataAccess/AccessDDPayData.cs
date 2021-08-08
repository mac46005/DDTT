using DDTT.ClassLib.Models.BusinessModels;
using DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ClassLib.GenericDataAccess;

namespace DDTT.DataAccessLibrary.DataAccess
{
    public class AccessDDPayData
    {
        public List<DD_Pay> GetAll()
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                return cnn.LoadSetData<DD_Pay, dynamic>("dbo.spDDPay_GetAll", "", new { }).ToList();
            }
        }
        public DD_Pay GetById(int id)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<DD_Pay, dynamic>("dbo.spDDPay_GetById", "", new { Id = id });
            }
        }
        public void DeleteById(int id)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("dbo.spDDPay_DeleteById", "", new { Id = id });
            }
        }
    }
}
