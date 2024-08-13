/************************************************************************************************
*	File Name			:	PatientInfoModel.cs             							        *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/04/26														    *
*   Author				:	Yu.Haiyang 					     									*
*																								*
*   Description			:	数据存储类，用于保存患者信息窗口的信息                        		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.04.26	Yu.Haiyang 	新规作成									     	*
*																								*
*************************************************************************************************/

using System;
using TCS.Core.Common;

namespace TCS.Core.TreatmentPlanDefinitions
{
    /// <summary>
    ///     患者信息
    /// </summary>
    public class PatientInfoModel : PatientBaseInfoModel
    {
        /// <summary>
        ///     总治疗次数=来自TPS的本治疗计划需要治疗的次数+本治疗计划手动新添加的治疗次数
        /// </summary>
        public int TreatmentTotalCount { get; set; }

        /// <summary>
        ///     来自TPS的本治疗计划需要治疗的次数
        /// </summary>
        public int TreatmentCount { get; set; }

        /// <summary>
        ///     已成功治疗信息次数
        /// </summary>
        public int SuccessCount { get; set; }


        /// <summary>
        ///     本治疗计划手动新添加的治疗次数(根据患者治疗情况，大夫可以手动添加治疗次数)
        /// </summary>
        public int AppendCount { get; set; }

        /// <summary>
        ///     患者年龄
        /// </summary>
        public DateTime PatientAge { get; set; }

        /// <summary>
        ///     患者照片
        /// </summary>
        public string PatientPhoto { get; set; }

        /// <summary>
        ///     患者性别
        /// </summary>
        public PatientSex PatientSex { get; set; }

        /// <summary>
        ///     治疗状态
        /// </summary>
        public TreatmentPlanStatus TreatmentPlanStatus { get; set; }

        /// <summary>
        ///     计划上传时间
        /// </summary>
        public string PlanPutTime { get; set; }

        /// <summary>
        ///     排程状态
        /// </summary>
        public ScheduleResults ScheduleResults { get; set; }

        /// <summary>
        ///     排程ID
        /// </summary>
        public string ScheduleID { get; set; }
    }

    // ---------- ChangeRequest(184) Added by WangYunXia 2022.4.24 Start ----------
    /// <summary>
    ///     莆田新的治疗计划区别于兰州、武威治疗计划的字段
    /// </summary>
    public class TreatmentPlanAppendix
    {
        /// <summary>
        ///     制作计划数据的TPS名称
        /// </summary>
        public string ManufacturerModelName { get; set; }

        /// <summary>
        ///     制作计划数据的TPS版本号
        /// </summary>
        public string SoftwareVersions { get; set; }
        // ---------- (#196) Modified by zhang.pengchao 2023.06.05 Start ----------

        public bool IsCashim => this.ModelType== ManufacturerModelType.Cashim;
        public bool IsRayStation => this.ModelType == ManufacturerModelType.Raystation;
        public bool IsCiPlan => this.ModelType == ManufacturerModelType.CiPlan;
        /// <summary>
        /// 计划数据类型
        /// </summary>
        public ManufacturerModelType ModelType
        {
            get
            {
                //追加一个phoenix，如果取得到phoenix和cashim，都按照IsCashim处理
                if (ManufacturerModelName.IsNotNullOrEmpty() 
                    && (ManufacturerModelName.ToLower().Contains(GLOBALCONST.TPS_cashim.ToLower())
                    || ManufacturerModelName.ToLower().Contains(GLOBALCONST.TPS_phoenix.ToLower())))
                {
                    return ManufacturerModelType.Cashim;
                }
                else if (ManufacturerModelName.IsNotNullOrEmpty() && ManufacturerModelName.ToLower().Contains(GLOBALCONST.TPS_raystation.ToLower()))
                {
                    return ManufacturerModelType.Raystation;
                }
                else if (ManufacturerModelName.IsNullOrEmpty() && SoftwareVersions.IsNotNullOrEmpty() && SoftwareVersions.ToLower().Contains(GLOBALCONST.TPS_ciPlan.ToLower()))
                {
                    return ManufacturerModelType.CiPlan;
                }
                else
                {
                    return ManufacturerModelType.UNKNOWN;
                }
            }
        }
    }
    /// <summary>
    /// 计划类型
    /// </summary>
    public enum ManufacturerModelType
    {
        /// <summary>
        /// 未知
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// 国科离子
        /// </summary>
        Cashim,
        /// <summary>
        /// Raystation
        /// </summary>
        Raystation,
        /// <summary>
        /// ciPlan
        /// </summary>
        CiPlan
    }
    // ---------- (#196) Modified by zhang.pengchao 2023.06.05 End ----------
    // ---------- ChangeRequest(184) Added by WangYunXia 2022.4.24 End ----------
}