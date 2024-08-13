using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.Core.Model.HGHPositionModel
{
    internal class HGHEnum
    {
    }

    /// <summary>
    /// 订阅/移除治疗床位置信息的位置
    /// </summary>
    public enum PPS_INFO_ATTACH
    {
        // 杭州摆位画面
        Position = 0,
        // 回上床位
        StartBedPos,
        // 小程序-治疗床
        AppletCouch
    }
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
}
