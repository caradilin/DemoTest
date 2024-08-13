/************************************************************************************************
*	File Name			:	SpotScanCalibrationBaseModel.cs              	    	            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存点扫描束流标定信息                              *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.TCSTableModel
{
    public class SpotScanCalibrationBaseModel : CalibrationBaseModel
    {
        /// <summary>
        ///     治疗头
        /// </summary>
        public string NozzleID { get; set; }

        /// <summary>
        ///     射野大小
        /// </summary>
        public string BeamSize { get; set; }

        //------------------------------Add by feijinqiu 2021.8.31 Start ----------------------
        /// <summary>
        ///     脊形过滤器
        /// </summary>
        public string RidgeFilter { get; set; }

        //------------------------------Add by feijinqiu 2021.8.31 End ----------------------
        /// <summary>
        ///     能量
        /// </summary>
        public double Energy { get; set; }

        /// <summary>
        ///     等中心距离
        /// </summary>
        public double ISOCenterDistance { get; set; }

        /// <summary>
        ///     标定深度
        /// </summary>
        public double CalibrationDepth { get; set; }

        /// <summary>
        ///     状态
        /// </summary>
        public string ExamineStatus { get; set; }

        /// <summary>
        ///     创建日
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///     更新日
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}