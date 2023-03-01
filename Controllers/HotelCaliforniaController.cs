
//namespace HotelCalifornia.API.Controllers
//{
//    [Route("api/hotel-california")]
//    [ApiController]
//    public class HotelCaliforniaController : ControllerBase
//    {
//        private readonly HotelCaliforniaDbContext _context;

//        public HotelCaliforniaController(HotelCaliforniaDbContext context)
//        {
//            _context = context;
//        }


//        //api/hotel-california/
//        [HttpGet]
//        public IActionResult GetAll()
//        {
//            var hotelCalifa = _context.HotelEvents.Where(d => !d.IsDeleted).ToList();

//            return Ok(hotelCalifa);
//        }

//        //api/hotelcalifornia/ 356499876 GET
//        [HttpGet("{id}")]
//        public IActionResult GetById(Guid id)
//        {
//            var hotelCalifa = _context.HotelEvents.SingleOrDefault(d => d.Id == id);
//            if (hotelCalifa == null)
//            {
//                return NotFound();
//            }
//            return Ok(hotelCalifa);
//        }

//        //api/hotelcalifornia/ 356499876 POST
//        [HttpPost]
//        public IActionResult Post(HotelCalifa hotelCalifa)
//        {
//            _context.HotelEvents.Add(hotelCalifa);

//            return CreatedAtAction(nameof(GetById), new { id = hotelCalifa.Id }, hotelCalifa);
//        }
//        //api/hotelcalifornia 356499876 PUT
//        [HttpPut("{id}")]
//        public IActionResult Update(Guid id, HotelCalifa input)
//        {
//            var hotelCalifa = _context.HotelEvents.SingleOrDefault(d => d.Id == id);

//            if (hotelCalifa == null)
//            {
//                return NotFound();
//            }

//            hotelCalifa.Update(input.Title, input.Description, input.StartDate, input.EndDate);

//            return NoContent();

//        }
//        //api/hotelcalifornia/ 356499876 DELETE
//        [HttpDelete("{id}")]
//        public IActionResult Delete(Guid id)
//        {
//            var hotelCalifa = _context.HotelEvents.SingleOrDefault(d => d.Id == id);
//            if (hotelCalifa == null)
//            {
//                return NotFound();
//            }

//            hotelCalifa.Delete();

//            return NoContent();
//        }
//    }
//}
