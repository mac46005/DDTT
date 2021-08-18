using Caliburn.Micro;
using DDTT.ClassLib.Models.BusinessModels;
using DDTT.DataAccessLibrary.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT_WPF_UI.ViewModels
{
    internal class ShellViewModel : Conductor<object>
    {
        
        public ShellViewModel()
        {
            ActivateItem(IoC.Get<DashBoardViewModel>());
        }

        public void AddIncome()
        {
            ActivateItem(IoC.Get<AddIncomeViewModel>());
        }
        public void AddExpense()
        {
            ActivateItem(IoC.Get<AddExpenseViewModel>());
        }
        public void AddMileage()
        {
            ActivateItem(IoC.Get<AddMileageViewModel>());
        }
        public void ManageIncome() 
        {
            ActivateItem(IoC.Get<ManageIncomeViewModel>());
        }
        public void ManageExpenditures()
        {
            ActivateItem(IoC.Get<ManageExpendituresViewModel>());
        }
        public void ManageExpenseTypes()
        {
            ActivateItem(IoC.Get<ManageExpenseTypesViewModel>());
        }
        public void ManageJobTypes()
        {
            ActivateItem(IoC.Get<ManageJobTypesViewModel>());
        }
    }
}
