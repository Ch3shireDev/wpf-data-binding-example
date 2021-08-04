using System.Windows;

namespace Example
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public ViewModel ViewModel { get; set; } = new ViewModel();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.RefreshElements();
            Refresh();
        }

        private void Refresh()
        {
            DataContext = null;
            DataContext = ViewModel;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewModel.ParameterA += 1;
            Refresh();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ViewModel.ParameterB += "a";
            Refresh();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ViewModel.ParameterC += 1;
            Refresh();
        }
    }
}