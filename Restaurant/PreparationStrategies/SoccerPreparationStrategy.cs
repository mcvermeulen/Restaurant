﻿using System;
namespace Restaurant
{
    public class SoccerPreparationStrategy : PreparationStrategy
    {
        public SoccerPreparationStrategy()
        {
            this.name = "soccer preparation";
        }

        public override void Execute()
        {
            Console.Write("open a beer and hum the anthem of favourite soccer team");
        }
    }
}
