using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using DrinkMaker.Controllers;
using Newtonsoft.Json;

namespace DrinkTests
{
    class DrinkMakerControllerTests
    {
        [Test]
        public void TestCoffee()
        {
            var sut = new DrinkMakerController();
            var actions = sut.DrinkActions("coffee");
            List<String> actionList = (List<String>)actions.Value;
            
            Assert.AreEqual(actionList.Count, 4);
            Assert.AreEqual(0, actionList.FindIndex(a => a.Contains("Boil some water")));
            Assert.AreEqual(1, actionList.FindIndex(a => a.Contains("Brew the coffee grounds")));
            Assert.AreEqual(2, actionList.FindIndex(a => a.Contains("Pour coffee in the cup")));
            Assert.AreEqual(3, actionList.FindIndex(a => a.Contains("Add sugar and milk")));

        }

        [Test]
        public void TestLemonTea()
        {
            var sut = new DrinkMakerController();
            var actions = sut.DrinkActions("lemontea");
            List<String> actionList = (List<String>)actions.Value;

            Assert.AreEqual(actionList.Count, 4);
            Assert.AreEqual(0, actionList.FindIndex(a => a.Contains("Boil some water")));
            Assert.AreEqual(1, actionList.FindIndex(a => a.Contains("Steep the water in the tea")));
            Assert.AreEqual(2, actionList.FindIndex(a => a.Contains("Pour tea in the cup")));
            Assert.AreEqual(3, actionList.FindIndex(a => a.Contains("Add lemon")));

        }

        [Test]
        public void TestChocolate()
        {
            var sut = new DrinkMakerController();
            var actions = sut.DrinkActions("chocolate");
            List<String> actionList = (List<String>)actions.Value;

            Assert.AreEqual(actionList.Count, 3);
            Assert.AreEqual(0, actionList.FindIndex(a => a.Contains("Boil some water")));
            Assert.AreEqual(1, actionList.FindIndex(a => a.Contains("Add drinking chocolate to the water")));
            Assert.AreEqual(2, actionList.FindIndex(a => a.Contains("Pour chocolate in the cup")));

        }

    }
}
