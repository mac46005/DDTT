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
    internal class AddExpenseTypeViewModel : Screen
    {
        IEventAggregator _eventAggregator;
        IInsert<ExpenseType> _insertExpenseType;
        public AddExpenseTypeViewModel(IEventAggregator eventAggregator,IDataAccess<ExpenseType> accessExpenseTypeData)
        {
            _eventAggregator = eventAggregator;
            _insertExpenseType = accessExpenseTypeData;
        }
        public string CategoryName { get; set; }

        public void Submit()
        {
            var expenseType = IoC.Get<ExpenseType>();
            expenseType.CategoryName = CategoryName;

            _insertExpenseType.Insert(expenseType);
            _eventAggregator.PublishOnUIThread(new NavigateToDashBoard());
        }
    }
}
