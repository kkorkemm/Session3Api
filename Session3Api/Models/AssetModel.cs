using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session3Api.Models
{
    using Base;

    public class AssetModel
    {
        public AssetModel(Assets assets)
        {
            ID = assets.ID;
            AssetSN = assets.AssetSN;
            AssetName = assets.AssetName;
        }

        public long ID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
    }
}