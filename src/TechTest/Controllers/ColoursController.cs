using Microsoft.AspNetCore.Mvc;
using TechTest.Repositories;

namespace TechTest.Controllers
{
    [Route("api/colours")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        public ColoursController(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        private IUnitofWork _unitofWork { get; }

        [HttpGet]
        public IActionResult GetAll()
        {
            var colours =_unitofWork.Colors.GetAll()  ;

            return this.Ok(colours);
        }
    }
}
