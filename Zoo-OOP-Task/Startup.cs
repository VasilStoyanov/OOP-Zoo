// Created by Vasil Stoyanov 16.02.2017
namespace Zoo_OOP_Task
{
    using System;

    using Animals.Carnivores;
    using ZooKeepers;

    class Startup
    {
        static void Main()
        {
            var bengalTiger = new Tiger("Razor", 1);
            var whiteTiger = new Tiger("Pesho", 0);

            var keeper = new ZooKeeper();
            //keeper.Assign(whiteTiger);
        }
    }
}
