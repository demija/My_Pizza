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
using MyPizza_API.Util;
using System.Data.Entity.Core;

namespace MyPizza_API.Controllers
{
    public class VrstePizzaController : ApiController
    {
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/VrstePizza
        public IQueryable<VrstePizza> GetVrstePizza()
        {
            return db.VrstePizza;
        }

        [HttpGet]
        [Route("api/VrstePizza/AktivnePizze")]
        public List<VrstePizza> AktivnePizze()
        {
            return db.myPizza_GetAktivnePizze().ToList();
        }

        [HttpGet]
        [Route("api/VrstePizza/VelPizze/{vrstaPizzeId}")]
        public List<myPizza_GetVelPizza_Result> VelPizze(int vrstaPizzeId)
        {
            return db.myPizza_GetVelPizza(vrstaPizzeId).ToList();
        }

        /*
        [HttpGet]
        [Route("api/VrstePizza/RecommendProduct/{vrstaPizzeId}")]
        public List<VrstePizza> RecommendProduct(int vrstaPizzeId)
        {
            Recommender r = new Recommender();
            return r.GetSlicneProizvode(vrstaPizzeId);
        }
        */

        // GET: api/VrstePizza/5
        [ResponseType(typeof(VrstePizza))]
        public IHttpActionResult GetVrstePizza(int id)
        {
            VrstePizza vrstePizza = db.VrstePizza.Find(id);
            if (vrstePizza == null)
            {
                return NotFound();
            }

            return Ok(vrstePizza);
        }

        // PUT: api/VrstePizza/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVrstePizza(int id, VrstePizza vrstePizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vrstePizza.VrstaPizzeId)
            {
                return BadRequest();
            }

            db.Entry(vrstePizza).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VrstePizzaExists(id))
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

        // POST: api/VrstePizza
        [ResponseType(typeof(VrstePizza))]
        [ExceptionFilter]
        public IHttpActionResult PostVrstePizza(VrstePizza vrstePizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                vrstePizza.VrstaPizzeId = Convert.ToInt32(db.myPizza_VrstePizza_Insert(vrstePizza.Vrsta, vrstePizza.Opis, vrstePizza.DatumDodavanja, vrstePizza.DatumIzmjene, vrstePizza.Slika, vrstePizza.SlikaThumb).FirstOrDefault());
            }
            catch (EntityException ex)
            {
                throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }

            foreach (Sastojci s in vrstePizza.Sastojak)
            {
                db.myPizza_VrsteSastojci_Insert(vrstePizza.VrstaPizzeId, s.SastojakId);
            }

            return CreatedAtRoute("DefaultApi", new { id = vrstePizza.VrstaPizzeId }, vrstePizza);
        }

        private HttpResponseException CreateHttpResponseException(string reason, HttpStatusCode statusCode)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                StatusCode = statusCode,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };

            return new HttpResponseException(msg);
        }

        // DELETE: api/VrstePizza/5
        [ResponseType(typeof(VrstePizza))]
        public IHttpActionResult DeleteVrstePizza(int id)
        {
            VrstePizza vrstePizza = db.VrstePizza.Find(id);
            if (vrstePizza == null)
            {
                return NotFound();
            }

            db.VrstePizza.Remove(vrstePizza);
            db.SaveChanges();

            return Ok(vrstePizza);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VrstePizzaExists(int id)
        {
            return db.VrstePizza.Count(e => e.VrstaPizzeId == id) > 0;
        }
    }
}