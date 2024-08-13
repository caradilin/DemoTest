/************************************************************************************************
*	File Name			:	OISDicomInstance.cs            							            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/06/04															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	OISDB的表DicomInstance对应的数据类                             		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.06.04	HeDian		    新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.OISTableModel
{
    public class OISDicomInstance
    {
        public string SOPInstanceUID { get; set; }

        public int InstanceNumber { get; set; }

        public string ReferencedFile { get; set; }

        public string TransferSyntax { get; set; }

        public string SOPClassUID { get; set; }

        public string StationName { get; set; }

        public string SeriesInstanceUID { get; set; }

        public DateTime ReceiveDate { get; set; }

        public string RetrieveAETitle { get; set; }

        public int ImageRows { get; set; }

        public int ImageColumns { get; set; }

        public int NumberOfFrames { get; set; }

        public int BitsAllocated { get; set; }
    }
}