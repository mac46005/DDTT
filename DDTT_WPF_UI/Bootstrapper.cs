using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AutoMapper;
using Caliburn.Micro;
using DDTT.ClassLib.Models.BusinessModels;
using DDTT.DataAccessLibrary.DataAccess;
using DDTT.DataAccessLibrary.DataAccess.Interfaces;
using DDTT_WPF_UI.ViewModels;

namespace DDTT_WPF_UI
{
    internal class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _container = new SimpleContainer();
        public Bootstrapper()
        {
            Initialize();
        }
        protected override void Configure()
        {
            var configMapper = new MapperConfiguration(cfg => 
            {

            });

            var mapper = configMapper.CreateMapper();
            _container.Instance<IMapper>(mapper);

            _container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>();

            _container
                .PerRequest<Income, Income>()
                .PerRequest<Expenditure, Expenditure>()
                .PerRequest<ExpenseType, ExpenseType>()
                .PerRequest<JobType, JobType>()
                .PerRequest<Mileage, Mileage>()
                .PerRequest<IDataAccess<Income>, AccessIncomeData>()
                .PerRequest<IDataAccess<Expenditure>, AccessExpenseData>()
                .PerRequest<IDataAccess<ExpenseType>, AccessExpenseTypeData>()
                .PerRequest<IDataAccess<JobType>,AccessJobTypeData>();
            GetType().Assembly.GetTypes()
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(vmType => _container.RegisterPerRequest(
                    vmType, vmType.ToString(), vmType));
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }
        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }
        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}
