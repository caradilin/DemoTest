/************************************************************************************************
*	File Name			:	PatientInfo.cs  		        					                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/08/24															*
*   Author				:	Yu.Haiyang															*
*																								*
*   Description			:	实现对治疗室的患者信息的取得                                        *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.08.24	Yu.Haiyang	    新规作成										*
*																								*
*************************************************************************************************/

using System.Linq;
using TCS.Core.TreatmentPlanDefinitions;

namespace TCS.Core.Model.OpcUaNodeData.RoomModel
{
    /// <summary>
    ///     治疗室PatientInfo节点
    /// </summary>
    public class PatientInfo
    {
        /// <summary>
        ///     患者姓名
        /// </summary>
        public string PatientName { get; set; }

        /// <summary>
        ///     治疗状态
        /// </summary>
        public TreatmentPlanStatus TreatmentPlanStatus { get; set; }

        /// <summary>
        ///     患者ID
        /// </summary>
        public string PatientID { get; set; }

        /// <summary>
        ///     计划名称
        /// </summary>
        public string PlanName { get; set; }

        /// <summary>
        ///     治疗情况
        /// </summary>
        public string TreatInfo { get; set; }

        /// <summary>
        ///     治疗模式
        /// </summary>
        public string TreatMode { get; set; }

        /// <summary>
        ///     治疗头
        /// </summary>
        public string NozzleID { get; set; }

        /// <summary>
        ///     治疗层
        /// </summary>
        public int TreatLayer { get; set; }

        /// <summary>
        ///     治疗剂量
        /// </summary>
        public double TreatTotalDose { get; set; }

        /// <summary>
        ///     已完成剂量
        /// </summary>
        public double CompletedDose { get; set; }

        /// <summary>
        ///     患者性别
        /// </summary>
        public PatientSex PatientSex { get; set; }

        /// <summary>
        ///     计划表附加字段
        /// </summary>
        public string Appendix { get; set; }

        public void UpdatePatientInfo(BeamPlanModel m, string treatMode, BeamScanStatus s)
        {
            //TreatMode = TcsMethodUtility.GetBeamType(type);
            TreatMode = treatMode;
            NozzleID = m.Nozzle;
            if (s == BeamScanStatus.S)
                TreatLayer = m.PointScanLayers.Any(layer => layer.LayerExecute)
                    ? m.PointScanLayers.First(layer => layer.LayerExecute).LayerIndex
                    : m.PointScanLayers.Last().LayerIndex;
            else
                TreatLayer = m.UniformScanLayers.Any(layer => layer.LayerExecute)
                    ? m.UniformScanLayers.First(layer => layer.LayerExecute).LayerIndex
                    : m.UniformScanLayers.Last().LayerIndex;

            TreatTotalDose = m.BeamMeterset;
            CompletedDose = m.CurrentBeamMeterset;
        }
    }
}