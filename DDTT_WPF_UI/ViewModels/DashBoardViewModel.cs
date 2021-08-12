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
        }
        private void LoadData()
        {

        }
        public List<JobType> JobTypeList() => _getAllJobTypes.GetAll();


    }
}
