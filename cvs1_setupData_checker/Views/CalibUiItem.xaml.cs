using cvs1_setupData_checker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for CalibItem.xaml
    /// </summary>
    public partial class CalibUiItem : UserControl
    {
        List<CalibDataItem> DataList { get; set; }

        public CalibUiItem()
        {
            InitializeComponent();
        }

        public void setUISize(double width, double height)
        {
            var graphHeight = height - gridHeader.Height - gridFooter.Height;

            graph.setUISize(width, graphHeight);
        }
    }
}
