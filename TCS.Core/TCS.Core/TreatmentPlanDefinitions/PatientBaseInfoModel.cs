/************************************************************************************************
*	File Name			:	PatientBaseInfoModel.cs              	    	                    *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存患者数据的信息                                  *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using Newtonsoft.Json;

namespace TCS.Core.TreatmentPlanDefinitions
{
    public class PatientBaseInfoModel
    {
        /// <summary>
        ///     患者名
        /// </summary>
        public string PatientName { get; set; }

        /// <summary>
        ///     患者ID
        /// </summary>
        public string PatientID { get; set; }

        /// <summary>
        ///     治疗计划名称
        /// </summary>
        public string TreatmentPlanName { get; set; }

        /// <summary>
        ///     治疗计划ID
        /// </summary>
        public string TreatmentPlanID { get; set; }

        /// <summary>
        ///     DicomStudy UID
        /// </summary>
        public string StudyinstanceUID { get; set; }

        /// <summary>
        ///     患者的选中状态，默认非选中
        /// </summary>
        public bool IsChecked { get; set; }

        // ---------- ChangeRequest(184) Added by WangYunXia 2022.4.24 Start ----------
        /// <summary>
        ///     计划表附加字段
        /// </summary>
        public string Appendix { get; set; }

        // ---------- ChangeRequest(184) Added by WangYunXia 2022.4.24 End ----------
        // ---------- ChangeRequest(184) Added by WangYunXia 2022.4.24 Start ----------
        private TreatmentPlanAppendix _treatmentPlanAppendix;
        /// <summary>
        ///     新计划系统RayStation附加字段
        /// </summary>
        public TreatmentPlanAppendix TreatmentPlanAppendix {
            get => Appendix.IsNotNullOrEmpty() ? JsonConvert.DeserializeObject<TreatmentPlanAppendix>(Appendix) : new TreatmentPlanAppendix();
            set => _treatmentPlanAppendix = value;
        }

        // ---------- ChangeRequest(184) Added by WangYunXia 2022.4.24 End ----------
    }
}