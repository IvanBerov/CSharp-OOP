namespace Gym.Models.Gyms
{
    public class WeightliftingGym : Gym
    {
        private const int initialCapacity = 20;

        public WeightliftingGym(string name) 
            : base(name, initialCapacity)
        {
        }
    }
}
