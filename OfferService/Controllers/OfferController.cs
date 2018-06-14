
namespace OfferService.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using OfferService.Data.Entities;
    using OfferService.Data.UnitOfWork;

    [Produces("application/json")]
    [Route("api/Offer")]
    public class OfferController : Controller
    {
        private readonly IOfferUnit offerunit;
        private string msgOK = "Oferta  guardada satisfactoriamente";
        private string msgError = "Error al guardar";


        [HttpPost]
        public async Task<IActionResult> PostOffer(OfferDb dataOffer)
        {
            try
            {
                await offerunit.RepositoryOffer.SaveOffer(dataOffer);
                await offerunit.Complete();
                return Ok(msgOK);

            }
            catch (Exception ex)
            {
                return BadRequest(msgError);

            }
        }
    }
}