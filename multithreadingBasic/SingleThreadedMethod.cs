using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace multithreadingBasic
{
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Concatenate a String type variable 50,000 times.
        /// </summary>
        private void ConcatString()
        {
            string _s = "";
            int _count_S = 0;
            Stopwatch _sw_S = new();

            _sw_S.Start();

            for (int i = 0; i < 50000; i++)
            {
                _s += i.ToString();
                _count_S++;
            }

            txb_String_Count.Text = _count_S.ToString();
            txb_String_RAM.Text = (GC.GetAllocatedBytesForCurrentThread() / 1024 / 1024).ToString();
            txb_String_Time.Text = _sw_S.Elapsed.ToString();

            _sw_S.Stop();

            txb_String_Result.Text = _s;
            lbl_String_Length.Content = _s.Length;
        }

        /// <summary>
        /// Concatenate a StringBuilder object 50,000 times.
        /// </summary>
        private void ConcatStringBuilder()
        {
            StringBuilder _sb = new();
            int _count_SB = 0;
            Stopwatch _sw_SB = new();

            _sw_SB.Start();

            for (int i = 0; i < 50000; i++)
            {
                _sb.Append(i);
                _count_SB++;
            }

            txb_StringBuilder_Count.Text = _count_SB.ToString();
            txb_StringBuilder_RAM.Text = (GC.GetAllocatedBytesForCurrentThread() / 1024 / 1024).ToString();
            txb_StringBuilder_Time.Text = _sw_SB.Elapsed.ToString();

            _sw_SB.Stop();

            txb_StringBuilder_Result.Text = _sb.ToString();
            lbl_StringBuilder_Length.Content = _sb.Length;
        }
    }
}
