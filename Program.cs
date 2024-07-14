using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variables = Basic.Variables;

namespace Basic
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Variable
            Console.WriteLine("Hello World");
            Variables.Variable variable = new Variables.Variable();
            variable.ConvertToInt_Option1();
            variable.ConvertToInt_Option2();
            variable.ConvertToInt_Option3();



            
          }
    }
}
