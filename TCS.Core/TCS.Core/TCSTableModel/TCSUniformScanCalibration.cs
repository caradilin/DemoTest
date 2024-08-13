/************************************************************************************************
*	File Name			:	TCSUniformScanCalibration.cs              	    	                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存均匀扫描标定表的信息                            *
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
    ///     均匀扫描标定表Model
    /// </summary>
    public class TCSUniformScanCalibration : UniformScanCalibrationBaseModel
    {
        /// <summary>
        ///     标定者ID
        /// </summary>
        public string CalibrationID { get; set; }

        /// <summary>
        ///     标定者
        /// </summary>
        public string CalibrationPerson { get; set; }

        /// <summary>
        ///     最后标定时间
        /// </summary>
        public DateTime CalibrationDate { get; set; }
    }
}