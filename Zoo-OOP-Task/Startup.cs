// Created by Vasil Stoyanov 16.02.2017
namespace Zoo_OOP_Task
{
    using System;

    using Animals.Carnivores;
    using ZooKeepers;
    using ZooNS;

    class Startup
    {
        static void Main()
        {
            var bengalTiger = new Tiger("Razor", 1);
            var whiteTiger = new Tiger("Pesho", 0);
            var brownTiger = new Tiger("Gosho", 1);
            var megaTiger = new Tiger("Izrud", 2);
            var lameTiger = new Tiger("WTF", 1);

            var peshoTheKeeper = new ZooKeeper();
            var goshoTheKeeper = new ZooKeeper();

            var zoo = new Zoo();

            zoo.AddAnimal(bengalTiger);
            zoo.AddAnimal(whiteTiger);
            zoo.AddAnimal(brownTiger);
            zoo.AddAnimal(megaTiger);
            zoo.AddAnimal(lameTiger);

            peshoTheKeeper.Assign(bengalTiger);
            peshoTheKeeper.Assign(whiteTiger);

            goshoTheKeeper.Assign(brownTiger);
            goshoTheKeeper.Assign(megaTiger);
            goshoTheKeeper.Assign(lameTiger);

            zoo.AddZooKeeper(peshoTheKeeper);
            zoo.AddZooKeeper(goshoTheKeeper);

            for (int i = 0; i < 20; i++)
            {
                zoo.TriggerCycle();
            }
        }
    }
}
