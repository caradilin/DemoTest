namespace TCS.Core.Common
{
    #region UICONST

    public class UICONST
    {
        public const string VISIBILITY_COLLAPSED = "Collapsed";
        public const string VISIBILITY_VISIBLE = "Visible";
        public const string VISIBILITY_HIDDEN = "Hidden";
        // ---------- 变更对应(205) Add by ZhangYao 2022.06.29 End ----------


        //定位验证页数据check结果图表显示
        public const string WAITSTATE = "/TCS;component/Resources/Images/Waiting.png";
        public const string OKSTATE = "/TCS;component/Resources/Images/Correct.png";
        public const string WARNSTATE = "/TCS;component/Resources/Images/Warn.png";

        public const string INFOSTATE = "/TCS;component/Resources/Images/Info.png";
        public const string ERRORSTATE = "/TCS;component/Resources/Images/Error.png";

        //小程序数据状态显示
        public const string MiniProgramsGreenLight = "/TCS;component/Resources/Images/MiniProgramsGreenLight.png";
        public const string MiniProgramsGrayLight = "/TCS;component/Resources/Images/MiniProgramsGrayLight.png";
        public const string MiniProgramsYellowLight = "/TCS;component/Resources/Images/MiniProgramsYellowLight.png";
        public const string MiniProgramsRedLight = "/TCS;component/Resources/Images/MiniProgramsRedLight.png";

        //日期格式文本
        public const string HOUR = "时";
        public const string MINUTE = "分";
        public const string SECOND = "秒";

        //设备运动状态
        public const string MOVING = "运动中";
        public const string STOP_MOVING = "运动停止";

        // ---------- 对应变更(221) Added by ZhangYao 2022.08.24 Start ----------
        //患者概要窗口文本
        public const string BRIEFVIEWEMPTYTEXT = "无";

        #region 文本相关

        public const string LASERLAMP = "激光灯";
        public const string COUCH = "治疗床";
        public const string DR = "DR";
        public const string PC = "初级准直器";
        public const string MLC = "多叶光栅";
        public const string RS = "射程移位器";
        public const string RF = "脊形过滤器";
        public const string SC = "散射体";
        public const string CHAINSYSTEM = "连锁系统";
        public const string DDS = "剂量配送";
        public const string CP = "补偿器";

        #endregion

        // ---------- 变更对应(205) Add by ZhangYao 2022.06.29 Start ----------

        #region MLC文本相关

        public const string MLC_ANGLE_ERROR = "多叶光栅位置移位(叶片角度存在误差)";
        public const string MLC_LEAF_ERROR = "多叶光栅位置移位(叶片构型存在误差)";
        public const string MLC_ANGLEANDLEAF_ERROR = "多叶光栅位置移位(叶片角度和构型都存在误差)";

        #endregion

        // ---------- 对应变更(221) Added by ZhangYao 2022.08.24 End ----------

        #region 设备OPCUA文本相关
        public const string OPCUA_PPS = "PPS";
        public const string OPCUA_DR = "DR";
        public const string OPCUA_CBCT = "CBCT";
        public const string OPCUA_ITS = "ITS";
        #endregion
    }

    #endregion UICONST
}