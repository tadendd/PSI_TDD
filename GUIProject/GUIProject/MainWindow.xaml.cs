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

namespace GUIProject
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
        static int finalValue = 0;
        static bool Checked = true;
        static double tempC = 0;
        static double tempF = 0;
        static double BUN = 0;
        
        static double G = 0;
 
        static double O = 0;

        static int age = 0;
        static int rate = 0;
        static double PH = 0;
        static int SBP = 0;
        static int Sodium = 0;
        static int h = 0;
        static int count = 0;
        static string filepath;
        static String s1 = null;
        static String s2 = null;
        static String s3 = null;
        static String s4 = null;
        static String s5 = null;
        static int box3 = 1;
        static int box2 = 1;
        static int box1 = 1;
        static int box4 = 1;
        static int box5 = 1;
        static int box6 = 1;
        static int box7 = 1;
        static int box8 = 1;
        static int box9 = 1;
        static int box10 = 1;
        static int box11 = 1;
        static int box12 = 1;
        static int box13 = 1;
        static int box14 = 1;
        static int box15 = 1;
        static int box16 = 1;

        public int TextChanged { get; private set; }
        public bool AcceptsReturn { get; set; }
        private void CheckBox_Checked(object sender, System.EventArgs e)
        {
            if (Checked == true)
            {
                finalValue = finalValue + 10;
                Console.WriteLine(finalValue);
                 box1 = 1;
            }
            else
            {
                finalValue = finalValue - 10;
                Console.WriteLine(finalValue);
                 box1 = 0;
            }
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            if (Checked == true)
            {
                finalValue = finalValue + 30;
                Console.WriteLine(finalValue);
            }
            else
            {
                finalValue = finalValue - 30;
                Console.WriteLine(finalValue);
            }
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            if (Checked == true)
            {
                finalValue = finalValue + 20;
                Console.WriteLine(finalValue);
                box13 = 1;
            }
            else
            {
                finalValue = finalValue - 20;
                Console.WriteLine(finalValue);
                box13 = 0;
            }
        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            if (Checked == true)
            {
                finalValue = finalValue + 10;
                Console.WriteLine(finalValue);
                box11 = 1;
            }
            else
            {
                finalValue = finalValue - 10;
                Console.WriteLine(finalValue);
                box11 = 0;
            }
        }

        private void CheckBox_Checked_4(object sender, RoutedEventArgs e)//Cerebro
        {
            if (Checked == true)
            {
                finalValue = finalValue + 10;
                Console.WriteLine(finalValue);
                box5 = 1;
            }
            else
            {
                finalValue = finalValue = -10;
                Console.WriteLine(finalValue);
                box5 = 0;
            }

        }

        private void CheckBox_Checked_5(object sender, RoutedEventArgs e)//Renel
        {
            if (Checked == true)
            {
                finalValue = finalValue + 20;
                Console.WriteLine(finalValue);
                int box3 = 1;
            }
            else
            {
                finalValue = finalValue - 20;
                Console.WriteLine(finalValue);
                box3 = 0;
            }
        }

        private void CheckBox_Checked_6(object sender, RoutedEventArgs e)//Altered Mental Status
        {
            if (Checked == true)
            {
                finalValue = finalValue + 10;
                Console.WriteLine(finalValue);
                box9 = 1;
            }
            else
            {
                finalValue = finalValue - 10;
                Console.WriteLine(finalValue);
                box9 = 0;
            }
        }

        private void CheckBox_Checked_7(object sender, RoutedEventArgs e)
        {
            if (Checked == true)
            {
                finalValue = finalValue + 10;
                Console.WriteLine(finalValue);
                box7 = 1;
            }
            else
            {
                finalValue = finalValue - 10;
                Console.WriteLine(finalValue);
                box7 = 0;
            }
        }
        



        public void finalCalculation()
        {
            if (finalValue == 0)
            {
                s1 = ("The final PSI point value for this person is " + finalValue + ". Therefore, Risk Class is I, which has a low risk, which means the admission status " +
                    "is outpatient Care.");
                Console.WriteLine(s1);
                ResultBox.Text = s1;
                
            }
            else
            {
                if (finalValue <= 70)
                {
                    s2 = ("The final PSI point value for this person is " + finalValue + ". Therefore, Risk Class is II, which has a low risk, which means the admission status " +
                           "is outpatient Care.");
                    Console.WriteLine(s2);
                    ResultBox.Text = s2;
                }
                else
                {
                    if (finalValue >= 71 && finalValue <= 90) //Risk Level 3
                    {
                        s3 = ("The final PSI point value for this person is " + finalValue + ". Therefore, Risk Class is III, which has a low risk, which means the admission status " +
                               "is outpatient or observation admission.");
                        Console.WriteLine(s3);
                        ResultBox.Text = s3;
                    }
                    else
                    {
                        if (finalValue >= 91 && finalValue <= 130) //Risk Level 4
                        {
                            s4 = ("The final PSI point value for this person is " + finalValue + ". Therefore, Risk Class is VI, which has a moderate risk, which means the admission status " +
                                   "is inpatient admission");
                            Console.WriteLine(s4);
                            ResultBox.Text = s4;
                        }
                        else
                        {
                            if (finalValue > 130) // Risk Level 5
                            {
                                s5 = ("The final PSI point value for this person is " + finalValue + ". Therefore, Risk Class is V, which has a High risk, which means the admission status " +
                                       "is inpatient admission and should be checked for sepsis.");
                                Console.WriteLine(s5);
                                ResultBox.Text = s5;
                            }
                        }
                    }
                }
            }
            
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (Checked == true)
            {
                finalValue = finalValue - 10;
                
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int age = int.Parse(AgeBox.Text);
            finalValue = finalValue + age;

            int rate = int.Parse(RateBox1.Text);
            if (rate >= 30)
            {
                finalValue = finalValue + 20;
            }

            int pulse = int.Parse(PulseBox.Text);
            if (pulse >= 125)
            {
                finalValue = finalValue + 10;
            }

            int SBP = int.Parse(SBPBox.Text);
            if (SBP <= 90)
            {
                finalValue = finalValue + 20;
            }
            if ((tempC < 35 || tempF < 95) || (tempC > 39.9 || tempF > 103.8))
            {
                finalValue = finalValue + 15;
            }

            double PH = double.Parse(PHBox.Text);
            if (PH < 7.35)
            {
                finalValue = finalValue + 30;
            }

            if (BUN >= 30 || BUN >= 11)
            {
                finalValue = finalValue + 20;
            }

            int Sodium = int.Parse(SodiumBox.Text);
            if (Sodium < 130)
            {
                finalValue = finalValue + 20;
            }

            if (G >= 250 || G >= 14)
            {
                finalValue = finalValue + 10;
            }

            int h = int.Parse(HematocritBox.Text);
            if (h < 30)
            {
                finalValue = finalValue + 10;
            }

            if (O < 60 || O < 8)
            {
                finalValue = finalValue + 10;
            }
            finalCalculation();
            Console.WriteLine(finalValue);
            
        }
        private void Record()
        {
            int age = int.Parse(AgeBox.Text);
            int rate = int.Parse(RateBox1.Text);
            double tempC = double.Parse(TempBox.Text);
            double BUN = double.Parse(BUNBox.Text);
            double PH = double.Parse(PHBox.Text);
            double O = double.Parse(OxygenBox.Text);
            int Sodium = int.Parse(SodiumBox.Text);
            int SBP = int.Parse(SBPBox.Text);
            int h = int.Parse(HematocritBox.Text);
            double G = double.Parse(GlucoseBox.Text);
            

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(count + ": " + age + ", " + rate + ", " + tempC + ", " + box1 + ", "
                        + PH + ", " + SBP + ", " + BUN + ", " + ",\r\n " + Sodium + ", " + h + ", " + G + ", "
                        + ", " + O + ", " + ", " + box2 + ",\r\n " + box3 + ", " + box4 + ", " + box5 +
                        ", " + box6 + ", " + box7 + ",\r\n" + box8 + ", " + box9 + ", " + box10 + ", " + box11 + ","
                        + box12 + ", " + box13 + ",\r\n" + box14 + ", " + box15 + ", " + box16);
            filepath = "C:\\Users\\TadenPC\\Documents\\data.csv";//Change File location to do this.
            File.AppendAllText(filepath, sb.ToString());
           
        }

        public void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if(Checked == true)
            {
                tempC = double.Parse(TempBox.Text);
                tempF = (tempC * 1.8) + 32;
            }
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            if (Checked == true)
            {
                tempF = double.Parse(TempBox.Text);
                tempC = ((tempF - 32) * 5) / 9;
            }
            else
            {
                tempC = double.Parse(TempBox.Text);
                tempF = (tempC * 1.8) + 32;
            }
        }



        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            if (Checked == true)
            {
                BUN = double.Parse(BUNBox.Text);
            }
            else
            {
                BUN = double.Parse(BUNBox.Text);
            }
        }

            private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
            if (Checked == true)
            {
                G = double.Parse(GlucoseBox.Text);
               
            }
            else
            {
                G = double.Parse(GlucoseBox.Text);
            }
        }

       

        private void RadioButton_Checked_8(object sender, RoutedEventArgs e)
        {
            if (Checked == true)
            {
                O = double.Parse(OxygenBox.Text);
               
            }
            else
            {
                O = double.Parse(OxygenBox.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            count++;
            Record();
        }

        private void NeoplasticNo_Checked(object sender, RoutedEventArgs e)
        {
            if(Checked = true)
            {
                box2 = 1;
            }
            else
            {
               box2 = 0;
            }
        }

        private void RDNo_Checked(object sender, RoutedEventArgs e)
        {
            if (Checked = true)
            {
                box4 = 1;
            }
            else
            {
                box4 = 0;
            }
        }

        private void CDNo_Checked(object sender, RoutedEventArgs e)
        {
            if (Checked = true)
            {
                box6 = 1;
            }
            else
            {
                box6 = 0;
            }
        }

        private void XRayNo_Checked(object sender, RoutedEventArgs e)
        {
            if (Checked = true)
            {
                box8 = 1;
            }
            else
            {
                box8 = 0;
            }
        }

        private void AMSNo_Checked(object sender, RoutedEventArgs e)
        {
            if (Checked = true)
            {
                box10 = 1;
            }
            else
            {
                box10 = 0;
            }
        }

        private void CHFNo_Checked(object sender, RoutedEventArgs e)
        {
            if (Checked = true)
            {
                box12 = 1;
            }
            else
            {
                box12 = 0;
            }
        }

        private void LDNo_Checked(object sender, RoutedEventArgs e)
        {
            if (Checked = true)
            {
                box14 = 1;
            }
            else
            {
                box14 = 0;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (Checked == true)
            {
                finalValue = finalValue + 10;
                Console.WriteLine(finalValue);
                box15 = 1;
            }
            else
            {
                finalValue = finalValue - 10;
                Console.WriteLine(finalValue);
                box15 = 0;
            }
        }

        private void NHRNo_Checked(object sender, RoutedEventArgs e)
        {
            if (Checked = true)
            {
                box16 = 1;
            }
            else
            {
                box16 = 0;
            }
        }
    }




}