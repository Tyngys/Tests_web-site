namespace CP.Data.Models
{
    public class SecondTest : EntityBase
    {
        public int Mark { get; set; }

        public virtual User User { get; set; }
    }
}
