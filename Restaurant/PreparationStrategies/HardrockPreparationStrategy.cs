using System;
namespace Restaurant
{
    public class HardrockPreparationStrategy : PreparationStrategy
    {
        public HardrockPreparationStrategy()
        {
            this.name = "hardrock preparation";
        }

        public override void Execute()
        {
            Console.Write("take a collection of knifes and set some hardrock music on");
        }
    }
}
