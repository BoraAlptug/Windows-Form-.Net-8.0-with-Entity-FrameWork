using OdemePlanı_7.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_7.Business.ConverterForUI
{
    public class ConverterForUI: IConverterForUI
    {
        public string[] PayPlanListConvertToStringList(List<PayPlanPreviewListUI> payPlanPreviewListUIs)
        {
            List<string> list = new List<string>();

            foreach (var lt in payPlanPreviewListUIs)
            {
                if (lt.grupadi != null) { list.Add(lt.grupadi); }

            }

            return list.ToArray();
        }
        public DataGridView PayPlanDetailListConvertToDataGridviewList(List<PayPlanDetailListUI> payPlanPreviewListUIs)
        {
            DataGridView dt= new DataGridView();
            dt.DataSource = payPlanPreviewListUIs;
            return dt;
        }
    }
}
