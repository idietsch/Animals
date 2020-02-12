using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Pug : Dog {
        public bool BigDog { get; set; } = false;
        public Pug(string Name) :base(Name) {
            this.Muzzle = MuzzleType.Collapsed;
            this.Longtail = false;
        }
        public Pug() :this("Bacchus") {

        }
        public override string GetTypeOfDog() {
            return "Puggaroni";
        }
    }
}
