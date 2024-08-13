/************************************************************************************************
*	File Name			:	TCSTreatmentRecord.cs              	    	                        *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存治疗记录表的信息                                *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using System;
using System.Collections.Generic;
using TCS.Core.Model.OpcUaNodeData;
using TCS.Core.TreatmentPlanDefinitions;

namespace TCS.Core.TCSTableModel
{
    /// <summary>
    ///     12）	治疗记录表
    /// </summary>
    public class TCSTreatmentRecord
    {
        /// <summary>
        ///     治疗记录ID
        /// </summary>
        public string TRID { get; set; } = $"TRID_{DateTime.Now:yyyy - MM - dd hh: mm: ss.fff}";

        /// <summary>
        ///     治疗ID
        /// </summary>
        public string TreatmentID { get; set; }

        /// <summary>
        ///     开始时间
        /// </summary>
        public DateTime TreatmentStartDatetime { get; set; }

        /// <summary>
        ///     结束时间
        /// </summary>
        public DateTime TreatmentFinishDatetime { get; set; }

        /// <summary>
        ///     治疗步骤
        /// </summary>
        public string TreatmentStep { get; set; }

        /// <summary>
        ///     治疗数据
        /// </summary>
        public string TreatmentData { get; set; }

        /// <summary>
        ///     当前状态
        /// </summary>
        public string TreatmentStatus { get; set; }

        /// <summary>
        ///     异常数据
        /// </summary>
        public string AnomalousData { get; set; }

        /// <summary>
        ///     操作者
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        ///     授权者
        /// </summary>
        public string Anthorizer { get; set; }

        /// <summary>
        ///     创建日
        /// </summary>
        public DateTime CreateDate { get; set; } = DateTime.Now;

        /// <summary>
        ///     更新日
        /// </summary>
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }

    /// <summary>
    ///     治疗数据
    /// </summary>
    public class TCSTreatmentRecordNormalData
    {
        /// <summary>
        ///     授权类别
        /// </summary>
        public string AuthType { get; set; }
        /// <summary>
        ///     患者ID(患者验证)
        /// </summary>
        public string PatientId { get; set; }

        /// <summary>
        ///     扫码结果(患者验证)
        /// </summary>
        public string ScanPatientResult { get; set; }

        /// <summary>
        ///     设备确认计划数据（设备定位）
        /// </summary>
        public DeviceDataSet DevicePlanInfoDataSet { get; set; }

        /// <summary>
        ///     设备确认实际数据（设备定位）
        /// </summary>
        public DeviceDataSet DeviceActualInfoDataSet { get; set; }

        /// <summary>
        ///     治疗射野各层时间
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> BeamLayerSpendTime { get; set; }

        /// <summary>
        ///     dds申请束流数据
        /// </summary>
        public SpotTreatData SpotTreatData { get; set; }

        /// <summary>
        ///     dds申请束流数据
        /// </summary>
        public UniformTreatData UniformTreatData { get; set; }
    }
}