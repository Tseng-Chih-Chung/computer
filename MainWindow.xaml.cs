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

namespace computer
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAC_Click(object sender, RoutedEventArgs e)
        {
            txt_number.Text = "0";
        }

        private void btc1_Click(object sender, RoutedEventArgs e)
        {
            if(txt_number.Text == "0")
            {
                txt_number.Text = "";
            }
            txt_number.Text += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (txt_number.Text == "0")
            {
                txt_number.Text = "";
            }
            txt_number.Text += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (txt_number.Text == "0")
            {
                txt_number.Text = "";
            }
            txt_number.Text += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (txt_number.Text == "0")
            {
                txt_number.Text = "";
            }
            txt_number.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (txt_number.Text == "0")
            {
                txt_number.Text = "";
            }
            txt_number.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (txt_number.Text == "0")
            {
                txt_number.Text = "";
            }
            txt_number.Text += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (txt_number.Text == "0")
            {
                txt_number.Text = "";
            }
            txt_number.Text += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (txt_number.Text == "0")
            {
                txt_number.Text = "";
            }
            txt_number.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (txt_number.Text == "0")
            {
                txt_number.Text = "";
            }
            txt_number.Text += "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (txt_number.Text == "0")
            {
                txt_number.Text = "";
            }
            txt_number.Text += "0";
        }
    }
}
