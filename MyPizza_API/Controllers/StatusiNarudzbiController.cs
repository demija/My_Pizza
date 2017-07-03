using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using MyPizza_API.Models;

namespace MyPizza_API.Controllers
{
    public class StatusiNarudzbiController : ApiController
    {
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/StatusiNarudzbi
        public IQueryable<StatusiNarudzbi> GetStatusiNarudzbi()
        {
            return db.StatusiNarudzbi;
        }

        // GET: api/StatusiNarudzbi/5
        [ResponseType(typeof(StatusiNarudzbi))]
        public IHttpActionResult GetStatusiNarudzbi(int id)
        {
            StatusiNarudzbi statusiNarudzbi = db.StatusiNarudzbi.Find(id);
            if (statusiNarudzbi == null)
            {
                return NotFound();
            }

            return Ok(statusiNarudzbi);
        }

        // PUT: api/StatusiNarudzbi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStatusiNarudzbi(int id, StatusiNarudzbi statusiNarudzbi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != statusiNarudzbi.StatusNarudzbeId)
            {
                return BadRequest();
            }

            db.Entry(statusiNarudzbi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatusiNarudzbiExists(id))
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

        // POST: api/StatusiNarudzbi
        [ResponseType(typeof(StatusiNarudzbi))]
        public IHttpActionResult PostStatusiNarudzbi(StatusiNarudzbi statusiNarudzbi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.StatusiNarudzbi.Add(statusiNarudzbi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = statusiNarudzbi.StatusNarudzbeId }, statusiNarudzbi);
        }

        // DELETE: api/StatusiNarudzbi/5
        [ResponseType(typeof(StatusiNarudzbi))]
        public IHttpActionResult DeleteStatusiNarudzbi(int id)
        {
            StatusiNarudzbi statusiNarudzbi = db.StatusiNarudzbi.Find(id);
            if (statusiNarudzbi == null)
            {
                return NotFound();
            }

            db.StatusiNarudzbi.Remove(statusiNarudzbi);
            db.SaveChanges();

            return Ok(statusiNarudzbi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StatusiNarudzbiExists(int id)
        {
            return db.StatusiNarudzbi.Count(e => e.StatusNarudzbeId == id) > 0;
        }
    }
}