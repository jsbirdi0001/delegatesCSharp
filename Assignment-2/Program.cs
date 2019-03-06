using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{

    public class program
    {

        static void Main()
        {
            // Student Name: Jatinder Singh  Student ID: C0725866
            // Student Name: Arshdeep Singh Student ID: C0730385
            // Assignment 2
            // March 6, 2019


            DelegateExercises a = new DelegateExercises();
            a.Method2();
        }
    }


    public class DelegateExercises
    {

        public delegate void MyDelegate(int a);

        void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate(50);
        }
    }
}
