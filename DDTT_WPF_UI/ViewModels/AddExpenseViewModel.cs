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
    internal class AddExpenseViewModel : Screen
    {
        private IGetAll<JobType> _getAllJobTypes;
        private IInsert<Expenditure> _insertExpenditure;



        public AddExpenseViewModel(IDataAccess<JobType> accessJobTypeData, IDataAccess<Expenditure> accessExpenditureData)
        {
            _getAllJobTypes = accessJobTypeData;
            _insertExpenditure = accessExpenditureData;
            LoadData();
        }
        public void LoadData()
        {
            JobTypeList = _getAllJobTypes.GetAll();
        }
        public JobType SelectedJobType { get; set; }
        public List<JobType> JobTypeList { get; set; }

        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public string Note { get; set; }
        public void Submit()
        {
            var expense = IoC.Get<Expenditure>();
            expense.JobTypeId = SelectedJobType.Id;
            expense.JobType = SelectedJobType;
            expense.Amount = Amount;
            expense.TimeStamp = TimeStamp;

            _insertExpenditure.Insert(expense);
            TryClose();
        }
    }
}
