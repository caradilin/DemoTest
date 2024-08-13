using TCS.Core.Common;

namespace TCS.Core.Model
{
    public enum DefaultButtonType
    {
        No,
        Yes
    }
    public enum MsgLevel
    {
        Info,
        Warn,
        Error
    }
    public enum MsgShowButtonType
    {
        //是或者否按钮
        YesOrNo,
        //确认按钮
        Tip
    }
    public enum MsgTextType
    {
        //是或者否按钮
        ShortText,
        //确认按钮
        LongText
    }
    public enum MessageDialogResult
    {
        Wait = 99,
        Yes = 1,
        No = 0,
        Tip = 2,
        ToCouchPosition=3
    }

    public class MsgBaseModel
    {
        /// <summary>
        /// 消息Key
        /// </summary>
        public string MsgKey { get; set; } 

        /// <summary>
        /// 消息类别（info/warn/error）
        /// </summary>
        public MsgLevel MsgType { get; set; } = MsgLevel.Info;
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }

        /// <summary>
        /// 按钮点击结果
        /// </summary>
        public MessageDialogResult MessageDialogResult { get; set; } = MessageDialogResult.Wait;

        public MsgBaseModel(string msg)
        {
            Msg = msg;
        }
        public MsgBaseModel(string key, string msg)
        {
            MsgKey = key;
            Msg = msg;
        }
    }

    public class GoBackPatientListMsgModel : MsgBaseModel
    {
        public bool ToCouchPositionIsEnabled { get; set; } = true;
        public bool YesIsEnabled { get; set; } = true;
        public bool NoIsEnabled { get; set; } = true;
        public GoBackPatientListMsgModel(string key, string msg) :base(key, msg)
        {
        }
    }

    /// <summary>
    /// AlertDialogView model
    /// </summary>
    public class AlertDialogMsgModel : MsgBaseModel
    {
        /// <summary>
        /// 是/否按钮的默认选择状态
        /// </summary>
        public DefaultButtonType DefaultButtonType { get; set; }
        /// <summary>
        /// 按钮显示类别（是否、确认）
        /// </summary>
        public MsgShowButtonType MsgShowType { get; set; }

        /// <summary>
        /// 是否按钮的可视性
        /// </summary> 

        public string ButtonVisibility { get; set; }

        /// <summary>
        /// 确认按钮可视性
        /// </summary> 

        public string TipVisibility { get; set; }

        public string NoBackground { get; set; } = "#f3f3f5";
        public string NoForeground { get; set; } = "#303030";
        public string YesBackground { get; set; } = "#1ab394";
        public string YesForeground { get; set; } = "#ffffff";

        public AlertDialogMsgModel(MsgLevel level, MsgShowButtonType showType, string key, string msg, DefaultButtonType defaultButtonType = DefaultButtonType.Yes):base(key, msg)
        {
            MsgType = level;
            MsgShowType = showType;
            DefaultButtonType = defaultButtonType;
            if (showType == MsgShowButtonType.YesOrNo)
            {
                ButtonVisibility = UICONST.VISIBILITY_VISIBLE;
                TipVisibility = UICONST.VISIBILITY_COLLAPSED;
            }
            else
            {
                ButtonVisibility = UICONST.VISIBILITY_COLLAPSED;
                TipVisibility = UICONST.VISIBILITY_VISIBLE;
            }
            var defaultYesOrNo = defaultButtonType == DefaultButtonType.Yes ? true : false;
            if (defaultButtonType == DefaultButtonType.No)
            {
                NoBackground = "#1ab394";
                NoForeground = "#ffffff";
                YesBackground = "#f3f3f5";
                YesForeground = "#303030";
            }
        }
    }
}