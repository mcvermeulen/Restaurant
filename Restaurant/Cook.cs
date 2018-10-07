using System;
namespace Restaurant
{
    public class Cook
    {
        private String name;
        private PreparationStrategy preparation;

        public Cook(String name, PreparationStrategy preparation)
        {
            this.name = name;
            this.preparation = preparation;
        }

        public void prepare()
        {
            Console.Write(name + " has the " + preparation.getName() + ":  ");
            preparation.execute();
            Console.Write("\n");
        }

        public PreparationStrategy getPreparation()
        {
            return preparation;
        }

        public void setPreparation(PreparationStrategy preparation)
        {
            this.preparation = preparation;
        }
    }
}
