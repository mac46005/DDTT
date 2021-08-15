using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDTT.ClassLib.Models.BusinessModels;
using DDTT.DataAccessLibrary.DataAccess.Interfaces;


namespace DDTT_WPF_UI.ViewModels
{
    internal class AddMileageViewModel : Screen
    {
      private IGetAll<JobType> _getAllJobTypes;
      private IInsert<Mileage> _insertMileage;
      public AddMileageViewModel(IDataAccess<JobType> accessJobTypeData,IDataAccess<Mileage> accessMileageData){
        _getAllJobTypes = accessJobTypeData;
        _insertMileage = accessMileageData;
      }
      
      public List<JobType> JobTypeList {get;set;} = new List<JobType>();
      public JobType SelectedJobType {get;set;}
      
      
      
      
      
      
    }
}
