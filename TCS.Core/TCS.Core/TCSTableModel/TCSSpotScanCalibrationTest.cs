/************************************************************************************************
*	File Name			:	PhysicsSpotScanBeamCalibrationListModel.cs             				*
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/04/26														    *
*   Author				:	Li.Jian 													     	*
*																								*
*   Description			:	数据存储类，用于保存点扫描束流标定添加测试一览表的信息              *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.04.26	Li.Jian 	    新规作成									    *
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.TCSTableModel
{
    /// <summary>
    ///     点扫描标定测试Model
    /// </summary>
    public class TCSSpotScanCalibrationTest : SpotScanCalibrationBaseModel
    {
        /// <summary>
        ///     测试ID
        /// </summary>
        public string TestID { get; set; }

        /// <summary>
        ///     测试者
        /// </summary>
        public string Tester { get; set; }

        /// <summary>
        ///     测试日
        /// </summary>
        public DateTime TestDate { get; set; }

        /// <summary>
        ///     预设剂量
        /// </summary>
        public double PresetDose { get; set; }

        /// <summary>
        ///     实际剂量
        /// </summary>
        public double ActualDose { get; set; }

        /// <summary>
        ///     步长
        /// </summary>
        public string Step { get; set; }

        /// <summary>
        ///     IC1计数
        /// </summary>
        public int IC1Count { get; set; }

        /// <summary>
        ///     IC2计数
        /// </summary>
        public int IC2Count { get; set; }

        /// <summary>
        ///     IC3计数
        /// </summary>
        public int IC3Count { get; set; }

        // ---------- 变更对应(259) Added by Wang.Yunxia 2022.11.10 Start ----------
        /// <summary>
        ///     治疗头名称
        /// </summary>
        public string TreatmentHeadName { get; set; }
        // ---------- 变更对应(259) Added by Wang.Yunxia 2022.11.10 End ----------

        // ---------- 变更对应(267) Added by ZhangYao 2023.01.31 Start ----------  
        /// <summary>
        ///     射程移位器
        /// </summary>
        public double RangeShifter { get; set; }

        // ---------- 变更对应(267) Added by ZhangYao 2023.01.31 End ----------  
    }
}