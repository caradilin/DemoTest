using FastDeepCloner;
using System;
using System.Collections.Generic;
using TCS.Core.BO;
using TCS.Core.Model.DeviceModel;

namespace TCS.Core.TreatmentPlanDefinitions
{
    #region 射野计划

    /// <summary>
    ///     射野
    /// </summary>
    public class BeamPlanModel
    {
        /// <summary>
        ///     当前Beam的治疗头
        /// </summary>
        public string Nozzle;

        /// <summary>
        ///     ISOCID
        /// </summary>
        public string ISOCID { get; set; }

        /// <summary>
        ///     射野名
        /// </summary>
        public string BeamName { get; set; }

        /// <summary>
        ///     射野ID
        /// </summary>
        public string BeamID { get; set; }

        /// <summary>
        ///     当前射野 true:执行，false:跳过
        /// </summary>
        public bool BeamExecute { get; set; } = true;

        /// <summary>
        ///     当前射野为应当前治疗射野
        /// </summary>
        public bool IsTreatBeam { get; set; } = false;

        /// <summary>
        ///     治疗过程中已治疗剂量（或IC3MU计数）
        /// </summary>
        public double CurrentBeamMeterset { get; set; }


        public bool IsFirstTreatBeam { get; set; } = false;

        /// <summary>
        ///     计划总剂量(或IC3MU计数)
        /// </summary>
        public double BeamMeterset { get; set; }

        // ----------射野信息单位可见性 Added by hedian 2021.07.22 Start ----------
        /// <summary>
        ///     射野信息栏（剂量单位可见性）
        /// </summary>
        public string BeamUnitVisibility { get; set; }
        // ----------射野信息单位可见性 Added by hedian 2021.07.22 End ----------

        /// <summary>
        ///     计划中断前已治疗剂量(或IC3MU计数)
        /// </summary>
        public double BeamHadDownMeterset { get; set; }

        /// <summary>
        ///     设备数据(实际)
        /// </summary>
        [NoneCloneable]
        public DeviceDataSet ActualDeviceDataSet { get; set; } = new DeviceDataSet();

        /// <summary>
        ///     设备数据
        /// </summary>
        [NoneCloneable]
        public DeviceDataSet DeviceDataSet { get; set; }

        /// <summary>
        ///     点扫描所有层信息
        /// </summary>
        public List<PointScanLayer> PointScanLayers { get; set; }

        /// <summary>
        ///     均匀扫描信息
        /// </summary>
        public List<GratingInfo> UniformScanLayers { get; set; }

        /// <summary>
        ///     IC3标定因子(由射野剂量/层累计IC3MU计数计算得来，注意该项是假定值)
        /// </summary>
        public double IC3FactorByDoseDivisionMU { get; set; }

        /// <summary>
        ///     所有层的总剂量的MU计数（剂量/标定因子）
        ///     层剂量/IC3标定因子
        ///     TCS needs to translate FinalCumulativeDoseWeight into IC3 count, and sends to DDS and ITS.
        /// </summary>
        public uint IC3PresetMU { get; set; }

        // ---------- 变更对应(150) Add by LiuWenXing 2022.01.18 Start ----------
        /// <summary>
        ///     当前射野出束开始时间
        /// </summary>
        public DateTime ApplyBeamStartTime { get; set; }

        /// <summary>
        ///     当前射野出束结束始时间
        /// </summary>
        public DateTime ApplyBeamEndTime { get; set; }

        /// <summary>
        ///     均匀扫描-能量(计划)
        /// </summary>
        public double Energy { get; set; } = 0;


        /// <summary>
        /// 图像配准CiGps差值
        /// </summary>
        public List<Georeferencing> GeoreferencinginfoList { get; set; }

        /// <summary>
        /// 当前射野选择的部位
        /// </summary>
        public string PatientSite { get; set; }
		// ---------- 变更对应(150) Add by LiuWenXing 2022.01.18 End ----------
	}

