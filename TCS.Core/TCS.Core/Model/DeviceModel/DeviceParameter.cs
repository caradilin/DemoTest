namespace TCS.Core.Model.DeviceModel
{
    public class DeviceParameter
    {
        /// <summary>
        ///     参数ID
        /// </summary>
        public string ParameterID { get; set; }

        /// <summary>
        ///     设备ID
        /// </summary>
        public string DeviceID { get; set; }

        /// <summary>
        ///     设备参数名
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        ///     设备参数值
        /// </summary>
        public string ParameterValue { get; set; }

        /// <summary>
        ///     参数状态
        /// </summary>
        public string ParameterStatus { get; set; } = "E";

        /// <summary>
        ///     配置ID
        /// </summary>
        public string SetId { get; set; }

        /// <summary>
        ///     创建日
        /// </summary>
        public string CreateDate { get; set; }

        /// <summary>
        ///     创建日
        /// </summary>
        public string UpdateDate { get; set; }
    }
}