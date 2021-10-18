namespace Session3Api.Base
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class PMScheduleModels
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public Nullable<long> PMScheduleTypeID { get; set; }

        [JsonIgnore]
        public virtual PMScheduleTypes PMScheduleTypes { get; set; }
    }
}
