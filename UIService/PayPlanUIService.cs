using OdemePlanı_7.Business.ConverterForUI;
using OdemePlanı_7.Business.ConverterToListBoxItem;
using OdemePlanı_7.Business.ConverterToListBoxItem.Concrete;
using OdemePlanı_7.Business.Validator;
using OdemePlanı_7.Business.Validator.Abstract;
using OdemePlanı_7.Entities;
using OdemePlanı_7.Mapping;
using OdemePlanı_7.Mapping.Abstract;
using OdemePlanı_7.Repositories;
using System.Data;

namespace OdemePlanı_7.UIService
{
    public class PayPlanUIService : IPayPlanUIService
    {
        private readonly string active = "A";
        private readonly string passive = "P";


        private IPayPlanMapper mapper;
        private IPayPlanRepository repository;
        private IDataValidator dataValidator;
        private IConverterForUI converterForUI;
        private IUserValidator userValidator;

        public PayPlanUIService()
        {
            mapper = new PayPlanListMapper();
            repository = new PayPlanRepository();
            dataValidator = new DataValidator();
            converterForUI = new ConverterForUI();
            userValidator=new UserValidator();


        }
        public string[] PayPlanPreviewList()
        {
            return converterForUI
                    .PayPlanListConvertToStringList(dataValidator
                        .PayPlanListValidator(mapper
                            .PayPlanPreviewList(repository
                                .GetAllPayPlanPreviews())));

        }
        public DataGridView PayPlanDetailList(string grubadi)
        {
             return converterForUI
                .PayPlanDetailListConvertToDataGridviewList(dataValidator
                    .PayPlanDetailListValidator(repository
                        .GetPayPlanDetailList(grubadi)));
           
        }
        
        public void InsertNewPayPlan(DataGridView dataGridView,string grupadi)
        {

            //--> user validation
            #region
            if (userValidator.ValidateAddDataGridView(dataGridView)) { return; }
            if(userValidator.ValidatePercentData(dataGridView)) { return; }
            if (userValidator.ValidateGroupName(grupadi)) { return; }
            if (userValidator.ValidateGroupNameDuplicate (repository.PayPlanNameCheck(grupadi))) { return; }
            

            #endregion
            //--> data validation
            #region
            if (dataValidator.PayPlanAddTextCheckValidator(dataGridView)) { return; };
            grupadi = dataValidator.PayPlanGrupNameValidator(grupadi);
            dataGridView = dataValidator.PayPlanAddTextValidator(dataGridView);
            if (dataValidator.PayPlanPayShareValidator(dataGridView)) { return; }
            
            #endregion
            List<PayPlanAdd> addList = new List<PayPlanAdd>();


            var b = dataGridView.Rows.Count;
            var ozet_bimno = repository.LastOzetBimnoGet();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                addList.Add(new PayPlanAdd()
                {
                    bilgisayaradi_i="",
                    bilgisayaradi_k= Environment.UserName,
                    grupadi= grupadi,
                    aktifpasif= active,
                    iptaleden="",
                    iptaltarihi_d= null,
                    kaydeden = "",
                    kayittarihi_d= DateTime.Now,
                    odemesekli = (string)row.Cells[0].Value,
                    ozet_bimno= ozet_bimno,
                    sirketkodu="Rafex",
                    yuzde= (string)row.Cells[1].Value

                });

                
                
            }
            var a = mapper.PayPlanAdd(addList);
            repository.InsertPayPlan(a);
        }

        public void PayPlanDelete(string groupName)
        {
            // validation
            #region
            if (userValidator.ValidateUserPayPlanQuestions()) { return; }
            #endregion
            repository.PayPlanDeleteList(groupName);
            


        }
    }
}
