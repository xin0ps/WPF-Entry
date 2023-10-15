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

namespace wpf_task1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Random random = new Random();
            Button btn = (Button)sender;
            byte r = (byte)random.Next(0, 256);
            byte g = (byte)random.Next(0, 256);
            byte b = (byte)random.Next(0, 256);

            Color randomColor = Color.FromArgb(255, r, g, b);
            SolidColorBrush brush = new SolidColorBrush(randomColor);
            btn.Background = brush;
            MessageBox.Show($"{btn.Content} Buttonuna sol click edildi");
        }

    


        private void Button_Right_Click(object sender, RoutedEventArgs e)
        {



            Button button = (Button)sender;
            grid.Children.Remove(button);
            MessageBox.Show($"{button.Content} Button silindiii!");
            win.Title+=button.Content;

        }
    }
}

