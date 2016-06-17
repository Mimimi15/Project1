using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Logic.Models
{
    public class RecordShort
    {
        public int Id { get; set; }
        public string MasterId { get; set; }
        public DateTime Time { get; set; }
        public float Duration { get; set; }
        public string ClientName { get; set; }
        public string MasterName { get; set; }
    }
}
