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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _3D
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
                DispatcherTimer dp = new DispatcherTimer();
                dp.Interval = TimeSpan.FromSeconds(2);
                dp.IsEnabled = true;
                dp.Tick += dp_Tick;
                dp.Start();
  
     
        }

        void dp_Tick(object sender, EventArgs e)
        {
            if (i > 1)
            {
                return;
            }
            Point3D[] p3d = new Point3D[] { new Point3D(0, 0, 20), new Point3D(0, 0, 10) };
            this.cm.Position = p3d[i];
            i++;
        }
    }
}
