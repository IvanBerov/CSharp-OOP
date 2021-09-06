using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals.Feline
{
    public class Cat : Feline
    {
        private const double BaseWeightModifier = 0.3;

        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable)

        };
        public Cat(
            string name,
            double weight,
            string livingRegion,
            string bread)
            : base(name, weight, allowedFoods, BaseWeightModifier, livingRegion, bread)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
