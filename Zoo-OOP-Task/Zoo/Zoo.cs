// Created by Vasil Stoyanov 16.02.2017
namespace Zoo_OOP_Task.ZooNS
{
    using Animals;
    using System;
    using System.Collections.Generic;
    using ZooKeepers;

    public sealed class Zoo
    {
        private const byte ZooKepperMood = 3;
        private const byte ActiveStamina = 20;

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
            this.ZooKeepers = new List<ZooKeeper>();
        }

        public Zoo(IList<Animal> animals, IList<ZooKeeper> zooKeepers)
        {
            this.Animals = animals;
            this.ZooKeepers = zooKeepers;
        }

        public IList<Animal> Animals
        {
            get
            {
                return new List<Animal>(this.animals);
            }
            set
            {
                if (value != null)
                {
                    this.animals = new List<Animal>(value);
                }
            }
        }

        public IList<ZooKeeper> ZooKeepers
        {
            get
            {
                return new List<ZooKeeper>(this.zooKeepers);
            }
            set
            {
                if (value != null)
                {
                    this.zooKeepers = new List<ZooKeeper>(value);
                }
            }
        }

        public void AddZooKeeper(ZooKeeper zooKeeper)
        {
            if (zooKeeper != null)
            {
                this.zooKeepers.Add(zooKeeper);
            }
        }

        public void AddAnimal(Animal animal)
        {
            if (animal != null)
            {
                this.animals.Add(animal);
            }
        }

        public void TriggerCycle()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== Cycle {0} ===", this.currentCycle + 1);
            if (this.zooKeepers.Count == 0 || this.animals.Count < 2)
            {
                Console.WriteLine("Not enough zoo keepers or animals. Please add at least 1 zoo keeper and at least 2 animals");
                return;
            }
            // Feed animals
            foreach (ZooKeeper zooKeeper in this.zooKeepers)
            {
                if (zooKeeper.AssignnedAnimals.Count < 2)
                {
                    Console.WriteLine("Zookeeper with ID:{0} has less than 2 asigned animals, so he wont do anything.",
                        zooKeeper.Id);
                }

                var moodGenerator = new Random();
                foreach (Animal assignedAnimal in zooKeeper.AssignnedAnimals)
                {
                    int keeperIsInMood = moodGenerator.Next(1, 10);
                    if (keeperIsInMood < ZooKepperMood)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Zookeeper with ID:{0} is not in mood and will not feed {1} {2}",
                            zooKeeper.Id, assignedAnimal.Specie, assignedAnimal.Name);

                        continue;
                    }

                    zooKeeper.Feed(assignedAnimal);
                }
            }

            // Tire animals
            var rand = new Random();
            foreach (Animal animal in this.animals)
            {
                if(!animal.IsAlive())
                {
                    continue;
                }

                int randomNumber = rand.Next(20, 50);
                if (animal.Stamina >= ActiveStamina)
                {
                    animal.DecreaseStamina(randomNumber);
                }
                else if(animal.Stamina < ActiveStamina)
                {
                    Console.WriteLine("{0} is tired and will sleep to regain stamina!", animal.Name);
                    animal.IncreaseStamina(rand.Next(10, 20));
                }

                if (this.currentCycle % 10 == 0)
                {
                    animal.Age++;
                }
            }

            this.currentCycle++;
        }
    }
}
