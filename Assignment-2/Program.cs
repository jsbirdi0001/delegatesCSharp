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
            try
            {
                delegateExercises.Method3();
                Console.ReadLine();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Exception Occured.");
                Console.ReadLine();
            }
        }
    }
    public delegate int MyDelegate();
    public class DelegateExercises
    {
        void Method1()
        {
            throw new System.Exception();
        }
    }
    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        myDelegate2();
    }






}

