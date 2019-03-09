using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutoMapper
{
    class UserDto
    {
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string SureName { get; set; }
        public string Age{ get; set; }
        public string AccessCode{ get; set; }
        public IncomeDto IncomeInfo { get; set; }
        public DateTime Dob { get; set; }
    }
}
