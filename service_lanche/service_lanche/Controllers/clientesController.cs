﻿using System;
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
    public class clientesController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/clientes
        public IQueryable<clientes> Getclientes()
        {
            return db.clientes;
        }

        // GET: api/clientes/5
        [ResponseType(typeof(clientes))]
        public IHttpActionResult Getclientes(int id)
        {
            clientes clientes = db.clientes.Find(id);
            if (clientes == null)
            {
                return NotFound();
            }

            return Ok(clientes);
        }

        // PUT: api/clientes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putclientes(int id, clientes clientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clientes.id)
            {
                return BadRequest();
            }

            db.Entry(clientes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!clientesExists(id))
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

        // POST: api/clientes
        [ResponseType(typeof(clientes))]
        public IHttpActionResult Postclientes(clientes clientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.clientes.Add(clientes);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = clientes.id }, clientes);
        }

        // DELETE: api/clientes/5
        [ResponseType(typeof(clientes))]
        public IHttpActionResult Deleteclientes(int id)
        {
            clientes clientes = db.clientes.Find(id);
            if (clientes == null)
            {
                return NotFound();
            }

            db.clientes.Remove(clientes);
            db.SaveChanges();

            return Ok(clientes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool clientesExists(int id)
        {
            return db.clientes.Count(e => e.id == id) > 0;
        }
    }
}