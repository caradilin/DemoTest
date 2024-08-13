/************************************************************************************************
*	File Name			:	CPModel.cs              	    	                                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存补偿器设备信息                                  *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.Model.DeviceModel
{
    /// <summary>
    ///     补偿器
    /// </summary>
    public class CPModel : DeviceModelBase
    {
        /// <summary>
        ///     托架是否插入 1:插入 0未插入
        /// </summary>
        public int IsInsert { get; set; }

        /// <summary>
        ///     补偿器条码
        /// </summary>
        public string Code { get; set; }

        // ---------- 变更对应(212) Add by zhang.pengchao 2022.08.16 Start ----------
        /// <summary>
        ///     比较两个CPModel变量值是否相等(不是比较内存地址)
        /// </summary>
        /// <param name="cpmodel">被比较的CPModel</param>
        /// <returns>值都相当返回true 不等或者null返回false</returns>
        public bool ValueEquals(CPModel cpmodel)
        {
            if (cpmodel != null && cpmodel.IsInsert == IsInsert && cpmodel.Code == Code)
                return true;
            return false;
        }

        // ---------- 变更对应(212) Add by zhang.pengchao 2022.08.16 End ----------
    }
}