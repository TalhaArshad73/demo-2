using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdul_assignment_FM
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string input = "Pakistan";
            

            char [] chars=input.ToCharArray();
            int len = chars.Length;
            Console.WriteLine("Output is:");
            for (int i = 0; i < len; i++)
            {
               chars[i] =(char)((int) chars[i] + 2);
               Console.Write(chars[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
