using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoManageDocument.Models
{
    [Table("Document")]
    public class Document
    {
        [Key]
        public int DocumentId { get; set; }
        public string Tilte { get; set; }
        public string Content { get; set; }
        public string Create_date { get; set; }
        public string Create_by { get; set; }
        public string ImportentLevel { get; set; }
        public string EmergencyLevel { get; set; }
        public string SecurityLevel { get; set; }
        public string status_level { get; set; }
    }
}
