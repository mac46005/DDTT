using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels.Interfaces
{
    internal interface IDbAccess<T> : IInsert<T>,IEditById<T>,IGetById<T>,IGetAll<T>
    {
    }
}
