using OdemePlanı_7.Business.ConverterToListBoxItem;
using OdemePlanı_7.Business.ConverterToListBoxItem.Concrete;
using OdemePlanı_7.Business.Validator;
using OdemePlanı_7.UIService;

namespace OdemePlanı_7.UI.Forms
{
    public partial class PayPlanPreviewList_frm : Form
    {
        IPayPlanUIService PayPlanUIService;
        IItemsCascading itemsCascading;
        PayPlanAdd_frm payPlanAdd_Frm;
        public PayPlanPreviewList_frm(IPayPlanUIService PayPlanUIService)
        {
            InitializeComponent();
            this.PayPlanUIService = PayPlanUIService;
            this.itemsCascading = new ItemsCascading();
            this.payPlanAdd_Frm= new PayPlanAdd_frm();  
           
        }
       
        

        private void PayPlanPreviewListLoad()
        {
            payPlanPreviewList_lstbox.Items.Clear();
            payPlanPreviewList_lstbox.DataSource = PayPlanUIService.PayPlanPreviewList();
        }

        private void PayPlanPreviewList_frm_Load(object sender, EventArgs e)
        {
            payPlanPreviewList_lstbox.Items.Clear();
            payPlanPreviewList_lstbox.DataSource = PayPlanUIService.PayPlanPreviewList();
        }

        private void payPlanPreviewList_lstbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selection = payPlanPreviewList_lstbox.SelectedValue.ToString();
            if (selection == null) { return; }

            payPlanPreviewDetailList_dgw.DataSource = PayPlanUIService
                                                        .PayPlanDetailList(selection)
                                                                       .DataSource;

        }

        private void newPayPlanAdd_btn_Click(object sender, EventArgs e)
        {
            
            payPlanAdd_Frm.ShowDialog();
            
        }

        private void payPlanDelete_btn_Click(object sender, EventArgs e)
        {
            var selection = payPlanPreviewList_lstbox.SelectedValue.ToString();
            if (selection == null) { return; }
            PayPlanUIService.PayPlanDelete(selection);
            PayPlanPreviewListLoad();
        }

       
    }
}
