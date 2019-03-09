using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutoMapper
{
    class UserModel
    {

        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string SureName { get; set; }
        public int Age { get; set; }
        public string AccessCode { get; set; }
        public IncomeModel IncomeInfo { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
