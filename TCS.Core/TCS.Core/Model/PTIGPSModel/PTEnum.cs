namespace TCS.Core.Model.PTIGPSModel
{
    public enum MessageType
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
    /// 配准结果状态
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
}