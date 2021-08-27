using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDTT.ClassLib.Models.BusinessModels;
using DDTT.DataAccessLibrary.DataAccess.Interfaces;
using DDTT_WPF_UI.EventAggregatorFillerClasses;

namespace DDTT_WPF_UI.ViewModels
{
    internal class AddMileageViewModel : Screen
    {
        public string Title { get; set; } = "Add";
        public bool IsEditing { get; set; } 
        private IGetAll<JobType> _getAllJobTypes;
        private IInsert<Mileage> _insertMileage;
        private IGetById<Mileage> _getByIdMileage;
        private IEventAggregator _eventAggregator;
        public AddMileageViewModel(IDataAccess<JobType> accessJobTypeData, IDataAccess<Mileage> accessMileageData,
            IEventAggregator eventAggregator)
        {
            _getAllJobTypes = accessJobTypeData;
            _insertMileage = accessMileageData;
            _getByIdMileage = accessMileageData;
            _eventAggregator = eventAggregator;

            LoadData();
        }
        public void LoadData()
        {
            JobTypeList = _getAllJobTypes.GetAll();
        }

        public int Id { get; set; }
        public List<JobType> JobTypeList { get; set; } = new List<JobType>();
        public JobType SelectedJobType { get; set; }

        public decimal Amount { get; set; }

        public DateTime TimeStamp { get; set; } = DateTime.Now;

        public void Submit()
        {
            var mileage = IoC.Get<Mileage>();
            mileage.JobTypeId = SelectedJobType.Id;
            mileage.Amount = Amount;
            mileage.TimeStamp = TimeStamp;

            _insertMileage.Insert(mileage);
            _eventAggregator.PublishOnUIThread(new NavigateToDashBoard());
        }
        public void Modify(Mileage mileage)
        {
            Id = mileage.Id;
            SelectedJobType = mileage.JobType;
            Amount = mileage.Amount;
            TimeStamp = mileage.TimeStamp;

            //send edit to sql
        }

    }
}
