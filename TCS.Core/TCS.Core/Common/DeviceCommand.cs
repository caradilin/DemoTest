/************************************************************************************************
*	File Name			:	DeviceCommand.cs              	    	                            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	封装了共通的常量，枚举等定义                                    	*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.Common
{
    #region 设备交互命令

    /// <summary>
    ///     DDS交互命令
    /// </summary>
    public enum DDS_ControlCommand
    {
        DDS_IdleCMD = 1, // 1.DDS处于空闲状态                    DDS                   
        DDS_UrgentStopCMD = 2, // 2.紧急停止							DDS
        DDS_ENDBEAM = 9999, // 错误信息                             DDS
        DDS_STOPBYTCP = 9998, // TCP紧急停止、待机、断开连接          DDS
        DDS_STOPBYDEVICEMOVVING = 9997, // 设备移位                             DDS

        TCS_TestStartCMD = 101, // 101.开始标定测试					    TCS	
        DDS_TestReadyOKCMD = 102, // 102.DDS一切正常，可以开始标定测试    DDS
        TCS_TestDataOKCMD = 103, // 103.TCS写DDSData数据完成             TCS
        DDS_TestValidateOKCMD = 104, // 104.DDS验证标定测试数据正常			DDS
        TCS_TestLoadDataCMD = 105, // 105.开始加载DDS数据					TCS
        DDS_TestLoadCompleteCMD = 106, // 106.DDS数据加载完成                  DDS
        TCS_TestLoadPowerDataCMD = 107, // 107.开始加载电源数据				    TCS
        DDS_TestPowerDataCompleteCMD = 108, // 108.电源数据加载完成				    DDS
        DDS_TestApplyBeamCMD = 109, // 109.开始申请束流                     TCS
        TCS_TestBeamReadyOKCMD = 110, // 110.束流准备OK						TCS
        DDS_TestBeamStartCMD = 111, // 111.开始出束						    DDS
        DDS_TestStartMonitorCMD = 112, // 112.开始监测剂量配送				    DDS
        DDS_TestPresetDoseOKCMD = 113, // 113.预设剂量到                       DDS
        DDS_TestPresetTimeOKCMD = 114, // 114.预设剂量到                       DDS
        TCS_TestCompleteCMD = 115, // 115.本次测试结束					    TCS

        TCS_TreatStartCMD = 201, // 201.开始治疗						    TCS
        DDS_TreatReadyOKCMD = 202, // 202.DDS一切正常，可以开始治疗		DDS
        TCS_TreatDataOKCMD = 203, // 203.TCS写DDSData数据完成			    TCS
        DDS_TreatValidateOKCMD = 204, // 204.DDS验证治疗数据正常              DDS
        TCS_TreatLoadDataCMD = 205, // 205.开始加载DDS数据                  TCS
        DDS_TreatLoadCompleteCMD = 206, // 206.DDS数据加载完成                  DDS
        TCS_TreatLoadPowerDataCMD = 207, // 207.开始加载电源数据				    TCS
        DDS_TreatPowerDataCompleteCMD = 208, // 208.电源数据加载完成				    DDS
        DDS_TreatApplyBeamCMD = 209, // 209.开始申请束流					    DDS
        TCS_TreatBeamReadyOKCMD = 210, // 210.束流准备OK						TCS
        DDS_TreatBeamStartCMD = 211, // 211.开始出束						    DDS
        DDS_TreatStartMonitorCMD = 212, // 212.开始监测剂量配送				    DDS
        DDS_TreatPresetDoseOKCMD = 213, // 213.预设剂量到                       DDS
        DDS_TreatPresetTimeOKCMD = 214, // 214.预设剂量到                       DDS
        DDS_TreatCompleteCMD = 215, // 215.本次治疗结束                     DDS

        /// 小程序剂量配送测试使用
        TCS_CalibrationStartCMD = 301, // 301.开始位置标定						TCS
        DDS_CalibrationReadyOKCMD = 302, // 302.位置标定返回OK					DDS
        TCS_CalibrationWriteDataCMD = 303, // 303.TCS写DDSData数据        			TCS
        DDS_CalibrationReceivedDataCMD = 304, // 304.DDS收到数据					    DDS
        TCS_CalibrationLoadDataCMD = 305, // 305.开始加载数据					    TCS
        DDS_CalibrationLoadCompleteCMD = 306, // 306.加载完成					        DDS
        TCS_CalibrationLoadPowerDataCMD = 307, // 307.开始加载电源数据				    TCS
        DDS_CalibrationPowerDataCompleteCMD = 308, // 308.电源数据加载完成				    DDS
        DDS_CalibrationmonitorCMD = 309, // 309.开始申请束流					    DDS
        DDS_CalibrationBeamReadyOKCMD = 310, // 310.束流准备OK						TCS
        DDS_CalibrationBeamStartCMD = 311, // 311.开始出束					DDS
        DDS_CalibrationStartMonitorCMD = 312, // 312.开始监测剂量配送			DDS
        DDS_CalibrationPresetDoseOKCMD = 313, // 313.预设剂量到                 DDS
        DDS_CalibrationPresetTimeOKCMD = 314, // 314.预设剂量到                 DDS
        DDS_CalibrationCompleteCMD = 315 // 315.本次申请束流结束               DDS
    }

    /// <summary>
    ///     DR交互命令
    /// </summary>
    public enum DR_MoveCommand
    {
        IdleCMD = 1, // 1.DR处于空闲状态
        StopCMD = 2, // 2.停止运动
        Error = 9999,
        MoveTo0AngleRCMD = 11, // 11.移动到0度复位位置               TCS->DR
        MoveTo0AngleRCompleteCMD = 12, // 12.移动到0度复位位置完成           DR->TCS
        MoveTo0AngleHSCMD = 21, // 21.移动到0度水平拍摄位置           TCS->DR
        MoveTo0AngleHSCompleteCMD = 22, // 22.移动到0度水平拍摄位置完成		  DR->TCS
        MoveTo0AngleVSCMD = 31, // 31.移动到0度垂直拍摄位置           TCS->DR
        MoveTo0AngleVSCompleteCMD = 32, // 32.移动到0度垂直拍摄位置完成       DR->TCS

        MoveTo180AngleRCMD = 41, // 41.移动到180度复位位置			  TCS->DR
        MoveTo180AngleRCompleteCMD = 42, // 42.移动到180度复位位置完成		  DR->TCS
        MoveTo180AngleHSCMD = 51, // 51.移动到180度水平拍摄位置		  TCS->DR
        MoveTo180AngleHSCompleteCMD = 52, // 52.移动到180度水平拍摄位置完成	  DR->TCS
        MoveTo180AngleVSCMD = 61, // 61.移动到180度垂直拍摄位置		  TCS->DR
        MoveTo180AngleVSCompleteCMD = 62 // 62.移动到180度垂直拍摄位置完成	  DR->TCS
    }

    /// <summary>
    ///     BMS_RF交互命令
    /// </summary>
    public enum BMS_RF_MoveCommand
    {
        IdleCMD = 1, // 1.RF处于空闲状态
        StopCMD = 2, // 2.停止运动
        Error = 9999,

        MoveToTargetCMD = 11, // 11.运动到TargetPosition位置		  TCS->RF
        MoveToTargetCompleteCMD = 12 // 12.运动到TargetPosition位置完成	  RF->TCS
    }

    /// <summary>
    ///     BMS_RS交互命令
    /// </summary>
    public enum BMS_RS_MoveCommand
    {
        IdleCMD = 1, // 1.RS处于空闲状态
        StopCMD = 2, // 2.停止运动
        Error = 9999,

        MoveToTargetCMD = 11, // 11.运动到TargetPosition位置		  TCS->RF
        MoveToTargetCompleteCMD = 12 // 12.运动到TargetPosition位置完成	  RF->TCS
    }

    /// <summary>
    ///     BMS_PC交互命令
    /// </summary>
    public enum BMS_PC_MoveCommand
    {
        IdleCMD = 1, // 1.PC处于空闲状态
        StopCMD = 2, // 2.停止运动
        Error = 9999,

        MoveToTargetCMD = 11, // 11.运动到TargetPosition位置		  TCS->pc
        MoveToTargetCompleteCMD = 12 // 12.运动到TargetPosition位置完成	  pc->TCS
    }

    /// <summary>
    ///     Couch交互命令
    /// </summary>
    public enum Couch_MoveCommand
    {
        IdleCMD = 1, // 1.Couch处于空闲状态

        Error = 9999,

        MoveToTargetCMD = 2, // 11.运动到TargetPosition位置		  TCS->Couch
        MoveToTargetCompleteCMD = 3 // 12.运动到TargetPosition位置完成	  Couch->TCS
    }

    /// <summary>
    ///     光栅控制命令枚举定义
    /// </summary>
    public enum MLC_ControlCommand
    {
        /// <summary>
        ///     空闲
        /// </summary>
        MLC_IdleCMD = 1,

        /// <summary>
        ///     错误
        /// </summary>
        Error = 9999,

        /// <summary>
        ///     初始化命令
        /// </summary>
        TCS_InitilizeCMD = 10,

        /// <summary>
        ///     初始化开始
        /// </summary>
        MLC_InitilizeStartCMD = 11,

        /// <summary>
        ///     初始化正常完成
        /// </summary>
        MLC_InitilizeOKCMD = 12,

        /// <summary>
        ///     后退命令
        /// </summary>
        TCS_BackawayCMD = 20,

        /// <summary>
        ///     后退开始
        /// </summary>
        MLC_BackawayStartCMD = 21,

        /// <summary>
        ///     后退正常完成
        /// </summary>
        MLC_BackawayOKCMD = 22,

        /// <summary>
        ///     闭合命令
        /// </summary>
        TCS_CloseCMD = 30,

        /// <summary>
        ///     闭合开始
        /// </summary>
        MLC_CloseStartCMD = 31,

        /// <summary>
        ///     闭合正常完成
        /// </summary>
        MLC_CloseOKCMD = 32,

        /// <summary>
        ///     射野走位命令
        /// </summary>
        TCS_MoveCMD = 40,

        /// <summary>
        ///     射野走位开始
        /// </summary>
        MLC_MoveStartCMD = 41,

        /// <summary>
        ///     射野走位正常完成
        /// </summary>
        MLC_MoveOKCMD = 42,

        /// <summary>
        ///     机头旋转命令
        /// </summary>
        TCS_RotateCMD = 50,

        /// <summary>
        ///     机头旋转开始
        /// </summary>
        MLC_RotateStartCMD = 51,

        /// <summary>
        ///     机头旋转正常完成
        /// </summary>
        MLC_RotateOKCMD = 52,

        /// <summary>
        ///     命令处理失败
        /// </summary>
        MLC_FailedCMD = 9999
    }

    /// <summary>
    ///     ITS控制交互命令
    /// </summary>
    public enum ITS_ControlCommand
    {
        ITS_IdleCMD = 1, // 1.ITS处于空闲状态					ITS
        ITS_StopCMD = 2, // 2.紧急停止                           ITS

        /// <summary>
        ///     错误
        /// </summary>
        Error = 9999,
        TCS_StartTestCMD = 301, // 301.开始标定测试                     TCS
        ITS_ReadyOKCMD = 302, // 302.ITS一切正常，可以开始标定测试    ITS
        TCS_DataOKCMD = 303, // 303.TCS写ITS数据完成				    TCS
        ITS_ValidateOKCMD = 304, // 304.ITS验证标定测试数据正常			ITS
        TCS_StartLoadCMD = 305, // 305.开始加载ITS数据					TCS
        ITS_LoadCompleteCMD = 306, // 306.ITS数据加载完成					ITS
        TCS_StartMonitorCMD = 307, // 307.开始监测剂量                     TCS
        TCS_MonitorDoseCMD = 308, // 308.监测剂量中                       ITS
        ITS_PresetDoseOKCMD = 309, // 309.预设剂量到                       ITS
        DDS_PresetDoseOKCMD = 310, // 310.DDS预设剂量到，ITS停止监测		DDS
        TCS_TreatCompleteCMD = 311 // 311.本次治疗监测结束                 TCS
    }

    /// <summary>
    ///     ITS终止交互命令
    /// </summary>
    public enum ITS_StopMonitor
    {
        DDS_StopMonitorCMD = 1, // 1.停止监测							DDS
        ITS_StopOKCMD = 2, // 2.停止成功							ITS
        ITS_StopNGCMD = 3 // 3.停止失败							ITS
    }

    #endregion
}