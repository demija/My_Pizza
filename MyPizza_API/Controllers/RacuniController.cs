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
    public class RacuniController : ApiController
    {
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/Racuni
        public IQueryable<Racuni> GetRacuni()
        {
            return db.Racuni;
        }

        // GET: api/Racuni/5
        [ResponseType(typeof(Racuni))]
        public IHttpActionResult GetRacuni(int id)
        {
            Racuni racuni = db.Racuni.Find(id);
            if (racuni == null)
            {
                return NotFound();
            }

            return Ok(racuni);
        }

        // PUT: api/Racuni/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRacuni(int id, Racuni racuni)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != racuni.RacunId)
            {
                return BadRequest();
            }

            db.Entry(racuni).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RacuniExists(id))
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

        // POST: api/Racuni
        [ResponseType(typeof(Racuni))]
        public IHttpActionResult PostRacuni(Racuni racuni)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.myPizza_Racun_Insert(racuni.Datum, racuni.NarudzbaId, racuni.KorisnikId, racuni.CijenaSaPDV, racuni.CijenaBezPDV);

            //db.Racuni.Add(racuni);
            //db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = racuni.RacunId }, racuni);
        }

        // DELETE: api/Racuni/5
        [ResponseType(typeof(Racuni))]
        public IHttpActionResult DeleteRacuni(int id)
        {
            Racuni racuni = db.Racuni.Find(id);
            if (racuni == null)
            {
                return NotFound();
            }

            db.Racuni.Remove(racuni);
            db.SaveChanges();

            return Ok(racuni);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RacuniExists(int id)
        {
            return db.Racuni.Count(e => e.RacunId == id) > 0;
        }
    }
}