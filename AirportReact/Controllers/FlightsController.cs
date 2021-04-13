using BLL;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportReact.Controllers
{
    [ApiController]
    [Route("/api/flights/")]
    public class FlightsController : Controller
    {
        private IUnitOfWork DB;

        public FlightsController(IUnitOfWork basecontext)
        {
            DB = basecontext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flight>>> GetAll()
        {
            return new ActionResult<IEnumerable<Flight>>(await DB.Flights.GetList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Flight>> GetById(int id)
        {
            var flight = await DB.Flights.GetItem(id);
            if (flight == null) return NotFound();
            return flight;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Flight f)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DB.Flights.UpdateItem(f);
            await DB.Save();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Flight>> Create(Flight f)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var rez = await DB.Flights.CreateItem(f);
            await DB.Save();
            return rez;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePost(int id)
        {
            var post = await DB.Flights.GetItem(id);

            if (post == null)
            {
                return NotFound();
            }
            await DB.Flights.DeleteItem(id);
            await DB.Save();

            return NoContent();
        }
    }
}
