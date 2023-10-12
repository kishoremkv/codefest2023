using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    [Table("appointment_master")]
    public class AppointmentMaster : BaseEntity
    {
        [Key]
        [Column("appointment_id")]
        public int AppointmentId { get; set; }

        [Column("client_id")]
        public string ClientId { get; set; }
        [Column("therapist_id")]
        public string TherapistId { get; set; }

        [Column("appointment_time")]
        public DateTime AppointmentTime { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("actual_start")]
        public DateTime ActualStart { get; set; }

        [Column("actual_end")]
        public DateTime ActualEnd { get; set; }
    }
}