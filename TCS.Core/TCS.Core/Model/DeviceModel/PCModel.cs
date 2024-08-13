/************************************************************************************************
*	File Name			:	PCModel.cs              	    	                                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存初级准直器设备信息                             	*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.Model.DeviceModel
{
    /// <summary>
    ///     初级准直器
    /// </summary>
    public class PCModel : DeviceModelBase
    {
        /// <summary>
        ///     水平设备类型(计划验证保留此项)
        /// </summary>
        public string XDeviceType { get; set; }

        /// <summary>
        ///     垂直设备类型(计划验证保留此项)
        /// </summary>
        public string YDeviceType { get; set; }

        /// <summary>
        ///     水平位置
        /// </summary>
        public string HorizontalPosition { get; set; }

        /// <summary>
        ///     垂直位置
        /// </summary>
        public string VerticalPosition { get; set; }
    }
}