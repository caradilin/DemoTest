/************************************************************************************************
*	File Name			:	OISDicomSeries.cs           							            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/06/04															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	OISDB的表DicomSeries对应的数据类                            		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.06.04	HeDian		    新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.OISTableModel
{
    public class OISDicomSeries
    {
        /// <summary>
        ///     ISOCID
        /// </summary>
        public string ISOCID { get; set; }

        /// <summary>
        ///     治疗计划ID
        /// </summary>
        public string TreatmentPlanID { get; set; }

        /// <summary>
        ///     ISOCenter编号
        /// </summary>
        public string ISOCenterNo { get; set; }

        /// <summary>
        ///     ISOCenter数据
        /// </summary>
        public string ISOCenterData { get; set; }

        /// <summary>
        ///     ISOCenter的总射野数
        /// </summary>
        public string BeamTotalCount { get; set; }

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