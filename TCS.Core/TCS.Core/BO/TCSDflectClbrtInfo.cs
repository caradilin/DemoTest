using System;

namespace TCS.Core.BO
{
    /// <summary>
    ///     传递给电源的数据
    /// </summary>
    [Serializable]
    public class TCSDflectClbrtInfo
    {
        /// <summary>
        ///     正向KX值
        /// </summary>
        public float iso_param_posi_kx { get; set; }

        /// <summary>
        ///     正向BX值
        /// </summary>
        public float iso_param_posi_bx { get; set; }

        /// <summary>
        ///     负向KX值
        /// </summary>
        public float iso_param_nage_kx { get; set; }

        /// <summary>
        ///     负向BX值
        /// </summary>
        public float iso_param_nage_bx { get; set; }

        /// <summary>
        ///     正向KY值
        /// </summary>
        public float iso_param_posi_ky { get; set; }

        /// <summary>
        ///     正向BY值
        /// </summary>
        public float iso_param_posi_by { get; set; }

        /// <summary>
        ///     负向KY值
        /// </summary>
        public float iso_param_nage_ky { get; set; }

        /// <summary>
        ///     负向BY值
        /// </summary>
        public float iso_param_nage_by { get; set; }

        /// <summary>
        ///     分条KX（小数点保留2位）
        /// </summary>
        public float ic_param_kx { get; set; }

        /// <summary>
        ///     分条KY（小数点保留2位）
        /// </summary>
        public float ic_param_ky { get; set; }

        /// <summary>
        ///     分条BX（小数点保留2位）
        /// </summary>
        public float ic_param_bx { get; set; }

        /// <summary>
        ///     分条BY（小数点保留2位）
        /// </summary>
        public float ic_param_by { get; set; }
    }
}