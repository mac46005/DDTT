using Caliburn.Micro;
using DDTT.ClassLib.Models.BusinessModels;
using DDTT.DataAccessLibrary.DataAccess.Interfaces;
using DDTT_WPF_UI.EventAggregatorFillerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT_WPF_UI.ViewModels
{
    internal class ShellViewModel : Conductor<object>, IHandle<NavigateToDashBoard>
    {
        IEventAggregator _eventAggregator;
        public ShellViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);
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
        public void AddJobType()
        {
            ActivateItem(IoC.Get<AddJobTypeViewModel>());
        }
        public void AddExpenseType()
        {
            ActivateItem(IoC.Get<AddExpenseTypeViewModel>());
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



        // EventAggregator 
        public void Handle(NavigateToDashBoard message)
        {
            ActivateItem(IoC.Get<DashBoardViewModel>());
        }
    }
}
