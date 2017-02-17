// Created by Vasil Stoyanov 16.02.2017
namespace Zoo_OOP_Task.ZooKeepers
{
    using System;
    using System.Collections.Generic;

    using Animals;
    using AnimalFood;

    public sealed class ZooKeeper
    {
        private const byte MinimumAssaignedAnimalsLength = 2;

        private string id;

        private IList<Animal> assignedAnimals;

        public ZooKeeper()
        {
            this.AssignnedAnimals = new List<Animal>();
            this.Id = string.Format("{0}", Guid.NewGuid());
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public IList<Animal> AssignnedAnimals
        {
            get
            {
                return new List<Animal>(assignedAnimals);
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("Assaigned animals cannot be null!");
                }

                this.assignedAnimals = new List<Animal>(value);
            }
        }

        public int AssignnedAnimalsCount()
        {
            return this.assignedAnimals.Count;
        }

        public void Assign(Animal animal)
        {
            if(animal == null)
            {
                throw new ArgumentNullException("Asign animal cannot be null!");
            }
            else if(animal.ZooKeeperId.Length > 0)
            {
                Console.WriteLine("This animal is already asigned to a keeper. Aborting.");
                return;
            }

            animal.ZooKeeperId = this.id;
            this.assignedAnimals.Add(animal);
        }

        //TODO: Remove hidden dependencies
        public void Feed(Animal animalToFeed)
        {
            if(animalToFeed.ZooKeeperId != this.id)
            {
                Console.WriteLine("This animal is not asigned to this zoo keeper!");
                return;
            }

            Random randomFoodAmount = new Random();
            switch (animalToFeed.Specie)
            {
                case Species.Carnivore:
                    AnimalFood carnivoreFood = new AnimalFood(AnimalFoodType.Meat, (uint)randomFoodAmount.Next(1, 5));
                    animalToFeed.Eat(carnivoreFood);
                    break;
                case Species.Omnivore:
                    AnimalFood omnivoreFood = new AnimalFood(AnimalFoodType.Mandja, (uint)randomFoodAmount.Next(1, 5));
                    animalToFeed.Eat(omnivoreFood);
                    break;
                case Species.Mammal:
                    AnimalFood mammalFood = new AnimalFood(AnimalFoodType.Milk, (uint)randomFoodAmount.Next(1, 5));
                    animalToFeed.Eat(mammalFood);
                    break;
                case Species.Herbivore:
                    AnimalFood herbivoreFood = new AnimalFood(AnimalFoodType.Grass, (uint)randomFoodAmount.Next(1, 5));
                    animalToFeed.Eat(herbivoreFood);
                    break;
                default:
                    break;
            }
        }
    }
}
