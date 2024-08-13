using System;

namespace TCS.Core.TCSTableModel
{
    public class FactorSettingInfo
    {
        /// <summary>
        /// IC1因子
        /// </summary>
        public string IC1Factor { get; set; }

        /// <summary>
        /// IC2因子
        /// </summary>
        public string IC2Factor { get; set; }

        /// <summary>
        /// IC3因子
        /// </summary>
        public string IC3Factor { get; set; }

        /// <summary>
        /// 能量
        /// </summary>
        public double Energy { get; set; }

        /// <summary>
        /// 治疗头名称
        /// </summary>
        public string NozzleName { get; set; }


        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 标定因子
        /// </summary>
        public string CalibrationFactor { get; set; }

        /// <summary>
        /// 射野大小
        /// </summary>
        public string BeamSize { get; set; } = string.Empty;
    }
}