using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BasicCalculator
{
    public partial class MainPage : ContentPage
    {
        double first, second, result;
        string[] numbers = {" "," "};
        string symbol;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if("+-*/".Contains(btn.Text))
            {
                symbol = btn.Text;
                numbers[0] = Result.Text;
                Result.Text = "0"; 
            }
            else if("=".Contains(btn.Text))
            {
                numbers[1] = Result.Text;
                Calculate();
                Result.Text = result.ToString();
            }
            else if("C".Contains(btn.Text))
            {
                Result.Text = "0";
                numbers[0] = "";
                numbers[1] = "";
                symbol = "";
            }
            else
            {
                Result.Text += (sender as Button).Text;
            }
        }
        private void Calculate()
        {
            first = double.Parse(numbers[0]);
            second = double.Parse(numbers[1]);
            
            switch(symbol)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "/":
                    result = first / second;
                    break;
            }
        }
    }
}
