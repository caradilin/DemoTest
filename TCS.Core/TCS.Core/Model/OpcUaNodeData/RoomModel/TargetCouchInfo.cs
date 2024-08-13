/************************************************************************************************
*	File Name			:	TargetCouchInfo.cs  	            					                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2022/09/14															*
*   Author				:   Zhang.Pengchao 															*
*																								*
*   Description			:	治疗床目标位置信息                               *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2022/09/14	Zhang.Pengchao		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.Model.OpcUaNodeData.RoomModel
{
    /// <summary>
    ///     PPS治疗床位置信息
    /// </summary>
    public class TargetCouchInfo
    {
        /// <summary>
        ///     X轴移动值
        /// </summary>
        public double MoveX { get; set; }

        /// <summary>
        ///     Y轴移动值
        /// </summary>
        public double MoveY { get; set; }

        /// <summary>
        ///     Z轴移动值
        /// </summary>
        public double MoveZ { get; set; }

        /// <summary>
        ///     X轴旋转值
        /// </summary>
        public double RotateX { get; set; }

        /// <summary>
        ///     Y轴旋转值
        /// </summary>
        public double RotateY { get; set; }

        /// <summary>
        ///     Z轴旋转值
        /// </summary>
        public double RotateZ { get; set; }
    }
}