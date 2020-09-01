using BLOGGER_FETHULLAHKAYA.DATA;
using BLOGGER_FETHULLAHKAYA.DATA.REPO;
using BLOGS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BLOGGER_FETHULLAHKAYA.Controllers
{
    ///// <summary>
    ///// Authors controller is for CRUD operations of Authors
    ///// </summary>
    //[Route("api/[controller]")]
    //[ApiController]
    //public class AUTHORSController : ControllerBase
    //{

    //    private readonly IRepository<AUTHORS> _context;

    //    //singleton in the constructor


    //    public AUTHORSController(IRepository<AUTHORS> context)
    //    {
    //        _context = context;
    //    }

    //    //list all
    //    [HttpGet]
    //    public async Task<IEnumerable<AUTHORS>> Get()
    //    {
    //        return await _context.All().ToListAsync();
    //    }


    //    //find by id
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<AUTHORS>> GetAUTHORS(int id)
    //    {
    //        if (string.IsNullOrWhiteSpace(id.ToString()))
    //            return NotFound();
    //           return await _context.Where(x=>x.AUTOHOR_ID==id).FirstOrDefaultAsync();
             
                
    //    }


    //    //update
    //    [HttpPut("{id}")]
    //    public IActionResult PutAUTHORS(int id, AUTHORS AUTHORSSS)
    //    {
    //        if (id != AUTHORSSS.AUTOHOR_ID)
    //        {
    //            return BadRequest();
    //        }
    //        try
    //        {
    //            _context.Update(AUTHORSSS);
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {

    //            return BadRequest();

    //        }

    //        return NoContent();
    //    }


    //    //delete
    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<AUTHORS>> DeleteAUTHORS(int id)
    //    {
    //        var aUTHORS = await _context.Where(x => x.AUTOHOR_ID == id).FirstOrDefaultAsync();
    //        if (aUTHORS == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.Delete(aUTHORS);

    //        return aUTHORS;
    //    }


    //    //insert
    //    [HttpPost]
    //    public async Task<ActionResult<AUTHORS>> PostAUTHORS(AUTHORS Authors)
    //    {
    //        _context.Add(Authors);
    //        //await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetAUTHORS", new { id = Authors.AUTOHOR_ID }, Authors);
    //    }
    //}
}