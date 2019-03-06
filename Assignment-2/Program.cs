using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
//student Name -Jatinder Singh Student ID C0725866
//Studnt Name- Arshdeep Singh student ID C0730385
//CSD3354 section 2
//Assignment 2
// March 6,2019
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
    public delegate int MyDelegate(ref int intValue);
    public class DelegateExercises
    {
        int Method1(ref int intvalue)
        {
            int value = intvalue + 5
                System.Console.WriteLine("Method1" + intValue);
        }
    }
    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        MyDelegate myDelegate = new MyDelegate(Method1);
        MyDelegate myDelegate2 = myDelegate + myDelegate1;
        int intParameter = 5; ;
        myDelegate2(ref intParmeter);
    }






}


