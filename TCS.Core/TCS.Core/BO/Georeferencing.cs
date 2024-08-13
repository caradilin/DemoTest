/************************************************************************************************
*	File Name			:	Georeferencing.cs              	    	                            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存配准数据的信息                                  *
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.BO
{
    public class Georeferencing
    {
        public string BeamName { get; set; }
        public int DRCount { get; set; } = 0;
        public int CTCount { get; set; } = 0;
        public DeviceType DeviceType { get; set; }
        public double ShiftX { get; set; }
        public double ShiftY { get; set; }
        public double ShiftZ { get; set; }
        public double RotateX { get; set; }
        public double RotateY { get; set; }
        public double RotateZ { get; set; }
    }
}