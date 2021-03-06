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
    internal class AddExpenseViewModel : Screen
    {
        private IGetAll<JobType> _getAllJobTypes;
        private IInsert<Expenditure> _insertExpenditure;
        private IGetAll<ExpenseType> _getAllExpenseType;
        private IEventAggregator _eventAggregator;
        

        public AddExpenseViewModel(IDataAccess<JobType> accessJobTypeData, IDataAccess<Expenditure> accessExpenditureData,
            IEventAggregator eventAggregator,IDataAccess<ExpenseType> accessExpenseTypeData)
        {
            _getAllJobTypes = accessJobTypeData;
            _insertExpenditure = accessExpenditureData;
            _getAllExpenseType = accessExpenseTypeData;
            _eventAggregator = eventAggregator;

            LoadData();
        }
        public void LoadData()
        {
            JobTypeList = _getAllJobTypes.GetAll();
            ExpenseTypeList = _getAllExpenseType.GetAll();
        }
        public JobType SelectedJobType { get; set; }
        public List<JobType> JobTypeList { get; set; }

        public ExpenseType SelectedExpenseType { get; set; }
        public List<ExpenseType> ExpenseTypeList { get; set; }

        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public string Note { get; set; }
        public void Submit()
        {
            var expense = IoC.Get<Expenditure>();
            expense.JobTypeId = SelectedJobType.Id;
            expense.ExpenseTypeId = SelectedExpenseType.Id;
            expense.Amount = Amount;
            expense.TimeStamp = TimeStamp;
            _insertExpenditure.Insert(expense);

            _eventAggregator.PublishOnUIThread(new NavigateToDashBoard());
        }
    }
}
