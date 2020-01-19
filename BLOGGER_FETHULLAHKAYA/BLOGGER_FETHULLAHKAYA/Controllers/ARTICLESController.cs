using BLOGGER_FETHULLAHKAYA.DATA.REPO;
using BLOGS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BLOGGER_FETHULLAHKAYA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ARTICLESController : ControllerBase
    {

        // the Articles Controller gets the database context through IRepostory interface.
        // in the future, if we want to add some other properties or if we want to make changes , it will be easy because we only need to make changes inside interface.

        private readonly IRepository<ARTICLES> ARTICLESREPO;

        //singleton prencip which gets database context throug IRepostory
        public ARTICLESController(IRepository<ARTICLES> _ARTICLESREPO)
        {
            ARTICLESREPO = _ARTICLESREPO;
        }


        // GET api/articles
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ARTICLESREPO.All());
        }


        // GET api/articles/5
        [HttpGet("{id}")]
        public IActionResult Get(int? id)
        {
            if (!id.HasValue) return BadRequest();

            var artcls = ARTICLESREPO.GetById(id);

            if (artcls == null) return NotFound();

            return Ok(artcls);
        }



        // PUT api/articles
        [HttpPut("{id}")]
        public IActionResult Put(int? id, [FromBody]ARTICLES article)
        {
             
            try
            {
                if (!id.HasValue) return BadRequest();
                if (!ModelState.IsValid || article == null) return BadRequest();
                 
                if (ARTICLESREPO.Update(article))
                    return Ok(article);
            }
            catch (System.Exception)
            {


                return BadRequest();
            }

            return BadRequest();

        }

         
         
        // POST api/articles
        [HttpPost]
        public IActionResult Post([FromBody]ARTICLES articles)
        {
            if (!ModelState.IsValid || articles == null) return BadRequest();

            if (ARTICLESREPO.Add(articles))
                return Ok(articles);

            return BadRequest();
        }



        // DELETE api/articles/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int? id)
        {
            if (!id.HasValue) return BadRequest();

            var articles = ARTICLESREPO.GetById(id);
            if (articles == null) return NotFound();

            if (ARTICLESREPO.Delete(articles))
                return Ok(articles);
            return BadRequest();
        }

    }
}