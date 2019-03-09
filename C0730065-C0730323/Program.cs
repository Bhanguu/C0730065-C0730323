using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730065_C0730323
{
    class program
    {

    
    // Parminder Kaur Bhangu (C0730065)
    //Ravneet Kaur (C0730323)
    public static void Main(string[] args)
    {
            DelegateExercises de = new DelegateExercises();
            de.Method3();
            Console.ReadLine();
        }
    }
    delegate int MyDelegate(out int i);
    public class DelegateExercises
    {
        int Method1(out int i)
        {

            i = 100;
            Console.WriteLine("Method 1 " + i);
            return 0;
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            MyDelegate myDelegate1 = null;
            MyDelegate myDelegate2 = myDelegate + myDelegate1;
            int intValue;
            myDelegate2(out intValue);
        }

    }

}





