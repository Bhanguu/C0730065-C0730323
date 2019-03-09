using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730065_C0730323
{
    class program
    // Parminder Kaur Bhangu (C0730065)
    //Ravneet Kaur (C0730323)
    {



        public static void Main(string[] args)

        {
            DelegateExercises This = new DelegateExercises();

            This.Method2(50);
        }
    }


    public class DelegateExercises
    {

        public delegate void MyDelegate(int i);
        public void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.WriteLine(i);
            Console.ReadLine();
        }

        public void Method2(int i)
        {
            MyDelegate myDelegate = new MyDelegate(Method1);

            myDelegate(50);
        }
    }

}


