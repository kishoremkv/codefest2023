using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    [Table("address_master")]
    public class AddressMaster : BaseEntity
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }
        [Column("address1")]
        public string Address1 { get; set; }
        [Column("address2")]
        public string Address2 { get; set; }
        [Column("address3")]
        public string Address3 { get; set; }
        [Column("pin")]
        public string Pin { get; set; }

        [Column("country")]
        public string Country { get; set; }
    
    }
}