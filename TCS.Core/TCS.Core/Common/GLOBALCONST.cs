namespace TCS.Core.Common
{
    #region GLOBALCONST

    public class GLOBALCONST
    {
        // ---------- ChangeRequest(150) Added by WangYunXia 2021.1.20 Start ----------
        public const string UnderLine = "_";
        public const string SlashLine = " / ";
        public const string Comma = ",";

        public const string DataFormat = "yyyy/MM/dd HH:mm:ss";
        // ---------- ChangeRequest(150) Added by WangYunXia 2021.1.20 End ----------

        // ---------- Modified by hedian 2020.09.11 start ----------
        //public const int DIGITS = 2;
        public const int DIGITS = 3;

        public const int DDSDIGITS = 5;
        // ---------- Modified by hedian 2020.09.11 end ----------

        // ----------ChangeRequest(248) Added by ZhangYao 2022.09.22 start ----------
        // MLC实际光栅旋转角度，小数保留位数
        public const int KEEPONEDIGITS = 1;

        // ----------ChangeRequest(248) Added by hedian 2022.09.22 end ----------
        //TCS 配置文件
        public const string TCS_SETTINGS_FILE = @"Config\TCS.Config.json";
        public const string PUBLIC_OPCUA_FILE = @"Config\PublicServer.xml";
        public const string PPS_OPCUA_FILE = @"Config\PPSServer.xml";
        public const string TREATMENT_ROOM_CONFIG = @"Config\treatment_room_config.json";

        public const string keystatus = "Status";
        public const string keyheartbeat = "Heartbeat";
        public const string keyErrorInfo = "ErrorInfo";

        // TPS名称使用常量
        public const string TPS_ciPlan = "ciPlan";
        public const string TPS_raystation = "raystation";
        public const string TPS_cashim = "cashim";
        public const string TPS_phoenix = "phoenix";

        public const string Unit_mm = "mm";
        public const string Unit_Angle = "°";

        //权限校验位符
        public const int PERMISSION_BIT = 49;

        //点扫描治疗页中点的尺寸
        public const double POINTSIZE = 12;

        //点扫描治疗页中坐标轴范围大小（默认-15 <-> 15）
        // ----------变更对应（根据赵老师的要求，正负120） Modified by hedian 2021.12.29 Start ----------
        //public const float POINTINTERVALSIZE = 300; // 将单位从cm-->mm
        public const float POINTINTERVALSIZE = 240;
        // ----------变更对应（根据赵老师的要求，正负120） Modified by hedian 2021.12.29 End ----------

        //点扫描治疗页中点的尺寸
        public const double POINTSIZE1 = 11;

        //设备标定连锁状态显示
        public const string CHAINSYSTEMCLOSE = "pack://application:,,,/Resources/Images/ChainSystemClose.png";
        public const string CHAINSYSTEMOPEN = "pack://application:,,,/Resources/Images/ChainSystemOpen.png";


        public const string VERIFYPATIENT = "扫码确认";
        public const string IMAGEGUIDED = "摆位验证";
        public const string DEVICECONFIRM = "设备确认";
        public const string TREATMENT = "治疗";
        public const string DEVICT = "影像设备控制{0}";

        public const string TREATTOTALTIME = "出束总时间";

        // ----------变更对应（197） Added by zhang.pengchao 2022.06.13 Start ----------
        public const string TCPPRESS = "TCP按下";
        // ----------变更对应（197） Added by zhang.pengchao 2022.06.13 End ----------

        public const string BeamArea100 = "100";

        public const string BeamArea150 = "150"; //DCCT以外用

        // ---------- 变更对应(181) Add by LiuWenXing 2022.04.11 Start ----------
        public const string BeamArea225 = "225"; //DCCT专用

        public const string BeamArea400 = "400";

        // ---------- 变更对应(181) Add by LiuWenXing 2022.04.11 End ----------
        public const string BeamArea10To10 = "10*10";
        public const string BeamArea15To15 = "15*15";
        public const string BeamArea20To20 = "20*20";
        public const string BeamArea100To100 = "100.0*100.0";
        public const string BeamArea150To150 = "150.0*150.0";
        public const string BeamArea200To200 = "200.0*200.0";

        //1号治疗室名
        public const string R1 = "R1";

        //2号治疗室名
        public const string R2 = "R2";

        //2号治疗室名
        public const string R2H = "R2H";

        //2号治疗室名
        public const string R2V = "R2V";

        //3号治疗室名
        public const string R3 = "R3";

        //3号治疗室名
        public const string R3D = "R3D";

        //4号治疗室名
        public const string R4 = "R4";

        //1号治疗室治疗头
        public const string NOZZLEID_R1 = "51";

        //2号治疗室水平治疗头
        public const string NOZZLEID_R2H = "52";

        //2号治疗室垂直治疗头
        public const string NOZZLEID_R2V = "53";

        //3号治疗室治疗头
        public const string NOZZLEID_R3 = "54";
        public const string NOZZLEID_R3D = "56";

        //4号治疗室治疗头
        public const string NOZZLEID_R4 = "55";

        //SystemDeviceMessage中公共设备DeviceId
        public const string ComDevice = "COM";

        // ---------- Buglist(94) Modified by ZhangYao 2022.6.6 Start ----------
        /// <summary>
        ///     铜门实际宽度
        /// </summary>
        public const float ACTUALRASTER = 200;
        // ---------- Buglist(94) Modified by ZhangYao 2022.6.6 End ----------

        // ---------- Buglist(91) Added by WangYunXia 2022.5.6 Start ----------
        /// <summary>
        ///     模拟治疗订阅PPS实际位置的Key
        /// </summary>
        public const string KeyPPSE6POSWithPhysicsMode = "PPSE6POSPhysics";
        // ---------- Buglist(91) Added by WangYunXia 2022.5.6 End ----------

        // ---------- ChangeRequest(215) Added by WangYunXia 2022.7.18 Start ----------
        //标准坐标系基准角度（头射野）
        public const int StandardHead = 270;

        //标准坐标系基准角度（左射野）
        public const int StandardLeft = 180;

        //标准坐标系基准角度（右射野）
        public const int StandardRight0 = 0;

        //标准坐标系基准角度（右射野）
        public const int StandardRight360 = 360;
        // ---------- ChangeRequest(215) Added by WangYunXia 2022.7.18 End ----------

        //IGRT配准使用的单位
        public const string IGRTUnit = "mm";

        #region 扫描模式与束流类型相关

        public const string BEAMTYPE3DSS = "3DSS";
        public const string BEAMTYPE2D = "2D";

        public const string BEAMTYPE2DLS = "2DLS";

        // ----------(changerequest260) Modified by WangYunxia 2022.11.22 start ----------
        public const string BEAMTYPE3DLS = "3DLS";

        // ----------(changerequest260) Modified by WangYunxia 2022.11.22 End ----------
        public const string BEAMTYPE_STATIC = "STATIC";
        public const string BEAMTYPE_DYNAMIC = "DYNAMIC";
        public const string SCANMODE_UNIFORM = "UNIFORM";
        public const string SCANMODE_MODULATED = "MODULATED";

        public const string SCANMODE_MODULATED_SPEC = "MODULATED_SPEC"; //TPS新追加了一种点扫描模式（MODULATED_SPEC）。

        // ----------(changerequest260) Modified by WangYunxia 2022.11.18 start ----------
        public const string BEAMTYPE_LAYERSTACKING3D = "LAYERSTACKING3D";
        public const string BEAMTYPE_PENCILBEAMSCANNING = "PENCILBEAMSCANNING";

        public const string BEAMTYPE_UNIFORMSCANNING2D = "UNIFORMSCANNING2D";
        // ----------(changerequest260) Modified by WangYunxia 2022.11.18 End ----------

        #endregion

        #region 治疗室ID，配置文件中配置

        //1号治疗室ID
        public const string ROOM_0010 = "0010";

        //2号治疗室ID
        public const string ROOM_0011 = "0011";

        // ---------- Added by hedian 2020.10.19 start ----------
        //2号治疗室(水平)ID
        public const string ROOM_0011H = "0011H";

        //2号治疗室(垂直)ID
        public const string ROOM_0011V = "0011V";
        // ---------- Added by hedian 2020.10.19 end ----------

        //3号治疗室ID
        public const string ROOM_0100 = "0100";

        //3号治疗室(45度)ID
        public const string ROOM_0100D = "0100D";


        //4号治疗室ID
        public const string ROOM_0101 = "0101";

        //水平治疗头
        public const string HTreatmentHead = "HTreatmentHead";

        //垂直治疗头
        public const string VTreatmentHead = "VTreatmentHead";

        #endregion

        #region 房间ID

        //G1
        public const string RoomID_G1 = "G1";

        //G2
        public const string RoomID_G2 = "G2";

        //G3
        public const string RoomID_G3 = "G3";

        //G4
        public const string RoomID_G4 = "G4";

        #endregion

        // ---------- 变更对应(239) Added by zhang.pengchao 2022.09.08 Start ----------

        #region IGRT最大偏差值

        // 头，足 偏差值最大值，从配置文件获取的偏差值不能超过这个最大值
        public const int IGRT_HeadOffsetMax_X = 10;
        public const int IGRT_HeadOffsetMax_Y = 10;
        public const int IGRT_HeadOffsetMax_Z = 10;
        public const int IGRT_HeadOffsetMax_A = 5;
        public const int IGRT_HeadOffsetMax_B = 5;

        public const int IGRT_HeadOffsetMax_C = 5;

        // 颈部，小腿，胸部，大腿，腹部，盆腔 偏差值最大值，从配置文件获取的偏差值不能超过这个最大值
        public const int IGRT_BodyOffsetMax_X = 15;
        public const int IGRT_BodyOffsetMax_Y = 15;
        public const int IGRT_BodyOffsetMax_Z = 15;
        public const int IGRT_BodyOffsetMax_A = 5;
        public const int IGRT_BodyOffsetMax_B = 5;
        public const int IGRT_BodyOffsetMax_C = 5;

        #endregion IGRT最大偏差值

        // ---------- 变更对应(239) Added by zhang.pengchao 2022.09.08 End ----------

        //呼吸门控开关状态文本
        public const string RespiratoryGatingOpenText = "Yes";
        public const string RespiratoryGatingCloseText = "No";
    }

    #endregion
}