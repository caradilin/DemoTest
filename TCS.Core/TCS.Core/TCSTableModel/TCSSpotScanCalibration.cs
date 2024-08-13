/************************************************************************************************
*	File Name			:	TCSSpotScanCalibration.cs             			            	    *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/04/26														    *
*   Author				:	Li.Jian 													     	*
*																								*
*   Description			:	数据存储类，用于保存束流标定的信息                        		    *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.04.26	Li.Jian 	    新规作成								     	*
*																								*
*************************************************************************************************/

namespace TCS.Core.TCSTableModel
{
    /// <summary>
    ///     点扫描标定Model
    /// </summary>
    public class TCSSpotScanCalibration : SpotScanCalibrationBaseModel
    {
        /// <summary>
        ///     标定id
        /// </summary>
        public string CalibrationID { get; set; }

        /// <summary>
        ///     标定日
        /// </summary>
        public string CalibrationDate { get; set; }

        /// <summary>
        ///     标定者
        /// </summary>
        public string CalibrationPerson { get; set; }

        /// <summary>
        ///     等中心处扫描
        /// </summary>
        public string ISOCenterScan { get; set; }

        // ---------- 变更对应(259) Added by Wang.Yunxia 2022.11.10 Start ----------
        /// <summary>
        ///     治疗头名称
        /// </summary>
        public string TreatmentHeadName { get; set; }
        // ---------- 变更对应(259) Added by Wang.Yunxia 2022.11.10 End ----------

        // ---------- 变更对应(267) Added by ZhangYao 2023.01.31 Start ----------  
        public string RangeShifter { get; set; }
        // ---------- 变更对应(267) Added by ZhangYao 2023.01.31 End ----------  
    }
}