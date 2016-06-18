using System;

namespace Project.Web.Models
{
    public class ScheduleRequest
    {
        public string MasterId { get; set; }
        public DateTime Time { get; set; }
        public float Duration { get; set; }
    }
}