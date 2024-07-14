using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._1.Variables
{
    public class Variables
    {
      
        public void KhaiBao1()
        {
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);


        }

        public void KhaiBao2()
        {
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);
        }

        public void KhaiBao3()
        {
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);
        }
    }
}
