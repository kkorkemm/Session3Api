namespace Session3Api.Base
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class PMTasks
    {
        public long ID { get; set; }
        public long AssetID { get; set; }
        public long TaskID { get; set; }
        public long PMScheduleTypeID { get; set; }
        public Nullable<System.DateTime> ScheduleDate { get; set; }
        public Nullable<long> ScheduleKilometer { get; set; }
        public Nullable<bool> TaskDone { get; set; }

        [JsonIgnore]
        public virtual Assets Assets { get; set; }
        [JsonIgnore]
        public virtual PMScheduleTypes PMScheduleTypes { get; set; }
        [JsonIgnore]
        public virtual Tasks Tasks { get; set; }
    }
}
