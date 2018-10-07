using System;
namespace Restaurant
{
    public class MeditationPreparationStrategy : PreparationStrategy
    {
        public MeditationPreparationStrategy()
        {
            this.name = "meditation preparation";
        }

        public override void Execute()
        {
            Console.Write("5 minutes of mindfulness and a short breathing exercise");
        }
    }
}
