using System.Collections.Generic;

namespace Project.Logic.Models
{
    public class TimeTable
    {
        public TimeTable()
        {
            Records = new List<RecordShort>();
        }

        public IList<RecordShort> Records { get; set; }
    }
}