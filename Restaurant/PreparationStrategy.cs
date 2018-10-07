using System;
namespace Restaurant
{
    public abstract class PreparationStrategy
    {
        protected String name;

        protected PreparationStrategy()
        {
            this.name = "preparation";
        }

        public String getName() { return name; }

        public abstract void execute();
    }
}
