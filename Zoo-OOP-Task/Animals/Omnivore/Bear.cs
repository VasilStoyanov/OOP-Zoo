// Created by Vasil Stoyanov - 16.02.2017
namespace Zoo_OOP_Task.Animals.Carnivores
{
    using System;
    using AnimalFood;

    public class Bear : Animal
    {
        public Bear(string name, uint age)
            :base(12, 110, name, age)
        {

        }

        public override Species Specie
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override void DecreaseStamina(int staminaToDecrease)
        {
            throw new NotImplementedException();
        }

        public override void Eat(AnimalFood food)
        {
            throw new NotImplementedException();
        }

        public override string Speak()
        {
            throw new NotImplementedException();
        }
    }
}
