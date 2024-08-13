/************************************************************************************************
*	File Name			:	OISDicomBeam.cs              							            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/06/04															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	OISDB的表DicomBeam对应的数据类                              		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.06.04	HeDian		    新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.OISTableModel
{
    public class OISDicomBeam
    {
        /// <summary>
        ///     射野ID
        /// </summary>
        public string BeamID { get; set; }

        /// <summary>
        ///     治疗计划ID
        /// </summary>
        public string TreatmentPlanID { get; set; }

        /// <summary>
        ///     ISOCID
        /// </summary>
        public string ISOCID { get; set; }

        /// <summary>
        ///     射野名
        /// </summary>
        public string BeamName { get; set; }

        /// <summary>
        ///     总层数
        /// </summary>
        public int LayerTotalCount { get; set; }

        /// <summary>
        ///     射野扫描模式
        /// </summary>
        public BeamScanStatus BeamScanMode { get; set; }

        /// <summary>
        ///     射野剂量
        /// </summary>
        public double BeamDose { get; set; }

        /// <summary>
        ///     治疗数据(Json)
        /// </summary>
        public string TreatmentData { get; set; }

        /// <summary>
        ///     治疗头
        /// </summary>
        public string TreatmentHeadName { get; set; }

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