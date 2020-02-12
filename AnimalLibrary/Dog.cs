using System;

namespace AnimalLibrary {
    
    public enum BarkPitch {High, Medium, Low};
    public enum MuzzleType {Long, Short, Collapsed,};
    public class Dog {
        public bool Longtail { get; set; } //Long, short
        public BarkPitch Bark { get; set; } //high, medium, low
        public MuzzleType Muzzle { get; set; } //long, short, collapsed
        public bool ExtremeSenseOfSmell { get; set; } = false;  //Extreme, normal

        public Dog() {

        }
    }
}
