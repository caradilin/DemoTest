namespace TCS.Core.Common
{
    /// <summary>
    ///     设备配置参数名定义
    /// </summary>
    public class DeviceCONST
    {
        #region DR

        public const string DR_MOVINGERROR = "DR_MERange";
        public const string DR_ANGLEERROR = "DR_AERange";

        public const string DR_0RESETAXISX = "DR_0RESETAXISX"; // DR_0度复位X轴
        public const string DR_0RESETAXISY = "DR_0RESETAXISY"; // DR_0度复位Y轴
        public const string DR_0RESETAXISZ = "DR_0RESETAXISZ"; // DR_0度复位Z轴
        public const string DR_0RESETAXIST = "DR_0RESETAXIST"; // DR_0度复位T轴
        public const string DR_0RESETAXISS = "DR_0RESETAXISS"; // DR_0度复位S轴        

        public const string DR_0HSAXISX = "DR_0HSAXISX"; // DR_0度水平拍摄X轴
        public const string DR_0HSAXISY = "DR_0HSAXISY"; // DR_0度水平拍摄Y轴
        public const string DR_0HSAXISZ = "DR_0HSAXISZ"; // DR_0度水平拍摄Z轴
        public const string DR_0HSAXIST = "DR_0HSAXIST"; // DR_0度水平拍摄T轴
        public const string DR_0HSAXISS = "DR_0HSAXISS"; // DR_0度水平拍摄S轴

        public const string DR_0VSAXISX = "DR_0VSAXISX"; // DR_0度垂直拍摄X轴
        public const string DR_0VSAXISY = "DR_0VSAXISY"; // DR_0度垂直拍摄Y轴
        public const string DR_0VSAXISZ = "DR_0VSAXISZ"; // DR_0度垂直拍摄Z轴
        public const string DR_0VSAXIST = "DR_0VSAXIST"; // DR_0度垂直拍摄T轴
        public const string DR_0VSAXISS = "DR_0VSAXISS"; // DR_0度垂直拍摄S轴

        public const string DR_180RESETAXISX = "DR_180RESETAXISX"; // DR_180度复位X轴
        public const string DR_180RESETAXISY = "DR_180RESETAXISY"; // DR_180度复位Y轴
        public const string DR_180RESETAXISZ = "DR_180RESETAXISZ"; // DR_180度复位Z轴
        public const string DR_180RESETAXIST = "DR_180RESETAXIST"; // DR_180度复位T轴
        public const string DR_180RESETAXISS = "DR_180RESETAXISS"; // DR_180度复位S轴

        public const string DR_180HSAXISX = "DR_180HSAXISX"; // DR_180度水平拍摄X轴
        public const string DR_180HSAXISY = "DR_180HSAXISY"; // DR_180度水平拍摄Y轴
        public const string DR_180HSAXISZ = "DR_180HSAXISZ"; // DR_180度水平拍摄Z轴
        public const string DR_180HSAXIST = "DR_180HSAXIST"; //DR_180度水平拍摄T轴
        public const string DR_180HSAXISS = "DR_180HSAXISS"; // DR_180度水平拍摄S轴

        public const string DR_180VSAXISX = "DR_180VSAXISX"; // DR_180度垂直拍摄X轴
        public const string DR_180VSAXISY = "DR_180VSAXISY"; // DR_180度垂直拍摄Y轴
        public const string DR_180VSAXISZ = "DR_180VSAXISZ"; // DR_180度垂直拍摄Z轴
        public const string DR_180VSAXIST = "DR_180VSAXIST"; // DR_180度垂直拍摄T轴
        public const string DR_180VSAXISS = "DR_180VSAXISS"; // DR_180度垂直拍摄S轴

        #endregion

        #region COUCH

        public const string COUCH_MOVINGERROR = "COUCH_移动误差";
        public const string COUCH_ANGLEERROR = "COUCH_旋转误差";
        public const string COUCH_LEFTBEAMRANGEBEGIN = "COUCH_左射野移动角度范围";
        public const string COUCH_RIGHTBEAMRANGEBEGIN = "COUCH_右射野移动角度范围";
        public const string COUCH_ANOTHERRIGHTBEAMRANGEBEGIN = "COUCH_另一个右射野移动角度范围";

        public const string COUCH_HEADBEAMRANGEBEGIN = "COUCH_头射野移动角度范围";

        // ---------- ChangeRequest(215) Added by ZhangYao 2022.7.26 Start ----------
        public const string COUCH_ANOTHERLEFTBEAMRANGEBEGIN = "COUCH_另一个左射野移动角度范围";
        // ---------- ChangeRequest(215) Added by ZhangYao 2022.7.26 End ----------

        // ---------- ChangeRequest(PT_1) Added by CHZ 2023.05.05 Start ----------
        public const string COUCH_FIRSTGROUPBEAMRANGEBEGIN = "COUCH_第一个射野移动角度范围";
        public const string COUCH_SECONDGROUPBEAMRANGEBEGIN = "COUCH_第二个射野移动角度范围";

        public const string COUCH_THIRDGROUPBEAMRANGEBEGIN = "COUCH_第三个射野移动角度范围";
        //---------- ChangeRequest(PT_1) Added by CHZ 2023.05.05 End ----------

        #endregion

        #region RS

        public const string RS_NUM = "RS_数量";
        public const string RS_THICKNESSRANGEBEGIN = "RS_厚度范围";
        public const string RS_NONE = "RS_空位";
        public const string RS_RET1 = "RS_RET1";
        public const string RS_RET2 = "RS_RET2";

        #endregion

        #region RF

        public const string RF_NONE = "RF_空位";
        public const string RF_MOTIONSTATE = "RF_运动状态";
        public const string RF_MRF2 = "RF_MRF2";
        public const string RF_MRF4 = "RF_MRF4";
        public const string RF_20 = "RF_20";
        public const string RF_25 = "RF_25";
        public const string RF_30 = "RF_30";
        public const string RF_35 = "RF_35";
        public const string RF_40 = "RF_40";
        public const string RF_45 = "RF_45";
        public const string RF_50 = "RF_50";
        public const string RF_55 = "RF_55";
        public const string RF_60 = "RF_60";
        public const string RF_65 = "RF_65";
        public const string RF_70 = "RF_70";
        public const string RF_75 = "RF_75";
        public const string RF_80 = "RF_80";
        public const string RF_90 = "RF_90";
        public const string RF_100 = "RF_100";
        public const string RF_110 = "RF_110";
        public const string RF_120 = "RF_120";
        public const string RF_130 = "RF_130";
        public const string RF_140 = "RF_140";
        public const string RF_150 = "RF_150";

        #endregion

        #region SC

        public const string SC_SVACANCY = "SC_空位";
        public const string SC_SMOTIONSTATE = "SC_运动状态";
        public const string SC_PB05 = "SC_PB05";
        public const string SC_PB10 = "SC_PB10";
        public const string SC_PB15 = "SC_PB15";
        public const string SC_PB20 = "SC_PB20";
        public const string SC_PB25 = "SC_PB25";
        public const string SC_PB30 = "SC_PB30";
        public const string SC_PB35 = "SC_PB35";
        public const string SC_PB40 = "SC_PB40";
        public const string SC_PB45 = "SC_PB45";
        public const string SC_PB50 = "SC_PB50";
        public const string SC_PB55 = "SC_PB55";
        public const string SC_PB60 = "SC_PB60";
        public const string SC_PB65 = "SC_PB65";
        public const string SC_PB70 = "SC_PB70";

        #endregion

        #region PC

        public const string PC_HORIZONTALCOVERAGEBEGIN = "PC_水平范围";
        public const string PC_VERTICALCOVERAGEBEGIN = "PC_垂直范围";
        public const string PC_ERRORRANGE = "PC_误差范围";

        #endregion

        #region MLC

        public const string MLC_NUM = "MLC_叶片个数";
        public const string MLC_MOVINGRANGEBEGIN = "MLC_移动范围";
        public const string MLC_COPPERGATEFOLLOWRANGEBEGIN = "MLC_铜门跟随范围";
        public const string MLC_ROTATIONRANGEBEGIN = "MLC_旋转范围";
        public const string MLC_TELESCOPICRANGEBEGIN = "MLC_伸缩范围";
        public const string MLC_BLADEERROR = "MLC_叶片误差范围";
        public const string MLC_ANGLEERROR = "MLC_角度误差范围";

        #endregion

        #region DDS

        public const string DDS_IPADDRESSX = "DDS_IP地址X";
        public const string DDS_IPADDRESSY = "DDS_IP地址Y";
        public const string DDS_PORT = "DDS_端口";
        public const string DDS_FREQUENCY = "DDS_频率";

        // ---------- Delete by hedian 2020.09.17 start ---------
        //public const string DDS_AMPLITUDE = "DDS_幅值";        
        //public const string DDS_AMPLITUDECOEFFICIENT = "DDS_幅值系数";
        //public const string DDS_POSITIVEDEVIATION = "DDS_正偏移";
        //public const string DDS_NEGATIVEDEVIATION = "DDS_负偏移";
        //public const string DDS_INTERCEPTCOEFFICIENTA = "DDS_截距系数A";
        //public const string DDS_INTERCEPTCOEFFICIENTB = "DDS_截距系数B";
        //public const string DDS_INTERCEPTCOEFFICIENTC = "DDS_截距系数C";
        //public const string DDS_INTERCEPTCOEFFICIENTD = "DDS_截距系数D";
        // ---------- Delete by hedian 2020.09.17 end ---------
        // ---------- Added by hedian 2020.09.17 start ---------
        public const string DDS_SLITTINGKX = "DDS_分条KX";
        public const string DDS_SLITTINGBX = "DDS_分条BX";
        public const string DDS_SLITTINGKY = "DDS_分条KY";

        public const string DDS_SLITTINGBY = "DDS_分条BY";

        // ---------- Added by hedian 2020.09.17 end ---------
        public const string DDS_ICROTATION = "DDS_IC旋转";
        public const string DDS_PRESETTREATMENTTIME = "DDS_预设治疗时间";
        public const string DDS_WAVEFORMWIDTH = "DDS_波形宽度";

        #endregion
    }
}