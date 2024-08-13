// *************************************************************************************
// SCICHART® Copyright SciChart Ltd. 2011-2024. All rights reserved.
//  
// Web: http://www.scichart.com
//   Support: support@scichart.com
//   Sales:   sales@scichart.com
// 
// CreateAScatter3DChart.xaml.cs is part of the SCICHART® Examples. Permission is hereby granted
// to modify, create derivative works, distribute and publish any part of this source
// code whether for commercial, private or personal use. 
// 
// The SCICHART® examples are distributed in the hope that they will be useful, but
// without any warranty. It is provided "AS IS" without warranty of any kind, either
// expressed or implied. 
// *************************************************************************************

using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using Newtonsoft.Json;
using SciChart.Charting3D.Model;
using SciChart.Charting3D.PointMarkers;
using TCS.Core.TreatmentPlanDefinitions;

namespace WpfApp1
{
    public partial class CreateAScatter3DChart : UserControl
    {
        private List<PointScanLayer> beam;

        private int spot = 0;
        private int CurSpot = 0;
        private DispatcherTimer timer; // 定义定时器
        public CreateAScatter3DChart()
        {
            InitializeComponent();
       
            PointMarkerCombo.Items.Add(typeof(SpherePointMarker3D));
            PointMarkerCombo.Items.Add(typeof(CubePointMarker3D));
            PointMarkerCombo.Items.Add(typeof(PyramidPointMarker3D));
            PointMarkerCombo.Items.Add(typeof(CylinderPointMarker3D));

            var jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\beam.json");
            beam = GetJsonObject<List<PointScanLayer>>(jsonFilePath);

      
           timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10); // 设置定时器间隔为2ms
            timer.Tick += Timer_Tick; // 绑定Tick事件

            Loaded += OnLoaded;
        }
        private T GetJsonObject<T>(string jsonFilePath)
        {

            string jsonContent = File.ReadAllText(jsonFilePath);

            // 使用JsonConvert.DeserializeObject方法将JSON字符串反序列化为T对象  
            T data = JsonConvert.DeserializeObject<T>(jsonContent);
            return data;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            var xyzDataSeries3D = new XyzDataSeries3D<double>();

            foreach (var l in beam)
            {
                foreach(var s in l.PointScanInfos)
                {
                    var x = s.X;
                    var y = s.Y;
                    var z = l.LayerEnergy;

                    xyzDataSeries3D.Append(x, y, z);
                }
       
            }

            ScatterSeries3D.DataSeries = xyzDataSeries3D;

            PointMarkerCombo.SelectedIndex = 0;

            //timer.Start(); // 启动定时器
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            CurSpot++;

            ScatterSeries3D.DataSeries.Clear();
            var xyzDataSeries3D = new XyzDataSeries3D<double>();
            var c = 0;
            foreach (var l in beam)
            {
                foreach (var s in l.PointScanInfos)
                {
                    var x = s.X;
                    var y = s.Y;
                    var z = l.LayerEnergy;
                    c++;
                    if(c< CurSpot)
                    {
                        xyzDataSeries3D.Append(x, y, z, new PointMetadata3D(Colors.Red));
                    }
                    else
                    {
                        xyzDataSeries3D.Append(x, y, z);
                    }
                 
                }

            }

            ScatterSeries3D.DataSeries = xyzDataSeries3D;
        }

        private void PointMarkerCombo_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ScatterSeries3D != null && OpacitySlider != null && SizeSlider != null)
            {
                ScatterSeries3D.PointMarker = (BasePointMarker3D)Activator.CreateInstance((Type)((ComboBox)sender).SelectedItem);
                ScatterSeries3D.PointMarker.Fill = Color.FromArgb(0xFF, 0x64, 0xBA, 0xE4);
                ScatterSeries3D.PointMarker.Size = (float)SizeSlider.Value;
                ScatterSeries3D.PointMarker.Opacity = OpacitySlider.Value;
            }
        }

        private void SizeSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (ScatterSeries3D != null && ScatterSeries3D.PointMarker != null)
                ScatterSeries3D.PointMarker.Size = (float)((Slider)sender).Value;
        }

        private void OpacitySlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (ScatterSeries3D != null && ScatterSeries3D.PointMarker != null)
                ScatterSeries3D.PointMarker.Opacity = ((Slider)sender).Value;
        }
    }
}