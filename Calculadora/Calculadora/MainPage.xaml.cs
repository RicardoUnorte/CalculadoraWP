using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Calculadora
{
    public partial class MainPage : PhoneApplicationPage
    {
        static Double num1, num2;
        string signo;
        bool sw = false,dec =false;
        // Constructor
        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            if (sw == true)
            {
                textout.Text = "";
                sw = false;
            }
            Button bt = (Button)(e.OriginalSource);
            textout.Text += bt.Content;
        }
        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (sw == true)
            {
                textout.Text = "";
                sw = false;
            }
            Button bt = (Button)(e.OriginalSource);
            textout.Text += bt.Content;
        }
        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            if (sw == true)
            {
                textout.Text = "";
                sw = false;
            }
            Button bt = (Button)(e.OriginalSource);
            textout.Text += bt.Content;
        }
        private void bt03_Click(object sender, RoutedEventArgs e)
        {
            if (sw == true)
            {
                textout.Text = "";
                sw = false;
            }
            Button bt = (Button)(e.OriginalSource);
            textout.Text += bt.Content;
        }
        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            if (sw == true)
            {
                textout.Text = "";
                sw = false;
            }
            Button bt = (Button)(e.OriginalSource);
            textout.Text += bt.Content;
        }
        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            if (sw == true)
            {
                textout.Text = "";
                sw = false;
            }
            Button bt = (Button)(e.OriginalSource);
            textout.Text += bt.Content;
        }
        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            if (sw == true)
            {
                textout.Text = "";
                sw = false;
            }
            Button bt = (Button)(e.OriginalSource);
            textout.Text += bt.Content;
        }
        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            if (sw == true)
            {
                textout.Text = "";
                sw = false;
            }
            Button bt = (Button)(e.OriginalSource);
            textout.Text += bt.Content;
        }
        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            if (sw == true)
            {
                textout.Text = "";
                sw = false;
            }
            Button bt = (Button)(e.OriginalSource);
            textout.Text += bt.Content;
        }
        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            if (sw == true)
            {
                textout.Text = "";
                sw = false;
            }
            Button bt = (Button)(e.OriginalSource);
            textout.Text += bt.Content;
        }
        private void plus_click(object sender, RoutedEventArgs e)
        {

            num1 = Convert.ToDouble(textout.Text);
            Button bt = (Button)(e.OriginalSource);
            signo = Convert.ToString(bt.Content);
            sw = true;
            dec = false;
        }
        private void menos_click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(textout.Text);
            Button bt = (Button)(e.OriginalSource);
            signo = Convert.ToString(bt.Content);
            sw = true;
            dec = false;
        }
        private void mult_click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(textout.Text);
            Button bt = (Button)(e.OriginalSource);
            signo = Convert.ToString(bt.Content);
            sw = true;
            dec = false;
        }
        private void div_click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(textout.Text);
            Button bt = (Button)(e.OriginalSource);
            signo = Convert.ToString(bt.Content);
            sw = true;
            dec = false;
        }
        private void igual_click(object sender, RoutedEventArgs e)
        {
            
            num2 = Convert.ToDouble(textout.Text);
            Double result = Calcular(signo, num1, num2);
            textout.Text = Convert.ToString(result);
            dec = false;
            
            
        }

        private void AC_click(object sender, RoutedEventArgs e)
        {
            //Borrar todo AC
            textout.Text = "";

        }
        private void C_click(object sender, RoutedEventArgs e)
        {       //Borrar cada digito
            if (textout.Text.Equals(""))
            {
                textout.Text = "";
            }
            else
            {
                String c = textout.Text;
                textout.Text = c.Substring(0, c.Length - 1);
            }
        }
        private void Point_click(object sender, RoutedEventArgs e)
        {
            if (dec == false)
            {
                Button bt = (Button)(e.OriginalSource);
                textout.Text += bt.Content;
                dec = true;
            }
            else
            {
                return;
            }
            

        }

        private Double Calcular(String s, Double n1, Double n2){
              Double r=0;
                switch(s){
                    case "+":
                        r= n1 + n2;
                        break;
                    case "-":
                        r= n1 - n2;
                        break;
                    case "*":
                        r= n1 * n2;
                        break;
                    case "/":
                        r= n1 / n2;
                        break;
                }
                

                return r;
            }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}