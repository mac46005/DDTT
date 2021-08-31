using DataAccess.ClassLib.GenericDataAccess;
using DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces;
using SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels.Interfaces;
using SelfEmployedTaxEstimator.ClassLibrary.Models._1040ES_Lines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.ClassLib.DBNameHelper;

namespace SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels.Access1040ES_SpecificLines
{
    public class Line8DataAccess : IDataAccess<Line8>
    {
        const string line8 = nameof(Line8);
        public void DeleteById(int id)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("", "", new { });
            }
        }

        public void EditById(Line8 obj)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>(dbo_sp() + line8 + Pre_("Update"), "", new { });
            }
        }

        public List<Line8> GetAll()
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                return cnn.LoadSetData<Line8, dynamic>("", "", new { });
            }
        }

        public Line8 GetById(int id)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<Line8, dynamic>(dbo_sp() + line8 + Pre_("Get"), "", new { });
            }
        }

        public void Insert(Line8 obj)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("", "", new { });
            }
        }
    }
}
