using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Boxer : Dog {

        public bool BigDog = true;

        public Boxer(){

        }
        public Boxer(string Name) : base(Name) {
            this.Longtail = false;
            this.Bark = BarkPitch.Low;
            this.Muzzle = MuzzleType.Short;
        }
        public override string GetTypeOfDog() {
            return "Boxer";
        }
    }
}
