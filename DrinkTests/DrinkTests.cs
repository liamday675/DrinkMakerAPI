using NUnit.Framework;
using Drinks;

namespace DrinkTests
{
    public class DrinkTests
    {
        [Test]
        public void TestCoffee()
        {
            var sut = new Coffee();
            var actions = sut.Actions();

            Assert.AreEqual(actions.Count, 4);
            Assert.AreEqual(0, actions.FindIndex(a => a.Contains("Boil some water")));
            Assert.AreEqual(1, actions.FindIndex(a => a.Contains("Brew the coffee grounds")));
            Assert.AreEqual(2, actions.FindIndex(a => a.Contains("Pour coffee in the cup")));
            Assert.AreEqual(3, actions.FindIndex(a => a.Contains("Add sugar and milk")));

        }

        [Test]
        public void TestLemonTea()
        {
            var sut = new LemonTea();
            var actions = sut.Actions();

            Assert.AreEqual(actions.Count, 4);
            Assert.AreEqual(0, actions.FindIndex(a => a.Contains("Boil some water")));
            Assert.AreEqual(1, actions.FindIndex(a => a.Contains("Steep the water in the tea")));
            Assert.AreEqual(2, actions.FindIndex(a => a.Contains("Pour tea in the cup")));
            Assert.AreEqual(3, actions.FindIndex(a => a.Contains("Add lemon")));

        }

        [Test]
        public void TestChocolate()
        {
            var sut = new Chocolate();
            var actions = sut.Actions();

            Assert.AreEqual(actions.Count, 3);
            Assert.AreEqual(0, actions.FindIndex(a => a.Contains("Boil some water")));
            Assert.AreEqual(1, actions.FindIndex(a => a.Contains("Add drinking chocolate to the water")));
            Assert.AreEqual(2, actions.FindIndex(a => a.Contains("Pour chocolate in the cup")));

        }
    }
}
