namespace TCS.Core.Model
{
    public class TcpWaitResultModel
    {
        /// <summary>
        /// TCP结果
        /// </summary>
        public bool Result { get; set; }

        /// <summary>
        /// TCP当前状态
        /// </summary>
        public TCPButtonSatus TCPButtonSatus { get; set; }

        /// <summary>
        /// 请求TCP事件
        /// </summary>
        public TCPWaitEvent TcpWaitEvent { get; set; }

        /// <summary>
        /// 等待超时
        /// </summary>
        public int OperationTimeout { get; set; } = int.MaxValue;

        public TcpWaitResultModel(TCPWaitEvent waitEvent)
        {
            TcpWaitEvent = waitEvent;
        }
    }
}