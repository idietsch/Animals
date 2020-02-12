using System;

namespace AnimalLibrary {
    public class Dog {
        public bool Longtail { get; set; } //Long, short
        public string BarkPitch { get; set; } //high, medium, low
        public string MuzzleLength { get; set; } //long, short, collapsed
        public bool ExtremeSenseOfSmell { get; set; } = false;  //Extreme, normal

        public Dog() {

        }
    }
}
