using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Model.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(200)]
        public string Office { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalet { get; set; }
        [ForeignKey("RoleID")]
        public Role RoleID { get; set; }

    }
}
