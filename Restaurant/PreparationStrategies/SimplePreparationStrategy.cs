using System;
namespace Restaurant
{
    public class SimplePreparationStrategy : PreparationStrategy
    {
        public SimplePreparationStrategy()
        {
            this.name = "simple preparation";
        }

        public override void execute()
        {
            Console.Write("put an apron on");
        }
    }
}
