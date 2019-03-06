using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

// Student Name: Jatinder Singh Student ID: C0725866
// Student Name: Arshdeep Singh Student ID: C0730385
// CSD3354 Section 2
//March 6, 2019
{
    public class program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }
    public delegate int MyDelegate(out int i);
    public class DelegateExercises
    {
        int Method1(out int i)
        {
            System.Console.WriteLine("Method1");
            i = 10;
            return 0;
        }
    }
    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        MyDelegate myDelegate1 = new MyDelegate(Method1);
        MyDelegate myDelegate2 = myDelegate + myDelegate1;
        int intValue;
        myDelegate2(out intValue);
    }






}