namespace Zoo_OOP_Task.AnimalFood
{
    public class AnimalFood
    {
        private const byte GrassEnergyPerHundredGrams = 20;

        private const byte MandjaEnergyPerHundredGrams = 50;

        private const byte MeatEnergyPerHundredGrams = 40;

        private const byte MilkEnergyPerHundredGrams = 30;

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
                switch(foodType)
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
