/************************************************************************************************
*	File Name			:	TCSUniformScanCalibrationTest.cs              	    	            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存均匀扫描标定测试表的信息                        *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.TCSTableModel
{
    /// <summary>
    ///     均匀扫描标定测试表Model
    /// </summary>
    public class TCSUniformScanCalibrationTest : UniformScanCalibrationBaseModel
    {
        /// <summary>
        ///     测试ID
        /// </summary>
        public string TestID { get; set; }

        /// <summary>
        ///     测试时间
        /// </summary>
        public DateTime TestDate { get; set; }

        /// <summary>
        ///     标定者
        /// </summary>
        public string Tester { get; set; }

        /// <summary>
        ///     预设剂量数
        /// </summary>
        public double PresetDose { get; set; }

        /// <summary>
        ///     实际剂量
        /// </summary>
        public double ActualDose { get; set; }

        /// <summary>
        ///     IC1计数
        /// </summary>
        public int IC1Count { get; set; }

        /// <summary>
        ///     IC2计数
        /// </summary>
        public int IC2Count { get; set; }

        /// <summary>
        ///     IC3计数
        /// </summary>
        public int IC3Count { get; set; }
    }
}