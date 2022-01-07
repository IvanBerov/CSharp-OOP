using FakeAxeAndDummy.Contracts;

namespace FakeAxeAndDummy.Tests
{
    public class Fake : IAttackable
    {
        public int Health { get; }

        public void TakeAttack(int attackPoints)
        {
        }

        public int GiveExperience()
        {
            return 20;
        }

        public bool IsDead()
        {
            return true;
        }
    }
}
