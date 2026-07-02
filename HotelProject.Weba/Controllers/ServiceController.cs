using HotelProjectBusiness.Abstract;
using HotelProjectEntity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Weba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _ServiceService;

        public ServiceController(IServiceService ServiceService)
        {
            _ServiceService = ServiceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _ServiceService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _ServiceService.Insert(service); 
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
    
            var values = _ServiceService.GetByID(id);
            if (values == null)
            {
                return NotFound("Silinecek servis bulunamadı.");
            }
            _ServiceService.Delete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _ServiceService.Update(service); 
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _ServiceService.GetByID(id);
            return Ok(values); 
        }
    }
}