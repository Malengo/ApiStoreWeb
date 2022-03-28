using System.Net;
using ApiStoreWeb.Models.Entites;
using ApiStoreWeb.Repository.PurchaseRepository;
using Microsoft.AspNetCore.Mvc;

namespace ApiStoreWeb.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly IPurchaseRepository _repository;

        public PurchaseController(IPurchaseRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("api/vendas")]
        public async  Task<IActionResult> createPurchase([FromBody] Purchase purchase){
             try
             {
                 await _repository.addNewPurchase(purchase);
                 return Ok();
             }
             catch (System.Exception e)
             {
                 return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
                 throw;
             }
        }
    }
}
