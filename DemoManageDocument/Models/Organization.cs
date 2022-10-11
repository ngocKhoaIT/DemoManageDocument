using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoManageDocument.Models
{
    [Table("Organization")]
    public class Organization
    {
        [Key]
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationLevel { get; set; }
        public int amount { get; set; }
        public string personInCharge { get; set; }

        //public ICollection<Department> Departments { get; set; }
    }
}
