using System;
using System.Collections.Generic;
using System.Text;

namespace Drinks
{
    public class LemonTea : HotDrink
    {
        public LemonTea() : base("tea") { }

        public override List<String> Actions()
        {
            List<String> actions = new List<String>();

            base.AddInitialActions(actions);
            actions.Add("Steep the water in the tea");
            base.AddFinalActions(actions);
            actions.Add("Add lemon");

            return actions;
        }
    }
}
