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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        String FirstNum;
        String SecondNum;
        String Operator="" ;
        int Result;
        public MainWindow()
        {
            InitializeComponent();
        }
         private void Commonbtn(object sender, RoutedEventArgs e)
        {
            Button btncommon= (Button)sender;
             Operator = btncommon.Content.ToString();
              Answer.Text = FirstNum.ToString()+ Operator;
        }
        
        private void Numbtn(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <=5 ; i++)
            {
                MessageBox.Show("Hello");
            }
             
            //  Button btnNum= (Button)sender;
              
            //  if(Operator=="")
            //{
                   
            //    FirstNum += btnNum.Content.ToString();
            //    Answer.Text = FirstNum.ToString() ;

            //}
            //else
            //{
            //    SecondNum += btnNum.Content.ToString();
            //    Answer.Text = FirstNum.ToString() + Operator + SecondNum.ToString();
            //}
        }
        private void Equalbtn(object sender, RoutedEventArgs e)
        {
              int FirstNumber = Convert.ToInt32(FirstNum);
              int SecondNumber = Convert.ToInt32(SecondNum);

            if(Operator == "+")
            {
                 Result = FirstNumber + SecondNumber;
                Answer.Text =  Result.ToString();

            }
             else if (Operator == "-")
            {
                 Result = FirstNumber - SecondNumber;
                Answer.Text = Result.ToString();
             }
            else if (Operator == "÷")
            {
                Result = FirstNumber / SecondNumber;
                Answer.Text = Result.ToString();
            }
            else if (Operator == "%")
            {
                Result = FirstNumber % SecondNumber;
                Answer.Text = Result.ToString();
            }
            else if (Operator == "×")
            {
                Result = FirstNumber * SecondNumber;
                Answer.Text = Result.ToString();
            }
            FirstNum = "";
            SecondNum = "";
            Operator="";
        }
        private void clear(object sender, RoutedEventArgs e)
        {
            FirstNum = "";
            SecondNum = "";
            Operator="";
          
            Answer.Clear();
        }
    }
}
       
