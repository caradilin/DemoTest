/************************************************************************************************
*	File Name			:	OISDicomStudy.cs           							                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/06/04															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	OISDB的表DicomStudy对应的数据类                             		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.06.04	HeDian		    新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.OISTableModel
{
    public class OISDicomStudy
    {
        public string STUDYINSTANCEUID { get; set; }

        public DateTime STUDYDATE { get; set; }

        public string ACCESSIONNUMBER { get; set; }

        public string STUDYID { get; set; }

        public string REFDRNAME { get; set; }

        public string STUDYDESCRIPTION { get; set; }

        public string ADMITTINGDIAGNOSESDESC { get; set; }

        public string PATIENTAGE { get; set; }

        public int PATIENTSIZE { get; set; }

        public int PATIENTWEIGHT { get; set; }

        public string OCCUPATION { get; set; }

        public string ADDITIONALPATIENTHISTORY { get; set; }

        public string INTERPRETATIONAUTHOR { get; set; }

        public string PATIENTID { get; set; }

        public string RETRIEVEAETITLE { get; set; }
    }
}