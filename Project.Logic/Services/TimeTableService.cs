using System;
using System.Linq;
using Project.DB.Configurations;
using Project.Logic.Mappers;
using Project.Logic.Models;

namespace Project.Logic.Services
{
    public interface ITimeTableService
    {
        TimeTable GetTimeTable();
    }

    public class TimeTableService : ITimeTableService
    {
        private IContextProvider contextProvider;
        private ITimeTableMapper mapper;

        public TimeTableService(IContextProvider contextProvider, ITimeTableMapper mapper)
        {
            this.contextProvider = contextProvider;
            this.mapper = mapper;
        }
        public TimeTable GetTimeTable()
        {
            using (var context = contextProvider.Context)
            {
                var today = DateTime.Today;
                var nextDay = DateTime.Today.AddDays(1);
                var records = context.Records.Where(x => x.Time > today
                    && x.Time < nextDay).ToList();
                return mapper.Map(records);
            }
        }
    }
}
