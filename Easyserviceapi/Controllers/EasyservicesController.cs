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
using Easyserviceapi.Models;

namespace Easyserviceapi.Controllers
{
    public class EasyservicesController : ApiController
    {
        private EasyserviceapiContext db = new EasyserviceapiContext();

        // GET: api/Easyservices
        public IQueryable<Easyservice> GetEasyservices()
        {
            return db.Easyservices;
        }

        // GET: api/Easyservices/5
        [ResponseType(typeof(Easyservice))]
        public IHttpActionResult GetEasyservice(int id)
        {
            Easyservice easyservice = db.Easyservices.Find(id);
            if (easyservice == null)
            {
                return NotFound();
            }

            return Ok(easyservice);
        }

        // PUT: api/Easyservices/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEasyservice(int id, Easyservice easyservice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != easyservice.Id)
            {
                return BadRequest();
            }

            db.Entry(easyservice).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EasyserviceExists(id))
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

        // POST: api/Easyservices
        [ResponseType(typeof(Easyservice))]
        public IHttpActionResult PostEasyservice(Easyservice easyservice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Easyservices.Add(easyservice);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = easyservice.Id }, easyservice);
        }

        // DELETE: api/Easyservices/5
        [ResponseType(typeof(Easyservice))]
        public IHttpActionResult DeleteEasyservice(int id)
        {
            Easyservice easyservice = db.Easyservices.Find(id);
            if (easyservice == null)
            {
                return NotFound();
            }

            db.Easyservices.Remove(easyservice);
            db.SaveChanges();

            return Ok(easyservice);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EasyserviceExists(int id)
        {
            return db.Easyservices.Count(e => e.Id == id) > 0;
        }
    }
}