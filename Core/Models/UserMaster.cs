using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class UserMaster
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("user_type")]
        public string UserType { get; set;}
        [Column("password")]
        public string Password { get; set; }
        [Column("active")]
        public int Active { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("mobile")]
        public int Mobile { get; set; } 
        public DateTime DOB { get; set; }
        [Column("email")]
        public string Email { get; set; }
    }
}