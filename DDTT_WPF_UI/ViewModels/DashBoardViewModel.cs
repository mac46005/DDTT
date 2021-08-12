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
    internal class DashBoardViewModel : Screen
    {
        private IGetAll<JobType> _getAllJobTypes;
        public DashBoardViewModel(IDataAccess<JobType> accessJobTypeData)
        {
            _getAllJobTypes = accessJobTypeData;
            LoadData();
        }
        private void LoadData()
        {
            JobTypeList = _getAllJobTypes.GetAll();
        }
        public List<JobType> JobTypeList { get; set; }


    }
}
