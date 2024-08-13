/************************************************************************************************
*	File Name			:	TBMSDatapoint.cs  	            					                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/07/04															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	TBMS数据节点的定义                                          		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.07.04	HeDian		    新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.Model.AppletModel
{
    public class TBMSDatapoint : DatapointBase
    {
        /// <summary>
        ///     加速器当前出束的能量_治疗头
        /// </summary>
        private string _TBMS_ACS_BeamInfo;

        /// <summary>
        ///     加速器当前出束的能量
        /// </summary>
        private string _TBMS_ACS_CurrentBeam;


        /// <summary>
        ///     加速器当前模式，治疗模式、调束模式
        /// </summary>
        private string _TBMS_ACS_Mode;

        /// <summary>
        ///     加速器状态信息
        /// </summary>
        private string _TBMS_ACS_Status;

        /// <summary>
        ///     取消申请束流，为空时可取消
        /// </summary>
        private string _TBMS_Beam_Cancel;

        /// <summary>
        ///     申请束流，为空时可申请
        /// </summary>
        private string _TBMS_Beam_Request;

        /// <summary>
        ///     束流申请状态
        /// </summary>
        private string _TBMS_BeamAppStatus;

        /// <summary>
        ///     终端申请的能量_治疗头
        /// </summary>
        private string _TBMS_BeamLine;

        /// <summary>
        ///     51线允许出束，true为允许，false为异常
        /// </summary>
        private string _TBMS_BeamPermit51;

        /// <summary>
        ///     52线允许出束，true为允许，false为异常
        /// </summary>
        private string _TBMS_BeamPermit52;

        /// <summary>
        ///     53线允许出束，true为允许，false为异常
        /// </summary>
        private string _TBMS_BeamPermit53;

        /// <summary>
        ///     束流申请状态
        /// </summary>
        private string _TBMS_ClearInterlockError;

        /// <summary>
        ///     束流申请系统错误码
        /// </summary>
        private string _TBMS_ErrorInfo;

        /// <summary>
        ///     束流申请系统心跳信号
        /// </summary>
        private string _TBMS_Heartbeat;

        /// <summary>
        ///     出束需要延时，true为需要，false不需要
        /// </summary>
        private string _TBMS_NeedSleep;

        /// <summary>
        ///     束流申请队列
        /// </summary>
        private string _TBMS_Request_Queue;

        /// <summary>
        ///     51线允许触发，true为允许，false为异常
        /// </summary>
        private string _TBMS_SequencePermit51;

        /// <summary>
        ///     52线允许触发，true为允许，false为异常
        /// </summary>
        private string _TBMS_SequencePermit52;

        /// <summary>
        ///     53线允许触发，true为允许，false为异常
        /// </summary>
        private string _TBMS_SequencePermit53;

        /// <summary>
        ///     已延时的秒数
        /// </summary>
        private string _TBMS_Sleepping;


        /// <summary>
        ///     申请出束，需要带sessionID
        /// </summary>
        private string _TBMS_StartSequence;


        /// <summary>
        ///     束流申请系统状态，false为联锁，true为正常
        /// </summary>
        private string _TBMS_Status;

        /// <summary>
        ///     停止束流触发，true为停止，false为正常
        /// </summary>
        private string _TBMS_StopSequence;

        /// <summary>
        ///     终端申请的能量_治疗头
        /// </summary>
        private string _TBMS_TCS_BeamInfo;

        public TBMSDatapoint(string nodeidprefix) : base(nodeidprefix)
        {
        }

        public string TBMS_Request_Queue
        {
            get
            {
                if (_TBMS_Request_Queue == null) _TBMS_Request_Queue = GetNodeIDByNodeName("TBMS.Request_Queue");

                return _TBMS_Request_Queue;
            }
        }

        public string TBMS_ACS_CurrentBeam
        {
            get
            {
                if (_TBMS_ACS_CurrentBeam == null) _TBMS_ACS_CurrentBeam = GetNodeIDByNodeName("TBMS.ACS_CurrentBeam");

                return _TBMS_ACS_CurrentBeam;
            }
        }

        public string TBMS_ACS_BeamInfo
        {
            get
            {
                if (_TBMS_ACS_BeamInfo == null) _TBMS_ACS_BeamInfo = GetNodeIDByNodeName("TBMS.ACS_BeamInfo");

                return _TBMS_ACS_BeamInfo;
            }
        }

        public string TBMS_TCS_BeamInfo
        {
            get
            {
                if (_TBMS_TCS_BeamInfo == null) _TBMS_TCS_BeamInfo = GetNodeIDByNodeName("TBMS.TCS_BeamInfo");

                return _TBMS_TCS_BeamInfo;
            }
        }

        public string TBMS_BeamLine
        {
            get
            {
                if (_TBMS_BeamLine == null) _TBMS_BeamLine = GetNodeIDByNodeName("TBMS.BeamLine");

                return _TBMS_BeamLine;
            }
        }

        public string TBMS_ACS_Mode
        {
            get
            {
                if (_TBMS_ACS_Mode == null) _TBMS_ACS_Mode = GetNodeIDByNodeName("TBMS.ACS_Mode");

                return _TBMS_ACS_Mode;
            }
        }

        public string TBMS_ACS_Status
        {
            get
            {
                if (_TBMS_ACS_Status == null) _TBMS_ACS_Status = GetNodeIDByNodeName("TBMS.ACS_Status");

                return _TBMS_ACS_Status;
            }
        }

        public string TBMS_Beam_Request
        {
            get
            {
                if (_TBMS_Beam_Request == null) _TBMS_Beam_Request = GetNodeIDByNodeName("TBMS.Beam_Request");

                return _TBMS_Beam_Request;
            }
        }

        public string TBMS_Beam_Cancel
        {
            get
            {
                if (_TBMS_Beam_Cancel == null) _TBMS_Beam_Cancel = GetNodeIDByNodeName("TBMS.Beam_Cancel");

                return _TBMS_Beam_Cancel;
            }
        }

        public string TBMS_StartSequence
        {
            get
            {
                if (_TBMS_StartSequence == null) _TBMS_StartSequence = GetNodeIDByNodeName("TBMS.StartSequence");

                return _TBMS_StartSequence;
            }
        }

        public string TBMS_StopSequence
        {
            get
            {
                if (_TBMS_StopSequence == null) _TBMS_StopSequence = GetNodeIDByNodeName("TBMS.StopSequence");

                return _TBMS_StopSequence;
            }
        }

        public string TBMS_NeedSleep
        {
            get
            {
                if (_TBMS_NeedSleep == null) _TBMS_NeedSleep = GetNodeIDByNodeName("TBMS.NeedSleep");

                return _TBMS_NeedSleep;
            }
        }

        public string TBMS_Sleepping
        {
            get
            {
                if (_TBMS_Sleepping == null) _TBMS_Sleepping = GetNodeIDByNodeName("TBMS.Sleepping");

                return _TBMS_Sleepping;
            }
        }

        public string TBMS_BeamPermit51
        {
            get
            {
                if (_TBMS_BeamPermit51 == null) _TBMS_BeamPermit51 = GetNodeIDByNodeName("TBMS.BeamPermit51");

                return _TBMS_BeamPermit51;
            }
        }

        public string TBMS_BeamPermit52
        {
            get
            {
                if (_TBMS_BeamPermit52 == null) _TBMS_BeamPermit52 = GetNodeIDByNodeName("TBMS.BeamPermit52");

                return _TBMS_BeamPermit52;
            }
        }

        public string TBMS_BeamPermit53
        {
            get
            {
                if (_TBMS_BeamPermit53 == null) _TBMS_BeamPermit53 = GetNodeIDByNodeName("TBMS.BeamPermit53");

                return _TBMS_BeamPermit53;
            }
        }

        public string TBMS_SequencePermit51
        {
            get
            {
                if (_TBMS_SequencePermit51 == null)
                    _TBMS_SequencePermit51 = GetNodeIDByNodeName("TBMS.SequencePermit51");

                return _TBMS_SequencePermit51;
            }
        }

        public string TBMS_SequencePermit52
        {
            get
            {
                if (_TBMS_SequencePermit52 == null)
                    _TBMS_SequencePermit52 = GetNodeIDByNodeName("TBMS.SequencePermit52");

                return _TBMS_SequencePermit52;
            }
        }

        public string TBMS_SequencePermit53
        {
            get
            {
                if (_TBMS_SequencePermit53 == null)
                    _TBMS_SequencePermit53 = GetNodeIDByNodeName("TBMS.SequencePermit53");

                return _TBMS_SequencePermit53;
            }
        }

        public string TBMS_BeamAppStatus
        {
            get
            {
                if (_TBMS_BeamAppStatus == null) _TBMS_BeamAppStatus = GetNodeIDByNodeName("TBMS.BeamAppStatus");

                return _TBMS_BeamAppStatus;
            }
        }

        public string TBMS_ClearInterlockError
        {
            get
            {
                if (_TBMS_ClearInterlockError == null)
                    _TBMS_ClearInterlockError = GetNodeIDByNodeName("TBMS.ClearInterlockError");

                return _TBMS_ClearInterlockError;
            }
        }

        public string TBMS_Status
        {
            get
            {
                if (_TBMS_Status == null) _TBMS_Status = GetNodeIDByNodeName("TBMS.Status");

                return _TBMS_Status;
            }
        }

        public string TBMS_ErrorInfo
        {
            get
            {
                if (_TBMS_ErrorInfo == null) _TBMS_ErrorInfo = GetNodeIDByNodeName("TBMS.ErrorInfo");

                return _TBMS_ErrorInfo;
            }
        }

        public string TBMS_Heartbeat
        {
            get
            {
                if (_TBMS_Heartbeat == null) _TBMS_Heartbeat = GetNodeIDByNodeName("TBMS.Heartbeat");

                return _TBMS_Heartbeat;
            }
        }
    }
}