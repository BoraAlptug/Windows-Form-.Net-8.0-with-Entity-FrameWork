using OdemePlanı_7.Entities;

namespace OdemePlanı_7.Business.Validator.Abstract
{
    public interface IDataValidator
    {
        public List<PayPlanPreviewListUI> PayPlanListValidator(List<PayPlanPreviewListUI> list);
        public List<PayPlanDetailListUI> PayPlanDetailListValidator(List<PayPlanDetailListUI> list);
        public DataGridView PayPlanAddTextValidator(DataGridView list);
        public string PayPlanGrupNameValidator(string name);
        public bool PayPlanPayShareValidator(DataGridView dataGridView);
        public bool PayPlanAddTextCheckValidator(DataGridView dataGridView);
    }
}
