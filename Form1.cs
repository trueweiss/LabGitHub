using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace CurrencyChart
{
    public partial class Form1 : Form
    {
        List<Rate> rates = new List<Rate>();

        public Form1()
        {
            InitializeComponent();
            DownloadFiles();
        }

        private void DownloadFiles()
        {
            using(var client = new WebClient())
            {
                client.DownloadFile("https://www.moex.com/export/derivatives/currency-rate.aspx?language=en&currency=USD/RUB&moment_start=2021-08-14&moment_end=2021-09-14", "USD.xml");
                client.DownloadFile("https://www.moex.com/export/derivatives/currency-rate.aspx?language=en&currency=EUR/RUB&moment_start=2021-08-14&moment_end=2021-09-14", "EUR.xml");
                client.DownloadFile("https://www.moex.com/export/derivatives/currency-rate.aspx?language=en&currency=UAH/RUB&moment_start=2021-08-14&moment_end=2021-09-14", "UAH.xml");
            }
        }

        private void LoadRates(string file)
        {
            rates.Clear();

            using (var fileStream = File.OpenText(file))
            {
                using (XmlReader reader = XmlReader.Create(fileStream))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "rate")
                        {
                            rates.Add(new Rate(reader.GetAttribute("moment"), reader.GetAttribute("value")));
                        }
                    }
                }
            }

            rates.Reverse();

        }

        private void ShowRates(string file, string title)
        {
            LoadRates(file);

            double min = rates[0].Value;
            double max = rates[0].Value;

       
            for (int i = 0; i < rates.Count; i++)
            {
                if (min > rates[i].Value)
                {
                    min = rates[i].Value;
                }

                if (max < rates[i].Value)
                {
                    max = rates[i].Value;
                }
            }

            Chart.Series[0].Points.Clear();                         
            Chart.ChartAreas[0].AxisY.Minimum = Math.Floor(min);    
            Chart.ChartAreas[0].AxisY.Maximum = Math.Ceiling(max); 
            Chart.Titles[0].Text = title;                          

            //Chart.Series[0].ToolTip = "Currency: #VALY";

           
            for (int i = 0; i < rates.Count; i++)
            {
                Chart.Series[0].Points.AddXY(rates[i].Moment, rates[i].Value);
            }

        }

        private void USD_Click(object sender, EventArgs e)
        {
            ShowRates("USD.xml", "Американский доллар к русскому рублю");
        }

        private void EUR_Click(object sender, EventArgs e)
        {
            ShowRates("EUR.xml", "Евро к русскому рублю");
        }

        private void UAH_Click(object sender, EventArgs e)
        {
            ShowRates("UAH.xml", "Украинская гривна к русскому рублю");
        }

        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();
        private void Chart_MouseMove(object sender, MouseEventArgs e)
        {
           // var pos = e.Location;

           // if (prevPosition.HasValue && pos == prevPosition.Value)
           //     return;

           // tooltip.RemoveAll();
           // prevPosition = pos;
           //var results = Chart.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);
           // foreach (var result in results)
           // {
           //     if (result.ChartElementType == ChartElementType.DataPoint)
           //     {
           //         var prop = result.Object as DataPoint;
           //         if (prop != null)
           //         {
           //             var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
           //             var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        
           //             int error = 50;
           //             if (Math.Abs(pos.X - pointXPixel) < error && Math.Abs(pos.Y - pointYPixel) < error)
           //             {
           //                 Chart.Series[0].MarkerColor = Color.Green;
           //                 Chart.Series[0].MarkerSize = 10;

           //                 Chart.Series[0].MarkerStyle = MarkerStyle.Circle;
           //                 Chart.Series[0].IsValueShownAsLabel = true;
           //                 Chart.Series[0].LabelFormat = "X=" + prop.XValue + ", Y=" + prop.YValues[0];

           //                 tooltip.Show("X=" + prop.XValue + ", Y=" + prop.YValues[0], this.Chart, pos.X, pos.Y - 15);
           //                 Debug.WriteLine("X=" + prop.XValue + ", Y=" + prop.YValues[0], this.Chart, pos.X, pos.Y - 15);
           //             }
           //         }
           //     }
           // }
        }

        DataPoint dpCurrent = null;
        int normalMarkerSize = 10;
        int largeMarkerSize = 15;

        private void Chart_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Left:
                    HitTestResult result = Chart.HitTest(e.X, e.Y, ChartElementType.DataPoint);
                    var prop = result.Object as DataPoint;
                    if (prop != null) prop.MarkerStyle = MarkerStyle.Circle;
                    break;

                case MouseButtons.Right:
                    Chart.Series[0].MarkerStyle = MarkerStyle.None;
                    break;

                 //    List<Rate> rates = new List<Rate>();
            }
            
        }
    }
}

 // var results = Chart.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);