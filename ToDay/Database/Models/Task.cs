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
    [Table("Task")]
    [EntityTypeConfiguration(typeof(TaskConfiguration))]
    internal class Task
    {
        [Key]
        public int task_Id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? sheduled_for { get; set; }
        public bool is_active { get; set; }
        public bool is_priority { get; set; }
    }
}
