using System;
using AnimalLibrary;

namespace Animals {
    class Program {
        static void Main(string[] args) {
            var germanSheperd1 = new GermanSheperd("Killfang");
            
            var germanSheperd = new GermanSheperd {
                Longtail = true,
                Bark = BarkPitch.Low,
                Muzzle = MuzzleType.Long,
                ExtremeSenseOfSmell = true,
                BigDog = true,
                Name = "Alfredo"
            };
            var pug = new Dog {
                Longtail = false,
                Bark = BarkPitch.Medium,
                Muzzle = MuzzleType.Collapsed,
                ExtremeSenseOfSmell = false,
                Name = "Dominic"
            };
        }
    }
}
