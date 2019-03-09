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
            This.Method3();
            Console.Read();
        }
    }
    public delegate void MyDelegate();
    public class DelegateExercises
    {
        void Method1()
        {
           
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            
            System.Console.WriteLine(myDelegate.ToString());
        }
    }

}


