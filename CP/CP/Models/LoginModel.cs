using System.ComponentModel.DataAnnotations;

namespace CP.Web.Models
{
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}