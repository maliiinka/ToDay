using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ToDay
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();


            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            chart1.Series.Add(series);
            chart1.Legends.Clear();

            chart1.ChartAreas[0].AxisX.Title = "Дата";
            chart1.ChartAreas[0].AxisY.Title = "Количество выполненных задач";
            chart1.Titles.Add("График эффективности за неделю");

            Random random = new Random();
            DateTime currentDate = DateTime.Today;

            for (int i = 6; i >= 0; i--)
            {
                DateTime date = currentDate.AddDays(-i);
                int tasksCompleted = random.Next(0, 10);

                if (date <= currentDate)
                {
                    series.Points.AddXY(date.ToOADate(), tasksCompleted);
                }
            }

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            chart1.ChartAreas[0].AxisX.IntervalOffsetType = DateTimeIntervalType.Days;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;

            // Установка максимального значения для оси X
            chart1.ChartAreas[0].AxisX.Maximum = currentDate.ToOADate();

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

        }
    }
}
