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
using Session3Api.Base;

namespace Session3Api.Controllers
{
    using Models;

    public class PMTasksController : ApiController
    {
        private KazanNeftSession3DBEntities db = new KazanNeftSession3DBEntities();

        // GET: api/PMTasks
        [ResponseType(typeof(List<PMTasks>))]
        public IHttpActionResult GetPMTasks()
        {
            return Ok(db.PMTasks.ToList().ConvertAll(p => new PMTaskModel(p)));
        }

        // GET: api/PMTasks/5
        [ResponseType(typeof(PMTasks))]
        public IHttpActionResult GetPMTasks(long id)
        {
            PMTasks pMTasks = db.PMTasks.Find(id);
            if (pMTasks == null)
            {
                return NotFound();
            }

            return Ok(new PMTaskModel(pMTasks));
        }

        // PUT: api/PMTasks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPMTasks(long id, PMTasks pMTasks)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pMTasks.ID)
            {
                return BadRequest();
            }

            db.Entry(pMTasks).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PMTasksExists(id))
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

        // POST: api/PMTasks
        [ResponseType(typeof(PMTasks))]
        public IHttpActionResult PostPMTasks(PMTasks pMTasks)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PMTasks.Add(pMTasks);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pMTasks.ID }, pMTasks);
        }

        // DELETE: api/PMTasks/5
        [ResponseType(typeof(PMTasks))]
        public IHttpActionResult DeletePMTasks(long id)
        {
            PMTasks pMTasks = db.PMTasks.Find(id);
            if (pMTasks == null)
            {
                return NotFound();
            }

            db.PMTasks.Remove(pMTasks);
            db.SaveChanges();

            return Ok(pMTasks);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PMTasksExists(long id)
        {
            return db.PMTasks.Count(e => e.ID == id) > 0;
        }
    }
}