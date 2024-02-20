using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_7.UIService
{
    public interface IPayPlanUIService
    {
        public string[] PayPlanPreviewList();
        public DataGridView PayPlanDetailList(string grubadi);
        public void InsertNewPayPlan(DataGridView dataGridView, string grupadi);
        public void PayPlanDelete(string groupName);
    }
}
