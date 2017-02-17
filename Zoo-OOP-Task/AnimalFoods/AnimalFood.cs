namespace Zoo_OOP_Task.AnimalFood
{
    public class AnimalFood
    {
        private const byte GrassEnergyPerHundredGrams = 10;

        private const byte MandjaEnergyPerHundredGrams = 40;

        private const byte MeatEnergyPerHundredGrams = 30;

        private const byte MilkEnergyPerHundredGrams = 20;

        private const byte DefaultCalories = 0;

        public AnimalFood(AnimalFoodType foodType, uint amount)
        {
            this.FoodType = foodType;
            this.Amount = amount;
        }

        public AnimalFoodType FoodType { get; set; }

        public uint Amount { get; set; }

        public uint Calories
        {
            get
            {
                switch (this.FoodType)
                {
                    case AnimalFoodType.Grass:
                        return GrassEnergyPerHundredGrams * this.Amount;
                    case AnimalFoodType.Mandja:
                        return MandjaEnergyPerHundredGrams * this.Amount;
                    case AnimalFoodType.Meat:
                        return MeatEnergyPerHundredGrams * this.Amount;
                    case AnimalFoodType.Milk:
                        return MilkEnergyPerHundredGrams * this.Amount;
                    default:
                        return DefaultCalories;

                }
            }
        }
    }
}
