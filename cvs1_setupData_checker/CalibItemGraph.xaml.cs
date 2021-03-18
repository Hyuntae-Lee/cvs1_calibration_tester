using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cvs1_setupData_checker
{
    /// <summary>
    /// Interaction logic for CalibItemGraph.xaml
    /// </summary>
    public partial class CalibItemGraph : UserControl
    {
        public CalibItemGraph()
        {
            InitializeComponent();
        }

        public void setUISize(double width, double height)
        {
            lineXAxis.X1 = 0;
            lineXAxis.Y1 = height / 2;
            lineXAxis.X2 = width;
            lineXAxis.Y2 = lineXAxis.Y1;
        }
    }
}
