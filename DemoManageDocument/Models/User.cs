using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoManageDocument.Models
{
    [Table("UserLogin")]
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Employee { get; set; }
    }
}
