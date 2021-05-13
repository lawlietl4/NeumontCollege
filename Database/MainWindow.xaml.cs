using Database.DataSet1TableAdapters;
using System.Windows;

namespace Database
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
        GameTableAdapter gameTableAdapter = new GameTableAdapter();
        DataSet1 dataSet = new DataSet1();
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gameTableAdapter.Fill(dataSet.Game);
            dgd.DataContext = dataSet.Game.DefaultView;
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            gameTableAdapter.Update(dataSet);
        }
    }
}
