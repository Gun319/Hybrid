using System.Windows;

namespace Hybrid.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Height = SystemParameters.WorkArea.Height / 1.2;
            this.Width = SystemParameters.WorkArea.Width / 1.2;
        }
    }
}