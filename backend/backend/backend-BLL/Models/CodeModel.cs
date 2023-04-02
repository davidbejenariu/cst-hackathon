using System.ComponentModel.DataAnnotations;

namespace backend.backend_BLL.Models
{
    public class CodeModel
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid? ProductId { get; set; }
    }
}
