using System;
using System.Collections.Generic;
using System.Text;

namespace Drinks
{
    // Can be extended should we ever want to make a cold drink
    public abstract class Drink : IActionable
    {
        public string DrinkName { get; set; }

        protected Drink(string name)
        {
            DrinkName = name;
        }

        protected List<String> AddInitialActions(List<String> actions)
        {
            return actions;
        }

        protected List<String> AddFinalActions(List<String> actions)
        {
            actions.Add($"Pour {DrinkName} in the cup");
            return actions;
        }

        public abstract List<String> Actions();
    }
}
