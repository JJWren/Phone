using System;

namespace Phone
{
    public class Nokia : Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) {}

        public virtual string Ring()
        {
            return $"... {Ringtone} ...";
        }

        public virtual string Unlock()
        {
            return $"Nokia {VersionNumber} unlocked with passcode";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("");
            string tabs = "$$$$$$$$$$$$$$$$$$$$$$$$$";
            Console.WriteLine(tabs);
            Console.WriteLine($"Nokia {VersionNumber}");
            Console.WriteLine($"Battery Percentage: {BatteryPercentage}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ringtone: {Ringtone}");
            Console.WriteLine(tabs);
            Console.WriteLine("");
        }
    }
}