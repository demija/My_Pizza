using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using MyPizza_API.Models;

namespace MyPizza_API.Controllers
{
    public class StatusiPizzaController : ApiController
    {
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/StatusiPizza
        public IQueryable<StatusiPizza> GetStatusiPizza()
        {
            return db.StatusiPizza;
        }

        // GET: api/StatusiPizza/5
        [ResponseType(typeof(StatusiPizza))]
        public IHttpActionResult GetStatusiPizza(int id)
        {
            StatusiPizza statusiPizza = db.StatusiPizza.Find(id);
            if (statusiPizza == null)
            {
                return NotFound();
            }

            return Ok(statusiPizza);
        }

        // PUT: api/StatusiPizza/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStatusiPizza(int id, StatusiPizza statusiPizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != statusiPizza.StatusPizzeId)
            {
                return BadRequest();
            }

            db.Entry(statusiPizza).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatusiPizzaExists(id))
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

        // POST: api/StatusiPizza
        [ResponseType(typeof(StatusiPizza))]
        public IHttpActionResult PostStatusiPizza(StatusiPizza statusiPizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.StatusiPizza.Add(statusiPizza);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = statusiPizza.StatusPizzeId }, statusiPizza);
        }

        // DELETE: api/StatusiPizza/5
        [ResponseType(typeof(StatusiPizza))]
        public IHttpActionResult DeleteStatusiPizza(int id)
        {
            StatusiPizza statusiPizza = db.StatusiPizza.Find(id);
            if (statusiPizza == null)
            {
                return NotFound();
            }

            db.StatusiPizza.Remove(statusiPizza);
            db.SaveChanges();

            return Ok(statusiPizza);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StatusiPizzaExists(int id)
        {
            return db.StatusiPizza.Count(e => e.StatusPizzeId == id) > 0;
        }
    }
}