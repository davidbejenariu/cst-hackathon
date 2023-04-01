namespace backend.backend_DAL.Entities
{
    public class Code
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Used { get; set; }
        public string ProductId { get; set; } //FK Offer
        public virtual Product Product { get; set; } // 1 - M:  Product - Code
    }
}
