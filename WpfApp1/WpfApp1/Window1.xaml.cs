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
using System.Windows.Shapes;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            int n = int.Parse(tx1.Text);

           
            char[] charArray = new char[n];
            tx.Text.ToCharArray().CopyTo(charArray, 0);
            charArray.Reverse();
            char k = charArray[0];
            charArray[0] = charArray[charArray.Length-1];
            charArray[charArray.Length - 1] = k;
            tx2.Text=(string)(charArray.ToString());


        }
    }
}
