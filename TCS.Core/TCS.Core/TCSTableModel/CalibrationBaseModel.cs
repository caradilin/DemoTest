/************************************************************************************************
*	File Name			:	CalibrationBaseModel.cs              	    	                    *
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
    public class CalibrationBaseModel
    {
        /// <summary>
        ///     IC1标定因子
        /// </summary>
        public double IC1Factor { get; set; }

        /// <summary>
        ///     IC2标定因子
        /// </summary>
        public double IC2Factor { get; set; }

        /// <summary>
        ///     IC3标定因子
        /// </summary>
        public double IC3Factor { get; set; }

        /// <summary>
        ///     审核者
        /// </summary>
        public string Reviewer { get; set; }

        /// <summary>
        ///     审核时间
        /// </summary>
        public DateTime? ReviewDateTime { get; set; }

        /// <summary>
        /// 标定因子
        /// </summary>
        public double CalibrationFactor { get; set; }
    }
}