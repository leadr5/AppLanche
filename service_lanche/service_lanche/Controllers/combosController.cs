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
using service_lanche.Models;

namespace service_lanche.Controllers
{
    public class combosController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/combos
        public IQueryable<combos> Getcombos()
        {
            return db.combos;
        }

        // GET: api/combos/5
        [ResponseType(typeof(combos))]
        public IHttpActionResult Getcombos(int id)
        {
            combos combos = db.combos.Find(id);
            if (combos == null)
            {
                return NotFound();
            }

            return Ok(combos);
        }

        // PUT: api/combos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putcombos(int id, combos combos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != combos.id)
            {
                return BadRequest();
            }

            db.Entry(combos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!combosExists(id))
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

        // POST: api/combos
        [ResponseType(typeof(combos))]
        public IHttpActionResult Postcombos(combos combos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.combos.Add(combos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = combos.id }, combos);
        }

        // DELETE: api/combos/5
        [ResponseType(typeof(combos))]
        public IHttpActionResult Deletecombos(int id)
        {
            combos combos = db.combos.Find(id);
            if (combos == null)
            {
                return NotFound();
            }

            db.combos.Remove(combos);
            db.SaveChanges();

            return Ok(combos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool combosExists(int id)
        {
            return db.combos.Count(e => e.id == id) > 0;
        }
    }
}