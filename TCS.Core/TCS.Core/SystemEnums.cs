using System.ComponentModel;

namespace TCS.Core
{
    public enum RoomMonitoringUiType
    {
        Button,   //显示按钮
        Icon,     //图标轮转
        Default  //不启用
    }
    public enum TCPWaitEvent
    {
        /// <summary>
        /// 等待按下开始治疗按钮
        /// </summary>
        WaitInterlockValid = 0,
        /// <summary>
        /// 等待取消紧急停止
        /// </summary>
        CancelEmergencyStop,
        /// <summary>
        /// 等待取消待机
        /// </summary>
        CancelStandby,
        /// <summary>
        /// 等待连接TCP
        /// </summary>
        WaitConnectTcp,
        /// <summary>
        /// 等待使能
        /// </summary>
        WaitingToEnable,

        /// <summary>
        /// 束流排队
        /// </summary>
        BeamQueuing
    }
    /// <summary>
    /// TCS按钮的状态
    /// </summary>
    public enum TCPButtonSatus
    {
        /// <summary>
        /// 0.空闲状态
        /// </summary>
        Idle = 0,

        /// <summary>
        /// 1.紧急停止
        /// </summary>
        EmergencyStop = 1,

        /// <summary>
        /// 2.初始化（准备状态）
        /// </summary>
        Initialization = 2,

        /// <summary>
        /// 3.自动定位（变更：3-->10)
        /// </summary>
        AutoLocation = 10,

        /// <summary>
        /// 4.治疗运动床使能（变更：4-->12)
        /// </summary>
        PositionVerificationDR = 12,

        /// <summary>
        /// 5.定位验证1
        /// </summary>
        PositionVerificationCouch = 5,

        /// <summary>
        /// 6.DR运动使能
        /// </summary>
        DRMoveIsVaild = 6,

        /// <summary>
        /// 7.开始治疗
        /// </summary>
        InterlockValid = 7,

        /// <summary>
        /// 8.暂停/恢复
        /// </summary>
        PauseOrRestart = 8,

        /// <summary>
        /// 34按钮同时按下
        /// </summary>
        Btn34Press = 22,

        /// <summary>
        /// 56按钮同时按下
        /// </summary>
        Btn56Press = 11

    }

    /// <summary>
    /// TCP节点(SetTCPCmd)的取值范围枚举
    /// </summary>
    public enum SetTCPCmd
    {
        /// <summary>
        /// 设置51线
        /// </summary>
        Line51 = 1,

        /// <summary>
        /// 设置52线
        /// </summary>
        Line52 = 2,

        /// <summary>
        /// 设置53线
        /// </summary>
        Line53 = 3,

        /// <summary>
        /// 设置54线
        /// </summary>
        Line54 = 4,

        /// <summary>
        /// 设置55线
        /// </summary>
        Line55 = 5,

        /// <summary>
        /// 设置空闲状态
        /// </summary>
        Idle = 6,

        /// <summary>
        /// 设置预置状态
        /// </summary>
        Preset = 7,

        /// <summary>
        /// 设置准备状态
        /// </summary>
        Ready = 8,

        /// <summary>
        /// 设置定位状态
        /// </summary>
        Location = 9,

        /// <summary>
        /// 设置定位验证1状态
        /// </summary>
        LocationValidateState1 = 10,

        /// <summary>
        /// 设置定位验证2状态
        /// </summary>
        LocationValidateState2 = 11,

        /// <summary>
        /// 设置治疗头有效
        /// </summary>
        NozzleEffective = 12,

        /// <summary>
        /// ITS初始化
        /// </summary>
        ITSInitilize = 13,

        /// <summary>
        /// 层治疗结束
        /// </summary>
        LayerTreatFinish = 14,

        /// <summary>
        /// 全部治疗结束
        /// </summary>
        AllLayerTreatFinish = 15,

        /// <summary>
        /// 暂停
        /// </summary>
        Pause = 16,

        /// <summary>
        /// 恢复
        /// </summary>
        Recovery = 17,

        /// <summary>
        /// 设置ITS预设值
        /// </summary>
        ITSPreset = 18,

