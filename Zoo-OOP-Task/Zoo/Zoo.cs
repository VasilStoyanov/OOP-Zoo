// Created by Vasil Stoyanov 16.02.2017
namespace Zoo_OOP_Task.Zoo
{
    using System.Collections.Generic;

    using Animals;
    using ZooKeepers;

    public sealed class Zoo
    {
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
            // Zoo keeper feed animals
            // Animals become tired
            // Check if animal should age (10 cycles)
        }

        public void FeedAnimal(ZooKeeper zooKeeper)
        {

        }
    }
}
