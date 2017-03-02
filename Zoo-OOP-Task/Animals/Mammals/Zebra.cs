namespace Zoo_OOP_Task.Animals.Mammals
{
    using System;
    using AnimalFood;

    public class Zebra : Animal
    {
        private const string ZebraSpeech = "Meh";

        private const byte ZebraAverageLowLifespan = 24;

        private const byte ZebraAverageHighLifespan = 26;

        public Zebra(string name, uint age)
            :base(ZebraAverageLowLifespan, ZebraAverageHighLifespan, name, age)
        {
        }

        public override Species Specie
        {
            get
            {
                return Species.Mammal;
            }
        }

        public override void Eat(AnimalFood food)
        {
            if (food == null)
            {
                throw new ArgumentNullException("Food cannot be null");
            }
            else if (food.FoodType != AnimalFoodType.Grass && food.FoodType != AnimalFoodType.Milk)
            {
                Console.WriteLine("I am a mammal. I eat only grass and milk!");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("Zebra {0} eated some {1} and increased stamina with {2}",
                this.Name, food.FoodType, food.Calories));

            this.IncreaseStamina((int)food.Calories);
        }

        public override string Speak()
        {
            return ZebraSpeech;
        }
    }
}
