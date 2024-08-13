namespace TCS.Core.TCSTableModel
{
    /// <summary>
    ///     表PPSMenuSet对应的数据类
    /// </summary>
    public class PPSMenuSet
    {
        ///// <summary>
        ///// 区域（LZ：兰州; WW:武威)
        ///// </summary>
        //public string Region { get; set; }

        ///// <summary>
        ///// 治疗室（G1-G4: 1号-4号）
        ///// </summary>
        //public string RoomID { get; set; }

        /// <summary>
        ///     菜单ID（10x: 首次首射野；11x:首次射野切换；20x:非首次首射野；21x:非首次射野切换）
        /// </summary>
        public string MenuID { get; set; }

        /// <summary>
        ///     菜单名
        /// </summary>
        public string MenuItem { get; set; }

        /// <summary>
        ///     菜单对应的命令（复数命令以分号分隔）
        /// </summary>
        public string MenuCommand { get; set; }

        /// <summary>
        ///     菜单组(取值范围：FFB,FSB,SFB,SSB,FTC,STC)
        /// </summary>
        public string MenuGroup { get; set; }

        /// <summary>
        ///     菜单组ID
        /// </summary>
        public string GroupID { get; set; }

        /// <summary>
        ///     备注说明
        /// </summary>
        public string Description { get; set; }
    }
}