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
    public class PMScheduleModelsController : ApiController
    {
        private KazanNeftSession3DBEntities db = new KazanNeftSession3DBEntities();

        // GET: api/PMScheduleModels
        public IQueryable<PMScheduleModels> GetPMScheduleModels()
        {
            return db.PMScheduleModels;
        }

        // GET: api/PMScheduleModels/5
        [ResponseType(typeof(PMScheduleModels))]
        public IHttpActionResult GetPMScheduleModels(long id)
        {
            PMScheduleModels pMScheduleModels = db.PMScheduleModels.Find(id);
            if (pMScheduleModels == null)
            {
                return NotFound();
            }

            return Ok(pMScheduleModels);
        }
    }
}