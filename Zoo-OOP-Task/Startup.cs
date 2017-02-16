// Created by Vasil Stoyanov 16.02.2017
namespace Zoo_OOP_Task
{
    using System;

    using Animals.Carnivores;

    class Startup
    {
        static void Main()
        {
            var tiger = new Tiger("Jumbo", 12);
            Console.WriteLine(tiger.CalculateLifeExpectancy());
        }
    }
}
