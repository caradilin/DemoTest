/************************************************************************************************
*	File Name			:	TCSPhysicsBaseInformation.cs              	    	                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/10/27															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存模拟治疗基础信息表的数据                        *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.10.27	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.TCSTableModel
{
    public class TCSPhysicsBaseInformation
    {
        /// <summary>
        ///     治疗计划ID
        /// </summary>
        public string TreatmentPlanID { get; set; }

        /// <summary>
        ///     患者ID
        /// </summary>
        public string PatientID { get; set; }

        /// <summary>
        ///     已完成的治疗数据
        /// </summary>
        public string HaddownTreatInfo { get; set; }

        /// <summary>
        ///     创建日
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///     更新日
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }

    public class HaddownTreatmentInfo
    {
        /// <summary>
        ///     射野ID
        /// </summary>
        public string BeamId { get; set; }

        /// <summary>
        ///     当前已治疗层
        /// </summary>
        public int LayerIndex { get; set; }

        /// <summary>
        ///     点扫描当前已治疗点
        /// </summary>
        public int? PointIndex { get; set; }

        /// <summary>
        ///     当前射野根据IC3已治疗剂量
        /// </summary>
        public double BeamIc3CurrentDose { get; set; }

        /// <summary>
        ///     均匀扫描：当前层根据IC1已治疗剂量
        /// </summary>
        public double? LayerIc1CurrentDose { get; set; }

        /// <summary>
        ///     均匀扫描：当前层根据IC2已治疗剂量
        /// </summary>
        public double? LayerIc2CurrentDose { get; set; }
    }
}