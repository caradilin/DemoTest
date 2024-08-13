/************************************************************************************************
*	File Name			:	UniformTreatData.cs              	    	                        *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	均匀扫描DDSData节点数据类                                           *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using TCS.Core.BO;

namespace TCS.Core.Model.OpcUaNodeData
{
    /// <summary>
    ///     均匀扫描DDSData节点数据类
    /// </summary>
    public class UniformTreatData
    {
        /// <summary>
        ///     加速器能量（2D每层能量都相同-每个射野的能量；2DLS每层能量不一定相同）
        /// </summary>
        public double Energy;

        /// <summary>
        ///     当前Beam的治疗头
        /// </summary>
        public string Nozzle;

        /// <summary>
        ///     电源的波形参数
        /// </summary>
        public PowerWaveParameter WaveParameter;

        /// <summary>
        ///     预设治疗时间（单位S)
        /// </summary>
        public uint PresetTime { get; set; }

        /// <summary>
        ///     射野大小: 10*10-->100; 15*15 -->150
        /// </summary>
        public string BeamArea { get; set; }

        /// <summary>
        ///     IC3预设计数
        /// </summary>
        public uint IC3PresetMU { get; set; }

        /// <summary>
        ///     总层数（2D时=1，2DLS时>=1）
        /// </summary>
        public uint TotalLayerCount { get; set; }

        /// <summary>
        ///     每层的数据
        /// </summary>
        public UniformLayerData[] LayerDatas { get; set; }
    }

    /// <summary>
    ///     层数据
    /// </summary>
    public class UniformLayerData
    {
        /// <summary>
        ///     当前层的索引-从1开始
        /// </summary>
        public int LayerIndex { get; set; }

        /// <summary>
        ///     IC1预设计数
        /// </summary>
        public uint IC1PresetMU { get; set; }

        /// <summary>
        ///     IC2预设计数
        /// </summary>
        public uint IC2PresetMU { get; set; }

        /// <summary>
        ///     射程移位器值
        /// </summary>
        public string RangeShifter { get; set; }

        /// <summary>
        ///     TPS传过来的光栅数据
        /// </summary>
        public string MLCModel { get; set; }

    }
}