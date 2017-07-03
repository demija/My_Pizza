using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using MyPizza_API.Models;

namespace MyPizza_API.Controllers
{
    public class GradoviController : ApiController
    {
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/Gradovi
        public IQueryable<Gradovi> GetGradovi()
        {
            return db.Gradovi;
        }

        // GET: api/Gradovi/5
        [ResponseType(typeof(Gradovi))]
        public IHttpActionResult GetGradovi(int id)
        {
            Gradovi gradovi = db.Gradovi.Find(id);
            if (gradovi == null)
            {
                return NotFound();
            }

            return Ok(gradovi);
        }

        // PUT: api/Gradovi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGradovi(int id, Gradovi gradovi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gradovi.GradId)
            {
                return BadRequest();
            }

            db.Entry(gradovi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GradoviExists(id))
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

        // POST: api/Gradovi
        [ResponseType(typeof(Gradovi))]
        public IHttpActionResult PostGradovi(Gradovi gradovi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Gradovi.Add(gradovi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = gradovi.GradId }, gradovi);
        }

        // DELETE: api/Gradovi/5
        [ResponseType(typeof(Gradovi))]
        public IHttpActionResult DeleteGradovi(int id)
        {
            Gradovi gradovi = db.Gradovi.Find(id);
            if (gradovi == null)
            {
                return NotFound();
            }

            db.Gradovi.Remove(gradovi);
            db.SaveChanges();

            return Ok(gradovi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GradoviExists(int id)
        {
            return db.Gradovi.Count(e => e.GradId == id) > 0;
        }
    }
}