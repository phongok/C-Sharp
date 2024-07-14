using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._2.DataType
{
    public class DataType

    {
        public void KhaiBao() {
            int myInt = 100000;
            Console.WriteLine(myInt);

            long myLong = 15000000000L;
            Console.WriteLine(myLong);

            float myFloat = 5.75F;
            Console.WriteLine(myFloat);

            double myDouble = 19.99D;
            Console.WriteLine(myDouble);

            bool myBool = true;
            Console.WriteLine(myBool);

            char myChar = 'P';
            Console.WriteLine(myChar);

            string myString = "Nguyễn Thanh Phong";

            Console.WriteLine(myString);

         }
        public void ConvertToInt_Option1()
        {
            string a = "123";
            int outphut_a = Convert.ToInt32(a);
            Console.WriteLine(outphut_a);
        }

        public void ConvertToInt_Option2()
        {
            string a = "1234";
            int outphut_a = int.Parse(a);
            Console.WriteLine(outphut_a);
        }

        public void ConvertToInt_Option3()
        {
            string a = "1234a";
            bool success = int.TryParse(a, out int outphut_a);
            if (success)
            {
                Console.WriteLine(outphut_a);
            }
            else
            {
                Console.WriteLine("Convert failed");
            }
        }
    }
}
