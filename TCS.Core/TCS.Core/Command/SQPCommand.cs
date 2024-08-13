namespace TCS.Core.Command
{
    public class SQPCommand
    {
        /// <summary>
        /// 快Q铁电源命令
        /// </summary>
        public enum ControlCommand
        {
            TCS_PowerON = 1,                              // 开机
            SQP_PowerONOK = 2,                              // 开机成功
            TCS_PowerOFF = 3,                              // 关机
            SQP_PowerOFFOK = 4,                              // 关机成功
            TCS_PowerReset = 5,                              // 复位
            SQP_PowerResetOK = 6                               // 复位成功
        };
    }
}