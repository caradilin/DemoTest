namespace TCS.Core.Model.PPSModel
{
    public class PPSCommand
    {
        public uint CommandID { get; set; }

        public string CommandName { get; set; }

        public string PositionPath { get; set; }

        public string NextCommandIDSet { get; set; }
    }
}