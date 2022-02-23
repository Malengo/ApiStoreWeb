using System.Net;
using ApiStoreWeb.Models;
using ApiStoreWeb.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiStoreWeb.Controllers
{
    public class SmartphoneController : Controller
    {
        private readonly ISmartphoneRepository _repository;

        public SmartphoneController(ISmartphoneRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("api/smartphone")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok( _repository.findAll());             
              
            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpPost("api/smartphone")]
        public IActionResult addPhone([FromBody] Smartphone phone)
        {
            try
            {                
                _repository.addAll(phone);
                return Ok("Foi 2");
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}
