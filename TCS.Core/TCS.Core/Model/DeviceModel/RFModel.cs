/************************************************************************************************
*	File Name			:	RFModel.cs              	             	                        *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存脊型过滤器设备信息              	          	*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.Model.DeviceModel
{
    /// <summary>
    ///     脊形过滤器
    /// </summary>
    public class RFModel : DeviceModelBase
    {
        /// <summary>
        ///     标识Id
        /// </summary>
        public string Id { get; set; }
    }
}