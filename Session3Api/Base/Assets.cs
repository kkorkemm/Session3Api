namespace Session3Api.Base
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    
    public partial class Assets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Assets()
        {
            this.AssetOdometers = new HashSet<AssetOdometers>();
            this.PMTasks = new HashSet<PMTasks>();
        }
    
        public long ID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public long DepartmentLocationID { get; set; }
        public long EmployeeID { get; set; }
        public long AssetGroupID { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> WarrantyDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<AssetOdometers> AssetOdometers { get; set; }
        [JsonIgnore]
        public virtual ICollection<PMTasks> PMTasks { get; set; }
    }
}
