using System;
using System.Collections.Generic;

namespace Project.DB.Models
{
    public partial class Record : BaseEntity
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string MasterId { get; set; }
        public System.DateTime Time { get; set; }
        public float Duration { get; set; }
        public virtual AspNetUser Client { get; set; }
        public virtual AspNetUser Master { get; set; }
    }
}
