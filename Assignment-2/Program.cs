using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class program{
        public static void Main()
        {
            DelegateExercises a = new DelegateExercises();
            a.Method2();
        }
    }
    public class DelegateExercises
    {
        // Student Name: Jatinder Singh  Student ID: C0725866
        // Student Name: Arshdeep Singh Student ID: C0730385

        public delegate void MyDelegate();

        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
