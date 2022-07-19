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
    public class registroVendasController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/registroVendas
        public IQueryable<registroVendas> GetregistroVendas()
        {
            return db.registroVendas;
        }

        // GET: api/registroVendas/5
        [ResponseType(typeof(registroVendas))]
        public IHttpActionResult GetregistroVendas(int id)
        {
            registroVendas registroVendas = db.registroVendas.Find(id);
            if (registroVendas == null)
            {
                return NotFound();
            }

            return Ok(registroVendas);
        }

        // PUT: api/registroVendas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutregistroVendas(int id, registroVendas registroVendas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != registroVendas.id)
            {
                return BadRequest();
            }

            db.Entry(registroVendas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!registroVendasExists(id))
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

        // POST: api/registroVendas
        [ResponseType(typeof(registroVendas))]
        public IHttpActionResult PostregistroVendas(registroVendas registroVendas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.registroVendas.Add(registroVendas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = registroVendas.id }, registroVendas);
        }

        // DELETE: api/registroVendas/5
        [ResponseType(typeof(registroVendas))]
        public IHttpActionResult DeleteregistroVendas(int id)
        {
            registroVendas registroVendas = db.registroVendas.Find(id);
            if (registroVendas == null)
            {
                return NotFound();
            }

            db.registroVendas.Remove(registroVendas);
            db.SaveChanges();

            return Ok(registroVendas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool registroVendasExists(int id)
        {
            return db.registroVendas.Count(e => e.id == id) > 0;
        }
    }
}