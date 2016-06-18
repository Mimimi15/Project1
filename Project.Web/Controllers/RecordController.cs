using System.Web.Http;
using Microsoft.AspNet.Identity;
using Project.Logic.Models;
using Project.Logic.Services;
using Project.Web.Models;

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
        [Authorize]
        public void Post(ScheduleRequest request)
        {
            service.Schedule(User.Identity.GetUserId(), request.MasterId, request.Time, request.Duration);
        }
    }
}
