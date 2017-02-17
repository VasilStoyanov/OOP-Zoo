// Created by Vasil Stoyanov 16.02.2017
namespace Zoo_OOP_Task.Zoo
{
    using System.Collections.Generic;

    using Animals;
    using ZooKeepers;
    using System;

    public sealed class Zoo
    {
        private const byte ZooKepperMood = 4;

        private IList<Animal> animals;
        private IList<ZooKeeper> zooKeepers;

        private uint currentCycle = 0;

        public Zoo()
        {
            this.Animals = new List<Animal>();
            this.zooKeepers = new List<ZooKeeper>();
    }

        public Zoo(IList<Animal> animals)
        {
            this.Animals = new List<Animal>(animals);
            this.zooKeepers = new List<ZooKeeper>();
        }

        public Zoo(IList<Animal> animals, IList<ZooKeeper> zooKeepers)
        {
            this.Animals = new List<Animal>(animals);
            this.zooKeepers = new List<ZooKeeper>(zooKeepers);
        }

        public IList<Animal> Animals
        {
            get
            {
                return this.animals;
            }
            set
            {
                if(value != null)
                {
                    this.animals = value;
                }
            }
        }

        public void TriggerCycle()
        {
            foreach(ZooKeeper zooKeeper in this.zooKeepers)
            {
                if(zooKeeper.AssignnedAnimals.Count < 2)
                {
                    Console.WriteLine("Zookeeper with ID:{0} has less than 2 asigned animals, so he wont do anything.",
                        zooKeeper.Id);
                }
                foreach(Animal assignedAnimal in zooKeeper.AssignnedAnimals)
                {
                    var keeperIsInMood = new Random().Next(1, 10);
                    if(keeperIsInMood < ZooKepperMood)
                    {
                        continue;
                    }

                    zooKeeper.Feed(assignedAnimal);
                }
            }
            
            foreach(Animal animal in this.animals)
            {
                animal.DecreaseStamina(new Random().Next(30, 50));
                if(this.currentCycle == 10)
                {
                    animal.Age++;
                    this.currentCycle = 0;
                }
            }

            this.currentCycle++;
        }
    }
}
