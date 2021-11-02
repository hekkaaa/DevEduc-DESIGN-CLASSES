using NUnit.Framework;

namespace DESIGN_CLASSES.Tests
{
    public class Monster
    {
        [SetUp]
        public void Setup()
        {
            Monster test = new Monster(false);
        }

        [Test]
        public void GetAttack_Tests()
        {
            Monster test = new Monster();
            Assert.AreEqual(10, test.);
        }
    }
}