        /// <summary>
        /// 设置ITS实际值
        /// </summary>
        ITSActual = 19,

        /// <summary>
        /// 设置56线 
        /// </summary>
        Line56 = 56,

        /// <summary>
        /// 设置完成
        /// </summary>
        Finish = 99
    }

    /// <summary>
    /// TCP节点(GetTCPCmd)的取值范围枚举
    /// </summary>
    public enum GetTCPCmd
    {
        /// <summary>
        /// TCP打开串口成功
        /// </summary>
        Open = 100,

        /// <summary>
        /// 51线设置成功
        /// </summary>
        Line51 = 101,

        /// <summary>
        /// 52线设置成功
        /// </summary>
        Line52 = 102,

        /// <summary>
        /// 53线设置成功
        /// </summary>
        Line53 = 103,

        /// <summary>
        /// 54线设置成功
        /// </summary>
        Line54 = 104,

        /// <summary>
        /// 55线设置成功
        /// </summary>
        Line55 = 105,

        /// <summary>
        /// 设置空闲状态成功
        /// </summary>
        Idle = 106,

        /// <summary>
        /// 设置预置状态成功
        /// </summary>
        Preset = 107,

        /// <summary>
        /// 设置准备状态成功
        /// </summary>
        Ready = 108,

        /// <summary>
        /// 设置定位状态成功
        /// </summary>
        Location = 109,

        /// <summary>
        /// 设置定位验证1状态成功
        /// </summary>
        LocationValidateState1 = 110,

        /// <summary>
        /// 设置定位验证2状态成功
        /// </summary>
        LocationValidateState2 = 111,

        /// <summary>
        /// 设置治疗头有效成功
        /// </summary>
        NozzleEffective = 112,

        /// <summary>
        /// ITS初始化成功
        /// </summary>
        ITSInitilize = 113,

        /// <summary>
        /// 层治疗结束成功
        /// </summary>
        LayerTreatFinish = 114,

        /// <summary>
        /// 全部治疗结束成功
        /// </summary>
        AllLayerTreatFinish = 115,

        /// <summary>
        /// 暂停成功
        /// </summary>
        Pause = 116,

        /// <summary>
        /// 恢复成功
        /// </summary>
        Recovery = 117,

        /// <summary>
        /// 设置ITS预设值成功
        /// </summary>
        ITSPreset = 118,

        /// <summary>
        /// 设置ITS实际值成功
        /// </summary>
        ITSActual = 119,

        /// <summary>
        /// TCP关闭
        /// </summary>
        Close = 999

    }
    public enum Region
    {
        LZ,//兰州
        HGH,//杭州
        WW,//武威
        DGM,//东莞
        PT,//莆田
        WUH,//武汉
        CLAPA,//北大激光等离子体加速器
    }


    public enum ControlProtocol
    {
        Modbus,
        OpcUa,
        OAM,
    }

    /// <summary>
    /// 设备类型枚举（仅用于标识设备控制协议）
    /// </summary>
    public enum DeviceCategory
    {
        DCCT,
        TBMS,
        ACS,
        EVS,
        MIOR,
        SIP,
        SQP,
        IGPS,
        MI,
        BMS,
        RS,
        RF,
        CP,
        TCP,
        ROOM,
        DDS,
        ITS,
        MLC,
        TreatmentHall,
        PPS,
        DR,
        CT,
        Room
    }
    public enum DeviceType
    {
        EVS,
        TBMS,
        MIOR_OR1,
        MIOR_OR2,
        DCCT,
        SIP,

        /// <summary>
        ///     快Q铁
        /// </summary>
        SQP, // Added by hedian 2021.06.03

        DR,
        CT,
        PPS,
        COUCH,
        MI_CIRCLE,
        MI_CIRCLE_HW,
        MI_CIRCLE_SW,
        BMS_PC,
        BMS_CP,
        BMS_RF,
        BMS_RS,
        BMS_SC,

        //TCP,
        DDS,
        ITS,
        MLC,
        IGPS,
        ROOM
    }

    public enum MonitorSource
    {
        STATUS,
        HEARTBEAT
    }

