using BLOGGER_FETHULLAHKAYA.DATA;
using BLOGS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLOGGER_FETHULLAHKAYA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AUTHORSController : ControllerBase
    {
        private readonly DatabaseContext _context;


        // in this controller, i have'nt applied a Repostry Patter. so in the future, it will be hard to make some changes. 

            //singleton in the constructor
        public AUTHORSController(DatabaseContext context)
        {
            _context = context;
        }

        //list all
        [HttpGet]
        public async Task<IEnumerable<AUTHORS>> Get()
        {
            return await _context.AUTHORSS.ToListAsync();
        }


        //find by id
        [HttpGet("{id}")]
        public async Task<ActionResult<AUTHORS>> GetAUTHORS(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
                return NotFound();
            return await _context.AUTHORSS.FindAsync(id);
        }


        //update
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAUTHORS(int id, AUTHORS AUTHORSSS)
        {
            if (id != AUTHORSSS.AUTOHOR_ID)
            {
                return BadRequest();
            }

            _context.Entry(AUTHORSSS).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                return BadRequest();

            }

            return NoContent();
        }


        //delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<AUTHORS>> DeleteAUTHORS(int id)
        {
            var aUTHORS = await _context.AUTHORSS.FindAsync(id);
            if (aUTHORS == null)
            {
                return NotFound();
            }

            _context.AUTHORSS.Remove(aUTHORS);
            await _context.SaveChangesAsync();

            return aUTHORS;
        }


        //insert
        [HttpPost]
        public async Task<ActionResult<AUTHORS>> PostAUTHORS(AUTHORS Authors)
        {
            _context.AUTHORSS.Add(Authors);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAUTHORS", new { id = Authors.AUTOHOR_ID }, Authors);
        }
    }
}