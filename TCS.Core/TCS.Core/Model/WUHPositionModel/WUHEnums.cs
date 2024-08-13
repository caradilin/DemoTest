using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.Core.Model.WUHPositionModel
{
    /// <summary>
    /// 消息类型枚举(CT)
    /// </summary>
    public enum CTMsgType
    {
        /// <summary>
        /// 未知类型
        /// </summary>
        Unknown,

        /// <summary>
        /// IGRT-->TCS：建立连接
        /// </summary>
        Connect,

        /// <summary>
        /// TCS-->IGRT：建立连接成功
        /// </summary>
        ConnectSucceed,

        /// <summary>
        /// TCS-->IGRT：查询IGRT状态
        /// </summary>
        GetIGRTStatus,

        /// <summary>
        /// IGRT-->TCS：IGRT返回状态
        /// </summary>
        PartsStatusInfo,

        /// <summary>
        /// TCS-->IGRT：发送定位请求
        /// </summary>
        IGRTRequest,

        /// <summary>
        /// IGRT-->TCS：收到定位请求
        /// </summary>
        IGRTRequestReady,

        /// <summary>
        /// TCS-->IGRT：发送患者信息，加载定位计划
        /// </summary>
        IGRTLoadPlan,

        /// <summary>
        /// 定位计划加载中（IGRT内部使用?）
        /// </summary>
        IGRTPlanLoading,

        /// <summary>
        /// IGRT-->TCS：定位计划已经加载
        /// </summary>
        IGRTPlanLoaded,

        /// <summary>
        /// TCS-->IGRT：通知IGRT消息
        /// </summary>
        TCSMessageInfo,

        /// <summary>
        /// IGRT-->TCS：发送定位模式和定位角度
        /// </summary>
        IGRTPositionMode,

        /// <summary>
        /// TCS-->IGRT：发送定位就绪
        /// </summary>
        TCSPositionReady,

        /// <summary>
        /// IGRT-->TCS：发送配准结果
        /// </summary>
        IGRTPositionResult,

        /// <summary>
        /// TCS-->IGRT：发送收到定位结果
        /// </summary>
        TCSPositionResult_FB,

        /// <summary>
        /// IGRT-->TCS：发送检查收到的定位结果
        /// </summary>
        IGRTPositionResult_FB,

        /// <summary>
        /// TCS-->IGRT：发送移床已完成
        /// </summary>
        MoveCouchComplete,

        /// <summary>
        /// IGRT-->TCS：发送接收到治疗床已经完成的反馈
        /// </summary>
        IGRTPositionReady,

        // ---------- 2021.02.02 Added by hedian start ----------
        /// <summary>
        /// TCS-->IGRT：发送透视命令
        /// </summary>
        RequestDynamicImaging,

        /// <summary>
        /// IGRT-->TCS：发送停止透视
        /// </summary>
        StopDynamicImaging,
        // ---------- 2021.02.02 Added by hedian start ----------

        /// <summary>
        /// IGRT-->TCS：发送IGRT异常
        /// </summary>
        IGRTError,

        /// <summary>
        /// TCS-->IGRT：发送TCS异常
        /// </summary>
        TCSError

    };

    /// <summary>
    /// 消息类型枚举(DR)
    /// </summary>
    public enum DRMsgType
    {
        /// <summary>
        /// 加载计划(TCS->IGPS)
        /// </summary>
        LoadPlan = 0,

        /// <summary>
        /// 加载计划反馈(IGPS->TCS)
        /// </summary>
        LoadPlan_FB,

        /// <summary>
        /// 定位请求(TCS->IGPS)
        /// </summary>
        PositionRequest,

        /// <summary>
        /// 定位请求反馈(IGPS->TCS)
        /// </summary>
        PositionRequest_FB,

        /// <summary>
        /// 定位结果(IGPS->TCS)
        /// </summary>
        PositionResult,

        /// <summary>
        /// 定位结果反馈(TCS->IGPS)
        /// </summary>
        PositionResult_FB,

        /// <summary>
        /// 定位完成(IGPS->TCS)
        /// </summary>
        PositionComplete,

        /// <summary>
        /// 定位完成反馈(TCS->IGPS)
        /// </summary>
        PositionComplete_FB,

        /// <summary>
        /// 定位取消(IGPS->TCS)
        /// </summary>
        PositionCancel,

        /// <summary>
        /// 定位取消反馈(TCS->IGPS)
        /// </summary>
        PositionCancel_FB,

        /// <summary>
        /// 未知（初始化默认值）
        /// </summary>
        Unknown

    }

    /// <summary>
    /// DR 配准结果（验证用）
    /// </summary>
    public enum GeoreferencingResult
    {
        /// <summary>
        /// 正常 <10
        /// </summary>
        Normal,

        /// <summary>
        /// 警告 >=10 && <15
        /// </summary>
        Warn,

        /// <summary>
        /// 异常 >=15
        /// </summary>
        Abnormal
    }

    /// <summary>
    /// WUH用的射野类型
    /// </summary>
    public enum WUHBeamType
    {
        /// <summary>
        /// 未知射野
        /// </summary>
        N,

        /// <summary>
        /// 左射野
        /// </summary>
        L,

        /// <summary>
        /// 头射野(垂直射野)
        /// </summary>
        H,

        /// <summary>
        /// 右射野
        /// </summary>
        R
    }
}
