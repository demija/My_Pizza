using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using MyPizza_API.Models;

namespace MyPizza_API.Controllers
{
    public class DodatniSastojciController : ApiController
    {
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/DodatniSastojci
        public IQueryable<DodatniSastojci> GetDodatniSastojci()
        {
            return db.DodatniSastojci;
        }

        // GET: api/DodatniSastojci/5
        [ResponseType(typeof(DodatniSastojci))]
        public IHttpActionResult GetDodatniSastojci(int id)
        {
            DodatniSastojci dodatniSastojci = db.DodatniSastojci.Find(id);
            if (dodatniSastojci == null)
            {
                return NotFound();
            }

            return Ok(dodatniSastojci);
        }

        [HttpGet]
        [Route("api/DodatniSastojci/SelectTop")]
        public List<myPizza_DodatniSastojciTop_Result> SelectTop()
        {
            return db.myPizza_DodatniSastojciTop().ToList();
        }

        // PUT: api/DodatniSastojci/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDodatniSastojci(int id, DodatniSastojci dodatniSastojci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dodatniSastojci.DodatniSastojakId)
            {
                return BadRequest();
            }

            db.Entry(dodatniSastojci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DodatniSastojciExists(id))
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

        // POST: api/DodatniSastojci
        [ResponseType(typeof(DodatniSastojci))]
        public IHttpActionResult PostDodatniSastojci(DodatniSastojci dodatniSastojci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.myPizza_DodatniSastojci_Insert(dodatniSastojci.NarudzbaPizzaId, dodatniSastojci.SastojakId);

            return CreatedAtRoute("DefaultApi", new { id = dodatniSastojci.DodatniSastojakId }, dodatniSastojci);
        }

        // DELETE: api/DodatniSastojci/5
        [ResponseType(typeof(DodatniSastojci))]
        public IHttpActionResult DeleteDodatniSastojci(int id)
        {
            DodatniSastojci dodatniSastojci = db.DodatniSastojci.Find(id);
            if (dodatniSastojci == null)
            {
                return NotFound();
            }

            db.DodatniSastojci.Remove(dodatniSastojci);
            db.SaveChanges();

            return Ok(dodatniSastojci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DodatniSastojciExists(int id)
        {
            return db.DodatniSastojci.Count(e => e.DodatniSastojakId == id) > 0;
        }
    }
}