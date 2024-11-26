using System.Drawing;
using System.Windows;
using System.Windows.Media;
using Color = System.Windows.Media.Color;

namespace colorgame
{ 
    public partial class MainWindow : Window
    {
        Color[] colorArray = new Color[]
        {
            Colors.Red,
            Colors.Green,
            Colors.Blue,
            Colors.Yellow,
            Colors.Purple,
            Colors.Magenta,
            Colors.Silver,
            Colors.LightGreen,
            Colors.DarkGreen,
            Colors.LightBlue,
            Colors.LightGray,
            Colors.DarkGray,
            Colors.LightGray,
            Colors.LightGreen,
            Colors.LightBlue,
            Colors.LightGray,
            Colors.DarkGray,
            Colors.LightGray,
            Colors.DarkGray
        };
        public Random random = new Random();

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void MyButton_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            while (i < random.Next(1, 5000)) {
                
                ga.Background = new SolidColorBrush(colorArray[random.Next(0, 18)]);
                
                i++;
                await Task.Delay(10);
            }

        }

    }
}