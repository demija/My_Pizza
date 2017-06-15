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
    public class KorisniciController : ApiController
    {
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/Korisnici
        public IQueryable<Korisnici> GetKorisnici()
        {
            return db.Korisnici;
        }

        [HttpGet]
        [Route("api/Korisnici/SearchKorisnici/{name?}")]
        public List<myPizza_Korisnici_SelectByImePrezime_Result> SearchKorisnici(string name = "")
        {
            return db.myPizza_Korisnici_SelectByImePrezime(name).ToList();
        }

        // GET: api/Korisnici/5
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult GetKorisnici(int id)
        {
            Korisnici korisnici = db.Korisnici.Find(id);
            if (korisnici == null)
            {
                return NotFound();
            }

            return Ok(korisnici);
        }

        [ResponseType(typeof(Korisnici))]
        [Route("api/Korisnici/{username}")]
        public IHttpActionResult GetKorisnici(string username)
        {
            Korisnici korisnik = db.Korisnici.Where(x => x.KorisnickoIme == username).FirstOrDefault();
            if (korisnik == null)
            {
                return NotFound();
            }

            return Ok(korisnik);
        }

        // PUT: api/Korisnici/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnici(int id, Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != korisnici.KorisnikId)
            {
                return BadRequest();
            }

            db.Entry(korisnici).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisniciExists(id))
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

        // POST: api/Korisnici
        [ResponseType(typeof(Korisnici))]
        [ExceptionFilter]
        public IHttpActionResult PostKorisnici(Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                korisnici.KorisnikId = Convert.ToInt32(db.myPizza_Korisnici_Insert(korisnici.Ime, korisnici.Prezime, korisnici.KorisnickoIme, korisnici.LozinkaHash, korisnici.LozinkaSalt,
                        korisnici.Email, korisnici.BrojTelefona, korisnici.DatumRegistracije, korisnici.StatusKorisnikaId, korisnici.GradId, korisnici.Ulica).FirstOrDefault());
            }
            catch (EntityException ex)
            {
                throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }

            if (korisnici.Uloge != null)
            {
                foreach (UlogeKorisnika u in korisnici.Uloge)
                {
                    db.myPizza_KorisnickeUloge_Insert(korisnici.KorisnikId, u.UlogaKorisnikaId, DateTime.Now);
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = korisnici.KorisnikId }, korisnici);
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

        // DELETE: api/Korisnici/5
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult DeleteKorisnici(int id)
        {
            Korisnici korisnici = db.Korisnici.Find(id);
            if (korisnici == null)
            {
                return NotFound();
            }

            db.Korisnici.Remove(korisnici);
            db.SaveChanges();

            return Ok(korisnici);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KorisniciExists(int id)
        {
            return db.Korisnici.Count(e => e.KorisnikId == id) > 0;
        }
    }
}