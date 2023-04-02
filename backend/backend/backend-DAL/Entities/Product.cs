namespace backend.backend_DAL.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        // 1 - 1: Offer - Product
        public string OfferId { get; set; }
        public virtual Offer? Offer { get; set; }

        // 1 - M : Product - Codes
        public virtual IEnumerable<Code>? Codes { get; set; }
    }
}
