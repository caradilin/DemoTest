using System.Collections.Generic;

namespace TCS.Core.Model
{
    /// <summary>
    /// 治疗头信息相关
    /// </summary>
    public class RoomInfoModel
    {
        /// <summary>
        /// 治疗头名称
        /// </summary>
        public string HeadName { get; set; }

        /// <summary>
        /// 治疗头编号
        /// </summary>
        public int HeadNum { get; set; }

        /// <summary>
        /// 房间号
        /// </summary>
        public string RoomId { get; set; }

        /// <summary>
        /// 房间OpcUa Id
        /// </summary>
        public string RoomOpcId { get; set; }
        /// <summary>
        /// 治疗头id
        /// </summary>
        /// 
        public string[] HeadId { get; set; }

        /// <summary>
        /// 扫描模式
        /// </summary>
        public BeamScanStatus BeamScanStatus { get; set; }

        /// <summary>
        /// 运维模式-设备配置-治疗床左右头射野范围编辑是否可用
        /// </summary>
        public List<string> BeamTypes { get; set; }
    }
}