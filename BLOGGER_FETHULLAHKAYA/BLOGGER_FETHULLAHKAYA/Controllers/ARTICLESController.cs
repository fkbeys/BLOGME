using BLOGGER_FETHULLAHKAYA.DATA.REPO;
using BLOGS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BLOGGER_FETHULLAHKAYA.Controllers
{
    /// <summary>
    /// The Artciles controller is for CRUD operations for Articles
    /// </summary>
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
        /// <summary>
        /// This Get Method returns All Articles
        /// </summary>
        /// <returns>Array of Articles </returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ARTICLESREPO.All());
        }

        /// <summary>
        /// This Get method finds an articel according to its ID
        /// </summary>
        /// <param name="id">Int id to find the article </param>
        /// <returns>an article</returns>
        // GET api/articles/5
        [HttpGet("{id}")]
        public IActionResult Get(int? id)
        {
            if (!id.HasValue) return BadRequest();

            var artcls = ARTICLESREPO.GetById(id);

            if (artcls == null) return NotFound();

            return Ok(artcls);
        }


        /// <summary>
        /// Put method to update the article
        /// </summary>
        /// <param name="id">int id to find the article</param>
        /// <param name="article"> the new updated values </param>
        /// <returns>returns OK if the operation is success</returns>
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

         
         /// <summary>
         /// To insert a new article record
         /// </summary>
         /// <param name="articles">article information</param>
         /// <returns>returns OK if the operation is success</returns>
        // POST api/articles
        [HttpPost]
        public IActionResult Post([FromBody]ARTICLES articles)
        {
            if (!ModelState.IsValid || articles == null) return BadRequest();

            if (ARTICLESREPO.Add(articles))
                return Ok(articles);

            return BadRequest();
        }


        /// <summary>
        /// deletes the specific record
        /// </summary>
        /// <param name="id">int id to find the record that will be deleted</param>
        /// <returns> Returns OK if the operation is success</returns>
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