using System;

namespace TCS.Core.TCSTableModel
{
    /// <summary>
    ///     IGRT位置信息表
    /// </summary>
    public class IGRTTreatmentPosition
    {
        /// <summary>
        ///     治疗计划ID
        /// </summary>
        public string TreatmentPlanID { get; set; }

        /// <summary>
        ///     射野ID
        /// </summary>
        public string BeamID { get; set; }

        /// <summary>
        ///     治疗位置数据(Json）
        /// </summary>
        public string TreatmentPosition { get; set; }

        /// <summary>
        ///     IGRT设备信息（电源电流等)
        /// </summary>
        public string IGRTDeviceInfo { get; set; }

        /// <summary>
        ///     IGRT设备信息（电源电流等)
        /// </summary>
        public string DystopyDR { get; set; }

        /// <summary>
        ///     有效性
        /// </summary>
        public string Validity { get; set; }

        /// <summary>
        ///     插入数据的登录用户ID
        /// </summary>
        public string CreateOperator { get; set; }

        /// <summary>
        ///     创建日时(插入数据的日时）
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///     更新数据的登录用户ID
        /// </summary>
        public string UpdateOperator { get; set; }

        /// <summary>
        ///     更新日时(设置有效性=无效的日时）
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        ///     治疗部位
        /// </summary>
        public string SelectedBodyParts { get; set; }
    }
}