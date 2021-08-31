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
    public class Line3DataAccess : IDataAccess<Line3>
    {
        const string line3 = nameof(Line3);
        public void DeleteById(int id)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("", "", new { });
            }
        }

        public void EditById(Line3 obj)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>(dbo_sp() + line3 + Pre_("Update"), "", new { });
            }
        }

        public List<Line3> GetAll()
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                return cnn.LoadSetData<Line3, dynamic>("", "", new { });
            }
        }

        public Line3 GetById(int id)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<Line3, dynamic>(dbo_sp() + line3 + Pre_("Get"), "", new { });
            }
        }

        public void Insert(Line3 obj)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("", "", new { });
            }
        }
    }
}
