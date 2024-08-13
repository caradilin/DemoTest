/************************************************************************************************
*	File Name			:	CouchModel.cs              	    	                                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存治疗床设备信息                               	*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.Model.DeviceModel
{
    /// <summary>
    ///     治疗床
    /// </summary>
    public class CouchModel : DeviceModelBase
    {
        // ---------- Added by hedian 2020.09.26 start ----------
        public CouchModel()
        {
            IsocenterRotateAngle = 0d;
            AxisZRotateAngle = 0d;
            AxisX = 0d;
            AxisY = 0d;
            AxisZ = 0d;
        }

        /// <summary>
        /// 设置等中心以外的其他值
        /// </summary>
        /// <param name="couchModel"></param>
        public void SetValueExceptIsocenter(CouchModel couchModel)
        {
            this.AxisX = couchModel.AxisX;
            this.AxisZ = couchModel.AxisZ;
            this.AxisY = couchModel.AxisY;
            this.AxisZRotateAngle = couchModel.AxisZRotateAngle;
        }
        /// <summary>
        ///     等中心旋转角度
        /// </summary>
        public double IsocenterRotateAngle { get; set; }

        /// <summary>
        ///     Z轴旋转角度
        /// </summary>
        public double AxisZRotateAngle { get; set; }

        /// <summary>
        ///     X轴
        /// </summary>
        public double AxisX { get; set; }

        /// <summary>
        ///     Y轴
        /// </summary>
        public double AxisY { get; set; }

        /// <summary>
        ///     Z轴
        /// </summary>
        public double AxisZ { get; set; }

        // ---------- Added by hedian 2020.09.26 end ----------
    }
}