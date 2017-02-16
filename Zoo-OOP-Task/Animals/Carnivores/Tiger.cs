// Created by Vasil Stoyanov - 16.02.2017
namespace Zoo_OOP_Task.Animals.Carnivores
{
    using System;

    public class Tiger : Animal
    {
        private const string TigerSpeech = "RAWRRRRR";

        private const byte TigerAverageLowLifespan = 20;

        private const byte TigerAverageHighLifespan = 26;

        public Tiger(string name, uint age)
            : base(Species.Carnivore, TigerAverageLowLifespan, TigerAverageHighLifespan, name, age)
        {
        }

        public Tiger(string name, uint age, DateTime birthDay)
            : base(Species.Carnivore, TigerAverageLowLifespan, TigerAverageHighLifespan, name, age, birthDay)
        {
        }

        public Tiger(string name, uint age, DateTime birthDay, int stamina)
            : base(Species.Carnivore, TigerAverageLowLifespan, TigerAverageHighLifespan, name, age, birthDay, stamina)
        {
        }

        public override string Eat()
        {
            return String.Format("Tiger {0} starts to eat...", this.Name);
        }

        public override string Speak()
        {
            return String.Format("Tiger " + this.Name + " says: " + TigerSpeech);
        }

    }
}
