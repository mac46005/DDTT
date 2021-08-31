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
    public class Line5DataAccess : IDataAccess<Line5>
    {
        const string line5 = nameof(Line5);
        public void DeleteById(int id)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("", "", new { });
            }
        }

        public void EditById(Line5 obj)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>(dbo_sp() + line5 + Pre_("Update"), "", new { });
            }
        }

        public List<Line5> GetAll()
        {
            using (ILoadSetData cnn = new SqlDataAccess())
            {
                return cnn.LoadSetData<Line5, dynamic>("", "", new { });
            }
        }

        public Line5 GetById(int id)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<Line5, dynamic>(dbo_sp() + line5 + Pre_("Get"), "", new { });
            }
        }

        public void Insert(Line5 obj)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData<dynamic>("", "", new { });
            }
        }
    }
}
