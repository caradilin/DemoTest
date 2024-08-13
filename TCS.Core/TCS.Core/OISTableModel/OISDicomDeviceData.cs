/************************************************************************************************
*	File Name			:	OISDicomDeviceData.cs              						            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/06/04															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	OISDB的表DicomDeviceData对应的数据类                           		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.06.04	HeDian		    新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.OISTableModel
{
    public class OISDicomDeviceData
    {
        /// <summary>
        ///     射野ID
        /// </summary>
        public string BeamID { get; set; }

        /// <summary>
        ///     射野涉及的设备数据(Json字符串)
        /// </summary>
        public string DeviceData { get; set; }

        /// <summary>
        ///     创建日时
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///     更新日时
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}