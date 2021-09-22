using Caliburn.Micro;
using DDTT.ClassLib.Models.BusinessModels;
using DDTT.DataAccessLibrary.DataAccess;
using DDTT.DataAccessLibrary.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT_WPF_UI.ViewModels
{
    internal class DashBoardViewModel : Conductor<object>
    {
        private IThisWeek _income_ThisWeek;
        private IThisMonth _income_ThisMonth;
        private IThisYear _income_ThisYear;
        public DashBoardViewModel(IDataAccess<JobType> accessJobTypeData,AccessIncomeData accessIncomeData)
        {
            _income_ThisWeek = accessIncomeData;
            _income_ThisMonth = accessIncomeData;
            _income_ThisYear = accessIncomeData;
            LoadData();
        }
        private void LoadData()
        {
            ThisWeek =  "Income: " + _income_ThisWeek.ThisWeek().ToString();
            ThisMonth = "Income: " + _income_ThisMonth.ThisMonth().ToString();
            ThisYear = "Income: " + _income_ThisYear.ThisYear().ToString();
        }
        public string ThisWeek { get; set; } = "Income: $0.00\tExpenses: $0.00\tMiles: 0.00m";
        public string ThisMonth { get; set; } = "Income: $0.00\tExpenses: $0.00\tMiles: 0.00m";
        public string ThisYear { get; set; } = "Income: $0.00\tExpenses: $0.00\tMiles: 0.00m";
    }
}
