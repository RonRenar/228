using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string EncryptSentence(string sentence)
        {
            string encryptedSentence = "";

            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    char encryptedChar = EncryptChar(c);
                    encryptedSentence += encryptedChar;
                }
                else
                {
                    encryptedSentence += c;
                }
            }

            return encryptedSentence;
        }
        static char EncryptChar(char c)
        {
            bool isLowerCase = char.IsLower(c);
            char normalizedChar = char.ToUpper(c);

            char encryptedChar;
            if (normalizedChar == 'Я')
            {
                encryptedChar = isLowerCase ? 'а' : 'А';
            }
            else if (normalizedChar == 'Ё')
            {
                encryptedChar = isLowerCase ? 'ж' : 'Ж';
            }
           
            else
            {
                encryptedChar = (char)(normalizedChar + 1);
                if (isLowerCase && !char.IsLower(encryptedChar))
                {
                    encryptedChar = char.ToLower(encryptedChar);
                }
                else if (!isLowerCase && !char.IsUpper(encryptedChar))
                {
                    encryptedChar = char.ToUpper(encryptedChar);
                }
            }

            return encryptedChar;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string sentence =tx.Text;
            string encryptedSentence = EncryptSentence(sentence);

            lb.Content= encryptedSentence;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
             Window window = new Window1();   
            window.Show();
        }
    }
}
