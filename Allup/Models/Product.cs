namespace Allup.Models
{
    public class Product : BaseEntity
    {
        public string Image { get; set; }
        public bool IsMain { get; set; }
        public string Name { get; set; }
    }
}
