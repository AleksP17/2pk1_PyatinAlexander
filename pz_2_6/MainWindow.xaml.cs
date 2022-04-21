using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace pz_2_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void press03Button_Click(object sender, RoutedEventArgs e)
        { 
            Regex x = new Regex(@"[-+*/]+");
            Match y = x.Match(inputTextBlock.Text);
            string nul = "0";
            while (y.Success) 
            {
                nul = Convert.ToString(y);
                y = y.NextMatch();
            }
            string text = inputTextBlock.Text;
            string[] newText = Regex.Split(text, "[-+*/]+");
            if (nul == "+")
                inputTextBlock.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) + Convert.ToDouble(newText[1]))}"; 
            else if (nul == "-")
                inputTextBlock.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) - Convert.ToDouble(newText[1]))}";
            else if (nul == "*")
                inputTextBlock.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) * Convert.ToDouble(newText[1]))}";
            else if (nul == "/")
                inputTextBlock.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) / Convert.ToDouble(newText[1]))}";
            else
                inputTextBlock.Text = "ERROR";
        }

        private void press7Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '7';
        }
        private void press8Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '8';
        }
        private void press9Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '9';
        }
        private void press4Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '4';
        }

        private void press5Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '5';
        }

        private void press6Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '6';
        }
        private void press1Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '1';
        }

        private void press2Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '2';
        }

        private void press3Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '3';
        }
        private void press0Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '0';
        }

       
        private void press00Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '+';
        }

        private void press01Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '-';
        }

        private void press02Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '*';
        }

        private void press04Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += '/';
        }

    }
}
