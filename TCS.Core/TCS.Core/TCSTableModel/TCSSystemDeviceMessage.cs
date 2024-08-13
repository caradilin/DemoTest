/************************************************************************************************
*	File Name			:	TCSSystemDeviceMessage.cs        					                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/06/05															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	TCSDB的表SystemDeviceMessage对应的数据类                       		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.06.05	HeDian		    新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.TCSTableModel
{
    public class TCSSystemDeviceMessage
    {
        public string MessageID { get; set; }

        public string Message { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}