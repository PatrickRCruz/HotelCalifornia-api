using HotelCalifornia.API.Models;
using HotelCalifornia.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace HotelCalifornia.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private IGuestService _guestService;

        public GuestsController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<Guest>>> GetGuests()
        {
            try
            {
                var guests = await _guestService.GetGuests();
                return Ok(guests);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter hóspede");
            }
        }

        [HttpGet("HóspedePorNome")]
        public async Task<ActionResult<IAsyncEnumerable<Guest>>>
            GetGuestByName([FromQuery] string Name)
        {
            try
            {
                var guests = await _guestService.GetGuestByName(Name);

                if (guests == null)
                    return NotFound($"Não existem hóspedes com o critério{Name}");
                return Ok(guests);
            }
            catch
            {
                return BadRequest("Request Inválido");
            }
        }

        [HttpGet("{Id:int}", Name = "GetGuest")]
        public async Task<ActionResult<Guest>> GetGuest(int Id)
        {
            try
            {
                var guest = await _guestService.GetGuest(Id);

                if (guest == null)
                    return NotFound($"Não existe hóspede com o Id= {Id}");

                return Ok(guest);
            }
            catch
            {
                return BadRequest("Request Inválido");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create(Guest guest)
        {
            try
            {
                await _guestService.CreateGuest(guest);
                return CreatedAtRoute(nameof(GetGuest), new { Id = guest.Id }, guest);

            }
            catch
            {
                return BadRequest("Request Inválido");
            }
        }

        [HttpPut("{Id:int}")]
        public async Task<ActionResult> Update(int Id, [FromBody] Guest guest)
        {
            try
            {
                if (guest.Id == Id)
                {
                    await _guestService.UpdateGuest(guest);
                    return Ok($"Hóspede com Id ={Id} foi atualizado com sucesso");
                }
                else
                {
                    return BadRequest("Dados incorretos");
                }
            }
            catch
            {
                return BadRequest("Request Inválido");
            }
        }

        [HttpDelete("{Id:int}")]
        public async Task<ActionResult> Delete(int Id)
        {
            try
            {
                var guest = await _guestService.GetGuest(Id);
                if (guest != null)
                {
                    await _guestService.DeleteGuest(guest);
                    return Ok($"Hóspede de id={Id} foi removido com sucesso!");
                }
                else 
                {
                    return NotFound($"Hósped com o id={Id} não foi localizado!");
                }
            }
            catch
            {
                return BadRequest("Request Inválido");
            }
        }


    }

}
