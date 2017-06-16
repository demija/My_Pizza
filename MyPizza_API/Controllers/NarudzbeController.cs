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
    public class NarudzbeController : ApiController
    {
        private MyPizzaEntities1 db = new MyPizzaEntities1();

        // GET: api/Narudzbe
        public IQueryable<Narudzbe> GetNarudzbe()
        {
            return db.Narudzbe;
        }

        // GET: api/Narudzbe/5
        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult GetNarudzbe(int id)
        {
            Narudzbe narudzbe = db.Narudzbe.Find(id);
            if (narudzbe == null)
            {
                return NotFound();
            }

            return Ok(narudzbe);
        }

        [HttpGet]
        [Route("api/Narudzbe/GetBrojAktivnihNarudzbi")]
        public int GetBrojAktivnihNarudzbi()
        {
            return db.Narudzbe.Where(x => x.StatusNarudzbeId == 1).Count();
        }

        [HttpGet]
        [Route("api/Narudzbe/GetAktivneNarudzbe")]
        public List<myPizza_Narudzbe_SelectAktivne_Result> GetAktivneNarudzbe()
        {
            return db.myPizza_Narudzbe_SelectAktivne().ToList();
        }

        [HttpGet]
        [Route("api/Narudzbe/GetNarudzbeDetails/{id}")]
        public List<myPizza_Narudzbe_Details_Result> GetNarudzbeDetails(int id)
        {
            return db.myPizza_Narudzbe_Details(id).ToList();
        }

        [HttpGet]
        [Route("api/Narudzbe/UpdateNarudzbe/{id}")]
        public void UpdateNarudzbe(int id)
        {
            db.myPizza_NarudzbaUpdate(id);
        }

        // PUT: api/Narudzbe/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNarudzbe(int id, Narudzbe narudzbe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != narudzbe.NarudzbaId)
            {
                return BadRequest();
            }

            db.Entry(narudzbe).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NarudzbeExists(id))
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

        // POST: api/Narudzbe
        [ResponseType(typeof(Narudzbe))]
        [ExceptionFilter]
        public IHttpActionResult PostNarudzbe(Narudzbe narudzbe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                narudzbe.NarudzbaId = Convert.ToInt32(db.MyPizza_Narudzbe_Insert(narudzbe.KorisnikId, narudzbe.StatusNarudzbeId, narudzbe.DatumNarudzbe, narudzbe.OtkazanaNarudzba, narudzbe.AdresaZaDostavu, narudzbe.BrojTelefona).FirstOrDefault());
            }
            catch (EntityException ex)
            {
                throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }

            return CreatedAtRoute("DefaultApi", new { id = narudzbe.NarudzbaId }, narudzbe);
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

        // DELETE: api/Narudzbe/5
        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult DeleteNarudzbe(int id)
        {
            Narudzbe narudzbe = db.Narudzbe.Find(id);
            if (narudzbe == null)
            {
                return NotFound();
            }

            db.Narudzbe.Remove(narudzbe);
            db.SaveChanges();

            return Ok(narudzbe);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NarudzbeExists(int id)
        {
            return db.Narudzbe.Count(e => e.NarudzbaId == id) > 0;
        }
    }
}