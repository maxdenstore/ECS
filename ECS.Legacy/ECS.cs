namespace ECS.Legacy
{
    public class ECS
    {
        private int _threshold;
        private readonly ITempSensor _tempSensor;   //changed to use interface reference
        private readonly IHeater _heater;           //same

        public ECS(int thr, ITempSensor x, IHeater y)
        {
            SetThreshold(thr);
            _tempSensor = x;
            _heater = y;
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return 0;
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }

    public class FakeECS
    {

        private int _threshold;
        public readonly ITempSensor _tempSensor;   //changed to use interface reference
        public readonly IHeater _heater;           //same

        public FakeECS(int thr, ITempSensor x, IHeater y)
        {
            SetThreshold(thr);
            _tempSensor = x;
            _heater = y;
        }

        public bool Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                return true;
            else
                return false;

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return 0;
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
