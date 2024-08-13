/************************************************************************************************
*	File Name			:	RSModel.cs              	    	                                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存射程移位器设备信息                           	*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.Model.DeviceModel
{
    /// <summary>
    ///     射程移位器
    /// </summary>
    public class RSModel : DeviceModelBase
    {
        /// <summary>
        ///     厚度
        /// </summary>
        public float Thickness { get; set; }

        public RSModel(float thickness)
        {
            Thickness = thickness;
        }
    }
}