using System;
using FakeAxeAndDummy.Tests;
using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    private const int attack = 50;
    private const int durability = 50;
    private Axe axe;

    [SetUp]
    public void Setup()
    {
        axe = new Axe(attack, durability);
    }

    [Test]
    public void Ctor_WithValidParameters_ShouldSetCorrectly()
    {
        bool actual = axe.AttackPoints == attack && axe.DurabilityPoints == durability;

        Assert.IsTrue(actual);
    }

    [TestCase(0)]
    [TestCase(-1)]
    public void Attack_WithDurabilityPointsEqualToOrLessThanZero_ShouldThrowException(int durabilityPoints)
    {
        var axe = new Axe(50, durabilityPoints);

        var fakeDummy = new Fake();

        var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(fakeDummy));

        StringAssert.Contains("Axe is broken", ex.Message);
    }

    [Test]
    public void Attack_ShouldDecreaseByOneAfterAttack()
    {
        var fakeDummy = new Fake();

        var expected = durability - 1;
        axe.Attack(fakeDummy);
        var actual = axe.DurabilityPoints;

        Assert.AreEqual(expected, actual);
    }
}