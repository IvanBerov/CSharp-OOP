using System;
using FightingArena;
//using FightingArena;
using NUnit.Framework;

namespace Tests
{
    public class WarriorTests
    {
        [Test]
        [TestCase("", 50, 100)]
        [TestCase(" ", 50, 100)]
        [TestCase(null, 50, 100)]
        [TestCase("WarriorName", 0, 100)]
        [TestCase("WarriorName",  -10, 100)]
        [TestCase("WarriorName", 50, -10)]
        public void Ctor_ThrowException_WhenDataIsInvalid
            (string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>
                (()=> new Warrior(name, damage, hp));
        }

        [Test]
        [TestCase(30, 55)]
        [TestCase(15, 55)]
        [TestCase(55, 30)]
        [TestCase(55, 15)]
        public void Attack_ThrowsException_WhenHpIsLessThanMinimum(int attackerHp, int warriorHp)
        {
            var attacker = new Warrior("Attacker", 50, attackerHp);
            var warrior = new Warrior("Warrior", 10, warriorHp);

            Assert.Throws<InvalidOperationException>
                (() => attacker.Attack(warrior));
        }

        [Test]
        public void Attack_ThrowsException_WhenWarriorKillsTheAttacker()
        {
            var attacker = new Warrior("Attacker", 50, 100);
            var warrior = new Warrior("Warrior", attacker.HP + 1, 100);

            Assert.Throws<InvalidOperationException>
                (() => attacker.Attack(warrior));
        }

        [Test]
        public void Attack_DecreasesAttackerHealthPoints()
        {
            int initialAttackerHealthPoints = 100;

            var attacker = new Warrior("Attacker", 50, initialAttackerHealthPoints);
            var warrior = new Warrior("Warrior", 30, 100);

            attacker.Attack(warrior);

            Assert.That(attacker.HP, Is.EqualTo(initialAttackerHealthPoints - warrior.Damage));
        }

        [Test]
        public void Attack_SetEnemyHpToZero_WhenAttackerDamageIsGreater_ThanEnemyHp()
        {
            var attacker = new Warrior("Attacker", 50, 100);
            var warrior = new Warrior("Warrior", 30, 40);

            attacker.Attack(warrior);

            Assert.That(warrior.HP, Is.EqualTo(0));
        }

        [Test]
        public void Attack_DecreasesEnemyHp_ByAttackerDamage()
        {
            int warriorInitialHp = 100;

            var attacker = new Warrior("Attacker", 50, 100);
            var warrior = new Warrior("Warrior", 30, warriorInitialHp);

            attacker.Attack(warrior);

            Assert.That(warrior.HP, Is.EqualTo(warriorInitialHp - attacker.Damage));
        }
    }
}