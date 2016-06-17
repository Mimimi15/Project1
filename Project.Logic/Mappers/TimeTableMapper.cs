using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DB.Models;
using Project.Logic.Models;

namespace Project.Logic.Mappers
{
    public interface ITimeTableMapper
    {
        TimeTable Map(IEnumerable<Record> records);
    }
    public class TimeTableMapper : ITimeTableMapper
    {
        private IRecordShortMapper mapper;

        public TimeTableMapper(IRecordShortMapper mapper)
        {
            this.mapper = mapper;
        }

        public TimeTable Map(IEnumerable<Record> records)
        {
            var result = new TimeTable();
            foreach (var record in records)
            {
                result.Records.Add(mapper.Map(record));
            }
            return result;
        }
    }
}
