namespace TCS.Core.Model.AppletModel
{
    /// <summary>
    ///     12个参数: 4个X数据 + 4个Y数据 + 4个分条数据
    /// </summary>
    public class CalibrationData
    {
        public double Energy { get; set; }
        public string iso_param_posi_kx { get; set; } = string.Empty;
        public string iso_param_posi_bx { get; set; } = string.Empty;
        public string iso_param_nage_kx { get; set; } = string.Empty;
        public string iso_param_nage_bx { get; set; } = string.Empty;
        public string ic_param_kx1 { get; set; } = string.Empty;
        public string ic_param_bx1 { get; set; } = string.Empty;
        public string iso_param_posi_ky { get; set; } = string.Empty;
        public string iso_param_posi_by { get; set; } = string.Empty;
        public string iso_param_nage_ky { get; set; } = string.Empty;
        public string iso_param_nage_by { get; set; } = string.Empty;
        public string ic_param_ky1 { get; set; } = string.Empty;
        public string ic_param_by1 { get; set; } = string.Empty;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            CalibrationData otherData = (CalibrationData)obj;
            return Energy == otherData.Energy &&
                   iso_param_posi_kx == otherData.iso_param_posi_kx &&
                   iso_param_posi_bx == otherData.iso_param_posi_bx &&
                   iso_param_nage_kx == otherData.iso_param_nage_kx &&
                   iso_param_nage_bx == otherData.iso_param_nage_bx &&
                   ic_param_kx1 == otherData.ic_param_kx1 &&
                   ic_param_bx1 == otherData.ic_param_bx1 &&
                   iso_param_posi_ky == otherData.iso_param_posi_ky &&
                   iso_param_posi_by == otherData.iso_param_posi_by &&
                   iso_param_nage_ky == otherData.iso_param_nage_ky &&
                   iso_param_nage_by == otherData.iso_param_nage_by &&
                   ic_param_ky1 == otherData.ic_param_ky1 &&
                   ic_param_by1 == otherData.ic_param_by1;
        }
    }
}