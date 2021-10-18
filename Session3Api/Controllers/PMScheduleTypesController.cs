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
    public class PMScheduleTypesController : ApiController
    {
        private KazanNeftSession3DBEntities db = new KazanNeftSession3DBEntities();

        // GET: api/PMScheduleTypes
        [ResponseType(typeof(List<PMScheduleTypes>))]
        public IHttpActionResult GetPMScheduleTypes()
        {
            return Ok(db.PMScheduleTypes);
        }

        // GET: api/PMScheduleTypes/5
        [ResponseType(typeof(PMScheduleTypes))]
        public IHttpActionResult GetPMScheduleTypes(long id)
        {
            PMScheduleTypes pMScheduleTypes = db.PMScheduleTypes.Find(id);
            if (pMScheduleTypes == null)
            {
                return NotFound();
            }

            return Ok(pMScheduleTypes);
        }
    }
}