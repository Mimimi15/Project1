using System;
using System.Collections.Generic;

namespace Project.DB.Models
{
    public partial class Record : BaseEntity
    {
        public decimal Id { get; set; }
        public decimal ClientId { get; set; }
        public decimal MasterId { get; set; }
        public System.DateTime Hour { get; set; }
        public string Duration { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
