namespace Session3Api.Base
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class PMScheduleTypes
    {
        public PMScheduleTypes()
        {
            this.PMScheduleModels = new HashSet<PMScheduleModels>();
            this.PMTasks = new HashSet<PMTasks>();
        }
    
        public long ID { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<PMScheduleModels> PMScheduleModels { get; set; }

        [JsonIgnore]
        public virtual ICollection<PMTasks> PMTasks { get; set; }
    }
}
