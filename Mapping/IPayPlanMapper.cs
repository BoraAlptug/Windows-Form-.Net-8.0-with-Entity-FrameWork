using OdemePlanı_7.Entities;

namespace OdemePlanı_7.Mapping.Abstract
{
    public interface IPayPlanMapper
    {
        List<PayPlanPreviewListUI> PayPlanPreviewList(List<PayPlanPreviewListUI> payPlanPreviewListDbs);
        List<musteriteklifleriozet_odemesekli> PayPlanAdd(List<PayPlanAdd> payPlanAdds);

    }
}
