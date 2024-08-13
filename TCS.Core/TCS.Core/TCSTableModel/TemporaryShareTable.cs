/************************************************************************************************
*	File Name			:	TemporaryShareTable.cs             			            	        *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2022/01/21														    *
*   Author				:	Wang.Yunxia 												     	*
*																								*
*   Description			:	数据存储类，用于保存治疗报告的信息                        		    *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2022.01.21	Wang.Yunxia 	  新规作成								     	*
*																								*
*************************************************************************************************/

namespace TCS.Core.TCSTableModel
{
    /// <summary>
    ///     用于保存治疗报告的信息
    /// </summary>
    public class TemporaryShareTable
    {
        /// <summary>
        ///     表自增长字段
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        ///     保存射野数据
        /// </summary>
        public string Data1 { get; set; }

        /// <summary>
        ///     保存层或者其它数据
        /// </summary>
        public string Data2 { get; set; }

        /// <summary>
        ///     计划ID
        /// </summary>
        public string Key1 { get; set; }
    }
}