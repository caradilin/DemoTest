/************************************************************************************************
*	File Name			:	BeamInfoData.cs              	    	                            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存补偿器信息                               	    *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using TCS.Core.TreatmentPlanDefinitions;

namespace TCS.Core.Model.OpcUaNodeData.RoomModel
{
    public class BeamInfoData
    {
        /// <summary>
        ///     补偿器区域的射野名
        /// </summary>
        public string BeamName { get; set; }

        /// <summary>
        ///     补偿器条码
        /// </summary>
        public string CpCode { get; set; }

        /// <summary>
        ///     补偿器区域的治疗头
        /// </summary>
        public string NozzleId { get; set; }


        public static BeamInfoData GetBeamInfoData(BeamPlanModel m)
        {
            var b = new BeamInfoData();
            b.BeamName = m.BeamName;
            b.CpCode = m.DeviceDataSet?.CPModel?.Code;
            b.NozzleId = m.Nozzle;
            //NozzleId = RoomSetting.RoomHeadNoList.Single(item =>
            //        item.RoomId == Tcs.TcsSetting.RoomNum && item.HeadId.Contains(TreatmentData.CurrentBeamPlanModel.DeviceDataSet.TreatmentHeadName)).HeadNum
            //    .ToString();
            return b;
        }
    }
}