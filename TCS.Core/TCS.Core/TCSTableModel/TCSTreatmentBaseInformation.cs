/************************************************************************************************
*	File Name			:	TCSTreatmentBaseInformation.cs              	    	            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存治疗基础信息表的数据                            *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.TCSTableModel
{
    public class TCSTreatmentBaseInformation : TCSPhysicsBaseInformation
    {
        /// <summary>
        ///     治疗ID
        /// </summary>
        public string TreatmentID { get; set; }

        /// <summary>
        ///     当前治疗次数
        /// </summary>
        public int TreatmentNumber { get; set; }
    }
}