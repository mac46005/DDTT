using Caliburn.Micro;
using DDTT.ClassLib.Models.BusinessModels;
using DDTT_WPF_UI.EventAggregatorFillerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT_WPF_UI.ViewModels
{
    internal class IncomeItemViewModel : Screen
    {
        private IEventAggregator _eventAggregator;
        public IncomeItemViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }
        public Income Income { get; set; }
        public void Edit()
        {
            _eventAggregator.PublishOnUIThread(new NavigateToEditItem(Income));
        }
        public void Delete()
        {

        }
    }
}
