/************************************************************************************************
*	File Name			:	TCSMessage.cs              	    	                                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存通用对话框消息信息                              *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.TCSTableModel
{
    public class TCSMessage
    {
        /// <summary>
        ///     构造函数
        /// </summary>
        /// <param name="message"></param>
        public TCSMessage(string message)
        {
            Message = message;
            CreateDate = DateTime.Now;
        }

        /// <summary>
        ///     消息类型：I(正常)/W(警告)/E(错误)
        /// </summary>
        public string MessageType { get; set; }

        /// <summary>
        ///     消息内容
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     创建日
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}