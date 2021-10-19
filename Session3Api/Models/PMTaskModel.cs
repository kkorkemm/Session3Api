using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session3Api.Models
{
    using Base;

    public class PMTaskModel
    {
        public PMTaskModel(PMTasks tasks)
        {
            ID = tasks.ID;
            AssetID = tasks.AssetID;
            TaskID = tasks.TaskID;
            PMScheduleTypeID = tasks.PMScheduleTypeID;
            ScheduleDate = tasks.ScheduleDate;
            ScheduleKilometer = tasks.ScheduleKilometer;
            TaskDone = tasks.TaskDone;

            AssetName = tasks.Assets.AssetName;
            AssetSN = tasks.Assets.AssetSN;
            TaskName = tasks.Tasks.Name;
            TypeName = tasks.PMScheduleTypes.Name;

            var model = tasks.PMScheduleTypes.PMScheduleModels.FirstOrDefault();
            ModelName = AppData.GetContext().PMScheduleModels.Where(p => p.ID == model.ID).FirstOrDefault().Name;
        }

        public long ID { get; set; }
        public long AssetID { get; set; }
        public long TaskID { get; set; }
        public long PMScheduleTypeID { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public long? ScheduleKilometer { get; set; }
        public bool? TaskDone { get; set; }

        public string AssetName { get; set; }
        public string AssetSN { get; set; }
        public string TaskName { get; set; }
        public string TypeName { get; set; }
        public string ModelName { get; set; }

    }
}