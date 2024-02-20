using OdemePlanı_7.Business.Validator.Abstract;
using OdemePlanı_7.Entities;

namespace OdemePlanı_7.Business.Validator
{
    public class DataValidator : IDataValidator
    {
        public List<PayPlanPreviewListUI> PayPlanListValidator(List<PayPlanPreviewListUI> list)
        {
            List<PayPlanPreviewListUI> newList = new List<PayPlanPreviewListUI>();

            foreach (var item in list)
            {
                if (item.grupadi != null)
                {
                    item.grupadi = item.grupadi.ToUpper().Trim();
                    newList.Add(item);
                }

            }

            return newList;
        }
        public List<PayPlanDetailListUI> PayPlanDetailListValidator(List<PayPlanDetailListUI> list)
        {
            List<PayPlanPreviewListUI> newList = new List<PayPlanPreviewListUI>();
            foreach (var item in list)
            {
                if (item.odemesekli != null && item.yuzde != null)
                {
                    item.odemesekli = item.odemesekli.ToUpper().Trim();
                    item.yuzde = item.yuzde.ToUpper().Trim();
                }

            }
            return list;
        }
        public DataGridView PayPlanAddTextValidator(DataGridView list)
        {

            foreach (DataGridViewRow row in list.Rows)
            {
                
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        cell.Value = cell.Value.ToString().Trim().ToUpper();
                    }
                    if (cell.Value == null)
                    {

                        break;
                    }
                }              
            }

            return list;
        }
        public bool PayPlanAddTextCheckValidator(DataGridView dataGridView)
        {
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null) 
                    { 
                        MessageBox.Show($"Satır Boş Bırakılamaz {row.Index+1}"); 
                        return true; 
                    }
                    
                }
            }

            return false;
        }
        public string PayPlanGrupNameValidator(string name)
        {
            name = name.ToUpper().Trim();
            return name;
        }
        public bool PayPlanPayShareValidator(DataGridView dataGridView)
        {

            double result = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    result += Convert.ToDouble(row.Cells[1].Value);
                }

            }
            if (result > 100)
            {
                MessageBox.Show("Ödeme Yüzdeleri 100'den büyük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
    }
}
