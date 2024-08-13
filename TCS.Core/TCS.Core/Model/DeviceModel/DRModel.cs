/************************************************************************************************
*	File Name			:	DRModel.cs              	    	                                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存DR设备设备信息                               	*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using System.Collections.Generic;
using System.Linq;
using TCS.Core.Common;

namespace TCS.Core.Model.DeviceModel
{
    /// <summary>
    ///     DR设备
    /// </summary>
    public class DRModel : DeviceModelBase
    {
        /// <summary>
        ///     构造函数
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="drStatus">状态</param>
        public DRModel(TcsMode mode, DrStatus drStatus, List<DeviceParameter> paras)
        {
            if (mode == TcsMode.TreatmentMode)
            {
                MovingError = paras.Single(item => item.ParameterName == DeviceCONST.DR_MOVINGERROR).ParameterValue
                    .ToDouble();
                AngleError = paras.Single(item => item.ParameterName == DeviceCONST.DR_ANGLEERROR).ParameterValue
                    .ToDouble();
            }

            if (mode == TcsMode.TreatmentMode || mode == TcsMode.PhysicalMode) SetDr(drStatus, paras);
        }

        /// <summary>
        ///     Y轴
        /// </summary>
        public double AxisY { get; set; }

        /// <summary>
        ///     Z轴
        /// </summary>
        public double AxisZ { get; set; }

        /// <summary>
        ///     X轴
        /// </summary>
        public double AxisX { get; set; }

        /// <summary>
        ///     T轴
        /// </summary>
        public double AxisT { get; set; }

        /// <summary>
        ///     S轴
        /// </summary>
        public double AxisS { get; set; }

        /// <summary>
        ///     移动误差范围
        /// </summary>
        public double MovingError { get; set; }

        /// <summary>
        ///     角度误差范围
        /// </summary>
        public double AngleError { get; set; }

        public void SetDr(DrStatus drStatus, List<DeviceParameter> paras)
        {
            switch (drStatus)
            {
                case DrStatus.Reset0:
                    AxisX = paras.Single(item => item.ParameterName == DeviceCONST.DR_0RESETAXISX).ParameterValue
                        .ToDouble();
                    AxisY = paras.Single(item => item.ParameterName == DeviceCONST.DR_0RESETAXISY).ParameterValue
                        .ToDouble();
                    AxisZ = paras.Single(item => item.ParameterName == DeviceCONST.DR_0RESETAXISZ).ParameterValue
                        .ToDouble();
                    AxisT = paras.Single(item => item.ParameterName == DeviceCONST.DR_0RESETAXIST).ParameterValue
                        .ToDouble();
                    AxisS = paras.Single(item => item.ParameterName == DeviceCONST.DR_0RESETAXISS).ParameterValue
                        .ToDouble();
                    break;
                case DrStatus.H0:
                    AxisX = paras.Single(item => item.ParameterName == DeviceCONST.DR_0HSAXISX).ParameterValue
                        .ToDouble();
                    AxisY = paras.Single(item => item.ParameterName == DeviceCONST.DR_0HSAXISY).ParameterValue
                        .ToDouble();
                    AxisZ = paras.Single(item => item.ParameterName == DeviceCONST.DR_0HSAXISZ).ParameterValue
                        .ToDouble();
                    AxisT = paras.Single(item => item.ParameterName == DeviceCONST.DR_0HSAXIST).ParameterValue
                        .ToDouble();
                    AxisS = paras.Single(item => item.ParameterName == DeviceCONST.DR_0HSAXISS).ParameterValue
                        .ToDouble();
                    break;
                case DrStatus.V0:
                    AxisX = paras.Single(item => item.ParameterName == DeviceCONST.DR_0VSAXISX).ParameterValue
                        .ToDouble();
                    AxisY = paras.Single(item => item.ParameterName == DeviceCONST.DR_0VSAXISY).ParameterValue
                        .ToDouble();
                    AxisZ = paras.Single(item => item.ParameterName == DeviceCONST.DR_0VSAXISZ).ParameterValue
                        .ToDouble();
                    AxisT = paras.Single(item => item.ParameterName == DeviceCONST.DR_0VSAXIST).ParameterValue
                        .ToDouble();
                    AxisS = paras.Single(item => item.ParameterName == DeviceCONST.DR_0VSAXISS).ParameterValue
                        .ToDouble();
                    break;
                case DrStatus.Reset180:
                    AxisX = paras.Single(item => item.ParameterName == DeviceCONST.DR_180RESETAXISX).ParameterValue
                        .ToDouble();
                    AxisY = paras.Single(item => item.ParameterName == DeviceCONST.DR_180RESETAXISY).ParameterValue
                        .ToDouble();
                    AxisZ = paras.Single(item => item.ParameterName == DeviceCONST.DR_180RESETAXISZ).ParameterValue
                        .ToDouble();
                    AxisT = paras.Single(item => item.ParameterName == DeviceCONST.DR_180RESETAXIST).ParameterValue
                        .ToDouble();
                    AxisS = paras.Single(item => item.ParameterName == DeviceCONST.DR_180RESETAXISS).ParameterValue
                        .ToDouble();
                    break;
                case DrStatus.H180:
                    AxisX = paras.Single(item => item.ParameterName == DeviceCONST.DR_180HSAXISX).ParameterValue
                        .ToDouble();
                    AxisY = paras.Single(item => item.ParameterName == DeviceCONST.DR_180HSAXISY).ParameterValue
                        .ToDouble();
                    AxisZ = paras.Single(item => item.ParameterName == DeviceCONST.DR_180HSAXISZ).ParameterValue
                        .ToDouble();
                    AxisT = paras.Single(item => item.ParameterName == DeviceCONST.DR_180HSAXIST).ParameterValue
                        .ToDouble();
                    AxisS = paras.Single(item => item.ParameterName == DeviceCONST.DR_180HSAXISS).ParameterValue
                        .ToDouble();
                    break;
                case DrStatus.V180:
                    AxisX = paras.Single(item => item.ParameterName == DeviceCONST.DR_180VSAXISX).ParameterValue
                        .ToDouble();
                    AxisY = paras.Single(item => item.ParameterName == DeviceCONST.DR_180VSAXISY).ParameterValue
                        .ToDouble();
                    AxisZ = paras.Single(item => item.ParameterName == DeviceCONST.DR_180VSAXISZ).ParameterValue
                        .ToDouble();
                    AxisT = paras.Single(item => item.ParameterName == DeviceCONST.DR_180VSAXIST).ParameterValue
                        .ToDouble();
                    AxisS = paras.Single(item => item.ParameterName == DeviceCONST.DR_180VSAXISS).ParameterValue
                        .ToDouble();
                    break;
            }
        }
    }

    public enum DrStatus
    {
        /// <summary>
        ///     0复位
        /// </summary>
        Reset0,

        /// <summary>
        ///     0水平拍摄
        /// </summary>
        H0,

        /// <summary>
        ///     0垂直拍摄
        /// </summary>
        V0,

        /// <summary>
        ///     180复位
        /// </summary>
        Reset180,

        /// <summary>
        ///     180水平拍摄
        /// </summary>
        H180,

        /// <summary>
        ///     180垂直拍摄
        /// </summary>
        V180
    }
}