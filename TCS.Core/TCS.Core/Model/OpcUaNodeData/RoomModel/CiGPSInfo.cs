namespace TCS.Core.Model.OpcUaNodeData.RoomModel
{
    /// <summary>
    ///     治疗室内部使用的治疗床的具体数据类
    /// </summary>
    public class CiGPSInfo
    {
        /// <summary>
        ///     X轴移动值
        /// </summary>
        public double MoveX { get; set; }

        /// <summary>
        ///     Y轴移动值
        /// </summary>
        public double MoveY { get; set; }

        /// <summary>
        ///     Z轴移动值
        /// </summary>
        public double MoveZ { get; set; }

        /// <summary>
        ///     X轴旋转值
        /// </summary>
        public double RotateX { get; set; }

        /// <summary>
        ///     Y轴旋转值
        /// </summary>
        public double RotateY { get; set; }

        /// <summary>
        ///     Z轴旋转值
        /// </summary>
        public double RotateZ { get; set; }
    }
}