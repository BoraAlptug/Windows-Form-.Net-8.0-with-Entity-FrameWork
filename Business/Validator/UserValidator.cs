using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations.Builders;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OdemePlanı_7.Business.Validator
{

    public class UserValidator : IUserValidator
    {
        private string emptyDataError = "Hücreler Boş Bırakılamaz";
        private string nonNumericValueErrorMessage = "Lütfen Sayısal Bir Değer Giriniz";
        private string groupNameEmptyValueErrorMessage = "Lütfen Grup Adı Giriniz";
        private string groupNameNotStringValueErrorMessage = "Lütfen Grup Adına İsim Giriniz";
        private string groupNameDuplicateErrorMessage = "Mükerrer Grup Adı";
        private string payPlanDeleteQuestion = "Planı Silinecek";
        private string massegeBoxOkAnswer = "OK";
        private string massegeBoxCancelAnswer = "CANCEL";


        public bool ValidateAddDataGridView(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {
                        MessageBox.Show(emptyDataError, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                }
            }
            return false;
        }
        public bool ValidatePercentData(DataGridView dataGridView)
        {
            double number = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                
                    if (!(double.TryParse((string?)row.Cells[1].Value, out number)))
                    {
                        
                        MessageBox.Show(nonNumericValueErrorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                
            }

            return false;
        }
        public bool ValidateGroupName(string groupName) 
        {
            double number = 0;
            if (string.IsNullOrEmpty(groupName)) 
            {
                MessageBox.Show(groupNameEmptyValueErrorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; 
            }
            if((double.TryParse(groupName, out number))) 
            {
                MessageBox.Show(groupNameNotStringValueErrorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; 
            }
            return false;
        }
        public bool ValidateGroupNameDuplicate(bool resultGroupName) 
        {
            if (resultGroupName)
            {
                MessageBox.Show(groupNameDuplicateErrorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }


            return false;
        }
        public bool ValidateUserPayPlanQuestions() 
        {
           var result = MessageBox.Show(payPlanDeleteQuestion, 
                        "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result.ToString().ToUpper() == massegeBoxCancelAnswer) { return true; }

            return false; 
        }
    }
}
