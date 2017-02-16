// Created by Vasil Stoyanov 16.02.2017
namespace Zoo_OOP_Task.ZooKeepers
{
    using System;
    using System.Collections.Generic;

    using Animals;

    public sealed class ZooKeeper
    {
        private const byte MinimumAssaignedAnimalsLength = 2;

        private string id;

        private IList<Animal> assignedAnimals;

        public ZooKeeper()
        {
            this.AssignnedAnimals = new List<Animal>();
            this.id = string.Format("{0}", Guid.NewGuid());
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

                this.assignedAnimals = new List<Animal>(value);
            }
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

    }
}
