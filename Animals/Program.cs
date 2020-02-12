using System;
using System.Collections.Generic;
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
            var pug1 = new Pug("Hopscotch");
            var pug2 = new Pug();
            var boxer1 = new Boxer("Hephestus");
            var boxer2 = new Boxer();

            var pug = new Dog {
                Longtail = false,
                Bark = BarkPitch.Medium,
                Muzzle = MuzzleType.Collapsed,
                ExtremeSenseOfSmell = false,
                Name = "Dominic"
            };

            var dogs = new List<Dog>();
            dogs.Add(pug);
            dogs.Add(germanSheperd);
            dogs.Add(pug1);
            dogs.Add(pug2);
            dogs.Add(boxer1);
            dogs.Add(boxer2);
            dogs.Add(germanSheperd1);

            foreach (var dog in dogs) {
                Console.WriteLine(dog.GetTypeOfDog());
            }
        }
    }
}
