
using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    public class MisoRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        public void BuildBroth()
        {
            ramen.Broth = BrothType.Miso;
        }

        public void BuildNoodles()
        {
            ramen.Noodles = NoodleType.Udon;
        }

        public void BuildToppings()
        {
            ramen.Toppings = Topping.GreenOnions;
        }

        public void BuildExtras()
        {
            ramen.Extras = Extra.Corn;
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
