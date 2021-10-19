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
    public class AssetOdometersController : ApiController
    {
        private KazanNeftSession3DBEntities db = new KazanNeftSession3DBEntities();

        // GET: api/AssetOdometers
        [ResponseType(typeof(List<AssetOdometers>))]
        public IHttpActionResult GetAssetOdometers()
        {
            return Ok(db.AssetOdometers);
        }

        // GET: api/AssetOdometers/5
        [ResponseType(typeof(AssetOdometers))]
        public IHttpActionResult GetAssetOdometers(long id)
        {
            AssetOdometers assetOdometers = db.AssetOdometers.Find(id);
            if (assetOdometers == null)
            {
                return NotFound();
            }

            return Ok(assetOdometers);
        }
    }
}