using System;

namespace ECS.Legacy
{
    public class Application
    {
        public static void Main(string[] args)
        {
            //rand 20-29 sensor set.
            var ext = new ECSExtention(); 
            ext.setRandom();
            var ecs = new ECS(ext.thresholdsChange,new TempSensor(), new Heater());

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();

            Console.WriteLine(ext.thresholdsChange);
        }
    }
}
