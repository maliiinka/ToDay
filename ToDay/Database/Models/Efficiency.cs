using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDay.Database.Models.Configurations;

namespace ToDay.Database.Models
{
    [Table("Applicant")]
    [EntityTypeConfiguration(typeof(EfficiencyConfiguration))]
    internal class Efficiency
    {
        [Key]
        public int efficiency_Id { get; set; }
        public DateTime? day { get; set; }
        public int completed_tasks { get; set; }
    }
}
