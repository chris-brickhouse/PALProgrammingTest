using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALConsoleTest {

    public enum BottleType {
        Soda, Beer, Juice, Water
    }

    class Bottle {
        public int Number { get; set; }
        public decimal? Size { get; set; }
        public BottleType? Type { get; set; }
    }

    class Beer : Bottle {

        public Beer() {
            Type = BottleType.Beer;
        }
        public string ABV { get; set; }
    }

    class Soda : Bottle {
        public Soda() {
            Type = BottleType.Soda;
        }
        public int? SugarGrams { get; set; }
    }

    class Juice : Bottle {
        public Juice() {
            Type = BottleType.Juice;
        }
        public int? VitaminCAmount { get; set; }
    }

    class Water : Bottle {
        public Water() {
            Type = BottleType.Juice;
        }
        public string Source { get; set; }
    }
}
