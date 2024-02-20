using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using OdemePlanı_7.DataAccess.Context;
using OdemePlanı_7.Entities;
using System.Security.Cryptography.X509Certificates;

namespace OdemePlanı_7.Repositories
{
    public class PayPlanRepository : IPayPlanRepository
    {
        private DenemeDbContext context;
        private readonly string active = "A";
        private readonly string passive = "P";

        public PayPlanRepository()
        {
            context = new DenemeDbContext();

        }

        public List<PayPlanPreviewListUI> GetAllPayPlanPreviews()
        {
            var listDbs = context.musteriteklifleriozet_odemesekli
                .Where(x => x.ozet_bimno < 0 && x.aktifpasif == active)
                .OrderBy(x => x.ozet_bimno)
                .GroupBy(x => new { x.grupadi, x.ozet_bimno })
                .Select(group => new PayPlanPreviewListUI
                {
                    grupadi = group.Key.grupadi,
                    ozet_bimno = group.Key.ozet_bimno
                })
                .ToList();

            return listDbs;
        }
        public List<PayPlanDetailListUI> GetPayPlanDetailList(string grubadi)
        {
            var listDbs = context.musteriteklifleriozet_odemesekli
                .Where(x => x.grupadi == grubadi && x.aktifpasif == active)
                .OrderBy(x => x.ozet_bimno)
                .Select(group => new PayPlanDetailListUI
                {
                    odemesekli = group.odemesekli,
                    yuzde = group.yuzde
                })
                .ToList();
            return listDbs;
        }
        public int LastOzetBimnoGet()
        {
            var result = context.musteriteklifleriozet_odemesekli
                        .Min(x => x.ozet_bimno);
            return Convert.ToInt32(result) - 1;
        }
        public void InsertPayPlan(List<musteriteklifleriozet_odemesekli> payPlanAdds)
        {

            context.musteriteklifleriozet_odemesekli.AddRange(payPlanAdds);
            context.SaveChanges();
        }
        public bool PayPlanNameCheck(string groupName)
        {
            var paymentPlan = context.musteriteklifleriozet_odemesekli
                        .OrderBy(x => x.ozet_bimno)
                        .FirstOrDefault(x => x.grupadi == groupName && x.aktifpasif == active);

            if (paymentPlan != null) { return true; }

            return false;

        }
        public void PayPlanDeleteList(string groupName)
        {

            var groupContent = context.musteriteklifleriozet_odemesekli
                 .Where(x => x.grupadi == groupName && x.aktifpasif == active)
                 .OrderByDescending(x => x.bimno)
                 .Select(group=> new PayPlanDelete()
                 {
                     bimno = group.bimno,
                     aktifpasif = group.aktifpasif,
                 })
                 .ToList();
            foreach (var group in groupContent)
            {
                
                context.musteriteklifleriozet_odemesekli
                    .Where(x => x.bimno==group.bimno && x.aktifpasif == active)
                    .ExecuteUpdate(newGroup=>newGroup
                    .SetProperty( newGroup=>newGroup.aktifpasif,passive));
            }

                
     
        }
        

    }
}
