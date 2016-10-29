namespace CP.Data.Models
{
    public class User : EntityBase
    {
        public string UserName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; } 
        public string Password { get; set; }
        public int P_D { get; set; }
        public int A_S { get; set; }
        public int S_L { get; set; }
        public int N_O { get; set; }
        public int K { get; set; }

        public  int RoleId { get; set; }
        public virtual  Role Role { get; set; }

        public  virtual SecondTest SecondTest { get; set; }
    }
}