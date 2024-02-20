using OdemePlanı_7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_7.Business.ConverterToListBoxItem
{
    public interface IItemsCascading
    {
        public void PayPlanCascading(DataGridView dataGridView);
        public void PayPlanAddListCascading(DataGridView dataGridView);

    }
}
