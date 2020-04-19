using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfLearn
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

        //private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    TextBlock textBlock = sender as TextBlock;
        //    textBlock.Text = "Change Text Block 1";
        //}

        //private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        //{
        //    Process.Start(e.Uri.ToString());
        //    TextBlock ob = sender as TextBlock;
        //    textBlock2.Text = textblock1.Inlines.ElementAt(0).ToString();
        //    textBlock2.Inlines.Add(new Run("Text new Add") { FontSize = 30 });
        //}



        //private void Button1_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void SetSourceImage_Click(object sender, RoutedEventArgs e)
        //{

        //    image1.Source = new BitmapImage(new Uri(pathSource.Text));
        //}

        //private void Radio1_Checked(object sender, RoutedEventArgs e)
        //{
        //    RadioButton radio = sender as RadioButton;
        //    var result = radio.Content;
        //    if (result == null) result = "Radio 1";  
        //}
    }
}
