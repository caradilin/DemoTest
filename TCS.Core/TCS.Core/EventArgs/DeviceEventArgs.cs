namespace TCS.Core.EventArgs
{
    public enum CTInfoType
    {
        SystemRemoteControlMode,
        LinearAxisAtZeroPosition,
        LinearAxisAtWorkPosition, 
        RotaryAxisAtStartPosition,
        RotaryAxisAtEndPosition,
        LinearAxisActPosition,
        LinearAxisActVelocity,
        RotaryAxisActPosition,
        RotaryAxisActVelocity,
        SystemError,
        LinearAxisErrorID,
        RotaryAxisErrorID,
        LinearAxisMoving,
        RotaryAxisMoving
    }

    public enum DRInfoType
    {
        LiftAxisAtWorkPosition,
        LiftAxisAtZeroPosition,
        SystemError,
        LiftAxisActPosition,
        LiftAxisActVelocity,
        LiftAxisMoving,
    }
    public enum RoomInfoType
    {
        Default,
        R1,
        R2,
        R3,
        R4
    }
    public enum IGRTInfoType
    {
        Result,
        DrError,
        CtError,
        IgrtData,
        DRIgpsCommand
    }
    public enum TBMSInfoType
    {
        ACSBeamInfoNodeId,
        ACSCurrentBeamNodeId,
        BeamAppStatusNodeId
    }
    public enum DDSInfoType
    {
        ControlCommand,
        Layer,
        IC1,
        IC2,
        IC1Preset,
        IC2Preset,
        SpotIndex,
        SpotCountPreset,
        SpotCountFinished,
        SetPowerCommand,
        SpotPresetMU,
        CurrentSpotMU,
        CurrentXPosition,
        CurrentYPosition,
        PowerXMode,
        PowerXValue,
        PowerXStatus,
        PowerXErrorInfo,
        PowerYMode,
        PowerYValue,
        PowerYStatus,
        PowerYErrorInfo,
        SystemInfo,
        Status,
        ErrorInfo,
        ControllerStatus,
        SpotDoseTotalCurrent,
        SpotDoseTotalPreset
    }

    public enum PPSInfoType
    {
        X,
        Y,
        Z,
        A,
        B,
        C,
        E1,
        PositionNum,
        B_CmdExecuted,
        SystemError,
        SystemErrorID,
        ProcessStatus
    }

    public enum SQPOrSIPInfoType
    {
        PowerMode,
        PowerValue,
        PowerStatus,
        Status,
        ErrorInfo,
        ControlCommand
    }

    public enum EVSInfoType
    {
        EnergyAck,
        FrequencyAck,
        EnergyRequest,
        EnergyTolerance,
        FrequencyRequest,
        FrequencyTolerance,
        FrequencyInterlock,
        Status,
        ErrorInfo
    }
    public enum BMSInfoType
    {
        Position,
        TargetPosition,
        ErrorInfo,
        MoveStatus,
        Status,
        MoveCommand
    }
    public enum ITSInfoType
    {
        CurrentMU,
        DoseRate,
        PresetMU,
        PresetTime,
        ErrorInfo,
        Status,
        ControllerStatus
    }
    public enum MIInfoType
    {
        HWStatus,
        SWStatus,
        HWErrorInfo,
        SWErrorInfo,
        DisableHWError,
        DisableSWError
    }

    public enum WUHCTInfoType
    {
        LinearAxisMoving,
        LinearAxisAtZeroPosition,
        SystemError
    }
    public enum HGHCTInfoType
    {
        LinearAxisMoving,
        LinearAxisAtZeroPosition,
        SystemError
    }
    public enum WUHPPSInfoType
    {
        PPSMotionCommand,
        PPSValid,
        DROffsetA,
        DROffsetB,
        DROffsetC,
        DROffsetX,
        DROffsetY,
        DROffsetZ,
        DROffsetDataValid,
        TAOffsetC,
        TAOffsetDataValid,
        PPSRequest,
        TAOffsetRequest,
        DROffsetPosReached,
        //TAFlowEnd,
        PPSCurInfoA,
        PPSCurInfoB,
        PPSCurInfoC,
        PPSCurInfoX,
        PPSCurInfoY,
        PPSCurInfoZ,
        PPSErrorId,
        PPSError,
        PPSRobotReady,
        PPSWaitToCT,
        DROffsetFinValid,
        CTOffsetRequest,
        DROffsetRequest,
        CTOffsetA,
        CTOffsetB,
        CTOffsetC,
        CTOffsetX,
        CTOffsetY,
        CTOffsetZ,
        CTOffsetDataValid,
        CTOffsetFinValid,
        //TAOffsetFinValid,
        CTOffsetPosReached,
        PPSWaitCTZero,
        TAPosReached,
        ProcessCommandTreatNum,
        SkipCT,
        SkipDR,
        Home,
        HomePosReached,
        BedInTreatPos,
        RobotMoving,
        JogOffsetA,
        JogOffsetB,
        JogOffsetC,
        JogOffsetX,
        JogOffsetY,
        JogOffsetZ,
        JogOffsetDataValid,
        JogOffsetPosReached,
        RobRemoteMode,
        GlobalVel,
        TACanNotReach,
        LeftValid,
        HeadValid,
        RightValid,
        LeftAngle,
        HeadAngle,
        RightAngle,
        MoveTolSO,
        bRobotAtISO,
        A_OFFSET,
        B_OFFSET,
        C_OFFSET,
        X_OFFSET,
        Y_OFFSET,
        Z_OFFSET
    }

    public enum HGHPPSInfoType
    {
        CouchStatus,
        CouchPosition,
        CouchMoveReached, 
        CouchErrorIds,
        CouchCommand,
        CouchCommandFB,
        CouchStatusBedPos,
        CouchErrorIdsBedPos,
        CouchCommandFBBedPos,
        CouchMoveReachedBedPos,
    }

    public class DeviceEventArgs : System.EventArgs
    {
        public DeviceEventArgs(DeviceType deviceType)
        {
            DeviceType = deviceType;
        }

        public DeviceEventArgs(DeviceType deviceType, IGRTInfoType igrtInfoType)
        {
            DeviceType = deviceType;
            IgrtInfoType = igrtInfoType;
        }
        public DeviceEventArgs(DeviceType deviceType, DDSInfoType ddsInfoType)
        {
            DeviceType = deviceType;
            DDSInfoType = ddsInfoType;
        }
        public DeviceEventArgs(DeviceType deviceType, PPSInfoType ppsInfoType)
        {
            DeviceType = deviceType;
            PPSInfoType = ppsInfoType;
        }
        public DeviceEventArgs(DeviceType deviceType, SQPOrSIPInfoType sqpOrSipInfoType)
        {
            DeviceType = deviceType;
            SqpOrSipInfoType = sqpOrSipInfoType;
        }
        public DeviceEventArgs(DeviceType deviceType, EVSInfoType evsInfoType)
        {
            DeviceType = deviceType;
            EVSInfoType = evsInfoType;
        }

        public DeviceEventArgs(DeviceType deviceType, DRInfoType drInfoType)
        {
            DeviceType = deviceType;
            DRInfoType = drInfoType;
        }
        public DeviceEventArgs(DeviceType deviceType, CTInfoType ctInfoType)
        {
            DeviceType = deviceType;
            CTInfoType = ctInfoType;
        }

        public DeviceEventArgs(DeviceType deviceType, BMSInfoType bmsInfoType)
        {
            DeviceType = deviceType;
            BMSInfoType = bmsInfoType;
        }

        public DeviceEventArgs(DeviceType deviceType, MIInfoType miInfoType)
        {
            DeviceType = deviceType;
            MIInfoType = miInfoType;
        }
        public DeviceEventArgs(DeviceType deviceType, ITSInfoType itsInfoType)
        {
            DeviceType = deviceType;
            ITSInfoType = itsInfoType;
        }
        public DeviceEventArgs(DeviceType deviceType, TBMSInfoType tbmsInfoType)
        {
            DeviceType = deviceType;
            TBMSInfoType = tbmsInfoType;
        }
        public DeviceEventArgs(DeviceType deviceType, WUHPPSInfoType wuhPPSInfoType)
        {
            DeviceType = deviceType;
            WUHPPSInfoType = wuhPPSInfoType;
        }

        public DeviceEventArgs(DeviceType deviceType, WUHCTInfoType wuhCTInfoType)
        {
            DeviceType = deviceType;
            WUHCTInfoType = wuhCTInfoType;
        }

        public DeviceEventArgs(DeviceType deviceType, HGHCTInfoType hghCTInfoType)
        {
            DeviceType = deviceType;
            HGHCTInfoType = hghCTInfoType;
        }

        public DeviceEventArgs(DeviceType deviceType, HGHPPSInfoType hghPPSIntoType)
        {
            DeviceType = deviceType;
            HGHPPSInfoType = hghPPSIntoType;
        }

        public DeviceEventArgs(DeviceType deviceType, RoomInfoType roomInfoType)
        {
            DeviceType = deviceType;
            RoomInfoType = roomInfoType;
        }
        /// <summary>
        /// 设备类型属性
        /// </summary>
        public DeviceType DeviceType { get; }

        /// <summary>
        /// IGRT消息类别
        /// </summary>
        public IGRTInfoType IgrtInfoType { get; }
        /// <summary>
        /// DDS消息类别
        /// </summary>
        public DDSInfoType DDSInfoType { get; }
        /// <summary>
        /// SQP消息类别
        /// </summary>
        public SQPOrSIPInfoType SqpOrSipInfoType { get; }

        /// <summary>
        /// PPS消息类别
        /// </summary>
        public PPSInfoType PPSInfoType { get; }
        /// <summary>
        /// TBMS消息类别
        /// </summary>
        public TBMSInfoType TBMSInfoType { get; }
        /// <summary>
        /// EVS消息类别
        /// </summary>
        public EVSInfoType EVSInfoType { get; }

        /// <summary>
        /// DR消息类别
        /// </summary>
        public DRInfoType DRInfoType { get; }

        /// <summary>
        /// CT消息类别
        /// </summary>
        public CTInfoType CTInfoType { get; }

        /// <summary>
        /// BMS消息类别
        /// </summary>
        public BMSInfoType BMSInfoType { get; }

        /// <summary>
        /// MI消息类别
        /// </summary>
        public MIInfoType MIInfoType { get; }
        /// <summary>
        /// ITS消息类别
        /// </summary>
        public ITSInfoType ITSInfoType { get; }
        /// <summary>
        /// WUH CT消息类别
        /// </summary>
        public WUHCTInfoType WUHCTInfoType { get; }

        /// <summary>
        /// WUH PPS消息类别
        /// </summary>
        public WUHPPSInfoType WUHPPSInfoType { get; }
        /// <summary>
        /// HGH PPS消息类别
        /// </summary>
        public HGHPPSInfoType HGHPPSInfoType { get; }

        /// <summary>
        /// HGH CT消息类别
        /// </summary>
        public HGHCTInfoType HGHCTInfoType { get; }

        /// <summary>
        /// 隶属治疗室
        /// </summary>
        public RoomInfoType RoomInfoType { get; }
    }
}