using DataAccess.ClassLib.GenericDataAccess;
using DataAccess.ClassLib.Interface.MapMultipleObject_Interfaces;
using DDTT.ClassLib.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.DataAccessLibrary.DataAccess
{
    public class AccessIncome
    {
        public List<Income> GetAllIncomes()
        {
            using (IMapTwoObjects mapTwoObjects = new SqlDataAccess())
            {
                return mapTwoObjects.MapTwoObjects<Income, DD_Pay, Tip, dynamic>("dbo.spIncome_GetAll", "", (pay, tip) => { return new Income { DD_Pay = pay, Tip = tip }; }, null);
            }
        }
    }
}
