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
    public class VelicinePizzaController : ApiController
    {
        private MyPizzaEntities db = new MyPizzaEntities();

        // GET: api/VelicinePizza
        public IQueryable<VelicinePizza> GetVelicinePizza()
        {
            return db.VelicinePizza;
        }

        // GET: api/VelicinePizza/5
        [ResponseType(typeof(VelicinePizza))]
        public IHttpActionResult GetVelicinePizza(int id)
        {
            VelicinePizza velicinePizza = db.VelicinePizza.Find(id);
            if (velicinePizza == null)
            {
                return NotFound();
            }

            return Ok(velicinePizza);
        }

        // PUT: api/VelicinePizza/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVelicinePizza(int id, VelicinePizza velicinePizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != velicinePizza.VelicinaPizzeId)
            {
                return BadRequest();
            }

            db.Entry(velicinePizza).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VelicinePizzaExists(id))
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

        // POST: api/VelicinePizza
        [ResponseType(typeof(VelicinePizza))]
        public IHttpActionResult PostVelicinePizza(VelicinePizza velicinePizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VelicinePizza.Add(velicinePizza);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = velicinePizza.VelicinaPizzeId }, velicinePizza);
        }

        // DELETE: api/VelicinePizza/5
        [ResponseType(typeof(VelicinePizza))]
        public IHttpActionResult DeleteVelicinePizza(int id)
        {
            VelicinePizza velicinePizza = db.VelicinePizza.Find(id);
            if (velicinePizza == null)
            {
                return NotFound();
            }

            db.VelicinePizza.Remove(velicinePizza);
            db.SaveChanges();

            return Ok(velicinePizza);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VelicinePizzaExists(int id)
        {
            return db.VelicinePizza.Count(e => e.VelicinaPizzeId == id) > 0;
        }
    }
}