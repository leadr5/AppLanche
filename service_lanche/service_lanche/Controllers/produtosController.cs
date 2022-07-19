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
    public class produtosController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/produtos
        public IQueryable<produtos> Getprodutos()
        {
            return db.produtos;
        }

        // GET: api/produtos/5
        [ResponseType(typeof(produtos))]
        public IHttpActionResult Getprodutos(int id)
        {
            produtos produtos = db.produtos.Find(id);
            if (produtos == null)
            {
                return NotFound();
            }

            return Ok(produtos);
        }

        // PUT: api/produtos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putprodutos(int id, produtos produtos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != produtos.id)
            {
                return BadRequest();
            }

            db.Entry(produtos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!produtosExists(id))
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

        // POST: api/produtos
        [ResponseType(typeof(produtos))]
        public IHttpActionResult Postprodutos(produtos produtos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.produtos.Add(produtos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = produtos.id }, produtos);
        }

        // DELETE: api/produtos/5
        [ResponseType(typeof(produtos))]
        public IHttpActionResult Deleteprodutos(int id)
        {
            produtos produtos = db.produtos.Find(id);
            if (produtos == null)
            {
                return NotFound();
            }

            db.produtos.Remove(produtos);
            db.SaveChanges();

            return Ok(produtos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool produtosExists(int id)
        {
            return db.produtos.Count(e => e.id == id) > 0;
        }
    }
}