// Created by Vasil Stoyanov - 16.02.2017
namespace Zoo_OOP_Task.Animals.Carnivores
{
    using System;
    using AnimalFood;

    public class Tiger : Animal
    {
        private const string TigerSpeech = "RAWRRRRR";

        private const byte TigerAverageLowLifespan = 20;

        private const byte TigerAverageHighLifespan = 26;

        public Tiger(string name, uint age)
            : base(TigerAverageLowLifespan, TigerAverageHighLifespan, name, age)
        {
        }

        public Tiger(string name, uint age, DateTime birthDay)
            : base(TigerAverageLowLifespan, TigerAverageHighLifespan, name, age, birthDay)
        {
        }

        public Tiger(string name, uint age, DateTime birthDay, int stamina)
            : base(TigerAverageLowLifespan, TigerAverageHighLifespan, name, age, birthDay, stamina)
        {
        }

        public override Species Specie
        {
            get
            {
                return Species.Carnivore;
            }
        }

        public override void Eat(AnimalFood food)
        {
            if(food == null)
            {
                throw new ArgumentNullException("Food cannot be null");
            }
            else if (food.FoodType != AnimalFoodType.Meat)
            {
                Console.WriteLine("I am a carnivore. I eat only meat!");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("Tiger {0} eated some meat and increased stamina with {1}",
                this.Name, food.Calories));

            this.IncreaseStamina((int)food.Calories);
        }

        public override string Speak()
        {
            return TigerSpeech;
        }
    }
}
