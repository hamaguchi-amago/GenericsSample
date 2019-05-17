using System;

namespace GenericsSample {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Sample1");
            new Sample1().Main();

            Console.WriteLine("Sample2");
            new Sample2().Main();

            Console.WriteLine("Sample3");
            new Sample3().Main();

            Console.ReadKey();
        }
    }
}
