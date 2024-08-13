using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.Model.OISTableModel
{
    public class OISTreatmentSchedule
    {


        /// <summary>
        /// 排程ID
        /// </summary>
        public string ScheduleID { get; set; }

        /// <summary>
        /// 治疗计划ID
        /// </summary>
        public string TreatmentPlanID { get; set; }

        /// <summary>
        /// 计划开始时间
        /// </summary>
        public DateTime PlanStartDatetime { get; set; }

        /// <summary>
        /// 计划结束时间
        /// </summary>
        public DateTime PlanFinishDatetime { get; set; }

        /// <summary>
        /// 实际开始时间
        /// </summary>
        public DateTime ActualStartDatetime { get; set; }

        /// <summary>
        /// 实际结束时间
        /// </summary>
        public DateTime ActualFinishDatetime { get; set; }

        /// <summary>
        /// 本次排程执行结果
        /// </summary>
        public string ScheduleResults { get; set; }

        /// <summary>
        /// 创建日
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 更新日
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}
