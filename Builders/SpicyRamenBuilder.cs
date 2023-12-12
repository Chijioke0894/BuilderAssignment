
using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    public class SpicyRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        public void BuildBroth()
        {
            ramen.Broth = BrothType.SpicyTonkotsu;
        }

        public void BuildNoodles()
        {
            ramen.Noodles = NoodleType.Thin;
        }

        public void BuildToppings()
        {
            ramen.Toppings = Topping.ChashuPork;
        }

        public void BuildExtras()
        {
            ramen.Extras = Extra.ExtraSpice;
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
