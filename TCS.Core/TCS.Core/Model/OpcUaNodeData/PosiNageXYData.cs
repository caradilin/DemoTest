/************************************************************************************************
*	File Name			:	PosiNageXYData.cs              	    	                            *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存传递给电源的数据                               	*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

namespace TCS.Core.Model.OpcUaNodeData
{
    /// <summary>
    ///     于计算传递给电源的数据
    /// </summary>
    public class PosiNageXYData
    {
        /// <summary>
        ///     正向KX值（小数点保留2位）
        /// </summary>
        public float ISOPosiKX { get; set; }

        /// <summary>
        ///     正向BX值（小数点保留2位）
        /// </summary>
        public float ISOPosiBX { get; set; }

        /// <summary>
        ///     负向KX值（小数点保留2位）
        /// </summary>
        public float ISONageKX { get; set; }

        /// <summary>
        ///     负向BX值（小数点保留2位）
        /// </summary>
        public float ISONageBX { get; set; }

        /// <summary>
        ///     正向KY值（小数点保留2位）
        /// </summary>
        public float ISOPosiKY { get; set; }

        /// <summary>
        ///     正向BY值（小数点保留2位）
        /// </summary>
        public float ISOPosiBY { get; set; }

        /// <summary>
        ///     负向KY值（小数点保留2位）
        /// </summary>
        public float ISONageKY { get; set; }

        /// <summary>
        ///     负向BY值（小数点保留2位）
        /// </summary>
        public float ISONageBY { get; set; }

        /// <summary>
        ///     分条KX（小数点保留2位）
        /// </summary>
        public float SlittingKX { get; set; }

        /// <summary>
        ///     分条KY（小数点保留2位）
        /// </summary>
        public float SlittingKY { get; set; }

        /// <summary>
        ///     分条BX（小数点保留2位）
        /// </summary>
        public float SlittingBX { get; set; }

        /// <summary>
        ///     分条BY（小数点保留2位）
        /// </summary>
        public float SlittingBY { get; set; }
    }
}