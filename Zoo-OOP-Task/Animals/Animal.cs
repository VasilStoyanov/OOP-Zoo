// Created by Vasil Stoyanov - 16.02.2017
namespace Zoo_OOP_Task.Animals
{
    using System;

    using AnimalFood;

    public abstract class Animal
    {
        private const byte DefaultStaminaForAnimal = 100;

        private string name;

        private Species specie;

        private DateTime birthDate;

        private uint age;

        private int stamina;

        private uint averageLifeSpan;

        protected int hunger;

        public Animal(Species specie, byte lowLifespan, byte highLifespan, string name, uint age)
            :this(specie, lowLifespan, highLifespan, name, age, new DateTime(), DefaultStaminaForAnimal)
        {
        }

        public Animal(Species specie, byte lowLifespan, byte highLifespan, string name, uint age, DateTime birthDay)
            : this(specie, lowLifespan, highLifespan, name, age, birthDay, DefaultStaminaForAnimal)
        {
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

        public abstract Species Specie
        {
            get
            {
                return this.specie;
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
                this.birthDate = value;
            }
        }

        public virtual string ZooKeeperId { get; set; } = "";

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

        protected virtual bool IsAlive(uint lifeExpectancy)
        {
            return lifeExpectancy > 0;
        }

        protected virtual bool IsActive()
        {
            return this.Stamina > 0;
        }

        public abstract void Eat(AnimalFood food);

        public virtual void DecreaseStamina(int staminaToDecrease)
        {
            Console.WriteLine(String.Format("{0} decreased stamina by {1}",
                this.Name, staminaToDecrease));

            this.Stamina -= staminaToDecrease;
        }

        public virtual void IncreaseStamina(int staminaToIncrease)
        {
            Console.WriteLine(String.Format("{0} increased stamina by {1}",
                this.Name, staminaToIncrease));

            this.Stamina += staminaToIncrease;
        }

        public abstract string Speak();

        private uint GenerateRandomTigerLifespanInRange(Random generator, byte lowLifespan, byte highLifespan)
        {
            return (uint)generator.Next(lowLifespan, highLifespan);
        }
    }
}
