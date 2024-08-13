namespace TCS.Core.TCSTableModel
{
    public class MLCParameter
    {
        public string MLCID { get; set; }

        /// <summary>
        ///     命令集
        /// </summary>
        public int CommandSet { get; set; }

        /// <summary>
        ///     命令ID
        /// </summary>
        public int CommandID { get; set; }

        /// <summary>
        ///     命令名
        /// </summary>
        public string CommandSetName { get; set; }

        /// <summary>
        ///     同命令的参数执行时序
        /// </summary>
        public int Sequence { get; set; }

        /// <summary>
        ///     命令的具体参数
        /// </summary>
        public string Parameter { get; set; }

        /// <summary>
        ///     描述
        /// </summary>
        public string Description { get; set; }
    }
}