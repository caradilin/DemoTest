/************************************************************************************************
*	File Name			:	OISTreatmentPlanStatus.cs        						            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/06/04															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	OISDB的表TreatmentPlanStatus对应的数据类                       		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.06.04	HeDian		    新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.OISTableModel
{
    public class OISTreatmentPlanStatus
    {
        /// <summary>
        ///     治疗计划ID
        /// </summary>
        public string TreatmentPlanID { get; set; }

        /// <summary>
        ///     治疗计划成功治疗次数
        /// </summary>
        public int SuccessCount { get; set; }

        /// <summary>
        ///     治疗计划失败治疗次数
        /// </summary>
        public int FailuresCount { get; set; }

        /// <summary>
        ///     治疗计划中断治疗次数
        /// </summary>
        public int BreakOffCount { get; set; }

        /// <summary>
        ///     治疗计划当前状态
        ///     (N：未开始；C：标定OK；V：模拟验证OK；S：排程OK/等待治疗；D：治疗中；I：治疗中断；F：治疗完成；L：治疗失败)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        ///     创建日时
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///     更新日时
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}