/************************************************************************************************
*	File Name			:	OISTreatmentInformation.cs           				                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/06/04															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	OISDB的表TreatmentInformation对应的数据类                      		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.06.04	HeDian		    新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.OISTableModel
{
    public class OISTreatmentInformation
    {
        /// <summary>
        ///     治疗ID
        /// </summary>
        public string TreatmentID { get; set; }

        /// <summary>
        ///     患者ID
        /// </summary>
        public string PatientID { get; set; }

        /// <summary>
        ///     治疗计划ID
        /// </summary>
        public string TreatmentPlanID { get; set; }

        /// <summary>
        ///     当前治疗次数
        /// </summary>
        public string TreatmentNumber { get; set; }

        /// <summary>
        ///     治疗日时
        /// </summary>
        public string TreatmentDate { get; set; }

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