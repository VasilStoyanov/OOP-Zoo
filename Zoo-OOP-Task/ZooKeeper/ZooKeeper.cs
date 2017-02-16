// Created by Vasil Stoyanov 16.02.2017
namespace Zoo_OOP_Task.ZooKeepers
{
    using System.Collections.Generic;

    using Animals;
    using System;

    public sealed class ZooKeeper
    {
        private const byte MinimumAssaignedAnimalsLength = 2;

        private IList<Animal> assignedAnimals;

        public ZooKeeper(IList<Animal> assaignedAnimals)
        {
            this.AssignnedAnimals = new List<Animal>(assaignedAnimals);
        }

        public IList<Animal> AssignnedAnimals
        {
            get
            {
                return new List<Animal>(this.assignedAnimals);
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("Assaigned animals cannot be null!");
                }
                else if(value.Count < MinimumAssaignedAnimalsLength)
                {
                    throw new ArgumentException("Assaigned animals cannot be less than 2!");
                }

                this.assignedAnimals = new List<Animal>(value);
            }
        }

        public void AssignNew(Animal animal)
        {
            if(animal == null)
            {
                throw new ArgumentNullException("Asign animal cannot be null!");
            }

            this.assignedAnimals.Add(animal);
        }

    }
}
