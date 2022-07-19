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
    public class adicionalsController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/adicionals
        public IQueryable<adicional> Getadicional()
        {
            return db.adicional;
        }

        // GET: api/adicionals/5
        [ResponseType(typeof(adicional))]
        public IHttpActionResult Getadicional(int id)
        {
            adicional adicional = db.adicional.Find(id);
            if (adicional == null)
            {
                return NotFound();
            }

            return Ok(adicional);
        }

        // PUT: api/adicionals/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putadicional(int id, adicional adicional)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != adicional.id)
            {
                return BadRequest();
            }

            db.Entry(adicional).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!adicionalExists(id))
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

        // POST: api/adicionals
        [ResponseType(typeof(adicional))]
        public IHttpActionResult Postadicional(adicional adicional)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.adicional.Add(adicional);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = adicional.id }, adicional);
        }

        // DELETE: api/adicionals/5
        [ResponseType(typeof(adicional))]
        public IHttpActionResult Deleteadicional(int id)
        {
            adicional adicional = db.adicional.Find(id);
            if (adicional == null)
            {
                return NotFound();
            }

            db.adicional.Remove(adicional);
            db.SaveChanges();

            return Ok(adicional);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool adicionalExists(int id)
        {
            return db.adicional.Count(e => e.id == id) > 0;
        }
    }
}