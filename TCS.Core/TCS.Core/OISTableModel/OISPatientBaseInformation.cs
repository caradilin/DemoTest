/************************************************************************************************
*	File Name			:	OISPatientBaseInformation.cs  						                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/06/04															*
*   Author				:	He.Dian 															*
*																								*
*   Description			:	OISDB的表PatientBaseInformation对应的数据类                    		*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.06.04	HeDian		    新规作成										*
*																								*
*************************************************************************************************/

using System;

namespace TCS.Core.OISTableModel
{
    /// <summary>
    ///     患者基本信息表
    /// </summary>
    internal class OISPatientBaseInformation
    {
        /// <summary>
        ///     患者ID
        /// </summary>
        public string PatientID { get; set; }

        /// <summary>
        ///     患者姓名
        /// </summary>
        public string PatientName { get; set; }

        /// <summary>
        ///     患者出生年月日
        /// </summary>
        public DateTime PatientBirthDate { get; set; }

        /// <summary>
        ///     患者性别
        /// </summary>
        public string PatientSex { get; set; }

        /// <summary>
        ///     创建日时
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///     更新日时
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}