using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant r = new Restaurant("Charlie's Corner");

            Cook Christian = new Cook("Christian", new SimplePreparationStrategy());
            Cook Peter = new Cook("Peter", new HardrockPreparationStrategy());
            Cook Maria = new Cook("Maria", new SoccerPreparationStrategy());
            Cook Rody = new Cook("Rody", new SoccerPreparationStrategy());

            r.AddCook(Christian);
            r.AddCook(Peter);
            r.AddCook(Maria);
            r.AddCook(Rody);

            r.PrepareCooks();

            r.RemoveAllCooksWithPreparationType("soccer preparation");
            r.PrepareCooks();

            Cook Daan = new Cook("Daan", new MeditationPreparationStrategy());
            r.AddCook(Daan);

            r.ReplaceExistingCookWithNewCook(Peter, "Michel");
            r.PrepareCooks();
        }
    }
}
