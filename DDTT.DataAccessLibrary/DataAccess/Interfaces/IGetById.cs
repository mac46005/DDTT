using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.DataAccessLibrary.DataAccess.Interfaces
{
    public interface IGetById <T>
    {
        T GetById(int id);
    }
}
