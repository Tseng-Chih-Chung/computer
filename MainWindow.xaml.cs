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

        double Firstnumber;//第一個數值
        double Secondnumber;//第二個數值
        int operation;//+-*/的名稱
  
        private void btnAC_Click(object sender, RoutedEventArgs e)
        {
            txt_number.Text = "0";
            Firstnumber = 0;
            Secondnumber = 0;
            operation = -1; //這邊感覺可以不用加
            //只要按AllClean(AC)就把一切重製
        }

        private void btn_decimal_point_Click(object sender, RoutedEventArgs e)
        {
            if (txt_number.Text.IndexOf(".")==-1)
                //Indexof是要去判斷有沒有規定的字串出現
            {
                txt_number.Text += ".";
            }
            //如果沒有 . 才會加 .
        }

        void same(string _en)//用string是因為txt_number.text是字串
        {
            if (txt_number.Text == "0")
            {
                txt_number.Text = "";
                txt_number.Text += _en;
            }
            //如果預設數只有0就清零再添加對應數字
        }

        private void btc1_Click(object sender, RoutedEventArgs e)
        {
            same("1");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            same("2");
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            same("3");
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            same("4");
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            same("5");
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            same("6");
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            same("7");
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            same("8");
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            same("9");
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            same("0");
        }

        void first(int _symbol)
        {
            Firstnumber = Convert.ToSingle(txt_number.Text);
            //ToSingle只是把字串轉成浮點數(用Todouble也行)
            //double.TryParse(txt_number.Text, out Firstnumber); 這樣也可以
            txt_number.Text = "0";
            operation = _symbol;
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            first(0);//輸出+的代號
        }

        private void btn_reduce_Click(object sender, RoutedEventArgs e)
        {
            first(1);//輸出-的代號
        }

        private void btn_multiplication_Click(object sender, RoutedEventArgs e)
        {
            first(2);//輸出*的代號
        }

        private void btn_division_Click(object sender, RoutedEventArgs e)
        {
            first(3);//輸出/的代號
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            double Ans = 0;//建立名為Ans的浮點數
            Secondnumber = Convert.ToSingle(txt_number.Text);
            switch(operation)
            {
                case 0:
                    Ans = Firstnumber + Secondnumber;
                    break;
                case 1:
                    Ans = Firstnumber - Secondnumber;
                    break;
                case 2:
                    Ans = Firstnumber * Secondnumber;
                    break;
                case 3:
                    Ans = Firstnumber / Secondnumber;
                    break;
            }
            txt_number.Text = string.Format("{0:0.#####}", Ans);
            operation = -1; //讓再點一下=的數不會錯亂 像:非數值或呈現倒數(但會顯示0)
            Firstnumber = 0;
            Secondnumber = 0;
            Ans = 0;//做完運算後把一切浮點數歸零
        }

        
    }
}
