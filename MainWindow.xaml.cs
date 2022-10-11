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

namespace Password_Generator
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

        private static bool addUpperCase;
        private static bool addNumbers;
        private static bool addSpecials;
        private static string Chars;
        private static int length;



        private void uppercaseCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            addUpperCase = true;
        }
        private void uppercaseCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            addUpperCase = false;
        }

        private void numbersCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            addNumbers = true;
        }

        private void numbersCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            addNumbers = false;
        }

        private void specialCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            addSpecials = true;
        }
        private void specialCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            addSpecials = false;
        }

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            length = (int)lengthSlider.Value;
            if (addUpperCase && addNumbers && addSpecials)
            {
                Chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890?!@#$%^&*";
            }
            else if (addUpperCase && addNumbers)
            {
                Chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            }
            else if (addUpperCase && addSpecials)
            {
                Chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ?!@#$%^&*";
            }
            else if (addNumbers && addSpecials)
            {
                Chars = "abcdefghijklmnopqrstuvwxyz1234567890?!@#$%^&*";
            }
            else if (addUpperCase)
            {
                Chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            else if (addNumbers)
            {
                Chars = "abcdefghijklmnopqrstuvwxyz1234567890";
            }
            else if (addSpecials)
            {
                Chars = "abcdefghijklmnopqrstuvwxyz?!@#$%^&*";
            }
            else
            {
                Chars = "abcdefghijklmnopqrstuvwxyz";
            }
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            while (0 < length--)
            {
                sb.Append(Chars[random.Next(Chars.Length)]);
            }
            string password = sb.ToString();
            pwTextBox.Text = password;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(pwTextBox.Text);
        }

        private void lengthSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            length = (int)lengthSlider.Value;
        }

    }
}
