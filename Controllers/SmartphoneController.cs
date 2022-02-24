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
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _repository.findAll());

            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }
        [HttpGet("api/smartphone/{id}")]
        public async Task<IActionResult> GetPhoneById(int id)
        {
            try
            {
                return Ok(await _repository.findById(id));

            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpPost("api/smartphone")]
        public async Task<IActionResult> addPhone([FromBody] Smartphone phone)
        {

            try
            {
                await _repository.addNewPhone(phone);
                return Ok();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


        [HttpPut("api/smartphone/{id}")]
        public async Task<IActionResult> changePhone(int id, [FromBody] Smartphone phone)
        {

            if (phone.Id != id)
            {
                return BadRequest();
            }
            try
            {
                await _repository.updatePhone(phone);
                return Ok("Foi");
            }
            catch (System.Exception e)
            {
                Console.Write(e);
                throw;
            }
        }

        [HttpDelete("api/smartphone/{id}")]
        public async Task<IActionResult> delete(int id)
        {
            try
            {
                var findPhone = await _repository.findById(id);
                if (findPhone is null)
                    return BadRequest();

                await _repository.deletePhone(findPhone);
                return Ok();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
