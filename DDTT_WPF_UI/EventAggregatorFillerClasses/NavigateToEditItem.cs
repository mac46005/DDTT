using DDTT.ClassLib.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT_WPF_UI.EventAggregatorFillerClasses
{
    internal class NavigateToEditItem
    {
        public NavigateToEditItem(ISqlItemId item)
        {
            Item = item;
        }
            public ISqlItemId Item { get; set; }
    }
}
