using System.Diagnostics;
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

namespace ExampleApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
            this.Topmost = true;
        }

        private void Reboot_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");
        }

        private void Shutdown_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }
    }
}