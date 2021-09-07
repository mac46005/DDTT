using DataAccess.ClassLib.GenericDataAccess;
using DataAccess.ClassLib.Interface.BasicDataAccess_Interfaces;
using SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels.Interfaces;
using SelfEmployedTaxEstimator.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels
{
    public class _1040ES_ConfigDataAccess : IInsert<_1040ES_Config>, IGetById<_1040ES_Config>, IGetAll<_1040ES_Config>, IDeleteById, IEditById<_1040ES_Config>
    {
        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void EditById(_1040ES_Config obj)
        {
            using (ISaveSingleData cnn = new SqlDataAccess())
            {
                cnn.SaveData("", "", obj);
            }
        }

        public List<_1040ES_Config> GetAll()
        {
            throw new NotImplementedException();
        }

        public _1040ES_Config GetById(int id)
        {
            using (ILoadSingleData cnn = new SqlDataAccess())
            {
                return cnn.LoadSingleData<_1040ES_Config, dynamic>("", "", new { Id = id });
            }
        }

        public void Insert(_1040ES_Config obj)
        {
            throw new NotImplementedException();
        }
    }
}
