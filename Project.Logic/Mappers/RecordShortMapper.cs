using Project.DB.Models;
using Project.Logic.Models;

namespace Project.Logic.Mappers
{
    public interface IRecordShortMapper
    {
        RecordShort Map(Record record);
    }
    public class RecordShortMapper : IRecordShortMapper
    {
        public RecordShort Map(Record record)
        {
            return new RecordShort
            {
                Id = record.Id,
                MasterId = record.MasterId,
                Time = record.Time,
                Duration = record.Duration,
                ClientName = record.Client.UserName,
                MasterName = record.Master.UserName,
            };
        }

    }
}
