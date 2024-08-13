namespace TCS.Core.TCSTableModel
{
    /// <summary>
    ///     表PPSMenuGroup对应的数据类
    /// </summary>
    public class PPSMenuGroupData
    {
        /// <summary>
        ///     菜单组ID
        /// </summary>
        public string GroupID { get; set; }

        /// <summary>
        ///     区域（LZ：兰州; WW:武威)
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        ///     治疗室（G1-G4: 1号-4号）
        /// </summary>
        public string RoomID { get; set; }

        /// <summary>
        ///     菜单组类型（FFB: 首次首射野；SFB:非首次；BSS:同位射野切换；BSD:异位射野切换）
        /// </summary>
        public string GroupType { get; set; }

        /// <summary>
        ///     菜单名
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        ///     描述
        /// </summary>
        public string GroupTypeDescription { get; set; }
    }
}