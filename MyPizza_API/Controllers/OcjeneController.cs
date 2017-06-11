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
    public class OcjeneController : ApiController
    {
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/Ocjene
        public IQueryable<Ocjene> GetOcjene()
        {
            return db.Ocjene;
        }

        // GET: api/Ocjene/5
        [ResponseType(typeof(Ocjene))]
        public IHttpActionResult GetOcjene(int id)
        {
            Ocjene ocjene = db.Ocjene.Find(id);
            if (ocjene == null)
            {
                return NotFound();
            }

            return Ok(ocjene);
        }

        [HttpGet]
        [Route("api/Ocjene/OcjeneVrsta/{vrstaPizzeId}")]
        public List<myPizza_GetOcjeneForVrsta_Result> OcjeneVrsta(int vrstaPizzeId)
        {
            return db.myPizza_GetOcjeneForVrsta(vrstaPizzeId).ToList();
        }

        // PUT: api/Ocjene/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOcjene(int id, Ocjene ocjene)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ocjene.OcjenaId)
            {
                return BadRequest();
            }

            db.Entry(ocjene).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OcjeneExists(id))
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

        // POST: api/Ocjene
        [ResponseType(typeof(Ocjene))]
        public IHttpActionResult PostOcjene(Ocjene ocjene)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.myPizza_Ocjene_LikeDislike(ocjene.VrstaPizzeId, ocjene.KorisnikId, ocjene.DatumOcjene, ocjene.SvidjaSe, ocjene.NeSvidjaSe);

            //db.Ocjene.Add(ocjene);
            //db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ocjene.OcjenaId }, ocjene);
        }

        // DELETE: api/Ocjene/5
        [ResponseType(typeof(Ocjene))]
        public IHttpActionResult DeleteOcjene(int id)
        {
            Ocjene ocjene = db.Ocjene.Find(id);
            if (ocjene == null)
            {
                return NotFound();
            }

            db.Ocjene.Remove(ocjene);
            db.SaveChanges();

            return Ok(ocjene);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OcjeneExists(int id)
        {
            return db.Ocjene.Count(e => e.OcjenaId == id) > 0;
        }
    }
}