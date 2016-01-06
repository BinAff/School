using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinAff.Utility.Parallelism
{

    public static class CrossThread
    {

        public static void RunForEach<T>(Boolean isParallel, List<T> list, Predicate<T> predicate)
        {
            if (isParallel)
            {
                Parallel.ForEach<T>(list, data =>
                {
                    predicate(data);
                });
            }
            else
            {
                foreach (T data in list)
                {
                    predicate(data);
                }
            }
        }

        public delegate void VoidFunction();
        public static void InvokeSafeAsync(this Control control, VoidFunction voidFunction)
        {
            if (control.Disposing || control.IsDisposed) return;
            if (control.InvokeRequired)
            {
                if (!control.Disposing && !control.IsDisposed)
                {
                    control.BeginInvoke(new MethodInvoker(delegate
                    {
                        voidFunction();
                    }));
                }
            }
            else
            {
                voidFunction();
            }
        }

    }

}