using OdemePlanı_7.Business.ConverterToListBoxItem;
using OdemePlanı_7.Business.ConverterToListBoxItem.Concrete;
using OdemePlanı_7.Repositories;
using OdemePlanı_7.UIService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdemePlanı_7.UI.Forms
{
    public partial class PayPlanAdd_frm : Form
    {
        private IItemsCascading itemsCascading;
        private IPayPlanUIService payPlanUIService;

        public PayPlanAdd_frm()
        {
            InitializeComponent();
            this.itemsCascading = new ItemsCascading();
            this.payPlanUIService = new PayPlanUIService();

        }

        public void PayPlanAdd_frm_Load(object sender, EventArgs e)
        {
            payPlanAdd_dgw.Rows.Clear();
            itemsCascading.PayPlanAddListCascading(payPlanAdd_dgw);
        }

        private void payPlanListDeleteRow_btn_Click(object sender, EventArgs e)
        {
            if (payPlanAdd_dgw.RowCount > 1) { payPlanAdd_dgw.RowCount--; }
        }

        private void payPlanListAddRow_btn_Click(object sender, EventArgs e)
        {
            payPlanAdd_dgw.RowCount++;
        }

        private void payPlanAdd_btn_Click(object sender, EventArgs e)
        {
            payPlanUIService.InsertNewPayPlan(payPlanAdd_dgw, payPlanGroupName_txt.Text);

        }

        private void payPlanClose_btn_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
    }
}
