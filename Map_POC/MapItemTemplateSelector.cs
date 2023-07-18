using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_POC
{
    internal class MapItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate OddTemplate { get; set; }
        public DataTemplate EvenTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((PinModel)item).ID % 2 == 0 ? EvenTemplate : OddTemplate;
        }
    }
}
