using BuilderAssignment.Builders;
using BuilderAssignment.Models;

namespace BuilderAssignment
{
    public class RamenChef
    {
        private IRamenBuilder ?ramenBuilder;
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {
            //TODO#1: Call each builder step declared in RamenBuilder class
            ramenBuilder = builder;
            ramenBuilder.BuildBroth();
            ramenBuilder.BuildNoodles();
            ramenBuilder.BuildToppings();
            ramenBuilder.BuildExtras();

            return ramenBuilder.GetRamen();
        }
    }
}
