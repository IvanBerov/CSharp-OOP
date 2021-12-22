namespace Gym.Models.Gyms
{
    public class BoxingGym : Gym
    {
        private const int initialCapacity = 15;

        public BoxingGym(string name) 
            : base(name, initialCapacity)
        {
        }
    }
}
