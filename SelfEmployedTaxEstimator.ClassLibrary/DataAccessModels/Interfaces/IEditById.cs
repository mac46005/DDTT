using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels.Interfaces
{
    internal interface IEditById<T>
    {
        void EditById(T obj);
    }
}
