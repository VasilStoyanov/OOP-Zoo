﻿// Created by Vasil Stoyanov - 16.02.2017
namespace Zoo_OOP_Task.Animals
{
    using System;

    public abstract class Animal
    {
        private string name;

        private Species specie;

        private DateTime birthDate;

        private uint age;

        private int stamina;

        private uint averageLifeSpan;

        protected int hunger;

        public Animal(Species specie, byte lowLifespan, byte highLifespan, string name, uint age)
        {
            this.Name = name;
            this.Age = age;
            this.averageLifeSpan = GenerateRandomTigerLifespanInRange(new Random(), lowLifespan, highLifespan);
        }

        public Animal(Species specie, byte lowLifespan, byte highLifespan, string name, uint age, DateTime birthDay)
        {
            this.Specie = specie;
            this.Name = name;
            this.Birthdate = birthDay;
            this.averageLifeSpan = GenerateRandomTigerLifespanInRange(new Random(), lowLifespan, highLifespan);
        }

        public Animal(Species specie, byte lowLifespan, byte highLifespan, string name, uint age, DateTime birthDay, int stamina)
        {
            this.Specie = specie;
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthDay;
            this.Stamina = stamina;
            this.averageLifeSpan = GenerateRandomTigerLifespanInRange(new Random(), lowLifespan, highLifespan);
        }

        public virtual uint CalculateLifeExpectancy()
        {
            return this.averageLifeSpan - this.age;
        }

        public virtual string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public virtual Species Specie
        {
            get
            {
                return this.specie;
            }
            set
            {
                this.specie = value;
            }
        }

        public virtual DateTime Birthdate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                if(value != null)
                {
                    this.birthDate = value;
                }
            }
        }

        public virtual uint Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value >= UInt32.MinValue  && value < UInt32.MaxValue)
                {
                    this.age = value;
                }
            }
        }

        public virtual int Stamina { get; private set; }

        public abstract string Eat();

        public abstract string Speak();

        private uint GenerateRandomTigerLifespanInRange(Random generator, byte lowLifespan, byte highLifespan)
        {
            return (uint)generator.Next(lowLifespan, highLifespan);
        }
    }
}