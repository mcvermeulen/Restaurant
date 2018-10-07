using System;
namespace Restaurant
{
    public class Cook
    {
        private readonly String name;
        private PreparationStrategy preparation;

        public Cook(String name, PreparationStrategy preparation)
        {
            this.name = name;
            this.preparation = preparation;
        }

        public void Prepare()
        {
            Console.Write(name + " has the " + preparation.GetName() + ":  ");
            preparation.Execute();
            Console.Write("\n");
        }

        public PreparationStrategy GetPreparation()
        {
            return preparation;
        }

        public void SetPreparation(PreparationStrategy preparation)
        {
            this.preparation = preparation;
        }
    }
}
