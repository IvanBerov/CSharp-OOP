using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private readonly string name;
        private readonly string fovouriteFood;

        protected Animal(string name, string fovouriteFood)
        {
            this.name = name;
            this.fovouriteFood = fovouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {name} and my fovourite food is {fovouriteFood}";
        } 
    }
}
