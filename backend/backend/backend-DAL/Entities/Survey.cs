namespace backend.backend_DAL.Entities
{
    public class Survey
    {
        public Guid Id { get; set; }
        public string Name { get; set; }


        // 1 - 1: Offer - Survey
        public Offer? Offer { get; set; }

    }
}
