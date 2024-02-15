using System.ComponentModel;
using LiveCharts;
using System.Windows;

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

        public int[] getValues
        {
            get
            {
                return values;
            }
        }
        
    }
}