    /// <summary>
    ///     点扫描治疗数据每层解析类
    /// </summary>
    [Serializable]
    public class PointScanLayer
    {
        /// <summary>
        ///     层号
        /// </summary>
        public int LayerIndex { get; set; }

        /// <summary>
        ///     射野大小: 10*10-->100; 15*15 -->150
        /// </summary>
        public string BeamArea { get; set; }

        /// <summary>
        ///     当前层 true:执行，false:跳过
        /// </summary>
        public bool LayerExecute { get; set; } = true;

        /// <summary>
        ///     层能量
        /// </summary>
        public double LayerEnergy { get; set; }

        /// <summary>
        ///     层已治疗总剂量（治疗中断层作成时标记剂量，其它层无需赋值。注意当使用mu系统时，会被mu值更新）
        /// </summary>
        public double LayerHadDownMeterset { get; set; } = 0;

        /// <summary>
        ///     层已治疗Mu（治疗中断层作成时标记剂量，其它层无需赋值。记录DDS系统反馈，以避免标定因子计算丢失精度)）
        /// </summary>
        public double LayerHadDownMu { get; set; }
        /// <summary>
        ///     治疗过程中层已治疗剂量(注意当使用mu系统时，会被mu值更新)
        /// </summary>
        public double CurrentLayerMeterset { get; set; } = 0;

        /// <summary>
        ///     治疗过程中层已治疗mu（记录DDS系统反馈，以避免标定因子计算丢失精度)）
        /// </summary>
        public double IC2CurrentMu { get; set; } 

        /// <summary>
        ///     层剂量和(截止当前层剂量累计和)
        /// </summary>
        public double CumulativeMetersetWeight { get; set; }

        /// <summary>
        ///     点信息
        /// </summary>
        public List<PointScanInfo> PointScanInfos { get; set; }

        /// <summary>
        ///     IC1标定因子
        /// </summary>
        public double IC1Factor { get; set; }

        /// <summary>
        ///     IC2标定因子
        /// </summary>
        public double IC2Factor { get; set; }

        /// <summary>
        ///     IC3标定因子
        /// </summary>
        public double IC3Factor { get; set; }

        /// <summary>
        ///     IC2预设计数(不含已扫描数据)
        /// </summary>
        public uint IC2PresetMU { get; set; }

        /// <summary>
        ///     IC3预设计数(不含已扫描数据)
        /// </summary>
        public uint IC3PresetMU { get; set; }

        /// <summary>
        ///     用于计算传递给电源的数据((该项在患者计划验证时取得)
        /// </summary>
        [NoneCloneable]
        public TCSDflectClbrtInfo KBXYData { get; set; }

        /// <summary>
        /// 标定因子
        /// </summary>
        public double CalibrationFactor { get; set; }
    }

    /// <summary>
    ///     点扫描治疗数据点解析类
    /// </summary>
    [Serializable]
    public class PointScanInfo
    {
        /// <summary>
        ///     当前点的索引
        /// </summary>
        public int PointIndex { get; set; }

        /// <summary>
        ///     当前点 true:执行，false:跳过
        /// </summary>
        public bool PointExecute { get; set; } = true;

        // ---------- 变更对应(219) Modified by LiuWenXing 2022.8.18 Start ----------
        // TPS做成的点扫描坐标有“小数”的时候，因此类型变更（int->float）
        /// <summary>
        ///     X 坐标
        /// </summary>
        public float X { get; set; }

        /// <summary>
        ///     Y 坐标
        /// </summary>
        public float Y { get; set; }
        // ---------- 变更对应(219) Modified by LiuWenXing 2022.8.18 End ----------

        /// <summary>
        ///     每个坐标对应剂量权重
        /// </summary>
        public double SpotMeterset { get; set; }

        /// <summary>
        ///     点MU计数
        /// </summary>
        public uint IC1PresetMU { get; set; }
    }

    /// <summary>
    ///     光栅层信息
    /// </summary>
    public class GratingInfo
    {
        /// <summary>
        ///     层号
        /// </summary>
        public int LayerIndex { get; set; }

