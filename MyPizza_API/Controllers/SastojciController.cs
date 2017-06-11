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
    public class SastojciController : ApiController
    {
        //private MyPizzaEntities db = new MyPizzaEntities();
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/Sastojci
        public IQueryable<Sastojci> GetSastojci()
        {
            return db.Sastojci;
        }

        // GET: api/Sastojci/5
        [ResponseType(typeof(Sastojci))]
        public IHttpActionResult GetSastojci(int id)
        {
            Sastojci sastojci = db.Sastojci.Find(id);
            if (sastojci == null)
            {
                return NotFound();
            }

            return Ok(sastojci);
        }

        [HttpGet]
        [Route("api/Sastojci/VrstaSastojci/{vrstaPizzeId}")]
        public List<Sastojci> VrstaSastojci(int vrstaPizzeId)
        {
            return db.myPizza_GetSastojciForVrsta(vrstaPizzeId).ToList();
        }

        // PUT: api/Sastojci/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSastojci(int id, Sastojci sastojci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sastojci.SastojakId)
            {
                return BadRequest();
            }

            db.Entry(sastojci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SastojciExists(id))
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

        // POST: api/Sastojci
        [ResponseType(typeof(Sastojci))]
        public IHttpActionResult PostSastojci(Sastojci sastojci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sastojci.Add(sastojci);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sastojci.SastojakId }, sastojci);
        }

        // DELETE: api/Sastojci/5
        [ResponseType(typeof(Sastojci))]
        public IHttpActionResult DeleteSastojci(int id)
        {
            Sastojci sastojci = db.Sastojci.Find(id);
            if (sastojci == null)
            {
                return NotFound();
            }

            db.Sastojci.Remove(sastojci);
            db.SaveChanges();

            return Ok(sastojci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SastojciExists(int id)
        {
            return db.Sastojci.Count(e => e.SastojakId == id) > 0;
        }
    }
}