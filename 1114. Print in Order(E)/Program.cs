using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1114.Print_in_Order_E_
{
    public class Foo
    {
        private readonly object lockData = new object();
        private bool firstFinished;
        private bool secondFinished;
        public Foo()
        {

        }

        public void First(Action printFirst)
        {
            lock (lockData)
            {
                // printFirst() outputs "first". Do not change or remove this line.
                printFirst();
                firstFinished = true;
            }
        }

        public void Second(Action printSecond)
        {
            lock (lockData)
            {
                while (!firstFinished)
                    System.Threading.Monitor.Wait(lockData);
                // printSecond() outputs "second". Do not change or remove this line.
                printSecond();
                secondFinished = true;
                System.Threading.Monitor.Pulse(lockData);
            }
        }

        public void Third(Action printThird)
        {
            lock (lockData)
            {
                while (!secondFinished)
                    System.Threading.Monitor.Wait(lockData);
                // printThird() outputs "third". Do not change or remove this line.
                printThird();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
