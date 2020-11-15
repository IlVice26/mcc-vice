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

namespace Vice_Launcher
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Colors
        private Color color_gray = (Color)ColorConverter.ConvertFromString("#FF9E9E9E");
        public MainWindow()
        {
            InitializeComponent();

            // Canvas initial visibility
            GamePage.Visibility = Visibility.Visible;
            gioca_text.Foreground = Brushes.White;
            ChangelogPage.Visibility = Visibility.Hidden;
        }

        public void ChangeToChangelog(object Sender, RoutedEventArgs e) 
        {
            gioca_text.Foreground = new SolidColorBrush(color_gray);
            changelog_text.Foreground = Brushes.White;
            ChangelogPage.Visibility = Visibility.Visible;
            GamePage.Visibility = Visibility.Hidden;
        }

        public void ChangeToGame(object Sender, RoutedEventArgs e) 
        {
            changelog_text.Foreground = new SolidColorBrush(color_gray);
            gioca_text.Foreground = Brushes.White;
            ChangelogPage.Visibility = Visibility.Hidden;
            GamePage.Visibility = Visibility.Visible;
        } 
    }
}
