/************************************************************************************************
*	File Name			:	DoseDistributionTestModel.cs              	    	                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存均匀扫描剂量分配信息                            *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.Model.AppletModel
{
    public class UniformScanningDoseDistributionTestModel
    {
        public string PlvSerialNumberValue { get; set; }
        public string HitsValue { get; set; }
        public string ActualDoseUnitValue { get; set; }
        public string TrueCountValue { get; set; }
        public string PresetDoseGyValue { get; set; }
        public string ActualCountMUValue { get; set; }
        public string ActualDoseGyValue { get; set; }
    }
}