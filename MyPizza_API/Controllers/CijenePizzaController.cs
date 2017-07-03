using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using MyPizza_API.Models;

namespace MyPizza_API.Controllers
{
    public class CijenePizzaController : ApiController
    {
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/CijenePizza
        public IQueryable<CijenePizza> GetCijenePizza()
        {
            return db.CijenePizza;
        }

        // GET: api/CijenePizza/5
        [ResponseType(typeof(CijenePizza))]
        public IHttpActionResult GetCijenePizza(int id)
        {
            CijenePizza cijenePizza = db.CijenePizza.Find(id);
            if (cijenePizza == null)
            {
                return NotFound();
            }

            return Ok(cijenePizza);
        }

        // PUT: api/CijenePizza/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCijenePizza(int id, CijenePizza cijenePizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cijenePizza.CijenaPizzeId)
            {
                return BadRequest();
            }

            db.Entry(cijenePizza).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CijenePizzaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CijenePizza
        [ResponseType(typeof(CijenePizza))]
        public IHttpActionResult PostCijenePizza(CijenePizza cijenePizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CijenePizza.Add(cijenePizza);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cijenePizza.CijenaPizzeId }, cijenePizza);
        }

        // DELETE: api/CijenePizza/5
        [ResponseType(typeof(CijenePizza))]
        public IHttpActionResult DeleteCijenePizza(int id)
        {
            CijenePizza cijenePizza = db.CijenePizza.Find(id);
            if (cijenePizza == null)
            {
                return NotFound();
            }

            db.CijenePizza.Remove(cijenePizza);
            db.SaveChanges();

            return Ok(cijenePizza);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CijenePizzaExists(int id)
        {
            return db.CijenePizza.Count(e => e.CijenaPizzeId == id) > 0;
        }
    }
}