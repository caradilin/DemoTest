namespace TCS.Core.BO
{
    /// <summary>
    ///     RS移位器轴定位距离
    /// </summary>
    public class DestinationAddress
    {
        /// <summary>
        ///     点位
        /// </summary>
        public uint Position { get; set; }

        /// <summary>
        ///     定位距离
        /// </summary>
        public uint Distance { get; set; }

        /// <summary>
        ///     降能片厚度
        /// </summary>
        public string Thickness { get; set; }

        /// <summary>
        ///     轴号
        /// </summary>
        public uint AxisNo { get; set; }
    }
}