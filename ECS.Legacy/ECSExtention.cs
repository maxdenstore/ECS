using System.Security.Cryptography.X509Certificates;
using System;

namespace ECS.Legacy
{
    public class ECSExtention
    {
        public int thresholdsChange { get; set; }

        public void setRandom()
        {
            Random rnd = new Random();
            thresholdsChange = rnd.Next(20, 30);
           
        }
    }
        
  
}