using Caliburn.Micro;
using DDTT.ClassLib.Models.BusinessModels;
using DDTT.ClassLib.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT_WPF_UI.ViewModels
{
    internal class EditItemViewModel : Screen
    {
        public EditItemViewModel()
        {

        }
        public ISqlItemId Item { get; set; }
        public Income IncomeType { get; set; }
        public Expenditure ExpenseType { get; set; }
        public Mileage MileageType { get; set; }
        private LoadItemType()
        {
            if (typeof(Income).Equals(Item))
            {

            }else if
        }
    }
}
