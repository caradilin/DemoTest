namespace TCS.Core.EventArgs
{
    public class AuthTypeEventArgs : System.EventArgs
    {
        /// <summary>
        /// 授权类别
        /// </summary>
        public AuthType AuthType { get; set; }

        public AuthTypeEventArgs(AuthType deviceType)
        {
            AuthType = deviceType;
        }
    }
}