using OdemePlanı_7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_7.Business.ConverterForUI
{
    public interface IConverterForUI
    {
        public string[] PayPlanListConvertToStringList(List<PayPlanPreviewListUI> payPlanPreviewListUIs);
        public DataGridView PayPlanDetailListConvertToDataGridviewList(List<PayPlanDetailListUI> payPlanPreviewListUIs);
    }
}
