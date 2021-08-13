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
    internal class AddIncomeViewModel : Screen
    {
        IGetAll<JobType> _getAllJobTypes;
        IInsert<Income> _insertIncome;


        public JobType SelectedJobType { get; set; }
        public AddIncomeViewModel(IDataAccess<JobType> accessJobTypeData,IDataAccess<Income> accessIncomeData)
        {
            _getAllJobTypes = accessJobTypeData;
            _insertIncome = accessIncomeData;
        }

        public List<JobType> JobTypeList { get; set; }

    }
}
