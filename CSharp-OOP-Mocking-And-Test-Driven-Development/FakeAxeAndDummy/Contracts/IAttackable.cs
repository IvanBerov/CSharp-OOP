namespace FakeAxeAndDummy.Contracts
{
    public interface  IAttackable
    {
        public int Health { get; }

        public void TakeAttack(int attackPoints);

        public int GiveExperience();

        public bool IsDead();
    }
}
