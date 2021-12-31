﻿using System;
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

namespace asp.net.mvc_lesson3
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



        /// <summary>
        /// В методе вызывается делега - реализация патерна фабричных методов
        /// </summary>
        /// <param name="sender"> для соответвие требуемому типу делегата </param>
        /// <param name="e">для соответвие требуемому типу делегата</param>

        void clic1(object sender, RoutedEventArgs e)
        {

            StringConverter.StringCreate t = new StringConverter.StringCreate(new StringConverter().LargeCharacters);


            TextBox2.Text=t(TextBox1.Text);


        }


    }













}
