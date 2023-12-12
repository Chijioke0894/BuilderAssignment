using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    public class VeganRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        public void BuildBroth()
        {
            ramen.Broth = BrothType.Vegan;
        }

        public void BuildNoodles()
        {
            ramen.Noodles = NoodleType.Soba;
        }

        public void BuildToppings()
        {
            ramen.Toppings = Topping.BambooShoots;
        }

        public void BuildExtras()
        {
            ramen.Extras = Extra.none;
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
