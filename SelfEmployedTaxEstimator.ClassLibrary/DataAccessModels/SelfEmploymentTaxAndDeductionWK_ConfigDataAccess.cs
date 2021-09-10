using DataAccess.ClassLib.GenericDataAccess;
using DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces;
using SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels.Interfaces;
using SelfEmployedTaxEstimator.ClassLibrary.Models.SelfEmploymentTaxAndDeductions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels
{
    public class SelfEmploymentTaxAndDeductionsWK_ConfigDataAccess : IInsert<SelfEmploymentTaxAndDeductionWK_Config>, IGetById<SelfEmploymentTaxAndDeductionWK_Config>, IGetAll<SelfEmploymentTaxAndDeductionWK_Config>, IDeleteById, IEditById<SelfEmploymentTaxAndDeductionWK_Config>
    {
        public void DeleteById(int id = 0)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void EditById(SelfEmploymentTaxAndDeductionWK_Config obj)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData("", "", obj);
            }
        }

        public List<SelfEmploymentTaxAndDeductionWK_Config> GetAll()
        {
            throw new NotImplementedException();
        }

        public SelfEmploymentTaxAndDeductionWK_Config GetById(int id = 0)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<SelfEmploymentTaxAndDeductionWK_Config, dynamic>("", "", new { Id = id });
            }
        }

        public void Insert(SelfEmploymentTaxAndDeductionWK_Config obj)
        {
            throw new NotImplementedException();
        }
    }
}
