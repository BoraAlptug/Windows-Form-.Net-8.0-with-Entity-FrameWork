using OdemePlanı_7.Entities;
using OdemePlanı_7.UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_7.Business.ConverterToListBoxItem.Concrete
{
    public class ItemsCascading : IItemsCascading
    {
        public void PayPlanCascading(DataGridView dataGridView)
        {
            dataGridView.ReadOnly = false;
            
        }
        public void PayPlanAddListCascading(DataGridView dataGridView)
        {
            dataGridView.ReadOnly = false;
            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].HeaderText = "Ödeme Şekli";
            dataGridView.Columns[1].HeaderText = "Ödeme Yüzdesi";
            dataGridView.AllowUserToAddRows = false;

        }
        public void PayPanPreviewListButtons()
        {
           


        }
    }
}
