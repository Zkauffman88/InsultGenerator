using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGenerator
{
    class Insult
    {
        public void Welcome()
        {
            string Welcome = "Welcome to Turniphead's hurtful insult generator";
            Console.WriteLine("***********************************************");
            Console.WriteLine(Welcome);
            Console.WriteLine("***********************************************");

        }
        public void Selection()
        {
            string selection = "Input 'insult' for a new insult or input 'exit' to exit the program";
            Console.WriteLine(selection);
        }
               
    }
}
