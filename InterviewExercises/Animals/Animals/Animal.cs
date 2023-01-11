using Animals.Enums;

namespace Animals.Animals
{
    public abstract class Animal
    {
        private int maxEnergy;
        private int energy;
        private Type animalType;

        public Animal(int maxEnergy)
        {
            MaxEnergy = maxEnergy;
            Energy = maxEnergy;
            this.animalType = this.GetType();
        }

        public int MaxEnergy
        {
            get => maxEnergy;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Max Energy must be above zero");
                }

                maxEnergy = value;
            }
        }

        public int Energy
        {
            get => energy;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Energy must be a positive number");
                }
                else if (value > maxEnergy)
                {
                    energy = maxEnergy;
                    return;
                }

                energy = value;
            }
        }

        public void Feed(string foodName)
        {
            if (this.Energy <= 0)
            {
                Console.WriteLine($"{this.animalType.Name} is dead");
                return;
            }

            if (!ValidateFood(foodName))
            {
                return;
            }

            if (IsAnimalEatingFood(this.animalType, foodName))
            {
                Energy += 1;
                Console.WriteLine($"{this.animalType.Name} can eat {foodName}");
                Console.WriteLine($"Energy: {Energy}");
            }
            else
            {
                Energy -= 1;
                Console.WriteLine($"{this.animalType.Name} cannot eat {foodName}");
                Console.WriteLine($"Energy: {Energy}");

                if (Energy <= 0)
                {
                    Console.WriteLine($"The {this.animalType.Name} has died");
                }
            }
        }

        private bool ValidateFood(string foodName)
        {
            if (Enum.IsDefined(typeof(Food), foodName))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid food name");
                return false;
            }
        }

        private bool IsAnimalEatingFood(Type animalType, string foodName)
        {
            var isEating = false;

            if (animalType.Name == "Bear")
            {
                if (Enum.IsDefined(typeof(BearFood), foodName))
                {
                    isEating = true;
                }
            }
            else if (animalType.Name == "Wolf")
            {
                if (Enum.IsDefined(typeof(WolfFood), foodName))
                {
                    isEating = true;
                }
            }
            else if (animalType.Name == "Rabbit")
            {
                if (Enum.IsDefined(typeof(RabbitFood), foodName))
                {
                    isEating = true;
                }
            }

            return isEating;
        }
    }
}