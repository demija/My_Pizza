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
using System.Data.Entity.Core;
using MyPizza_API.Util;

namespace MyPizza_API.Controllers
{
    public class NarudzbePizzeController : ApiController
    {
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/NarudzbePizze
        public IQueryable<NarudzbePizze> GetNarudzbePizze()
        {
            return db.NarudzbePizze;
        }

        // GET: api/NarudzbePizze/5
        [ResponseType(typeof(NarudzbePizze))]
        public IHttpActionResult GetNarudzbePizze(int id)
        {
            NarudzbePizze narudzbePizze = db.NarudzbePizze.Find(id);
            if (narudzbePizze == null)
            {
                return NotFound();
            }

            return Ok(narudzbePizze);
        }

        // PUT: api/NarudzbePizze/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNarudzbePizze(int id, NarudzbePizze narudzbePizze)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != narudzbePizze.NarudzbaPizzaId)
            {
                return BadRequest();
            }

            db.Entry(narudzbePizze).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NarudzbePizzeExists(id))
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

        // POST: api/NarudzbePizze
        [ResponseType(typeof(NarudzbePizze))]
        [ExceptionFilter]
        public IHttpActionResult PostNarudzbePizze(NarudzbePizze narudzbePizze)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                narudzbePizze.NarudzbaPizzaId = Convert.ToInt32(db.myPizza_NarudzbePizze_Insert(narudzbePizze.NarudzbaId, narudzbePizze.PizzaId, narudzbePizze.Kolicina, narudzbePizze.Cijena).FirstOrDefault());
            }
            catch (EntityException ex)
            {
                //throw new NotImplementedException();
                throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }

            //db.NarudzbePizze.Add(narudzbePizze);
            //db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = narudzbePizze.NarudzbaPizzaId }, narudzbePizze);
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

        // DELETE: api/NarudzbePizze/5
        [ResponseType(typeof(NarudzbePizze))]
        public IHttpActionResult DeleteNarudzbePizze(int id)
        {
            NarudzbePizze narudzbePizze = db.NarudzbePizze.Find(id);
            if (narudzbePizze == null)
            {
                return NotFound();
            }

            db.NarudzbePizze.Remove(narudzbePizze);
            db.SaveChanges();

            return Ok(narudzbePizze);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NarudzbePizzeExists(int id)
        {
            return db.NarudzbePizze.Count(e => e.NarudzbaPizzaId == id) > 0;
        }
    }
}