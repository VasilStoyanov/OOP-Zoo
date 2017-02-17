// Created by Vasil Stoyanov - 16.02.2017
namespace Zoo_OOP_Task.Animals.Carnivores
{
    using System;

    public class Bear : Animal
    {
        public Bear(string name, uint age)
            :base(Species.Omnivore, 12, 110, name, age)
        {

        }

        public override void DecreaseStamina(int staminaToDecrease)
        {
            throw new NotImplementedException();
        }

        public override string Eat()
        {
            throw new NotImplementedException();
        }

        public override string Speak()
        {
            throw new NotImplementedException();
        }
    }
}
