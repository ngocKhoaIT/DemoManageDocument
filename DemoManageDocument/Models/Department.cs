using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoManageDocument.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } 
        public string Organization { get; set; }

        //public ICollection<Employee> Employees { get; set; } 
    }
}
