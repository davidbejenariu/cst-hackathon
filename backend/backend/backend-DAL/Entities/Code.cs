﻿namespace backend.backend_DAL.Entities
{
    public class Code
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public bool IsUsed { get; set; }

        public string ProductId { get; set; } // 1 - M: Product - Code
        public virtual Product? Product { get; set; }
    }
}
