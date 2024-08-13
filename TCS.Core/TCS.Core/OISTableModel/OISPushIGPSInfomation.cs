/************************************************************************************************
*	File Name			:	OISPushIGPSInfomation.cs              							    *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2021/06/154															*
*   Author				:	Fei.Jinqiu 															*
*																								*
*   Description			:	OISDB的表OISPushIGPSInfomation对应的数据类                          *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2021.06.15	Fei.Jinqiu		    新规作成									*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.OISTableModel
{
    public class OISPushIGPSInfomation
    {
        /// <summary>
        ///     治疗计划ID
        /// </summary>
        public string TreatmentPlanID { get; set; }

        /// <summary>
        ///     发送数据
        /// </summary>
        public string PushData { get; set; }

        /// <summary>
        ///     创建时间
        /// </summary>
        public DateTime CreatDate { get; set; }

        /// <summary>
        ///     更新时间
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }

    public class PushData
    {
        /// <summary>
        ///     发送时间
        /// </summary>
        public string PushTime { get; set; }

        /// <summary>
        ///     授权者
        /// </summary>
        public string PushDoctor { get; set; }
    }
}