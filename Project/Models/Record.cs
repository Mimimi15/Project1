using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Record
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string MasterId { get; set; }
        public System.DateTime Hour { get; set; }
        public float Duration { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
    }
}
