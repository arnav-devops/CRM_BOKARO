using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoProject.Models.Entity
{
    [Table("Users")]
    public partial class Users
    {
        [Key]
        [Column("uid")]
        public int Uid { get; set; }

        [Column("userName")]
        [StringLength(50)]
        public string UserName { get; set; }

        [Column("password")]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
