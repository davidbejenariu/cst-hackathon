namespace backend.backend_DAL.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }



        // 1 - 1: Offer - Product
        public Offer? Offer { get; set; }

        // 1 - M : Product - Codes
        public virtual ICollection<Code>? Codes { get; set; } //1-M

        
    }
}
