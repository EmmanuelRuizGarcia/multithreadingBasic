﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace multithreadingBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Shared Variables
        string _string1 = string.Empty;
        StringBuilder _string2 = new();
        int _count1 = 0;
        int _count2 = 0;
        double _mem1 = 0d;
        double _mem2 = 0d;
        TimeSpan _time1 = new();
        TimeSpan _time2 = new();
        Stopwatch _stopWatch1 = new();
        Stopwatch _stopWatch2 = new();
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Go_Click(object sender, RoutedEventArgs e)
        {
            //ConcatString(); // Concatenate a String type variable 50,000 times.
            //ConcatStringBuilder();  // Concatenate a StringBuilder object 50,000 times.
            DoConcatenation();
        }

        /// <summary>
        /// The caller method of running string concatenation by using the 
        /// selected threading approach. 
        /// <para> threadOption: 1 = BackgroundWorker.</para>
        /// </summary>
        /// <param name="threadOption">The option of the threading approach.</param>
        private void DoConcatenation(int threadOption = 1)
        {
            switch (threadOption)
            {
                case 1:
                    ActivateBGWorker(); // Defined in the BackgroundWorkerMethod.cs file.
                    break;
            }
        }
    }
}