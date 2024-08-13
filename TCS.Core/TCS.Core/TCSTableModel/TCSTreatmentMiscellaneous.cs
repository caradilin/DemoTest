/************************************************************************************************
*	File Name			:	TCSTreatmentMiscellaneous.cs              	    	                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存治疗辅助表的信息                                *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using System;
using TCS.Core.Model.DeviceModel;

namespace TCS.Core.TCSTableModel
{
    /// <summary>
    ///     15）	治疗辅助表
    /// </summary>
    public class TCSTreatmentMiscellaneous
    {
        /// <summary>
        ///     治疗计划ID
        /// </summary>
        public string TreatmentPlanID { get; set; }

        /// <summary>
        ///     辅助数据
        /// </summary>
        public string TreatmentAuxiliaryData { get; set; }

        /// <summary>
        ///     创建日
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///     更新日
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }

    /// <summary>
    ///     治疗辅助数据类
    /// </summary>
    public class TreatmentAuxiliaryData
    {
        /// <summary>
        ///     记录保存人
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///     治疗床原始位置
        /// </summary>
        public CouchModel OriginalPosition { get; set; }
    }
}