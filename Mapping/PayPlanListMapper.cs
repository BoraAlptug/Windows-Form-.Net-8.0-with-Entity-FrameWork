using AutoMapper;
using OdemePlanı_7.Entities;
using OdemePlanı_7.Mapping.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_7.Mapping
{
    public class PayPlanListMapper : Profile, IPayPlanMapper
    {
        public List<PayPlanPreviewListUI> PayPlanPreviewList(List<PayPlanPreviewListUI> payPlanPreviewListDbs)
        {
            List<PayPlanPreviewListUI> payPlanPreviewListUIs = new List<PayPlanPreviewListUI>();
            foreach (var db in payPlanPreviewListDbs)
            {
                payPlanPreviewListUIs.Add(new PayPlanPreviewListUI
                {
                    grupadi = db.grupadi,
                    ozet_bimno = db.ozet_bimno
                });
            }
            return payPlanPreviewListUIs;
        }
        public List<musteriteklifleriozet_odemesekli> PayPlanAdd(List<PayPlanAdd> payPlanAdds)
        {
            List<musteriteklifleriozet_odemesekli> musteriteklifleriozet_Odemeseklis 
                = new List<musteriteklifleriozet_odemesekli>();
            foreach (var db in payPlanAdds)
            {
                musteriteklifleriozet_Odemeseklis.Add(new musteriteklifleriozet_odemesekli
                {
                    aktifpasif=db.aktifpasif,
                    bilgisayaradi_i=db.bilgisayaradi_i,
                    bilgisayaradi_k=db.bilgisayaradi_k,
                    grupadi=db.grupadi,
                    iptaleden=db.iptaleden,
                    iptaltarihi_d=db.iptaltarihi_d,
                    kaydeden=db.kaydeden,
                    kayittarihi_d= db.kayittarihi_d,
                    odemesekli=db.odemesekli,
                    ozet_bimno=db.ozet_bimno,
                    sirketkodu=db.sirketkodu,
                    yuzde = db.yuzde
                });
            }
            return musteriteklifleriozet_Odemeseklis;
        }
       

    }
}
