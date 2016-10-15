using System.ComponentModel.DataAnnotations;

namespace CP.Web.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int P_D { get; set; }
        public int A_S { get; set; }
        public int S_L { get; set; }
        public int N_O { get; set; }
        public int K { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}