    public enum TcsRemoteStatus
    {
        RemoteClose,
        RemoteOpen
    }

    /// <summary>
    ///     治疗模式
    /// </summary>
    public enum TcsMode
    {
        /// <summary>
        ///     治疗模式
        /// </summary>
        TreatmentMode,

        /// <summary>
        ///     物理模式
        /// </summary>
        PhysicalMode,

        /// <summary>
        ///     运维模式
        /// </summary>
        ServiceMode,

        /// <summary>
        ///     OIS
        /// </summary>
        OISMode,

        /// <summary>
        ///     用户管理
        /// </summary>
        UserManageMode
    }

    /// <summary>
    ///     Tcs当前治疗状态
    /// </summary>
    public enum TcsStatus
    {
        /// <summary>
        ///     处于空闲状态
        /// </summary>
        Idle,

        /// <summary>
        ///     处于射野确认状态
        /// </summary>
        BeamConfirm,

        /// <summary>
        ///     设备移动中
        /// </summary>
        DeviceMoving,

        /// <summary>
        ///     患者部分确认中
        /// </summary>
        PatientSiteConfirm,

        /// <summary>
        ///     图像引导
        /// </summary>
        ImGuide,

        /// <summary>
        ///     等待治疗中
        /// </summary>
        WaitTreating,

        /// <summary>
        ///     等待申请束流
        /// </summary>
        WaitApplyBeam,

        /// <summary>
        ///     DDS申请失败
        /// </summary>
        DDSApplyFailure,

        /// <summary>
        ///     DDS工作中
        /// </summary>
        DDSWorking,

        /// <summary>
        ///     DDS立即停止
        /// </summary>
        DDSEmergencyStop,

        /// <summary>
        ///     DDS超时
        /// </summary>
        DDSTimeOut,

        /// <summary>
        ///     报告中
        /// </summary>
        Report,

        // ---------- BugList(87) Add by WangYunXia 2022.3.16 Start ----------
        /// <summary>
        ///     TCS紧急停止
        /// </summary>
        TCPEmergencyStop

        // ---------- BugList(87) Add by WangYunXia 2022.3.16 End ----------
    }

    public enum BeamTypes
    {
        /// <summary>
        ///     均匀扫描单层
        /// </summary>
        Ttyp_2D = 0,

        /// <summary>
        ///     均匀扫描多层
        /// </summary>
        Ttyp_2DLS,

        // ----------(changerequest260) Added by WangYunxia 2022.11.18 start ----------
        /// <summary>
        ///     均匀扫描多层(CASHIM,Raystation)
        /// </summary>
        Ttyp_3DLS,

        // ----------(changerequest260) Added by WangYunxia 2022.11.18 start ----------
        /// <summary>
        ///     点扫描多层
        /// </summary>
        Ttyp_3DSS,
        Ttyp_Unknown
    }

    /// <summary>
    ///     消息级别
    /// </summary>
    public enum MessageLevel
    {
        Info,
        Warn,
        Error
    }

    /// <summary>
    ///     OPCUA Server端数据节点值类型
    ///     UINT16：16位无符号整数
    ///     INT：整数
    ///     UINT：无符号整数
    ///     FLOAT：浮点数
    ///     STRING：字符串
    ///     DATETIME：日期
    ///     BOOLEAN：布尔型
    ///     UNKNOWN：未知
    /// </summary>
    public enum NodeType
    {
        UINT16,
        INT16,
        INT,
        UINT,
        FLOAT,
        DOUBLE,
        STRING,
        DATETIME,
        BOOLEAN,
        BOOLEANARRAY,
        UNKNOWN
    }

    /// <summary>
    ///     射野扫描模式
    /// </summary>
    public enum BeamScanStatus
    {
        /// <summary>
        ///     点扫描
        /// </summary>
        S,

        /// <summary>
        ///     均匀扫描
        /// </summary>
        U
    }

    /// <summary>
    ///     治疗计划状态
    /// </summary>
    public enum TreatmentPlanStatus
    {
        /// <summary>
        ///     未开始
        /// </summary>
        N,

        /// <summary>
        ///     标定OK
        /// </summary>
        C,

