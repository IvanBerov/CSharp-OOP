using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals.Feline
{
    public abstract class Feline : Mammal
    {
        protected Feline(
            string name,
            double weight,
            HashSet<string> allowedFoods,
            double weightModifier,
            string livingRegion, 
            string bread)
            : base(name, weight, allowedFoods, weightModifier, livingRegion)
        {
            this.Bread = bread;
        }

        public string Bread { get; private set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Bread}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
