using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT_WPF_UI.ViewModels
{
    internal class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
            ActivateItem(IoC.Get<DashBoardViewModel>());
        }
        public void AddIncome()
        {
            ActivateItem(IoC.Get<AddIncomeViewModel>());
        }
        public void AddExpense()
        {
            ActivateItem(IoC.Get<AddExpenseViewModel>());
        }
        public void ManageDDPay()
        {

        }
        public void ManageTips()
        {

        }
        public void ManageExpenseTypes()
        {

        }
    }
}