        /// <summary>
        ///     射野大小:
        /// </summary>
        public string BeamArea { get; set; }

        /// <summary>
        ///     当前层 true:执行，false:跳过
        /// </summary>
        public bool LayerExecute { get; set; } = true;

        /// <summary>
        ///     层能量计划值
        /// </summary>
        public double LayerEnergy { get; set; }

        /// <summary>
        ///     层能量实际值
        /// </summary>
        public double LayerEnergy_ACQ { get; set; }

        /// <summary>
        ///     层上次中断时已治疗IC1剂量(注意当使用mu系统时，会被mu值更新)
        /// </summary>
        public double LayerHadDownIC1Dose { get; set; }

        /// <summary>
        ///     层上次中断时已治疗IC1 Mu(记录DDS系统反馈，以避免标定因子计算丢失精度)
        /// </summary>
        public double LayerHadDownIC1Mu { get; set; }

        /// <summary>
        ///     层上次中断时已治疗IC2剂量(注意当使用mu系统时，会被mu值更新)
        /// </summary>
        public double LayerHadDownIC2Dose { get; set; }

        /// <summary>
        ///     层上次中断时已治疗IC2 Mu(记录DDS系统反馈，以避免标定因子计算丢失精度)
        /// </summary>
        public double LayerHadDownIC2Mu { get; set; }

        /// <summary>
        ///     层本次根据IC2得到已治疗总剂量(注意当使用mu系统时，会被mu值更新)
        /// </summary>
        public double Ic2CurrentDose { get; set; } = 0;

        /// <summary>
        ///     层本次根据IC2得到已治疗MU(记录DDS系统反馈，以避免标定因子计算丢失精度)
        /// </summary>
        public double Ic2CurrentMu { get; set; } = 0;

        /// <summary>
        ///     层本次根据IC1已治疗总剂量(注意当使用mu系统时，会被mu值更新)
        /// </summary>
        public double Ic1CurrentDose { get; set; } = 0;

        /// <summary>
        ///     层本次根据IC1已治疗MU(记录DDS系统反馈，以避免标定因子计算丢失精度)
        /// </summary>
        public double Ic1CurrentMu { get; set; } = 0;
        /// <summary>
        ///     层累计剂量权重
        /// </summary>
        public double CumulativeMetersetWeight { get; set; }

        /// <summary>
        ///     IC1标定因子
        /// </summary>
        public double IC1Factor { get; set; }

        /// <summary>
        ///     IC2标定因子
        /// </summary>
        public double IC2Factor { get; set; }

        /// <summary>
        ///     IC3标定因子
        /// </summary>
        public double IC3Factor { get; set; }

        /// <summary>
        ///     IC1预设计数
        /// </summary>
        public uint IC1PresetMU { get; set; }

        /// <summary>
        ///     IC2预设计数
        /// </summary>
        public uint IC2PresetMU { get; set; }

        /// <summary>
        ///     IC3预设计数
        /// </summary>
        public uint IC3PresetMU { get; set; }

        /// <summary>
        ///     射程移位器计划位置信息
        /// </summary>
        [NoneCloneable]
        public RSModel RSModel { get; set; }

        /// <summary>
        ///     射程移位器治疗过程中实际位置信息
        /// </summary>
        [NoneCloneable]
        public RSModel RSModelActual { get; set; }

        /// <summary>
        ///     光栅计划位置信息
        /// </summary>
        [NoneCloneable]
        public MLCModel MLCModel { get; set; }

        /// <summary>
        ///     光栅疗过程中实际位置信息
        /// </summary>
        [NoneCloneable]
        public MLCModel MLCModelActual { get; set; }

        /// <summary>
        /// 层名
        /// </summary>
        public string LayerName { get; set; }

        /// <summary>
        /// 标定因子
        /// </summary>
        public string CalibrationFactor { get; set; } = string.Empty;
    }

    #endregion
}