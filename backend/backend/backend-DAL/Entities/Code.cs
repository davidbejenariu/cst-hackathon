namespace backend.backend_DAL.Entities
{
    public class Code
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsUsed { get; set; }
        //public string ProductId { get; set; } //FK Offer
        public Guid? ProductId { get; set; } // 1 - M:  Product - Code

        public Product? Product { get; set; }
    }
}
