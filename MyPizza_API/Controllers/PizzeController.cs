using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using MyPizza_API.Models;

namespace MyPizza_API.Controllers
{
    public class PizzeController : ApiController
    {
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/Pizze
        public IQueryable<Pizze> GetPizze()
        {
            return db.Pizze;
        }

        // GET: api/Pizze/5
        [ResponseType(typeof(Pizze))]
        public IHttpActionResult GetPizze(int id)
        {
            Pizze pizze = db.Pizze.Find(id);
            if (pizze == null)
            {
                return NotFound();
            }

            return Ok(pizze);
        }

        // PUT: api/Pizze/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPizze(int id, Pizze pizze)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pizze.PizzaId)
            {
                return BadRequest();
            }

            db.Entry(pizze).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzeExists(id))
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

        // POST: api/Pizze
        [ResponseType(typeof(Pizze))]
        public IHttpActionResult PostPizze(Pizze pizze)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pizze.Add(pizze);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pizze.PizzaId }, pizze);
        }

        // DELETE: api/Pizze/5
        [ResponseType(typeof(Pizze))]
        public IHttpActionResult DeletePizze(int id)
        {
            Pizze pizze = db.Pizze.Find(id);
            if (pizze == null)
            {
                return NotFound();
            }

            db.Pizze.Remove(pizze);
            db.SaveChanges();

            return Ok(pizze);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PizzeExists(int id)
        {
            return db.Pizze.Count(e => e.PizzaId == id) > 0;
        }
    }
}