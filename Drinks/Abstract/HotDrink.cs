using System;
using System.Collections.Generic;
using System.Text;

namespace Drinks
{
    // Defines what the object is, ie a drink made from boiling water.
    public abstract class HotDrink : Drink
    {
        public HotDrink(string name) : base(name) { }

        protected new void AddInitialActions(List<String> actions)
        {
            base.AddInitialActions(actions);
            actions.Add("Boil some water");
        }

        protected new void AddFinalActions(List<String> actions)
        {
            base.AddFinalActions(actions);
        }
    }
}
