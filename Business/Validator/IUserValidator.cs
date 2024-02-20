using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_7.Business.Validator
{
    public interface IUserValidator
    {
        public bool ValidateAddDataGridView(DataGridView dataGridView);
        public bool ValidatePercentData(DataGridView dataGridView);
        public bool ValidateGroupName(string groupName);
        public bool ValidateGroupNameDuplicate(bool resultGroupName);
        public bool ValidateUserPayPlanQuestions();
    }
}
