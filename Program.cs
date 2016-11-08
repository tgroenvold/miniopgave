using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Consoleminiopgaver
{
    public class miniopgave
    {
        public static void Main()
        {
            Opgave1();
            Opgave2();
            Opgave3();
            Opgave4();
        }

        //Her er opgave 1
        public static void Opgave1()
        {
            Debug.WriteLine("Opgave 1");
            Debug.WriteLine("Hello world");
            Debug.WriteLine("Tommy Grønvold");
        }

        //Her er opgave 2
        public static void Opgave2()
        {
            Debug.WriteLine("opgave 2");
            Debug.WriteLine(12 + 13);
        }
        //Her er opgave 3
        public static void Opgave3()
        {
            Debug.WriteLine("opgave 3");
            Debug.WriteLine((float)5 / (float)24);
        }    
        //Her er opgave 4   
        public static void Opgave4()
        {
            Debug.WriteLine("opgave 4");
            Debug.WriteLine(-1 + 5 * 3);
            Debug.WriteLine((24 + 5) % (float)7);
            Debug.WriteLine((15 + -4)*6 / (float) 11);



        }   


    }
}