        /// <summary>
        ///     模拟验证OK
        /// </summary>
        V,

        /// <summary>
        ///     等待治疗
        /// </summary>
        S,

        /// <summary>
        ///     治疗中
        /// </summary>
        D,

        /// <summary>
        ///     治疗中断
        /// </summary>
        I,

        /// <summary>
        ///     治疗完成
        /// </summary>
        F,

        /// <summary>
        ///     治疗失败
        /// </summary>
        L
    }

    /// <summary>
    ///     排程状态
    /// </summary>
    public enum ScheduleResults
    {
        /// <summary>
        ///     未开始
        /// </summary>
        N,

        /// <summary>
        ///     治疗中断
        /// </summary>
        I,

        /// <summary>
        ///     治疗完成
        /// </summary>
        F,

        /// <summary>
        ///     治疗失败
        /// </summary>
        L,

        /// <summary>
        ///     过期
        /// </summary>
        O
    }

    public enum PatientSex
    {
        /// <summary>
        ///     男
        /// </summary>
        M,

        /// <summary>
        ///     女
        /// </summary>
        F,

        /// <summary>
        ///     未知
        /// </summary>
        U,

        /// <summary>
        ///     未知
        /// </summary>
        O
    }

    /// <summary>
    ///     标定审核状态
    /// </summary>
    public enum ExamineStatus
    {
        /// <summary>
        ///     未审核
        /// </summary>
        N,

        /// <summary>
        ///     审核通过
        /// </summary>
        P,

        /// <summary>
        ///     审核未通过
        /// </summary>
        F,

        /// <summary>
        ///     作废
        /// </summary>
        I
    }

    /// <summary>
    ///     治疗中小程序状态
    /// </summary>
    public enum AppletStatus
    {
        /// <summary>
        ///     未连接
        /// </summary>
        Ununited,

        /// <summary>
        ///     正常
        /// </summary>
        Normal,

        /// <summary>
        ///     异常
        /// </summary>
        Error,

        /// <summary>
        ///     警告
        /// </summary>
        Warn
    }

    /// <summary>
    ///     脊型过滤器ID
    /// </summary>
    public enum RFID
    {
        IDLE,
        NONE,
        MRF2, // ---------- 变更对应(131) Add by LiuWenXing 2021.12.16 Start ----------
        MRF4,
        RF20, // ---------- 变更对应(131) Add by LiuWenXing 2021.12.16 Start ----------
        RF30,
        RF40,
        RF50,
        RF60,
        RF70,
        RF80,
        RF90,
        RF100,
        RF110,
        RF120,
        RF130,
        RF140, // ---------- 变更对应(131) Add by LiuWenXing 2021.12.16 Start ----------
        RF150
    }

    // ---------- Added by hedian 2020.10.19 start ----------
    /// <summary>
    ///     设备配置表中所配置的设备属于那个治疗头类型
    /// </summary>
    public enum DeviceSettingTypeofNozzleID
    {
        /// <summary>
        ///     水平治疗头
        /// </summary>
        H,

        /// <summary>
        ///     垂直治疗头
        /// </summary>
        V,

        /// <summary>
        ///      杭州3号治疗室45度治疗头
        /// </summary>
        D,

        /// <summary>
        ///     通用(不分水平和垂直)
        /// </summary>
        O
    }

    /// <summary>
    ///     治疗室设备ID的枚举定义
    /// </summary>
    public enum DeviceID
    {
        /// <summary>
        ///     治疗室1治疗床
        /// </summary>
        Room1Couch = 2,

        /// <summary>
        ///     治疗室1DR
        /// </summary>
        Room1DR = 3,

        /// <summary>
        ///     治疗室1脊形过滤器
        /// </summary>
        Room1RF = 7,

        /// <summary>
        ///     治疗室1剂量配送
        /// </summary>
        Room1DDS = 10,

        /// <summary>
        ///     治疗室2治疗床
        /// </summary>
        Room2Couch = 12,

        /// <summary>
        ///     治疗室2DR
        /// </summary>
        Room2DR = 13,

        /// <summary>
        ///     治疗室2初级准直器
        /// </summary>
        Room2PC = 14,

