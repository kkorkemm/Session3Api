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
    public class TasksController : ApiController
    {
        private KazanNeftSession3DBEntities db = new KazanNeftSession3DBEntities();

        // GET: api/Tasks
        [ResponseType(typeof(List<Tasks>))]
        public IHttpActionResult GetTasks()
        {
            return Ok(db.Tasks);
        }

        // GET: api/Tasks/5
        [ResponseType(typeof(Tasks))]
        public IHttpActionResult GetTasks(long id)
        {
            Tasks tasks = db.Tasks.Find(id);
            if (tasks == null)
            {
                return NotFound();
            }

            return Ok(tasks);
        }
    }
}