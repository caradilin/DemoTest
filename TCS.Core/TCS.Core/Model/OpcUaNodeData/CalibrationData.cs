/************************************************************************************************
*	File Name			:	CalibrationData.cs              	    	                        *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存点扫描标定的数据                                *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.Model.OpcUaNodeData
{
    public class CalibrationData
    {
        /// <summary>
        ///     能量
        /// </summary>
        public double Energy { get; set; }

        /// <summary>
        ///     步长
        /// </summary>
        public int Step { get; set; }

        /// <summary>
        ///     射野大小
        /// </summary>
        public string BeamSize { get; set; }

        /// <summary>
        ///     标定深度
        /// </summary>
        public double CalibrationDepth { get; set; }

        /// <summary>
        ///     等中心前距离
        /// </summary>
        public double ISOCenterDistance { get; set; }

        /// <summary>
        ///     脊形过滤器
        /// </summary>
        public string RidgeFilter { get; set; }

        /// <summary>
        ///     预设剂量数
        /// </summary>
        public double PresetDose { get; set; }

        /// <summary>
        ///     治疗头
        /// </summary>
        public string NozzleID { get; set; }

        /// <summary>
        ///     射程移位器
        /// </summary>
        public double RangeShifter { get; set; }

        /// <summary>
        ///     射野扫描模式
        /// </summary>
        public BeamScanStatus BeamScanMode { get; set; } = BeamScanStatus.S;

        /// <summary>
        ///     用于计算传递给电源的数据
        /// </summary>
        public PosiNageXYData KBXYData { get; set; }
    }
}