using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace multithreadingBasic
{
    public partial class MainWindow : Window
    {
        private void UseTaskFactoryStartNew()
        {
            Task.Factory.StartNew(() => ConcatString1())
                .ContinueWith(result =>
                {
                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        GetProperties.String1 = _string1;
                    }));
                });

            Task.Factory.StartNew(() => ConcatString2())
                .ContinueWith(result =>
                {
                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        GetProperties.String2 = _string2.ToString();
                    }));
                });

            // The following running a task within another task by using Task.Factory.StartNew.
            //Task? childTask = null;

            //var fatherTask = Task.Factory.StartNew(() =>
            //{
            //    ConcatString2();
            //    childTask = new Task(() => ConcatString1(), TaskCreationOptions.AttachedToParent);
            //    childTask.Start();
            //    childTask.ContinueWith(result =>
            //    {
            //        this.Dispatcher.BeginInvoke(new Action(() =>
            //        {
            //            GetProperties.String1 = _string1;
            //        }));
            //    });
            //}).ContinueWith(result =>
            //{
            //    this.Dispatcher.BeginInvoke(new Action(() =>
            //    {
            //        GetProperties.String2 = _string2.ToString();
            //    }));
            //});

            //fatherTask.Wait();
        }
    }
}
