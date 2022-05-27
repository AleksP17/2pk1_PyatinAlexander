﻿using Redactor;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Redactor_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string FileName;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Boolean bold = false;
            if (bold == false)
            {
                TextBox.FontWeight = FontWeights.Bold;
                bold = true;
            }
            else
            {
                TextBox.FontWeight = FontWeights.Normal;
                bold = false;
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Boolean italic = false;
            if (italic == false)
            {
                TextBox.FontStyle = FontStyles.Italic;
                italic = true;
            }
            else
            {
                TextBox.FontStyle = FontStyles.Normal;
                italic = false;
            }
        }
        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Boolean underline = false;
            if (underline == false)
            {
                TextBox.TextDecorations = TextDecorations.Underline;
                underline = true;
            }
            else
            {
                TextBox.TextDecorations = TextDecorations.Baseline;
                underline = false;
            }
        }
        private void newFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
                FileName = createFileWindow.FileName;
            FileListBox.Items.Add(FileName);
            FileStream file1 = new FileStream($@"C:\Users\Admin\Desktop\Redactor\Redactor\data\{FileName}.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            writer.Close();
        }
        private void openFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
                FileName = createFileWindow.FileName;
            FileListBox.Items.Add(FileName);
            FileStream file2 = new FileStream($@"C:\Users\Admin\Desktop\Redactor\Redactor\data\{FileName}.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file2);
            TextBox.Text = reader.ReadToEnd();
            reader.Close();
        }
        private void saveFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
                FileName = createFileWindow.FileName;
            FileListBox.Items.Add(FileName);
            FileStream file1 = new FileStream($@"C:\Users\Admin\Desktop\Redactor\Redactor\data\{FileName}.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            writer.Write($"{TextBox.Text}");
            writer.Close();
        }
        private void deleteFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
                FileName = createFileWindow.FileName;
            File.Delete($@"C:\Users\Admin\Desktop\Redactor\Redactor\data\{FileName}.txt");

        }
        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
