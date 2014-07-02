using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class MyTest
    {
        public static void Main(string[] args)
        {
            MyTest myTest = new MyTest();
            Console.WriteLine("Welcome" + "\n");
            Console.WriteLine(myTest.getHello());
            Console.ReadLine();
        }

        public string getHello()
        {
            return "Hello";
        }
    }
}
