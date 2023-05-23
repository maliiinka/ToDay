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
using ToDay.Database;

namespace ToDay
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            IRepository repository = new Repository();
            List<Database.Models.Efficiency> efficiencies = repository.getEfficienciesByWeek();
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            chart1.Series.Add(series);
            chart1.Legends.Clear();

            chart1.ChartAreas[0].AxisX.Title = "Дата";
            chart1.ChartAreas[0].AxisY.Title = "Количество выполненных задач";
            chart1.Titles.Add("График эффективности за неделю");

            Random random = new Random();
            DateTime currentDate = DateTime.Today;

            foreach (Database.Models.Efficiency efficiency in efficiencies)
                series.Points.AddXY(efficiency.day.Value.AddDays(-1).ToOADate(), efficiency.completed_tasks);

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
