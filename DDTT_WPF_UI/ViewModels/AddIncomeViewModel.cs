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
    internal class AddIncomeViewModel : Screen
    {
        IGetAll<JobType> _getAllJobTypes;
        IInsert<Income> _insertIncome;
        IEventAggregator _eventAggregator;


        public AddIncomeViewModel(IDataAccess<JobType> accessJobTypeData, IDataAccess<Income> accessIncomeData,
            IEventAggregator eventAggregator)
        {
            _getAllJobTypes = accessJobTypeData;
            _insertIncome = accessIncomeData;
            _eventAggregator = eventAggregator;
            LoadData();
        }

        public List<JobType> JobTypeList { get; set; }
        public JobType SelectedJobType { get; set; }
        private void LoadData()
        {
            JobTypeList = _getAllJobTypes.GetAll();
        }

        public decimal BasePay { get; set; }
        public decimal Tip { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        public void Submit()
        {
            var income = IoC.Get<Income>();
            income.JobType = SelectedJobType;
            income.JobTypeId = SelectedJobType.Id;
            income.BasePay = BasePay;
            income.Tip = Tip;
            income.TimeStamp = TimeStamp;
            _insertIncome.Insert(income);


            _eventAggregator.PublishOnUIThread(new NavigateToDashBoard());
        }

    }
}
