using System.Web.Http;
using Project.Logic.Models;
using Project.Logic.Services;

namespace Project.Web.Controllers
{
    public class RecordController : ApiController
    {
        private ITimeTableService service;

        public RecordController(ITimeTableService service)
        {
            this.service = service;
        }

        [Authorize]
        public TimeTable Get()
        {
            return service.GetTimeTable();
        }
    }
}
