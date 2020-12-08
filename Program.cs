using System;

namespace PALConsoleTest {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            NintyNineBottles();
        }

        static void NintyNineBottles() {
            for (var i = 99; i >= 0; i--) {
                //Console.WriteLine(i + " bottles of beer on the wall, " + i + " bottles of beer, take one down and pass it around, " + (i - 1) + " bottles of beer on the wall");
                Console.WriteLine(i + " bottles of beer on the wall, " + i + " bottles of beer, take one down and pass it around, " + (i == 0 ? 0 : i - 1) + " bottles of beer on the wall");
            }
        }
    }
}
