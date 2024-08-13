/************************************************************************************************
*	File Name			:	TCSLog.cs              	    	                                    *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存操作日志数据的信息                              *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.TCSTableModel
{
    public class TCSLog
    {
        /// <summary>
        ///     构造函数
        /// </summary>
        /// <param name="log"></param>
        public TCSLog(string log, string user)
        {
            Log = log;
            OperationDateTime = DateTime.Now;
            Operator = user;
            Authorizer = string.Empty;
        }

        /// <summary>
        ///     操作具体内容日志
        /// </summary>
        public string Log { get; set; }

        /// <summary>
        ///     操作者
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        ///     操作日时（YYYY-MM-DD H24:MI:SS)
        /// </summary>
        public DateTime OperationDateTime { get; set; }

        /// <summary>
        ///     对操作授权的账号
        /// </summary>
        public string Authorizer { get; set; }
    }
}