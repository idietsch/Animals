using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    

    public class GermanSheperd : Dog {

        public bool BigDog { get; set; } = true;

        public GermanSheperd(string Name) : base(Name) {
            this.Longtail = true;
            this.ExtremeSenseOfSmell = true;
        }

        public GermanSheperd() {
            this.Muzzle = MuzzleType.Long; 
        }
    }
}
