using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels.Interfaces
{
    public interface IDataAccess<T> : IInsert<T>, IGetById<T>, IGetAll<T>, IDeleteById,IEditById<T>
    {
    }
}
