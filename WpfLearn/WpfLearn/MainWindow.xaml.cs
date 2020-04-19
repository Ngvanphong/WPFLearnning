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

            //string str1 = "Biding Template";
            //btnBidingBehide.DataContext = str1;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<DataItemCombobox> listData = new List<DataItemCombobox>()
            {
                new DataItemCombobox(){Name="Item 1",Value="Value 1"},
                new DataItemCombobox(){Name="Item 2",Value="Value 2"},
                new DataItemCombobox(){Name="Item 3",Value="Value 3"}
            };
          
            combobox2.ItemsSource = listData;
            combobox2.DisplayMemberPath = "Name";
            combobox2.SelectedValuePath = "Value";

            combobox3.ItemsSource = listData;

            combobox4.ItemsSource = typeof(Colors).GetProperties();


        }

        
        

        private void Combobox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var item = combobox2.SelectedItem as DataItemCombobox;
            //var value = combobox2.SelectedValue;          
        }

        private void Combobox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = combobox3.SelectedItem;

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
    public class DataItemCombobox
    {
        public string Name { set; get; }

        public string Value { set; get; }
    }
}
