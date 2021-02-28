using System;
using System.Collections.Generic;
using System.Text;

namespace Drinks
{
    public class Chocolate : HotDrink
    {
        public Chocolate() : base("chocolate") { }

        public override List<String> Actions()
        {
            List<String> actions = new List<String>();

            base.AddInitialActions(actions);
            actions.Add("Add drinking chocolate to the water");
            base.AddFinalActions(actions);

            return actions;
        }
    }
}
