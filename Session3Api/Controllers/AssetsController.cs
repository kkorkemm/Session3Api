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

    public class AssetsController : ApiController
    {
        private KazanNeftSession3DBEntities db = new KazanNeftSession3DBEntities();

        // GET: api/Assets
        [ResponseType(typeof(List<Assets>))]
        public IHttpActionResult GetAssets()
        {
            return Ok(db.Assets.ToList().ConvertAll(p => new AssetModel(p)));
        }

        // GET: api/Assets/5
        [ResponseType(typeof(Assets))]
        public IHttpActionResult GetAssets(long id)
        {
            Assets assets = db.Assets.Find(id);
            if (assets == null)
            {
                return NotFound();
            }

            return Ok(new AssetModel(assets));
        }
    }
}