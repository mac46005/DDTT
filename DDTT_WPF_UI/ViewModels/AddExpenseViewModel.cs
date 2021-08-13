﻿using Caliburn.Micro;
using DDTT.ClassLib.Models.BusinessModels;
using DDTT.DataAccessLibrary.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT_WPF_UI.ViewModels
{
    internal class AddExpenseViewModel : Screen
    {
        private IGetAll<JobType> _getAllJobTypes;



        public JobType SelectedJobType { get; set; }
        public AddExpenseViewModel(IDataAccess<JobType> dataAccess)
        {
            _getAllJobTypes = dataAccess;
        }
        public void LoadData()
        {
            JobTypeList = _getAllJobTypes.GetAll();
        }
        public List<JobType> JobTypeList { get; set; }

        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; }
        public void Submit()
        {
            var expense = IoC.Get<Expenditure>();
        }
    }
}
