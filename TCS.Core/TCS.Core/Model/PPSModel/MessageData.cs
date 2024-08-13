using System;

namespace TCS.Core.Model.PPSModel
{
    public class MessageData : ICloneable
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public string MessageType { get; set; } = string.Empty;
        /// <summary>
        /// IGRT的数据来源(DR/CBCT)
        /// </summary>
        public string DataSource { get; set; } = string.Empty;

        /// <summary>
        /// SessionID（唯一标识32位：GUID）
        /// </summary>
        public string SessionID { get; set; } = string.Empty;

        /// <summary>
        /// 患者ID
        /// </summary>
        public string PatientID { get; set; } = string.Empty;

        /// <summary>
        /// 患者姓名
        /// </summary>
        public string PatientName { get; set; } = string.Empty;

        /// <summary>
        /// 治疗计划名
        /// </summary>
        public string PlanName { get; set; } = string.Empty;

        /// <summary>
        /// 计划唯一标识(SOP Instance ID)
        /// </summary>
        public string RTPlanUID { get; set; } = string.Empty;

        /// <summary>
        /// 计划角度
        /// </summary>
        public string YawDegree { get; set; } = string.Empty;

        /// <summary>
        /// 分次（每个Session，从1开始）
        /// </summary>
        public string FractionID { get; set; } = string.Empty;

        // -------------- opcua节点中添加标识 Add by mhy 2023.6.20 Start ------------------
        /// <summary>
        /// 坐标系标识
        /// </summary>
        public string Coordinate { get; set; } = "GB/T18987";
        // -------------- opcua节点中添加标识 Add by mhy 2023.6.20 End ------------------

        /// <summary>
        /// 治疗床X
        /// </summary>
        public double Couch_x { get; set; } = 0d;

        /// <summary>
        /// 治疗床Y
        /// </summary>
        public double Couch_y { get; set; } = 0d;

        /// <summary>
        /// 治疗床Z
        /// </summary>
        public double Couch_z { get; set; } = 0d;

        /// <summary>
        /// 治疗床绕X轴角度
        /// </summary>
        public double Couch_Pitch { get; set; } = 0d;

        /// <summary>
        /// 治疗床绕Y轴角度
        /// </summary>
        public double Couch_Yaw { get; set; } = 0d;

        /// <summary>
        /// 治疗床绕Z轴角度
        /// </summary>
        public double Couch_Roll { get; set; } = 0d;

        /// <summary>
        /// 摆位验证报告名
        /// </summary>
        public string ImgName { get; set; } = string.Empty;

        public object Clone()
        {
            //throw new NotImplementedException();
            return this.MemberwiseClone();
        }

        /// <summary>
        /// 清除治疗床的数据（归零）
        /// </summary>
        public void ClearCouchData()
		{
            Couch_x = 0.0;
            Couch_y = 0.0;
            Couch_z = 0.0;
            Couch_Pitch = 0.0;
            Couch_Roll = 0.0;
            Couch_Yaw = 0.0;
		}
    }

    public class ErrorInfoData
    {
        /// <summary>
        /// 错误码
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        public string Message { get; set; }
    }
}
