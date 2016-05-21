using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUIZ;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            Service1 service1 = new Service1();
            Console.WriteLine(service1.HelloWorld());


            Console.ReadKey();
        }
    }
}
