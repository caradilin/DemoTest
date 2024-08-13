/************************************************************************************************
*	File Name			:	TCSDeviceInformation.cs              	    	                    *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存设备表的信息                                    *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.TCSTableModel
{
    /// <summary>
    ///     设备表
    /// </summary>
    public class TCSDeviceInformation
    {
        /// <summary>
        ///     设备ID
        /// </summary>
        public string DeviceID { get; set; }

        /// <summary>
        ///     设备名
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        ///     治疗室ID
        /// </summary>
        public string RoomID { get; set; }

        public string DeviceConnectionString { get; set; }

        /// <summary>
        ///     设备描述
        /// </summary>
        public string DeviceDescription { get; set; }

        /// <summary>
        ///     创建日
        /// </summary>
        public string CreateDate { get; set; }

        /// <summary>
        ///     创建日
        /// </summary>
        public string UpdateDate { get; set; }
    }
}