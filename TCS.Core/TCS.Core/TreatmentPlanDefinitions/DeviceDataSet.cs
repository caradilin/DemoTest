/************************************************************************************************
*	File Name			:	DeviceDataSet.cs             							            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/04/26														    *
*   Author				:	Yu.Haiyang 													     	*
*																								*
*   Description			:	数据存储类，用于保存设备相关信息                        		    *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.04.26	Yu.Haiyang 	新规作成									    	*
*																								*
*************************************************************************************************/

using TCS.Core.Model.DeviceModel;

namespace TCS.Core.TreatmentPlanDefinitions
{
    /// <summary>
    ///     设备计划数据信息集
    /// </summary>
    public class DeviceDataSet : DeviceData
    {
        /// <summary>
        ///     DR模型数据
        /// </summary>
        public DRModel DRModel { get; set; }

        // ---------- ChangeRequest(150) Added by WangYunXia 2021.1.20 Start ----------
        /// <summary>
        ///     治疗床模型数据
        /// </summary>
        public CouchModel CouchModel { get; set; } = new CouchModel();

        // ---------- ChangeRequest(150) Added by WangYunXia 2021.1.20 End ----------
    }

    public class DeviceData
    {
        /// <summary>
        /// MLC模型数据
        /// </summary>
        public MLCModel MLCModel { get; set; }

        /// <summary>
        /// PC模型数据
        /// </summary>
        public PCModel PCModel { get; set; }

        /// <summary>
        /// RS模型数据
        /// </summary>
        public RSModel RSModel { get; set; }

        /// <summary>
        /// RF模型数据
        /// </summary>
        public RFModel RFModel { get; set; }

        /// <summary>
        /// CP模型数据
        /// </summary>
        public CPModel CPModel { get; set; }

        /// <summary>
        ///     治疗头
        /// </summary>
        public string TreatmentHeadName { get; set; }

        /// <summary>
        ///     勾画文件sopinstanceuid
        /// </summary>
        public string ReferencedSOPInstanceUID { get; set; }

        /// <summary>
        ///     引用的勾画帧信息ID
        /// </summary>
        public string FrameOfReferenceUID { get; set; }

        /// <summary>
        ///     束流扫描模式
        /// </summary>
        public string ScanMode { get; set; }

        /// <summary>
        ///     束流类型
        /// </summary>
        public string BeamType { get; set; }

        // ----------(changerequest260) Added by WangYunxia 2022.11.18 start ----------
        /// <summary>
        ///     TPS射野类型（当计划是Raystation和CASHIM时不为空）
        /// </summary>
        public string TreatmentProtocols { get; set; }
        // ----------(changerequest260) Added by WangYunxia 2022.11.18 End ----------

        /// <summary>
        ///     扫描架角度
        /// </summary>
        public string GantryAngle { get; set; }

        /// <summary>
        /// </summary>
        public string BeamLimitingDeviceAngle { get; set; }

        /// <summary>
        ///     治疗床等中心旋转角度
        /// </summary>
        public string IsocenterRotateAngle { get; set; }

        /// <summary>
        ///     患者旋转方向
        /// </summary>
        public string PatientSupportRotationDirection { get; set; }

        /// <summary>
        ///     患者角度
        /// </summary>
        public string PatientSupportAngle { get; set; }

        /// <summary>
        ///     等中心前距
        /// </summary>
        public string BeamISODistance { get; set; }

        /// <summary>
        ///     标定深度
        /// </summary>
        public string BeamDepth { get; set; }

        /// <summary>
        ///     步长
        /// </summary>
        public string BeamStepSize { get; set; }


        /// <summary>
        /// 射野大小
        /// </summary>
        public string BeamSize { get; set; }

        /// <summary>
        /// 射野序号
        /// </summary>
        public string BeamNumber { get; set; }
    }
}