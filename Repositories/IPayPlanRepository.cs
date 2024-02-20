using OdemePlanı_7.Entities;

namespace OdemePlanı_7.Repositories
{
    public interface IPayPlanRepository
    {
        List<PayPlanPreviewListUI> GetAllPayPlanPreviews();
        List<PayPlanDetailListUI> GetPayPlanDetailList(string grubadi);
        int LastOzetBimnoGet();
        void InsertPayPlan(List<musteriteklifleriozet_odemesekli> payPlanAdds);
        public bool PayPlanNameCheck(string groupName);
        public void PayPlanDeleteList(string groupName);
    }
}
