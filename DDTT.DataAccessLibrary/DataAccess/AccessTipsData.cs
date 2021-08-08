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
    public class AccessTipsData
    {
        public Tip GetById(int id)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<Tip,dynamic>("dbo.spTip_GetById", "", new { Id = id });
            }
        }
        public List<Tip> GetAll()
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                return cnn.LoadSetData<Tip, dynamic>("dbo.spTip_GetAll", "", new { });
            }
        }
        public void DeleteById(int id)
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                cnn.LoadSetData<Tip, dynamic>("dbo.spTip_DeleteById", "", new { Id = id });
            }
        }
    }
}
