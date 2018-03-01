using System;

namespace ECS.Legacy
{
    public class EcsExtention
    {
        public int ThresholdsChange { get; private set; }

        public void SetRandom()
        {
            Random rnd = new Random();
            ThresholdsChange = rnd.Next(20, 30);
           
        }
    }
        
  
}