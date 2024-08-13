/************************************************************************************************
*	File Name			:	OISTreatmentPlanInfomation.cs    						            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/06/04															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	OISDB的表TreatmentPlanInfomation对应的数据类                   		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.06.04	HeDian		    新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.OISTableModel
{
    /// <summary>
    ///     治疗计划基本信息表
    /// </summary>
    internal class OISTreatmentPlanInfomation
    {
        /// <summary>
        ///     治疗计划ID
        /// </summary>
        public string TreatmentPlanID { get; set; }

        /// <summary>
        ///     治疗计划名
        /// </summary>
        public string TreatmentPlanName { get; set; }

        /// <summary>
        ///     患者ID
        /// </summary>
        public string PatientID { get; set; }

        /// <summary>
        ///     治疗总次数
        /// </summary>
        public int TreatmentCount { get; set; }

        /// <summary>
        ///     手动增加次数
        /// </summary>
        public int AppendCount { get; set; }

        /// <summary>
        ///     ISOCenter总数
        /// </summary>
        public int IsoCenterCount { get; set; }

        /// <summary>
        ///     治疗房间ID
        /// </summary>
        public string TreatmentRoomID { get; set; }

        /// <summary>
        ///     治疗计划有效性(0:无效 1:有效)
        /// </summary>
        public bool Effectiveness { get; set; }

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