        /// <summary>
        ///     治疗室2多叶光栅
        /// </summary>
        Room2MLC = 15,

        /// <summary>
        ///     治疗室2射程移位器
        /// </summary>
        Room2RS = 16,

        /// <summary>
        ///     治疗室2脊形过滤器
        /// </summary>
        Room2RF = 17,

        /// <summary>
        ///     治疗室2剂量配送
        /// </summary>
        Room2DDS = 20,

        /// <summary>
        ///     治疗室3治疗床
        /// </summary>
        Room3Couch = 22,

        /// <summary>
        ///     治疗室3DR
        /// </summary>
        Room3DR = 23,

        /// <summary>
        ///     治疗室3脊形过滤器
        /// </summary>
        Room3RF = 27,

        /// <summary>
        ///     治疗室3剂量配送
        /// </summary>
        Room3DDS = 30,

        /// <summary>
        ///     治疗室4治疗床
        /// </summary>
        Room4Couch = 32,

        /// <summary>
        ///     治疗室4DR
        /// </summary>
        Room4DR = 33,

        /// <summary>
        ///     治疗室4脊形过滤器
        /// </summary>
        Room4RF = 37,

        /// <summary>
        ///     治疗室4剂量配送
        /// </summary>
        Room4DDS = 40
    }
    // ---------- Added by hedian 2020.10.19 end ----------


    public enum RoomStatus
    {
        [Description("空闲")]
        Default = 0,
        [Description("等待患者")]
        WaitPatient,
        //PositioningScreenDisplayed
        [Description("患者摆位")]
        PatientPositioning,
        //TherapyBedToCTScanningPositionPressed
        [Description("CT配准")]
        CTRegistration,
        //TherapyBedToISOOrDRRegistrationPressed
        [Description("DR配准")]
        DRRegistration,
        //BeamRequestPressed
        [Description("等待治疗")]
        WaitingForTreatment,
        //DDSCommand205_BeamQueueing
        [Description("束流排队")]
        BeamQueuing,
        //DDSCommand212_BeamQueueing
        [Description("正在出束")]
        BeamDelivery,
        [Description("射野切换")]
        BeamSwitching,
        [Description("治疗结束")]
        TreatmentEnd
    }

    /// <summary>
    /// 补偿器插入类型
    /// </summary>
    public enum CompensatorInsertTypes
    {
        /// <summary>
        ///  补偿器没插入
        /// </summary>
        CompensatorNotInsert = 0,
        /// <summary>
        /// 补偿器插入
        /// </summary>
        CompensatorInsert
    }

    public enum AppletMode
    {
        // 运维模式
        Maintenance,

        // 治疗模式
        Treatment
    }

    public enum AuthType
    {
        //设备精度授权
        DeviceAccuracyAuth,
        //患者验证授权
        PatientVerificationAuth,
        //DR跳过授权
        DrSkipAuth,
        //CT跳过授权
        CtSkipAuth,
        //忽略CT故障授权
        IgnoreCtFaultAuth,
        //跳过摆位授权
        PositioningSkipAuth,
        //患者治疗部位变更授权
        TreatmentSiteChangeAuth,
        //确认标定授权
        CalibrationConfirmationAuth,
    }

    public enum CTType
    {
        CBCT = 0,
        CT
    }

    /// <summary>
    /// CT使能面板（目前只有回零位，待日后扩展）
    /// </summary>
    public enum CTWaitEvent
    {
        /// <summary>
        /// 请按下CT控制面板使能
        /// </summary>
        WaitingCTToZero = 0
    }

    public enum CouchMoveDirection
    {
        /// <summary>
        /// X轴方向
        /// </summary>
        X,

        /// <summary>
        /// Y轴方向
        /// </summary>
        Y,

        /// <summary>
        /// Z轴方向
        /// </summary>
        Z,

        /// <summary>
        /// Z轴旋转方向
        /// </summary>
        A,

        /// <summary>
        /// Y轴旋转方向
        /// </summary>
        B,

        /// <summary>
        /// X轴旋转方向
        /// </summary>
        C,

