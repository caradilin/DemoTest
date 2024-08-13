/************************************************************************************************
*	File Name			:	DatapointBase.cs  	            					                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/06/20															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	OPCUA Server数据节点定义的基类                                 		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.06.20	HeDian		    新规作成										*
*																								*
*************************************************************************************************/

using TCS.Core.Common;

namespace TCS.Core.Model.AppletModel
{
    public class DatapointBase
    {
        /// <summary>
        ///     数据节点ID前缀
        /// </summary>
        public string _NodeIdPrefix = string.Empty;

        /// <summary>
        ///     数据节点名前缀
        /// </summary>
        public string _NodePrefix = string.Empty;

        public DatapointBase(string nozzleid, string nodeidprefix)
        {
            _NodePrefix = GetNodeHeaderByNozzleID(nozzleid);
            _NodeIdPrefix = nodeidprefix;
        }

        public DatapointBase(string nodeidprefix)
        {
            _NodePrefix = string.Empty;
            _NodeIdPrefix = nodeidprefix;
        }

        public DatapointBase()
        {
        }

        public string GetNodeHeaderByNozzleID(string nozzleid)
        {
            var nodeheader = string.Empty;
            if (nozzleid == GLOBALCONST.NOZZLEID_R1)
            {
                nodeheader = "R1";
            }
            else if (nozzleid == GLOBALCONST.NOZZLEID_R2H)
            {
                nodeheader = "R2H";
            }
            else if (nozzleid == GLOBALCONST.NOZZLEID_R2V)
            {
                nodeheader = "R2V";
            }
            else if (nozzleid == GLOBALCONST.NOZZLEID_R3)
            {
                nodeheader = "R3";
            }
            else if (nozzleid == GLOBALCONST.NOZZLEID_R4)
            {
                nodeheader = "R4";
            }
            else if (nozzleid == GLOBALCONST.NOZZLEID_R3D)
            {
                nodeheader = "R3D";
            }

            return nodeheader;
        }

        public string GetNodeIDByNodeName(string nodename)
        {
            return string.Format(_NodeIdPrefix, nodename);
        }
    }
}