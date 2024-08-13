/************************************************************************************************
*	File Name			:	OISDicomISOCenter.cs           							            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/06/04															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	OISDB的表DicomISOCenter对应的数据类                            		*
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
    ///     Dicom等中心表
    /// </summary>
    public class OISDicomISOCenter
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
        ///     ISOCenter数
        /// </summary>
        public int ISOCenterNo { get; set; }

        /// <summary>
        ///     ISOCenter数据
        /// </summary>
        public string ISOCenterData { get; set; }

        /// <summary>
        ///     总射野数
        /// </summary>
        public int BeamTotalCount { get; set; }

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