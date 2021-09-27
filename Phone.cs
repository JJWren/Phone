using System;


namespace Phone
{
    public abstract class Phone
    {
        protected string _versionNumber;
        protected int _batteryPercentage;
        protected string _carrier;
        protected string _ringTone;

        public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        {
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringTone = ringTone;
        }

        public string VersionNumber { get { return _versionNumber; } }
        public int BatteryPercentage { get { return _batteryPercentage; } }
        public string Carrier { get { return _carrier; } }
        public string Ringtone { get { return _ringTone; } set { _ringTone = value; } }

        public abstract void DisplayInfo();
    }
}
