/************************************************************************************************
*	File Name			:	TCSDeviceSetting.cs              	    	                        *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存设备配置数据的信息                              *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.TCSTableModel
{
    public class TCSDeviceSetting
    {
        /// <summary>
        ///     配置ID
        /// </summary>
        public string SetID { get; set; }

        /// <summary>
        ///     设备ID
        /// </summary>
        public string DeviceID { get; set; }

        /// <summary>
        ///     配置者
        /// </summary>
        public string Configurer { get; set; }

        /// <summary>
        ///     授权者
        /// </summary>
        public string Authorizer { get; set; }

        /// <summary>
        ///     配置时间
        /// </summary>
        public string SettingDatetime { get; set; }

        /// <summary>
        ///     所属治疗头类型(H:水平;V:垂直;O:其它通用)
        /// </summary>
        public string TypeOfNozzleID { get; set; }
    }
}