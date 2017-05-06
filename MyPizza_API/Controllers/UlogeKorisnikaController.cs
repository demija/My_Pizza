using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MyPizza_API.Models;

namespace MyPizza_API.Controllers
{
    public class UlogeKorisnikaController : ApiController
    {
        //private MyPizzaEntities db = new MyPizzaEntities();
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/UlogeKorisnika
        public IQueryable<UlogeKorisnika> GetUlogeKorisnika()
        {
            return db.UlogeKorisnika;
        }

        // GET: api/UlogeKorisnika/5
        [ResponseType(typeof(UlogeKorisnika))]
        public IHttpActionResult GetUlogeKorisnika(int id)
        {
            UlogeKorisnika ulogeKorisnika = db.UlogeKorisnika.Find(id);
            if (ulogeKorisnika == null)
            {
                return NotFound();
            }

            return Ok(ulogeKorisnika);
        }

        // PUT: api/UlogeKorisnika/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUlogeKorisnika(int id, UlogeKorisnika ulogeKorisnika)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ulogeKorisnika.UlogaKorisnikaId)
            {
                return BadRequest();
            }

            db.Entry(ulogeKorisnika).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UlogeKorisnikaExists(id))
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

        // POST: api/UlogeKorisnika
        [ResponseType(typeof(UlogeKorisnika))]
        public IHttpActionResult PostUlogeKorisnika(UlogeKorisnika ulogeKorisnika)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UlogeKorisnika.Add(ulogeKorisnika);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ulogeKorisnika.UlogaKorisnikaId }, ulogeKorisnika);
        }

        // DELETE: api/UlogeKorisnika/5
        [ResponseType(typeof(UlogeKorisnika))]
        public IHttpActionResult DeleteUlogeKorisnika(int id)
        {
            UlogeKorisnika ulogeKorisnika = db.UlogeKorisnika.Find(id);
            if (ulogeKorisnika == null)
            {
                return NotFound();
            }

            db.UlogeKorisnika.Remove(ulogeKorisnika);
            db.SaveChanges();

            return Ok(ulogeKorisnika);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UlogeKorisnikaExists(int id)
        {
            return db.UlogeKorisnika.Count(e => e.UlogaKorisnikaId == id) > 0;
        }
    }
}