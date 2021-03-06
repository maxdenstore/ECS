﻿namespace ECS.Legacy
{
    public class TempSensor : ITempSensor
    {
        public int GetTemp()
        {
            return 25;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }

    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}