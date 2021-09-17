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
    internal class DashBoardViewModel : Conductor<object>
    {
        public DashBoardViewModel(IDataAccess<JobType> accessJobTypeData)
        {
        }
        private void LoadData()
        {

        } 
        public string ThisWeek { get; set; }
        public string ThisMonth { get; set; }
        public string ThisYear { get; set; }
    }
}
