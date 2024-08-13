/************************************************************************************************
*	File Name			:	MLCModel.cs              	    	                                *
*   Copyright			:	LANZHOU KEJIN TAIJI CORPORATION,LTD. All Rights Reserved.       	*
*   Create Date			:	2020/03/10															*
*   Author				:	Yu.HaiYang 															*
*																								*
*   Description			:	数据存储类，用于保存多叶光栅构型设备信息                          	*
*																								*
*-------------------------Revision History------------------------------------------------------*
*   No	Version		Date		Revised By		Description										*
*   1	V0.1		2020.03.10	Yu.HaiYang		新规作成										*
*																								*
*************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using TCS.Core.Common;

namespace TCS.Core.Model.DeviceModel
{
    /// <summary>
    ///     多叶光栅构型
    /// </summary>
    public class MLCModel : DeviceModelBase
    {
        /// <summary>
        /// 旋转是否已完成
        /// </summary>
        public bool RotateResult { get; set; } = false;
        /// <summary>
        ///     旋转方向
        /// </summary>
        public string RotateDirection { get; set; }

        /// <summary>
        ///     旋转角度
        /// </summary>
        public double RotateAngle { get; set; }

        /// <summary>
        ///     叶片对数
        /// </summary>
        public int BladeNum { get; set; }

        /// <summary>
        ///     叶片边界
        /// </summary>
        public string BladeBorder { get; set; }

        //铜门-A
        public double DoorA { get; set; } = 0;

        //铜门-B
        public double DoorB { get; set; } = 0;

        /// <summary>
        ///     多叶光栅叶片构型
        /// </summary>
        public string LeafJawPositions { get; set; }


        /// <summary>
        ///     多叶光栅OpcUa MLCData
        /// </summary>
        public string MLCData { get; set; }

        /// <summary>
        ///     Room MLC 光栅数据
        /// </summary>
        public string RoomMLCData { get; set; }

        /// <summary>
        /// 取得MLCData
        /// </summary>
        /// <param name="angleError"></param>
        /// <param name="abExchange"></param>
        /// <param name="abReverse"></param>
        /// <returns></returns>
        public string GetMLCData(double angleError, bool abExchange, bool abReverse)
        {
            if (MLCData.IsNullOrEmpty())
            {
                SetMLCDataString(angleError, abExchange, abReverse);
                return MLCData;
            }

            return MLCData;
        }

        /// <summary>
        /// 将治疗计划的光栅数据做成光栅DLL能使用的数据格式
        /// </summary>
        /// <param name="angletolrange"></param>
        /// <param name="abExchange"></param>
        /// <param name="abReverse"></param>
        public void SetMLCDataString(double angletolrange, bool abExchange, bool abReverse)
        {
            var leafPosition = LeafJawPositions.Split('\\').ToList();
            var mlctest = LeafJawPositions.Split('\\').ToList();
            string mlcDataInfoNodeValue = string.Empty;
            if (leafPosition.Count < BladeNum * 2)
            {
                throw new ArgumentException($"非法的多叶光栅目标数据，不足{BladeNum}对数据！");
            }
            //治疗计划中A边的所有值取反，写入到设备中
            for (int i = 0; i < leafPosition.Count / 2; i++)
            {
                //计划系统中前leafPosition.Count/2是A边
                leafPosition[i] = (leafPosition[i].ToFloat() * -1).ToString();
            }
            // ---------- Buglist(94) Modified by ZhangYao 2022.6.6 Start ----------
            // 统一数据
            mlctest = leafPosition;
            /// AB位置交换（默认A边在前B边在后；交换后B边在前A边在后)
            if (abExchange)
            {
                mlctest = ABExchange(leafPosition);
            }
            //AB各自反序(默认A1 - A50; B1 - B50；反序后A50 - A1; B50 - B1)
            if (abReverse)
            {
                mlctest = ABReverse(mlctest);
            }
            var leafWidth = GLOBALCONST.ACTUALRASTER / (mlctest.Count / 2);
            var firstSsLeaf = mlctest.FindIndex(v => Math.Abs(v.ToFloat()) > 0);
            float doorA = firstSsLeaf > 0 ? (firstSsLeaf) * leafWidth : 0;
            var lastSsLeaf = mlctest.FindLastIndex(v => Math.Abs(v.ToFloat()) > 0);
            float doorB = lastSsLeaf < mlctest.Count() - 1 ? (mlctest.Count() - 1 - lastSsLeaf) * leafWidth : 0;
            // ---------- Buglist(94) Modified by ZhangYao 2022.6.6 End ----------
            if (doorA < 0 && doorB < 0)
            {
                doorA = doorB = 0;
            }
            // ---------- 变更对应 tcs下发到光栅如果在 265-360之间 需要减去360  Modified by  2022.10.04 Start ----------
            // 因为计划系统那面角度是0-90 270-360  但是光栅程序只认 -90-0 0-90 所以要转换一下  不然旋转角度是不动的
            // tcs下发到光栅如果在 265-360之间，需要减去360。
            if (RotateAngle > 265.0 && RotateAngle < 360.0)
            {
                RotateAngle = RotateAngle - 360.0;
            }
            // ---------- 变更对应 tcs下发到光栅如果在 265-360之间 需要减去360  Modified by  2022.10.04 End ----------

            MLCData = string.Join(",", mlctest.Take(BladeNum)) + ";"
                       + string.Join(",", mlctest.GetRange(BladeNum, BladeNum)) + ";"
                       + doorA + "," + doorB + ";" + RotateAngle + ";" + angletolrange;

            // 在光栅信息转换了之后，重新更新叶片位置信息（为了治疗室的光栅表示用）
            RoomMLCData = string.Join(",", mlctest.Take(BladeNum * 2)).Replace(",", "\\");
        }

        /// <summary>
        /// 将输入的list数据均分两部分，各自交换位置
        /// </summary>
        /// <param name="lsab">叶片数据</param>
        /// <returns>交换位置后的List</returns>
        public static List<string> ABExchange(List<string> lsab)
        {
            if (lsab == null || lsab.Count == 0)
                return null;

            // 检查输入数据是否成对
            if (lsab.Count % 2 > 0)
                return null;

            List<string> lsret = new List<string>();

            // 追加B边数据到List首部
            for (int i = lsab.Count / 2; i < lsab.Count; i++)
                lsret.Add(lsab[i]);

            // 追加A边数据到List尾部
            for (int i = 0; i < lsab.Count / 2; i++)
                lsret.Add(lsab[i]);

            return lsret;
        }

        /// <summary>
        /// 将输入List的数据均分两部分，各自反转
        /// </summary>
        /// <param name="lsab">叶片数据</param>
        /// <returns>反转后的List</returns>
        public static List<string> ABReverse(List<string> lsab)
        {
            if (lsab == null || lsab.Count == 0)
                return null;

            // 检查输入数据是否成对
            if (lsab.Count % 2 > 0)
                return null;

            List<string> lsret = new List<string>();
            lsret.AddRange(lsab);
            lsret.Reverse(0, lsret.Count / 2);
            lsret.Reverse(lsret.Count / 2, lsret.Count / 2);

            return lsret;
        }

    }
}