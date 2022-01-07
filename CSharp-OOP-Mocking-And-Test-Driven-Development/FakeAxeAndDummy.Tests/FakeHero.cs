using FakeAxeAndDummy.Contracts;

namespace FakeAxeAndDummy.Tests
{
    class FakeHero : IWeapon
    {
        private IWeapon weapon;

        internal Hero Fake(string name)
        {
            return new Hero(name, weapon);
        }

        public int AttackPoints { get; }

        public int DurabilityPoints { get; }

        public void Attack(IAttackable target)
        {
        }
    }
}
