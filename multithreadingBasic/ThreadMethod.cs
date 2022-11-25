using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace multithreadingBasic
{
    public partial class MainWindow : Window
    {
        private void Thread1()
        {
            Thread thread1 = new(() => ConcatString1());
            thread1.Start();
            //thread1.Join(0);
            //txb_String_Result.Text = _string1;
            //lbl_String_Length.Content = _string1.Length;
        }

        private void Thread2()
        {
            Thread thread2 = new(() => ConcatString2());
            thread2.Start();
            //thread2.Join(0);
            //txb_StringBuilder_Result.Text = _string2.ToString();
            //lbl_StringBuilder_Length.Content = _string2.Length;
        }
    }
}
