/************************************************************************************************
*	File Name			:	OISTreatmentReport.cs           						            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/06/04															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	OISDB的表TreatmentReport对应的数据类                           		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.06.04	HeDian		    新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.OISTableModel
{
    internal class OISTreatmentReport
    {
        /// <summary>
        ///     治疗ID
        /// </summary>
        public string TreatmentID { get; set; }

        /// <summary>
        ///     报告数据(Json数据)
        /// </summary>
        public string ReportData { get; set; }

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