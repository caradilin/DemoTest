namespace TCS.Core.EventArgs
{
    public class MonitorArgs : System.EventArgs
    {
        // 构造函数，可以根据需要添加参数
        public MonitorArgs(string nodeId, string errInfo)
        {
            NodeId = nodeId;
            ErrInfo = errInfo;
        }

        // 节点
        public string NodeId { get; }

        // 错误
        public string ErrInfo { get; }
    }
}