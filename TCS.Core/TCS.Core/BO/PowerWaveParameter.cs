namespace TCS.Core.BO
{
    public class UfmEnergyData
    {
        public string En_id { get; set; }

        public string Energy { get; set; }
    }

    /// <summary>
    ///     电源波形参数
    /// </summary>
    public class PowerWaveParameter
    {
        /// <summary>
        ///     X电源幅值
        /// </summary>
        public float Amplitude_X { get; set; }

        /// <summary>
        ///     X电源频率
        /// </summary>
        public float Frequency_X { get; set; }

        /// <summary>
        ///     X电源正向幅值
        /// </summary>
        public float Poffset_X { get; set; }

        /// <summary>
        ///     X电源负向幅值
        /// </summary>
        public float Noffset_X { get; set; }

        /// <summary>
        ///     X电源非线性系数
        /// </summary>
        public float K_X { get; set; }

        /// <summary>
        ///     X电源截距
        /// </summary>
        public float Intercept_X { get; set; }

        /// <summary>
        ///     Y电源幅值
        /// </summary>
        public float Amplitude_Y { get; set; }

        /// <summary>
        ///     Y电源频率
        /// </summary>
        public float Frequency_Y { get; set; }

        /// <summary>
        ///     Y电源正向幅值
        /// </summary>
        public float Poffset_Y { get; set; }

        /// <summary>
        ///     Y电源负向幅值
        /// </summary>
        public float Noffset_Y { get; set; }

        /// <summary>
        ///     Y电源非线性系数
        /// </summary>
        public float K_Y { get; set; }

        /// <summary>
        ///     Y电源截距
        /// </summary>
        public float Intercept_Y { get; set; }
    }
}