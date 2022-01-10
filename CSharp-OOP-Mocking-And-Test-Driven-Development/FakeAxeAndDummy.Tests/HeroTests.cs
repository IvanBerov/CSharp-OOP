using FakeAxeAndDummy.Contracts;
using FakeAxeAndDummy.Tests;
using Moq;
using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    private const string name = "Jack";
    private const int defaultExperience = 0;
    private Hero hero;
    private IWeapon weapon;

    [Test]
    public void Constructor_WithValidParameter_ShouldSetFieldsCorrectly()
    {
        hero = new FakeHero().Fake(name);
        var heroName = hero.Name;
        var experience = hero.Experience;

        Assert.AreEqual(name, heroName);
        Assert.AreEqual(defaultExperience, experience);
    }

    [Test]
    public void Attack_WithValidTargetParameter_ShouldCallWeaponsAttackMethodOnce()
    {
        var mockedWeapon = new Mock<IWeapon>();
        var mockedTarget = new Mock<IAttackable>();
        hero = new Hero(name, mockedWeapon.Object);

        hero.Attack(mockedTarget.Object);

        mockedWeapon.Verify(x => x.Attack(It.IsAny<IAttackable>()), Times.Once);
    }
    [Test]
    public void Attack_TargetIsDeadAfterAttack_HeroShouldGainExperience()
    {
        var mockedWeapon = new Mock<IWeapon>().Object;
        var mockedTarget = new Mock<IAttackable>();
        mockedTarget.Setup(x => x.IsDead()).Returns(true);
        mockedTarget.Setup(x => x.GiveExperience()).Returns(10);
        hero = new Hero(name, mockedWeapon);

        hero.Attack(mockedTarget.Object);

        var expected = defaultExperience + 10;
        var actual = hero.Experience;
        Assert.AreEqual(expected, actual);
    }
}