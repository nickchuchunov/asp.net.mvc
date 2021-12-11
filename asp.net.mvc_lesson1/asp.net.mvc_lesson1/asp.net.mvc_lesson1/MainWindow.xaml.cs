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
using asp.net.mvc_lesson1._1;
using System.Threading;

namespace asp.net.mvc_lesson1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {







            InitializeComponent();

            Button1.Click += click1;












            

        }

       
        void click1(object sender, RoutedEventArgs e)
        {
              
           

            int number = int.Parse(TexBox1.Text);
            int deley = int.Parse(TexBox3.Text);
            Semaphore sem = new Semaphore(1, 1);

            FibonacciNumbers fibonacci = new FibonacciNumbers();
            fibonacci.Fibonacci1(number, deley);
            lock (fibonacci ) 
            {
                lock (TexBox2)
                {
                int lengthFib = 0;

                   // Thread t1 = new Thread(() =>
                   // {

                        while ((lengthFib != fibonacci.Numbers.Length))

                        {
                           
                            TexBox2.Text = fibonacci.Numbers;
                            lengthFib = fibonacci.Numbers.Length;
                            
                        }

                  //  });

                   // t1.Start();


                  



                    //TexBox2.Dispatcher.Thread.IsBackground = true;
                    // TexBox2.Dispatcher.Thread.Abort();
                    // sem.WaitOne();
                    // Task.Yield();






                }
            }




        }



        }

       


    }
