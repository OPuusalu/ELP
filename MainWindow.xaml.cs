using System.ComponentModel;
using LiveCharts;
using System.Windows;
using System.Windows.Shapes;
using LiveCharts.Wpf;

namespace ELP
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class LineValues
    {
        private int[] values = new[] { 15, 20, 10, 30 };
    }

    public class ViewModel
    {
        public SeriesCollection Series { get; set; }

        public ViewModel()
        {
            Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series1",
                    Values = new ChartValues<double> { 4, 6, 5, 3, -3, -1, 2 }
                }
            };
        }
    }
}