using System;
using System.Text;

namespace PALConsoleTest {
    class NintyNineBottles {

        // this is a property to make the 99 the default but dynamic
        public int Number { get; set; } = 99;

        // getter for halfway there
        public decimal HalfWayThere {
            get {
                return Math.Ceiling(Convert.ToDecimal(Number / 2));
            }
        }        
        
        // this is the construction, explain params + optional params
        public NintyNineBottles(int _number = 0) {
            if (_number > 0) {
                Number = _number;
            }
        }

        public void Run99() {            
            // explain for loop
            for (var i = Number; i >= 0; i--) {
                if (i == HalfWayThere) {
                    Console.WriteLine($"{i} bottles of beer on the wall, we are halfway there!");
                } else {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer, take one down and pass it around, {(i == 0 ? 0 : i - 1)} bottles of beer on the wall");
                }
            }
            Console.ReadLine();
        }

        // explain return types and stringbuilder
        public string Get99() {
            StringBuilder sb = new StringBuilder();            
            for (var i = Number; i >= 0; i--) {
                if (i == HalfWayThere) {
                    // explain newline Environment.NewLine - do first without to illustrate needing newlines
                    sb.Append($"{i} bottles of beer on the wall, we are halfway there!");
                } else {
                    sb.Append($"{i} bottles of beer on the wall, {i} bottles of beer, take one down and pass it around, {(i == 0 ? 0 : i - 1)} bottles of beer on the wall" + Environment.NewLine);
                }
            }
            return sb.ToString();
        }
    }
}
