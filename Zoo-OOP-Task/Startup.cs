// Created by Vasil Stoyanov 16.02.2017
namespace Zoo_OOP_Task
{
    using System;

    using Animals.Carnivores;
    using ZooKeepers;
    using ZooNS;

    public class Startup
    {
        static void Main()
        {
            RunDemo();
        }

        public static void RunDemo()
        {
            var bengalTiger = new Tiger("Razor", 1);
            var whiteTiger = new Tiger("Kali", 0);
            var brownTiger = new Tiger("Chochko", 1);
            var megaTiger = new Tiger("SBTech Tiger", 2);
            var lameTiger = new Tiger("Obicham da qm", 21);

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

            for (int i = 0; i < 120; i++)
            {
                zoo.TriggerCycle();
            }
        }
    }
}
