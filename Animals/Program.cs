using System;
using AnimalLibrary;

namespace Animals {
    class Program {
        static void Main(string[] args) {
            var germanSheperd = new Dog {
                Longtail = true,
                Bark = BarkPitch.Low,
                Muzzle = MuzzleType.Long,
                ExtremeSenseOfSmell = true
            };
        }
    }
}
