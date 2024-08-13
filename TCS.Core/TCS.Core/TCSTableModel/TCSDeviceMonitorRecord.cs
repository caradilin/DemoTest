/************************************************************************************************
*	File Name			:	TCSDeviceMonitorRecord.cs              	    	                    *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存设备监控记录表的信息                            *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.TCSTableModel
{
    public class TCSDeviceMonitorRecord
    {
        /// <summary>
        ///     监控ID
        /// </summary>
        public int DMRID { get; set; }

        /// <summary>
        ///     治疗ID
        /// </summary>
        public string TreatmentID { get; set; }

        /// <summary>
        ///     设备ID
        /// </summary>
        public string DeviceID { get; set; }

        /// <summary>
        ///     设备状态
        /// </summary>
        public string DeviceStatus { get; set; }

        /// <summary>
        ///     设备数据
        /// </summary>
        public string DeviceData { get; set; }

        /// <summary>
        ///     消息码	字符型
        /// </summary>
        public string MessageID { get; set; }

        /// <summary>
        ///     发生时间
        /// </summary>
        public DateTime OccurrenceDate { get; set; }

        /// <summary>
        ///     创建日
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///     更新日
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}