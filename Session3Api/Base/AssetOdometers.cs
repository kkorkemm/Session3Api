namespace Session3Api.Base
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class AssetOdometers
    {
        public long ID { get; set; }
        public long AssetID { get; set; }
        public System.DateTime ReadDate { get; set; }
        public long OdometerAmount { get; set; }

        [JsonIgnore]
        public virtual Assets Assets { get; set; }
    }
}