        /// <summary>
        /// E1轴方向
        /// </summary>
        E1
    }
    public enum PPSPositionNum
    {
        /// <summary>
        /// 上床位
        /// </summary>
        Bed_Position = 1,

        /// <summary>
        /// 上床位到待 CBCT 过渡位置 
        /// </summary>
        Bed_To_PreCBCT = 2,

        /// <summary>
        /// 待 CBCT 位置
        /// </summary>
        PreCBCT = 3,

        /// <summary>
        /// CBCT 去等中心过渡位，针对右/头部射野治疗
        /// </summary>
        Miderate = 4,

        /// <summary>
        /// 右射野治疗辅助点，相对 P4 床板转 180° 
        /// </summary>
        TO_ISO_RHS = 5,

        /// <summary>
        /// 右射野治疗等中心位基准点 
        /// </summary>
        ISO_RHS = 6,

        /// <summary>
        /// 左射野治疗辅助位：CBCT 到等中心过渡位置
        /// </summary>
        TO_ISO_LHS = 7,

        /// <summary>
        /// 左射野治疗等中心位基准点 
        /// </summary>
        ISO_LHS = 8,

        /// <summary>
        /// 头顶射野治疗辅助位，相对 P4 床板转 90°
        /// </summary>
        TO_ISO_Head = 9,

        /// <summary>
        /// 头顶射野治疗等中心位基准点
        /// </summary>
        ISO_Head = 10,

        /// <summary>
        /// 非首次治疗的过渡位，用于非最后肿瘤(不用)
        /// </summary>
        InterAux = 11,

        /// <summary>
        /// 摆位后 CBCT 成像位置 
        /// </summary>
        XCBCT_POS = 12,

        /// <summary>
        /// 左射野治疗位置 
        /// </summary>
        XTreatPos_LHS = 13,

        /// <summary>
        /// 右射野野治疗位置
        /// </summary>
        XTreatPos_RHS = 14,

        /// <summary>
        /// 头顶射野治疗位置 
        /// </summary>
        XTreatPos_Head = 15,

        /// <summary>
        /// 非首次治疗位置，来自 TCS 
        /// </summary>
        Treat_Pos = 16,

        /// <summary>
        /// 服务位置 
        /// </summary>
        ServicePoint = 17,

        /// <summary>
        /// 左射野等中心 CBCT 偏差修正
        /// </summary>
        XCBCT_ISO_LHS = 18,

        /// <summary>
        /// 右射野等中心 CBCT 偏差修正
        /// </summary>
        XCBCT_ISO_RHS = 19,

        /// <summary>
        /// 头顶射野等中心 CBCT 偏差修正
        /// </summary>
        XCBCT_ISO_Head = 20,

        /// <summary>
        /// 左射野等中心 DR 偏差修正
        /// </summary>
        XDR_ISO_LHS = 21,

        /// <summary>
        /// 右射野等中心 DR 偏差修正
        /// </summary>
        XDR_ISO_RHS = 22,

        /// <summary>
        /// 头顶射野等中心 DR 偏差修正 
        /// </summary>
        XDR_ISO_Head = 23,

        /// <summary>
        /// 新左射野治疗等中心位
        /// </summary>
        XNewISO_LHS = 24,

        /// <summary>
        /// 新右射野治疗等中心位 
        /// </summary>
        XNewISO_RHS = 25,

        /// <summary>
        /// 新头部射野治疗等中心位 
        /// </summary>
        XNewISO_Head = 26,

        /// <summary>
        /// 摆位后的中心点
        /// </summary>
        XISO_Pos = 27,

        // ---------- Added by hedian 2021.06.30 Start ---------- 
        /// <summary>
        /// DR拍摄位
        /// </summary>
        XDR_POS = 28,
        // ---------- Added by hedian 2021.06.30 End ----------
        // ---------- 变更对应(251) Modified by LiuWenXing 2022.9.26 Start ----------
        /// <summary>
        /// 治疗床远控运动完成点位
        /// </summary>
        JOG_POS = 35
        // ---------- 变更对应(251) Modified by LiuWenXing 2022.9.26 End ----------
    }
}