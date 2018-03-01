using System;

namespace ECS.Legacy
{
    public static class Application
    {
        public static void Main()
        {
            var ext = new EcsExtention(); 
            ext.SetRandom();
            var ecs = new Ecs(ext.ThresholdsChange,new TempSensor(), new Heater());

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();

            Console.WriteLine(ext.ThresholdsChange);
        }
    }
}
