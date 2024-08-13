/************************************************************************************************
*	File Name			:	UniformScanCalibrationBaseModel.cs              	    	        *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存均匀扫描标定基础信息表的信息                    *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.TCSTableModel
{
    public class UniformScanCalibrationBaseModel : CalibrationBaseModel
    {
        /// <summary>
        ///     患者ID
        /// </summary>
        public string PatientID { get; set; }

        /// <summary>
        ///     治疗计划ID
        /// </summary>
        public string TreatmentPlanID { get; set; }

        /// <summary>
        ///     治疗计划名称
        /// </summary>
        public string TreatmentPlanName { get; set; }

        /// <summary>
        ///     射野ID
        /// </summary>
        public string BeamID { get; set; }

        /// <summary>
        ///     射野名称
        /// </summary>
        public string BeamName { get; set; }

        /// <summary>
        ///     能量
        /// </summary>
        public double Energy { get; set; }

        /// <summary>
        ///     治疗头
        /// </summary>
        public string TreatmentHead { get; set; }

        /// <summary>
        ///     射程移位器
        /// </summary>
        public double RangeShifter { get; set; }

        //// ---------- 变更对应(260) Modified by LiuWenXing 2022.11.18 Start ----------
        ///// <summary>
        ///// TPS传过来的光栅数据
        ///// </summary>
        //public MLCModel MLCModel { get; set; }
        //// ---------- 变更对应(260) Modified by LiuWenXing 2022.11.18 End ----------


        /// <summary>
        ///     脊型过滤器
        /// </summary>
        public string RidgeFilter { get; set; }

        /// <summary>
        ///     标定深度
        /// </summary>
        public double CalibrationDepth { get; set; }


        /// <summary>
        ///     等中心点距离
        /// </summary>
        public double ISOCenterDistance { get; set; }

        /// <summary>
        ///     状态
        /// </summary>
        public string ExamineStatus { get; set; }

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