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
    internal class AddJobTypeViewModel : Screen
    {
        private IEventAggregator _eventAggregator;
        private IInsert<JobType> _insertJobType;
        public AddJobTypeViewModel(IEventAggregator eventAggregator,IDataAccess<JobType> accessJobTypeData)
        {
            _eventAggregator = eventAggregator;
            _insertJobType = accessJobTypeData;
        }
        public string Job { get; set; }
        public void Submit()
        {
            var jobType = IoC.Get<JobType>();
            jobType.Job = Job;

            _insertJobType.Insert(jobType);
            _eventAggregator.PublishOnUIThread(new NavigateToDashBoard());
        }
    }
}
