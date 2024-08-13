/************************************************************************************************
*	File Name			:	SpotTreatData.cs              	    	                            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	点扫描的数据类                                                      *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using Newtonsoft.Json;

namespace TCS.Core.Model.OpcUaNodeData
{
    /// <summary>
    ///     点扫描的数据类
    /// </summary>
    public class SpotTreatData
    {
        /// <summary>
        ///     当前Beam的治疗头
        /// </summary>
        public string Nozzle;

        /// <summary>
        ///     总层数
        ///     The sum of the list SpotEnergyLayers.
        /// </summary>
        public int TotalLayerCount { get; set; }

        /// <summary>
        ///     所有层的总剂量的计数（剂量/标定因子）
        ///     TCS needs to translate FinalCumulativeDoseWeight into IC3 count, and sends to DDS and ITS.
        /// </summary>
        public uint IC3PresetMU { get; set; }

        /// <summary>
        ///     预设治疗时间（单位：秒),来自配置文件
        ///     Set in TCS configuration file, TCS will send this value to DDS
        /// </summary>
        public uint PresetTime { get; set; }

        /// <summary>
        ///     所有层数据
        /// </summary>
        public SpotEnergyLayer[] LayerDatas { get; set; }
    }

    /// <summary>
    ///     层数据类
    /// </summary>
    public class SpotEnergyLayer
    {
        /// <summary>
        ///     射野大小: 10*10-->100; 15*15 -->150
        /// </summary>
        public string BeamArea;

        /// <summary>
        ///     用于计算传递给电源的数据
        /// </summary>
        public PosiNageXYData KBXYData { get; set; }

        /// <summary>
        ///     当前层的索引
        /// </summary>
        public int LayerIndex { get; set; }

        /// <summary>
        ///     能量
        /// </summary>
        public double Energy { get; set; }

        /// <summary>
        ///     当前层的剂量的计数（剂量和标定因子换算后的计数）
        ///     Sum of spot dose translated with calibration factor, it is dose count in MU.
        /// </summary>
        public uint IC2PresetMU { get; set; }

        /// <summary>
        ///     步长
        ///     Spot space from ciPlan, the custom tag is: "0029,1090"
        /// </summary>
        public int Step { get; set; }

        /// <summary>
        ///     点数据
        /// </summary>
        public Spot[] SpotDatas { get; set; }
    }

    /// <summary>
    ///     具体点数据类
    /// </summary>
    public class Spot
    {
        /// <summary>
        ///     当前点的索引
        /// </summary>
        [JsonProperty(PropertyName = "No")]
        public int SpotNumber { get; set; }

        // ---------- 变更对应(266) Deleted by Wangyunxia 2023.01.11 Start ----------
        ///// <summary>
        ///// 目前没有，默认0
        ///// </summary>
        //public float XBeamSize { get; set; } = 0;

        ///// <summary>
        ///// 目前没有，默认0
        ///// </summary>
        //public float YBeamSize { get; set; } = 0;
        // ---------- 变更对应(266) Deleted by Wangyunxia 2023.01.11 End ----------

        /// <summary>
        ///     计划里给出的位置X
        /// </summary>
        [JsonProperty(PropertyName = "X")]
        public float XPosition { get; set; }

        /// <summary>
        ///     计划里给出的位置Y
        /// </summary>
        [JsonProperty(PropertyName = "Y")]
        public float YPosition { get; set; }

        /// <summary>
        ///     IC1Mu
        /// </summary>
        [JsonProperty(PropertyName = "MU")]
        public float SpotMU { get; set; }
    }

    // ---------- 变更对应(266) Deleted by Wangyunxia 2023.01.11 Start ----------
    public class CalibrationSpot : Spot
    {
        // ---------- 变更对应(180) Add by LiuWenXing 2022.04.13 Start ----------
        /// <summary>
        ///     X电流值(A)
        /// </summary>
        [JsonProperty(PropertyName = "XV")]
        public float XCurrentValue { get; set; }

        /// <summary>
        ///     Y电流值(A)
        /// </summary>
        [JsonProperty(PropertyName = "YV")]
        public float YCurrentValue { get; set; }

        // ---------- 变更对应(180) Add by LiuWenXing 2022.04.13 End ----------
    }

    // ---------- 变更对应(266) Deleted by Wangyunxia 2023.01.11 End ----------
}