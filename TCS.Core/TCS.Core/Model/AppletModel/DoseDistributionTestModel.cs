/************************************************************************************************
*	File Name			:	DoseDistributionTestModel.cs              	    	                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存剂量分配信息                               	    *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.Model.AppletModel
{
    public class DoseDistributionTestModel
    {
        public string PatientName { get; set; }
        public object PlvSerialNumberValue { get; set; }
        public string IsocenterXValue { get; set; }
        public string IsocenterYValue { get; set; }
        public string HitsValue { get; set; }
        public string XCurrentValueState { get; set; }
        public string VCurrentValueState { get; set; }
        public string EffectivePowerSupplyValue { get; set; }
        public string PositionXValue { get; set; }
        public string PositionYValue { get; set; }
        public string ElectricCurrentXValue { get; set; }
        public string ElectricCurrentY { get; set; }
        public string ActualCountStateValue { get; set; }
        public string ActualDoseValue { get; set; }
    }
}