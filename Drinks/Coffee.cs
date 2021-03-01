using System;
using System.Collections.Generic;
using System.Text;

namespace Drinks
{
    public class Coffee : HotDrink
    {
        public Coffee() : base("coffee") { }

        public override List<String> Actions()
        {
            List<String> actions = new List<String>();

            base.AddInitialActions(actions);
            actions.Add("Brew the coffee grounds");
            base.AddFinalActions(actions);
            actions.Add("Add sugar and milk");

            return actions;
        }


    }
}
